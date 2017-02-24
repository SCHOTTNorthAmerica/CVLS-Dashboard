using SCHOTT.Core.Utilities;
using SCHOTT.CVLS.Ethernet.Binary;
using SCHOTT.CVLS.Ethernet.Binary.Enums;
using SCHOTT.CVLS.Serial;
using SCHOTT.CVLS.Utilities;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Dialogs;
using SCHOTT.WinForms.Docking;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    public partial class Upgrade : DockContent
    {
        private readonly BinarySocket _binarySocketRef;
        private readonly CVLSThreadedComPort _cvlsThreadedComPortRef;
        private bool _logsDownloadStarted = false;

        public Upgrade(CVLSThreadedComPort cvlsThreadedComPort, BinarySocket binarySocket)
        {
            InitializeComponent();

            var firmwareList = CustomerFirmware.Streams.Keys.ToList();

            if (firmwareList.Count > 0)
            {
                firmwareList.ForEach(s => firmwareVersions.Items.Add(s));
                firmwareVersions.SelectedIndex = 0;
            }

            firmwareLatest.Text = CustomerFirmware.CurrentVersion;
            
            _binarySocketRef = binarySocket;
            _binarySocketRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());
            _binarySocketRef.RegisterLoginUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());
            _binarySocketRef.FirmwareUploader.RegisterPercentUpdate(MessageBroker.MessageContext.NewThreadToGui, args => UpdateProgressBar(args.PercentTransfered));
            _binarySocketRef.LogDownloader.RegisterPercentUpdate(MessageBroker.MessageContext.NewThreadToGui, UpdateLogCount);

            _cvlsThreadedComPortRef = cvlsThreadedComPort;
            _cvlsThreadedComPortRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());
            _cvlsThreadedComPortRef.FirmwareUploader.RegisterPercentUpdate(MessageBroker.MessageContext.NewThreadToGui, args => UpdateProgressBar(args.PercentTransfered));
            _cvlsThreadedComPortRef.LogDownloader.RegisterPercentUpdate(MessageBroker.MessageContext.NewThreadToGui, UpdateLogCount);

            DisplayControls();
        }

        private void UpdateProgressBar(int progress)
        {
            if (firmwareSPIProgress.Value != progress)
                firmwareSPIProgress.Value = progress;
        }

        private void UpdateLogCount(TransferStatus status)
        {
            logStatus.Text = $@"{status.BytesTransfered}/{status.BytesTotal} = {status.PercentTransfered}";

            if (status.TransferState == TransferState.Succeeded)
            {
                List<LogData> logs = new List<LogData>();
                bool downloadComplete = false;

                if (_binarySocketRef.IsConnected)
                {
                    downloadComplete = _binarySocketRef.LogDownloader.GetCurrentLogs(ref logs).TransferState == TransferState.Succeeded;
                }
                else if (_cvlsThreadedComPortRef.IsConnected)
                {
                    downloadComplete = _cvlsThreadedComPortRef.LogDownloader.GetCurrentLogs(ref logs).TransferState == TransferState.Succeeded;
                }

                if (downloadComplete)
                {
                    // don't do anything with results unless button was pressed
                    if (!_logsDownloadStarted)
                        return;

                    // reset flag
                    _logsDownloadStarted = false;

                    if (logs.Count == 0)
                    {
                        CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                        {
                            Message = "No Exceptions!",
                            Title = "Error Log Downloader Status"
                        });
                    }
                    else
                    {
                        // save to a file
                        var file = CrossThreadDialogs.SaveAsFilename("Semicolon Seperated Values (*.csv)|*.csv|All Files (*.*)|*.*");
                        if (file.Length > 0)
                        {
                            var errors = logs.Aggregate("",
                                (current, log) => current + $"{log.LogCount};{log.Timestamp};{log.Message}\r\n");

                            try
                            {
                                File.WriteAllText(file, errors);
                                CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                                {
                                    Message = "File Saved!",
                                    Title = "Error Log Downloader Status"
                                });
                            }
                            catch
                            {
                                CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                                {
                                    Message = "Could not write file to location!",
                                    Title = "Error Log Downloader Status"
                                });
                            }
                        }
                        //else
                        //{
                        //    CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                        //    {
                        //        Message = "File Save Canceled!",
                        //        Title = "Error Log Downloader Status"
                        //    });
                        //}
                    }
                }
                else
                {
                    CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                    {
                        Message = "Download Failed!",
                        Title = "Error Log Downloader Status"
                    });
                }

            }
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }
        
        private void form_Load(object sender, EventArgs e)
        {
            var controlMonitor = new DetectEnterExit(scrollPanel);
            controlMonitor.ControlEnter += ControlMonitor_ControlEnter;
        }

        private void ControlMonitor_ControlEnter(Control pnl)
        {
            scrollPanel.Focus();
        }

        #region Display
        
        private void DisplayControls()
        {
            if (_binarySocketRef.IsConnected)
            {
                // request the firmware
                firmwareUnit.Text = _binarySocketRef.GetFirmware();

                // display proper controls
                if (_binarySocketRef.AdminPermissions != BinarySocket.LoginPermissions.Disabled)
                {
                    Connection.Visible = false;
                    LoginRequired.Visible = false;
                    Firmware.Visible = true;
                    firmwareSPIButton.Enabled = true;
                    ExceptionLogs.Visible = true;
                }
                else
                {
                    Connection.Visible = false;
                    LoginRequired.Visible = true;
                    Firmware.Visible = true;
                    firmwareSPIButton.Enabled = false;
                    ExceptionLogs.Visible = false;
                }
            }
            else if ( _cvlsThreadedComPortRef.IsConnected )
            {
                // request the firmware
                firmwareUnit.Text = _cvlsThreadedComPortRef.Protocol.Status.Identification.Firmware;

                // display proper controls
                LoginRequired.Visible = false;
                Firmware.Visible = true;
                
                var firmwareTest = _cvlsThreadedComPortRef.Protocol?.FirmwareVersion >= 1.14;
                ExceptionLogs.Visible = firmwareTest;
                firmwareSPIButton.Enabled = firmwareTest;
                Connection.Visible = !firmwareTest;
            }
            else
            {
                // display proper controls
                Connection.Visible = true;
                LoginRequired.Visible = false;
                Firmware.Visible = false;
                firmwareUnit.Text = "";
                ExceptionLogs.Visible = false;
            }
        }

        #endregion
        
        #region Events
        
        private void firmwareSPIButton_Click(object sender, EventArgs e)
        {
            if ( CustomerFirmware.Streams.ContainsKey(firmwareVersions.Text))
            {
                if (_binarySocketRef.IsConnected)
                {
                    _binarySocketRef.FirmwareUploader.Start(CustomerFirmware.Streams[firmwareVersions.Text]);
                }
                else
                {
                    _cvlsThreadedComPortRef.FirmwareUploader.Start(CustomerFirmware.Streams[firmwareVersions.Text]);
                }
            }
            else
            {
                CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                {
                    Message = "The selected firmware is not in the assembly for use.",
                    Title = "Firmware Missing"
                });
            }
        }
        
        private void formUnitDiagnostics_VisibleChanged(object sender, EventArgs e)
        {
            DisplayControls();
        }

        #endregion

        private void logsRead_Click(object sender, EventArgs e)
        {
            _logsDownloadStarted = true;

            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.LogDownloader.Start();
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.LogDownloader.Start();
            }
        }

        private void logsClear_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminLogsClear, true);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.SendCommandSingle("&o3");
            }
        }
    }
}

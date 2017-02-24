using SCHOTT.Core.Utilities;
using SCHOTT.CVLS.Dashboard.Utilities;
using SCHOTT.CVLS.Ethernet.Binary;
using SCHOTT.CVLS.Ethernet.Binary.Enums;
using SCHOTT.CVLS.Serial;
using SCHOTT.CVLS.Utilities;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Dialogs;
using SCHOTT.WinForms.Docking;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    public partial class Configurations : DockContent
    {
        private readonly BinarySocket _binarySocketRef;
        private readonly CVLSThreadedComPort _cvlsThreadedComPortRef;

        public Configurations(CVLSThreadedComPort cvlsThreadedComPort, BinarySocket binarySocket)
        {
            InitializeComponent();
            DisplayControls();

            _binarySocketRef = binarySocket;
            _binarySocketRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());
            _binarySocketRef.RegisterLoginUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());

            _cvlsThreadedComPortRef = cvlsThreadedComPort;
            _cvlsThreadedComPortRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());

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
        
        public void ResizeTable()
        {
            typeof(Control).GetMethod("OnResize",
             BindingFlags.Instance | BindingFlags.NonPublic)
             .Invoke(mainLayoutPanel, new object[] { EventArgs.Empty });
        }

        #region Internal Functions

        private void DisplayControls()
        {
            if (_binarySocketRef?.IsConnected == true)
            {
                Connection.Visible = false;
                ImportExport.Enabled = true;

                var loggedIn = _binarySocketRef?.AdminPermissions != BinarySocket.LoginPermissions.Disabled;
                ControlsTable.Visible = loggedIn;
                UserLevel.Visible = !loggedIn;
            }
            else if (_cvlsThreadedComPortRef?.IsConnected == true)
            {
                Connection.Visible = false;
                UserLevel.Visible = false;
                ControlsTable.Visible = true;
                
                ImportExport.Enabled = _cvlsThreadedComPortRef.Protocol?.FirmwareVersion >= 1.14;
            }
            else
            {
                Connection.Visible = true;
                UserLevel.Visible = false;
                ControlsTable.Visible = false;
                ImportExport.Enabled = false;
            }
        }

        #endregion

        #region Events
        
        private void formConfigurations_VisibleChanged(object sender, EventArgs e)
        {
            DisplayControls();
        }
        
        private void settingsSave_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSaveSettings, true);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Configurations.SettingsSave();
                //_cvlsThreadedComPortRef.SendCommand("&s");
            }
        }

        private void settingsRestore_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminRestoreSettings, true);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Configurations.SettingsRestore();
                //_cvlsThreadedComPortRef.SendCommand("&t");
            }
        }

        private void factoryRestoreAll_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminRestoreFactorySettings, true);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Configurations.SettingsRestoreFactory();
                //_cvlsThreadedComPortRef.SendCommand("&o");
            }
        }

        private void factoryPreserveNetwork_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminRestoreFactorySettingsPreserveNetwork, true);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Configurations.SettingsRestoreFactoryPreservingNetworkSettings();
                //_cvlsThreadedComPortRef.SendCommand("&o2");
            }
        }

        private void exportINI_Click(object sender, EventArgs e)
        {
            var iniFile = "";
            TransferStatus status;
            var transferSuccessfull = false;
            var message = "";

            if (_binarySocketRef.IsConnected)
            {
                status = _binarySocketRef.IniDownloader.GetFull(out iniFile);
                transferSuccessfull = status.TransferState == TransferState.Succeeded;
                message = status.Message;
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                status = _cvlsThreadedComPortRef.IniDownloader.GetFull(out iniFile);
                transferSuccessfull = status.TransferState == TransferState.Succeeded;
                message = status.Message;

                //transferSuccessfull = _cvlsThreadedComPortRef.Protocol.Configurations.DownloadIni(out iniFile, out message);
            }

            if (transferSuccessfull)
            {
                // download successfull, save to a file
                var file = CrossThreadDialogs.SaveAsFilename("INI Files (*.ini)|*.ini|All Files (*.*)|*.*");
                if (file.Length > 0)
                {
                    try
                    {
                        File.WriteAllText(file, iniFile);
                        CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                        {
                            Message = "Configuration Saved!",
                            Title = "INI Downloader Status"
                        });
                    }
                    catch
                    {
                        CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                        {
                            Message = "Could not write file to location!",
                            Title = "INI Downloader Status"
                        });
                    }
                }
                //else
                //{
                //    CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                //    {
                //        Message = "Save Canceled!",
                //        Title = "INI Downloader Status"
                //    });
                //}
            }
            else
            {
                CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                {
                    Message = message,
                    Title = "INI Downloader Status"
                });
            }
        }

        private void importINI_Click(object sender, EventArgs e)
        {
            string fileName;
            var message = "";

            if (!File.Exists(fileName = CrossThreadDialogs.OpenFilename("INI Files (*.ini)|*.ini|All Files (*.*)|*.*")))
                return;

            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            TransferStatus status;
            if (_binarySocketRef.IsConnected)
            {
                status = _binarySocketRef.IniUploader.UploadFull(fileStream);
                message = status.Message;
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                status = _cvlsThreadedComPortRef.IniUploader.UploadFull(fileStream);
                message = status.Message;

                //_cvlsThreadedComPortRef.Protocol.Configurations.UploadIni(fileStream, out message);
            }

            CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
            {
                Message = message,
                Title = "INI Uploader Status"
            });
        }

        private void login_Click(object sender, EventArgs e)
        {
            GlobalFunctions.BinaryLogin(_binarySocketRef);
        }

        #endregion
        
    }

}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SCHOTT.Core.Utilities;
using SCHOTT.CVLS.Communications;
using SCHOTT.CVLS.Enums;
using SCHOTT.CVLS.Ethernet.Binary;
using SCHOTT.CVLS.Ethernet.Binary.Enums;
using SCHOTT.CVLS.Serial;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    public partial class Status : DockContent
    {
        private readonly BinarySocket _binarySocketRef;
        private readonly CVLSThreadedComPort _cvlsThreadedComPortRef;

        private readonly Timer _statusUpdateTimer = new Timer();
        private readonly List<Label> _statusLabels = new List<Label>();

        public Status(CVLSThreadedComPort cvlsThreadedComPort, BinarySocket binarySocket)
        {
            InitializeComponent();
            
            _binarySocketRef = binarySocket;
            _binarySocketRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());
            _binarySocketRef.RegisterStatusUpdate(MessageBroker.MessageContext.NewThreadToGui, DisplayStatus);

            _cvlsThreadedComPortRef = cvlsThreadedComPort;
            _cvlsThreadedComPortRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());

            _statusUpdateTimer.Tick += StatusUpdateTimer_Tick;
            _statusUpdateTimer.Interval = 500;

            SetupStatusLabels();
            DisplayControls();
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }
        
        private void formStatus_Load(object sender, EventArgs e)
        {
            var controlMonitor = new DetectEnterExit(scrollPanel);
            controlMonitor.ControlEnter += ControlMonitor_ControlEnter;
        }

        private void ControlMonitor_ControlEnter(Control pnl)
        {
            scrollPanel.Focus();
        }

        #region Events

        private void StatusUpdateTimer_Tick(object sender, EventArgs e)
        {
            DisplayStatus(_cvlsThreadedComPortRef.Protocol?.Status.GetAll());
        }

        private void getSettings_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        #endregion

        #region Internal Functions

        private void SetupStatusLabels()
        {
            _statusLabels.Add(LEDTemp);
            _statusLabels.Add(LEDSensor);
            _statusLabels.Add(BoardTemp);
            _statusLabels.Add(BoardSensor);
            _statusLabels.Add(RefVoltage);
            _statusLabels.Add(InputVoltage);
            _statusLabels.Add(FanSpeed);
            _statusLabels.Add(SystemMode);
            _statusLabels.Add(Equalizer);
            _statusLabels.Add(LightFeedBack);
            _statusLabels.Add(LastCommand);
            _statusLabels.Add(UserModeLabel);
            _statusLabels.Add(KnobMode);
            _statusLabels.Add(SystemDate);
            _statusLabels.Add(SettingsWriteCount);
            _statusLabels.Add(FactoryWriteCount);
            _statusLabels.Add(SPIEraseCount);
            _statusLabels.Add(ErrorLogCount);
            _statusLabels.Add(Serial);
        }

        private void DisplayControls()
        {
            _statusUpdateTimer.Enabled = false;

            if (_binarySocketRef?.IsConnected == true)
            {
                SendPollingFrequency();

                statusTable.Visible = true;
                ConnectionRequired.Visible = false;
                CurrentStatusRefresh.Visible = false;
            }
            else if (_cvlsThreadedComPortRef?.IsConnected == true)
            {
                statusTable.Visible = true;
                ConnectionRequired.Visible = false;

                if (_cvlsThreadedComPortRef.Protocol?.FirmwareVersion >= 1.12 && _cvlsThreadedComPortRef.IsHighSpeed())
                {
                    // firmware is new enough to autopoll and we are connected with USB so it is fast enough
                    _statusUpdateTimer.Enabled = true;
                    CurrentStatusRefresh.Visible = false;
                }
                else
                {
                    // any other com port configuration has to use the manual polling
                    CurrentStatusRefresh.Visible = true;
                }
            }
            else
            {
                statusTable.Visible = false;
                ConnectionRequired.Visible = true;
                CurrentStatusRefresh.Visible = false;
            }

            CurrentStatusRefresh.ResizeGroupBox();
        }

        private void ClearStatus()
        {
            _statusLabels.ForEach(label =>
            {
                label.Text = @"-";
                label.BackColor = SystemColors.Control;
            });
        }

        private void ControlClear(Label c)
        {
            c.Text = @"-";
            c.BackColor = SystemColors.Control;
        }

        private void RefreshPage()
        {
            if (_cvlsThreadedComPortRef.Protocol?.FirmwareVersion >= 1.12)
            {
                DisplayStatus(_cvlsThreadedComPortRef.Protocol?.Status.GetAll());
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    #region Poll Status

                    var tempDouble = _cvlsThreadedComPortRef.Protocol?.Status.TemperatureLed.Temperature ?? -1;
                    var tempStatus = _cvlsThreadedComPortRef.Protocol?.Status.TemperatureLed.Status ?? StatusIndicators.ComError;
                    if (tempDouble < 0  || tempStatus == StatusIndicators.ComError)
                    {
                        ControlClear(LEDTemp);
                    }
                    else
                    {
                        LEDTemp.Text = $@"{tempDouble:0.0}C";
                        LEDTemp.BackColor = EnumConversion.StatusColor(tempStatus);
                    }

                    tempStatus = _cvlsThreadedComPortRef.Protocol?.Status.TemperatureLed.ThermistorStatus ?? StatusIndicators.ComError;
                    if (tempStatus == StatusIndicators.ComError)
                    {
                        ControlClear(LEDSensor);
                    }
                    else
                    {
                        LEDSensor.Text = EnumConversion.ThermistorIndicatorStrings[(int)tempStatus];
                        LEDSensor.BackColor = EnumConversion.StatusColor(tempStatus);
                    }

                    tempDouble = _cvlsThreadedComPortRef.Protocol?.Status.TemperatureBoard.Temperature ?? -1;
                    tempStatus = _cvlsThreadedComPortRef.Protocol?.Status.TemperatureBoard.Status ?? StatusIndicators.ComError;
                    if (tempDouble < 0 || tempStatus == StatusIndicators.ComError)
                    {
                        ControlClear(BoardTemp);
                    }
                    else
                    {
                        BoardTemp.Text = $@"{tempDouble:0.0}C";
                        BoardTemp.BackColor = EnumConversion.StatusColor(tempStatus);
                    }

                    tempStatus = _cvlsThreadedComPortRef.Protocol?.Status.TemperatureBoard.ThermistorStatus ?? StatusIndicators.ComError;
                    if (tempStatus == StatusIndicators.ComError)
                    {
                        ControlClear(BoardSensor);
                    }
                    else
                    {
                        BoardSensor.Text = EnumConversion.ThermistorIndicatorStrings[(int)tempStatus];
                        BoardSensor.BackColor = EnumConversion.StatusColor(tempStatus);
                    }

                    tempDouble = _cvlsThreadedComPortRef.Protocol?.Status.VoltageRefOut.Voltage ?? -1;
                    tempStatus = _cvlsThreadedComPortRef.Protocol?.Status.VoltageRefOut.Status ?? StatusIndicators.ComError;
                    if (tempDouble < 0)
                    {
                        ControlClear(RefVoltage);
                    }
                    else
                    {
                        RefVoltage.Text = $@"{tempDouble:0.0}V";
                        if (tempStatus == StatusIndicators.ComError)
                        {
                            var variance = Math.Abs(tempDouble - 5.0) * 20.0;
                            if (variance > 5.0)
                            {
                                RefVoltage.BackColor = EnumConversion.StatusColor(StatusIndicators.Error);
                            }
                            else if (variance > 2.0)
                            {
                                RefVoltage.BackColor = EnumConversion.StatusColor(StatusIndicators.Warning);
                            }
                            else
                            {
                                RefVoltage.BackColor = EnumConversion.StatusColor(StatusIndicators.Good);
                            }
                        }
                        else
                        {
                            RefVoltage.BackColor = EnumConversion.StatusColor(tempStatus);
                        }
                    }

                    tempDouble = _cvlsThreadedComPortRef.Protocol?.Status.VoltageInput.Voltage ?? -1;
                    tempStatus = _cvlsThreadedComPortRef.Protocol?.Status.VoltageInput.Status ?? StatusIndicators.ComError;
                    if (tempDouble < 0)
                    {
                        ControlClear(InputVoltage);
                    }
                    else
                    {
                        InputVoltage.Text = $@"{tempDouble:0.0}V";
                        
                        if (tempStatus == StatusIndicators.ComError)
                        {
                            if (tempDouble > 30.0 || tempDouble < 18)
                            {
                                InputVoltage.BackColor = EnumConversion.StatusColor(StatusIndicators.Error);
                            }
                            else if (tempDouble > 28.0 || tempDouble < 19)
                            {
                                InputVoltage.BackColor = EnumConversion.StatusColor(StatusIndicators.Warning);
                            }
                            else
                            {
                                InputVoltage.BackColor = EnumConversion.StatusColor(StatusIndicators.Good);
                            }
                        }
                        else
                        {
                            InputVoltage.BackColor = EnumConversion.StatusColor(tempStatus);
                        }
                    }

                    var tempInt = _cvlsThreadedComPortRef.Protocol?.Status.Fan.Speed ?? -1;
                    tempStatus = _cvlsThreadedComPortRef.Protocol?.Status.Fan.Status ?? StatusIndicators.ComError;
                    if (tempInt == -1)
                    {
                        ControlClear(FanSpeed);
                    }
                    else
                    {
                        if (tempStatus == StatusIndicators.ComError)
                        {
                            FanSpeed.Text = $@"{tempInt}RPM";
                            FanSpeed.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                        }
                        else
                        {
                            FanSpeed.Text = tempStatus == StatusIndicators.Off ? "Off" : $@"{tempInt}RPM";
                            FanSpeed.BackColor = EnumConversion.StatusColor(tempStatus);
                        }
                    }

                    var mode = _cvlsThreadedComPortRef.Protocol?.Status.System.SystemMode ?? Enums.SystemMode.ComError;
                    if (mode == Enums.SystemMode.ComError)
                    {
                        if (_cvlsThreadedComPortRef.Protocol?.Controls.Led.DemoMode == true)
                            mode = Enums.SystemMode.Demo;
                        else if (_cvlsThreadedComPortRef.Protocol?.Controls.Equalizer.Enable == true)
                            mode = Enums.SystemMode.Equalizer;
                        else if (_cvlsThreadedComPortRef.Protocol?.Controls.TriggeredStrobe.Enable == true)
                            mode = Enums.SystemMode.TriggeredStrobe;
                        else if (_cvlsThreadedComPortRef.Protocol?.Controls.ContinuousStrobe.Enable == true)
                            mode = Enums.SystemMode.ContinuousStrobe;
                        else
                            mode = Enums.SystemMode.Constant;
                    }

                    SystemMode.Text = EnumConversion.SystemModeStrings[(int)mode];
                    SystemMode.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

                    if (mode == Enums.SystemMode.Equalizer)
                    {
                        var equalizerMode = _cvlsThreadedComPortRef.Protocol?.Status.Equalizer.Mode ?? EqualizerStatus.ComError;
                        var equalizerStatus = _cvlsThreadedComPortRef.Protocol?.Status.Equalizer.Status ?? StatusIndicators.ComError;
                        if (equalizerMode == EqualizerStatus.ComError)
                        {
                            ControlClear(Equalizer);
                        }
                        else
                        {
                            Equalizer.Text = EnumConversion.EqualizerStrings[(int)equalizerMode];
                            if (equalizerStatus == StatusIndicators.ComError)
                            {
                                Equalizer.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                            }
                            else
                            {
                                Equalizer.BackColor = EnumConversion.StatusColor(equalizerStatus);
                            }
                        }
                    }
                    else
                    {
                        Equalizer.Text = @"Off";
                        Equalizer.BackColor = EnumConversion.StatusColor(StatusIndicators.Off);
                    }

                    tempInt = _cvlsThreadedComPortRef.Protocol?.Status.System.LightFeedBack ?? -1;
                    if (tempInt == -1)
                    {
                        ControlClear(LightFeedBack);
                    }
                    else
                    {
                        LightFeedBack.Text = $@"{tempInt}";
                        LightFeedBack.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    var lastCommand = _cvlsThreadedComPortRef.Protocol?.Status.System.LastCommandSource ?? CommandSource.ComError;
                    if (lastCommand == CommandSource.ComError)
                    {
                        ControlClear(LastCommand);
                    }
                    else
                    {
                        LastCommand.Text = EnumConversion.CommandSourceStrings[(int)lastCommand];
                        LastCommand.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    var userMode = _cvlsThreadedComPortRef.Protocol?.Status.System.SystemUserMode ?? UserMode.ComError;
                    if (userMode == UserMode.ComError)
                    {
                        ControlClear(UserModeLabel);
                    }
                    else
                    {
                        UserModeLabel.Text = EnumConversion.UserModeStrings[(int)userMode];
                        UserModeLabel.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    var knobMode = _cvlsThreadedComPortRef.Protocol?.Status.System.KnobMode ?? KnobControl.ComError;
                    if (knobMode == KnobControl.ComError)
                    {
                        ControlClear(KnobMode);
                    }
                    else
                    {
                        KnobMode.Text = EnumConversion.KnobControlStrings[(int)knobMode];
                        KnobMode.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    var systemTime = _cvlsThreadedComPortRef.Protocol?.Status.System.Time;
                    if (systemTime == null || systemTime.TimeRaw == 0)
                    {
                        ControlClear(SystemDate);
                    }
                    else
                    {
                        SystemDate.Text = systemTime.TimeString;
                        SystemDate.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    tempInt = _cvlsThreadedComPortRef.Protocol?.Status.Memory.CustomerSettings ?? -1;
                    if (tempInt == -1)
                    {
                        ControlClear(SettingsWriteCount);
                    }
                    else
                    {
                        SettingsWriteCount.Text = $@"{tempInt}";
                        SettingsWriteCount.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    tempInt = _cvlsThreadedComPortRef.Protocol?.Status.Memory.FactorySettings ?? -1;
                    if (tempInt == -1)
                    {
                        ControlClear(FactoryWriteCount);
                    }
                    else
                    {
                        FactoryWriteCount.Text = $@"{tempInt}";
                        FactoryWriteCount.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    tempInt = _cvlsThreadedComPortRef.Protocol?.Status.Memory.Firmware ?? -1;
                    if (tempInt == -1)
                    {
                        ControlClear(SPIEraseCount);
                    }
                    else
                    {
                        SPIEraseCount.Text = $@"{tempInt}";
                        SPIEraseCount.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    tempInt = _cvlsThreadedComPortRef.Protocol?.Status.Memory.Exceptions ?? -1;
                    if (tempInt == -1)
                    {
                        ControlClear(ErrorLogCount);
                    }
                    else
                    {
                        ErrorLogCount.Text = $@"{tempInt}";
                        ErrorLogCount.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    var tempString = _cvlsThreadedComPortRef.Protocol?.Status.Identification.SerialFull ?? "Com Error!";
                    if (tempString.Equals("Com Error!"))
                    {
                        ControlClear(Serial);
                    }
                    else
                    {
                        Serial.Text = tempString;
                        Serial.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                    }

                    #endregion
                }
                catch
                {
                    // ignored
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void DisplayStatus(StatusObject status)
        {
            if (status == null)
            {
                ClearStatus();
                return;
            }

            #region Status Label Updates

            LEDTemp.Text = $@"{status.TemperatureLed.Temperature:f1} C";
            LEDTemp.BackColor = EnumConversion.StatusColor(status.TemperatureLed.Status);
            LEDSensor.Text = EnumConversion.ThermistorIndicatorStrings[(uint)status.TemperatureLed.ThermistorStatus];
            LEDSensor.BackColor = EnumConversion.StatusColor(status.TemperatureLed.ThermistorStatus);

            BoardTemp.Text = $@"{status.TemperatureBoard.Temperature:f1} C";
            BoardTemp.BackColor = EnumConversion.StatusColor(status.TemperatureBoard.Status);
            BoardSensor.Text = EnumConversion.ThermistorIndicatorStrings[(uint)status.TemperatureBoard.ThermistorStatus];
            BoardSensor.BackColor = EnumConversion.StatusColor(status.TemperatureBoard.ThermistorStatus);

            RefVoltage.Text = $@"{status.VoltageRefOut.Voltage:f2} V";
            RefVoltage.BackColor = EnumConversion.StatusColor(status.VoltageRefOut.Status);

            InputVoltage.Text = $@"{status.VoltageInput.Voltage:f2} V";
            InputVoltage.BackColor = EnumConversion.StatusColor(status.VoltageInput.Status);

            FanSpeed.Text = status.Fan.Status == StatusIndicators.Off ? @"Off" : $@"{status.Fan.Speed} RPM";
            FanSpeed.BackColor = EnumConversion.StatusColor(status.Fan.Status);

            SystemMode.Text = EnumConversion.SystemModeStrings[(uint)status.System.Mode];
            SystemMode.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            if (status.System.Mode == Enums.SystemMode.Equalizer)
            {
                Equalizer.Text = EnumConversion.EqualizerStrings[(uint)status.Equalizer.Mode];
                Equalizer.BackColor = EnumConversion.StatusColor(status.Equalizer.Status);
            }
            else
            {
                Equalizer.Text = @"Off";
                Equalizer.BackColor = EnumConversion.StatusColor(StatusIndicators.Off);
            }

            LightFeedBack.Text = $@"{status.System.LightFeedBack}";
            LightFeedBack.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            LastCommand.Text = EnumConversion.CommandSourceStrings[(uint)status.System.LastCommandSource];
            LastCommand.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            UserModeLabel.Text = EnumConversion.UserModeStrings[(uint)status.System.UserMode];
            UserModeLabel.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            KnobMode.Text = EnumConversion.KnobControlStrings[(uint)status.System.KnobMode];
            KnobMode.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            SystemDate.Text = status.System.Time.TimeString;
            SystemDate.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            SettingsWriteCount.Text = $@"{status.Memory.CustomerSettings}";
            SettingsWriteCount.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            FactoryWriteCount.Text = $@"{status.Memory.FactorySettings}";
            FactoryWriteCount.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            SPIEraseCount.Text = $@"{status.Memory.Firmware}";
            SPIEraseCount.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            ErrorLogCount.Text = $@"{status.Memory.Exceptions}";
            ErrorLogCount.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            Serial.Text = status.Identification.SerialFull;
            Serial.BackColor = EnumConversion.StatusColor(StatusIndicators.Info);

            #endregion
        }

        #endregion

        #region External Functions

        public void SendPollingFrequency()
        {
            _binarySocketRef.SendBinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportStatus,
                   true, new List<byte> { (byte)PollerFrequencies.Poller10Hz });
        }

        public void SendPollingStop()
        {
            _binarySocketRef.SendBinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportStatus,
                   true, new List<byte> { 0 });
        }

        #endregion
        
    }
}

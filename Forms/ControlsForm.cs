using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using SCHOTT.Core.Utilities;
using SCHOTT.CVLS.Communications;
using SCHOTT.CVLS.Dashboard.Utilities;
using SCHOTT.CVLS.Enums;
using SCHOTT.CVLS.Ethernet.Binary;
using SCHOTT.CVLS.Ethernet.Binary.Enums;
using SCHOTT.CVLS.Serial;
using SCHOTT.CVLS.Utilities;
using SCHOTT.WinForms.Controls.Buttons;
using SCHOTT.WinForms.Controls.Combo_Controls;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    public partial class ControlsForm : DockContent
    {
        private readonly Docking _dockingObject;
        private readonly BinarySocket _binarySocketRef;
        private readonly CVLSThreadedComPort _cvlsThreadedComPortRef;
        
        private readonly List<ToggleButton> _ledChannelPowerButton = new List<ToggleButton>();
        private readonly List<SliderNumericCombo> _ledChannelPowerSlider = new List<SliderNumericCombo>();
        private readonly List<ToggleButton> _ledChannelShutdownButton = new List<ToggleButton>();

        private readonly List<SliderNumericCombo> _continuousChannelDutyCycleSliders = new List<SliderNumericCombo>();
        private readonly List<SliderNumericCombo> _continuousChannelPhaseShiftSliders = new List<SliderNumericCombo>();
        private readonly List<ToggleButton> _continuousChannelActiveHighButton = new List<ToggleButton>();

        private readonly List<SliderNumericCombo> _triggeredChannelDelaySliders = new List<SliderNumericCombo>();
        private readonly List<SliderNumericCombo> _triggeredChannelOnTimeSliders = new List<SliderNumericCombo>();
        private readonly List<ToggleButton> _triggeredChannelFallingEdgeButton = new List<ToggleButton>();

        private readonly Timer _controlsUpdateTimer = new Timer();

        public ControlsForm(Docking dockingObject, CVLSThreadedComPort cvlsThreadedComPort, BinarySocket binarySocket)
        {
            InitializeComponent();
            DisplayControls();

            _dockingObject = dockingObject;

            _binarySocketRef = binarySocket;
            _binarySocketRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());
            _binarySocketRef.RegisterLoginUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());
            _binarySocketRef.RegisterControlsUpdate(MessageBroker.MessageContext.NewThreadToGui, DisplayUpdate);

            _cvlsThreadedComPortRef = cvlsThreadedComPort;
            _cvlsThreadedComPortRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());

            _controlsUpdateTimer.Interval = 500;
            _controlsUpdateTimer.Tick += ControlsUpdateTimer_Tick;
            
            #region setup LED settings lists
            _ledChannelPowerButton.Add(LEDChannel1PowerButton);
            _ledChannelPowerButton.Add(LEDChannel2PowerButton);
            _ledChannelPowerButton.Add(LEDChannel3PowerButton);
            _ledChannelPowerButton.Add(LEDChannel4PowerButton);

            _ledChannelPowerSlider.Add(LEDChannel1Output);
            _ledChannelPowerSlider.Add(LEDChannel2Output);
            _ledChannelPowerSlider.Add(LEDChannel3Output);
            _ledChannelPowerSlider.Add(LEDChannel4Output);
            
            _ledChannelShutdownButton.Add(LEDChannel1ShutdownButton);
            _ledChannelShutdownButton.Add(LEDChannel2ShutdownButton);
            _ledChannelShutdownButton.Add(LEDChannel3ShutdownButton);
            _ledChannelShutdownButton.Add(LEDChannel4ShutdownButton);
            #endregion

            #region setup continuous strobe lists
            _continuousChannelDutyCycleSliders.Add(ContinuousChannel1DutyCycle);
            _continuousChannelDutyCycleSliders.Add(ContinuousChannel2DutyCycle);
            _continuousChannelDutyCycleSliders.Add(ContinuousChannel3DutyCycle);
            _continuousChannelDutyCycleSliders.Add(ContinuousChannel4DutyCycle);
            
            _continuousChannelPhaseShiftSliders.Add(ContinuousChannel1PhaseShift);
            _continuousChannelPhaseShiftSliders.Add(ContinuousChannel2PhaseShift);
            _continuousChannelPhaseShiftSliders.Add(ContinuousChannel3PhaseShift);
            _continuousChannelPhaseShiftSliders.Add(ContinuousChannel4PhaseShift);
            
            _continuousChannelActiveHighButton.Add(ContinuousChannel1WaveformActiveHigh);
            _continuousChannelActiveHighButton.Add(ContinuousChannel2WaveformActiveHigh);
            _continuousChannelActiveHighButton.Add(ContinuousChannel3WaveformActiveHigh);
            _continuousChannelActiveHighButton.Add(ContinuousChannel4WaveformActiveHigh);
            #endregion

            #region setup triggered strobe lists
            _triggeredChannelDelaySliders.Add(TriggeredChannel1Delay);
            _triggeredChannelDelaySliders.Add(TriggeredChannel2Delay);
            _triggeredChannelDelaySliders.Add(TriggeredChannel3Delay);
            _triggeredChannelDelaySliders.Add(TriggeredChannel4Delay);
            
            _triggeredChannelOnTimeSliders.Add(TriggeredChannel1OnTime);
            _triggeredChannelOnTimeSliders.Add(TriggeredChannel2OnTime);
            _triggeredChannelOnTimeSliders.Add(TriggeredChannel3OnTime);
            _triggeredChannelOnTimeSliders.Add(TriggeredChannel4OnTime);
            
            _triggeredChannelFallingEdgeButton.Add(TriggeredChannel1FallingEdgeEnable);
            _triggeredChannelFallingEdgeButton.Add(TriggeredChannel2FallingEdgeEnable);
            _triggeredChannelFallingEdgeButton.Add(TriggeredChannel3FallingEdgeEnable);
            _triggeredChannelFallingEdgeButton.Add(TriggeredChannel4FallingEdgeEnable);
            #endregion
            
        }
        
        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }
        
        private void formControls_Load(object sender, EventArgs e)
        {
            var controlMonitor = new DetectEnterExit(scrollPanel);
            controlMonitor.ControlEnter += ControlMonitor_ControlEnter;
        }

        private void ControlMonitor_ControlEnter(Control pnl)
        {
            scrollPanel.Focus();
        }
        
        #region Control Accessors
        
        private int KnobMode
        {
            set
            {
                if (_knobModeSuspend)
                {
                    if (_knobModeSelected != value)
                        return;

                    _knobModeSuspend = false;
                    scrollPanel.Focus();
                }
                else
                {
                    if (knobMode.SelectedIndex != value && knobMode.Items.Count > value)
                    {
                        knobMode.SelectedIndex = value;
                    }
                }
            }
        }

        #endregion

        #region External Functions

        public void ResizeTable()
        {
            typeof(Control).GetMethod("OnResize",
             BindingFlags.Instance | BindingFlags.NonPublic)
             .Invoke(formLayoutPanel, new object[] { EventArgs.Empty });
        }

        public void SendPollingFrequency()
        {
            _binarySocketRef.SendBinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportControls,
                   true, new List<byte> { (byte)PollerFrequencies.Poller10Hz });
        }

        public void SendPollingStop()
        {
            _binarySocketRef.SendBinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportControls,
                   true, new List<byte> { 0 });
        }
        
        public void DisplayControls()
        {
            _controlsUpdateTimer.Enabled = false;

            if (_binarySocketRef?.IsConnected == true)
            {
                Connection.Visible = false;
                CurrentSettings.Visible = false;

                if (_binarySocketRef?.UserPermissions == BinarySocket.LoginPermissions.Disabled)
                {
                    UserLevel.Visible = true;
                    scrollPanel.Visible = false;

                    SendPollingStop();
                }
                else
                {
                    UserLevel.Visible = false;
                    scrollPanel.Visible = true;

                    SendPollingFrequency();
                }
            }
            else if (_cvlsThreadedComPortRef?.IsConnected == true)
            {
                UserLevel.Visible = false;
                Connection.Visible = false;
                scrollPanel.Visible = true;

                if (_cvlsThreadedComPortRef.Protocol?.FirmwareVersion >= 1.12 && _cvlsThreadedComPortRef.IsHighSpeed())
                {
                    // firmware is new enough to autopoll and we are connected with USB so it is fast enough
                    _controlsUpdateTimer.Enabled = true;
                    CurrentSettings.Visible = false;
                }
                else
                {
                    // any other com port configuration has to use the manual polling
                    CurrentSettings.Visible = true;
                    RefreshPage();
                }
                
            }
            else
            {
                UserLevel.Visible = false;
                Connection.Visible = true;
                CurrentSettings.Visible = false;
                scrollPanel.Visible = false;
            }

            CurrentSettings.ResizeGroupBox();
        }
        
        #endregion

        #region Form Update

        private void ControlsUpdateTimer_Tick(object sender, EventArgs e)
        {
            DisplayUpdate(_cvlsThreadedComPortRef.Protocol?.Controls.GetAll());
        }

        private void RefreshPage()
        {
            if (_cvlsThreadedComPortRef.Protocol?.FirmwareVersion >= 1.12)
            {
                DisplayUpdate(_cvlsThreadedComPortRef.Protocol?.Controls.GetAll());
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    #region LED Settings

                    LEDDemoMode.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.Led.DemoMode == true);
                    LEDCombinedTrigger.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.Led.TriggerMode == TriggerModes.Combined);
                    KnobMode = (int)(_cvlsThreadedComPortRef.Protocol?.Controls.Led.KnobMode ?? KnobControl.Common);
                    LedSingleChannelDisplay(LEDSingleChannelOperation.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.Led.ChannelMode == ChannelModes.Single));
                    LEDOutputPowerButton.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.Led.Enable == true);
                    LEDOutput.Value = (int)((_cvlsThreadedComPortRef.Protocol?.Controls.Led.Power ?? 0) * 10.0);

                    Channels channel;
                    for (var j = 0; j < 4; j++)
                    {
                        channel = (Channels)(j + 1);
                        _ledChannelPowerButton[j].ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.Led.Channel(channel).Enabled == true);
                        _ledChannelPowerSlider[j].Value = (int)((_cvlsThreadedComPortRef.Protocol?.Controls.Led.Channel(channel).Power ?? 0) * 10.0);
                        _ledChannelShutdownButton[j].ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.Led.Channel(channel).ShutdownPolarity == SignalPolarity.ActiveHigh);
                    }

                    #endregion

                    #region Continuous Strobe

                    ContinuousStrobeEnable.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.ContinuousStrobe.Enable == true);
                    ContinuousSingleChannelDisplay(ContinuousSingleChannelEnable.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.ContinuousStrobe.ChannelMode == ChannelModes.Single));
                    ContinuousFrequency.Value = _cvlsThreadedComPortRef.Protocol?.Controls.ContinuousStrobe.Frequency ?? 6;

                    for (var j = 0; j < 4; j++)
                    {
                        channel = (Channels)(j + 1);
                        _continuousChannelDutyCycleSliders[j].Value = (int)((_cvlsThreadedComPortRef.Protocol?.Controls.ContinuousStrobe.Channel(channel).DutyCycle ?? 0) * 10.0);
                        _continuousChannelPhaseShiftSliders[j].Value = (int)((_cvlsThreadedComPortRef.Protocol?.Controls.ContinuousStrobe.Channel(channel).PhaseShift ?? 0) * 10.0);
                        _continuousChannelActiveHighButton[j].ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.ContinuousStrobe.Channel(channel).WavePolarity == SignalPolarity.ActiveHigh);
                    }

                    #endregion

                    #region Triggered Strobe

                    TriggeredStrobeEnable.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.TriggeredStrobe.Enable == true);
                    TriggeredStrobeGangedEnable.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.TriggeredStrobe.TriggerMode == TriggerModes.Combined);
                    TriggeredSingleChannelDisplay(TriggeredSingleChannelEnable.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.TriggeredStrobe.ChannelMode == ChannelModes.Single));

                    for (var j = 0; j < 4; j++)
                    {
                        channel = (Channels)(j + 1);
                        _triggeredChannelDelaySliders[j].Value = _cvlsThreadedComPortRef.Protocol?.Controls.TriggeredStrobe.Channel(channel).Delay ?? 0;
                        _triggeredChannelOnTimeSliders[j].Value = _cvlsThreadedComPortRef.Protocol?.Controls.TriggeredStrobe.Channel(channel).OnTime ?? 0;
                        _triggeredChannelFallingEdgeButton[j].ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.TriggeredStrobe.Channel(channel).EdgeType == EdgeTypes.FallingEdge);
                    }

                    #endregion

                    #region Equalizer Settings

                    EqualizerEnable.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.Equalizer.Enable == true);
                    EqualizerDelay.Value = _cvlsThreadedComPortRef.Protocol?.Controls.Equalizer.Delay ?? 0;
                    EqualizerTargetLight.Value = _cvlsThreadedComPortRef.Protocol?.Controls.Equalizer.Target ?? 0;
                    EqualizerLightOutput.Text = _cvlsThreadedComPortRef.Protocol?.Controls.Equalizer.LightOutput.ToString();
                    EqualizerPowerOutput.Text = _cvlsThreadedComPortRef.Protocol?.Controls.Equalizer.PowerOutput.ToString("0.0");

                    #endregion

                    #region Fan Settings

                    FanManualControlEnable.ToggleSet(_cvlsThreadedComPortRef.Protocol?.Controls.Fan.ManualOverride == true);
                    FanSpeed.Value = (int)((_cvlsThreadedComPortRef.Protocol?.Controls.Fan.Speed ?? 0) * 10.0);
                    FanTargetTemp.Value = (int)((_cvlsThreadedComPortRef.Protocol?.Controls.Fan.TargetTemperature ?? 0) * 10.0);

                    #endregion

                    Cursor.Current = Cursors.Default;
                    return;
                }
                catch
                {
                    // ignored
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void DisplayUpdate(ControlsObject controlsObject)
        {
            if (controlsObject == null)
                return;

            #region LED Settings

            LEDDemoMode.ToggleSet(controlsObject.Led.DemoMode);
            LEDCombinedTrigger.ToggleSet(controlsObject.Led.TriggerMode == TriggerModes.Combined);
            KnobMode = (int)controlsObject.Led.KnobMode;
            LedSingleChannelDisplay(LEDSingleChannelOperation.ToggleSet(controlsObject.Led.ChannelMode == ChannelModes.Single));
            LEDOutputPowerButton.ToggleSet(controlsObject.Led.Enable);
            LEDOutput.Value = (int)(controlsObject.Led.Power * 10.0);

            for (var j = 1; j <= 4; j++)
            {
                _ledChannelPowerButton[j - 1].ToggleSet(controlsObject.Led.Channel((Channels)j).Enabled);
                _ledChannelPowerSlider[j - 1].Value = (int)(controlsObject.Led.Channel((Channels)j).Power * 10.0);
                _ledChannelShutdownButton[j - 1].ToggleSet(controlsObject.Led.Channel((Channels)j).ShutdownPolarity == SignalPolarity.ActiveHigh);
            }

            #endregion

            #region Continuous Strobe

            ContinuousStrobeEnable.ToggleSet(controlsObject.ContinuousStrobe.Enable);
            ContinuousSingleChannelDisplay(ContinuousSingleChannelEnable.ToggleSet(controlsObject.ContinuousStrobe.ChannelMode == ChannelModes.Single));
            ContinuousFrequency.Value = controlsObject.ContinuousStrobe.Frequency;

            for (var j = 1; j <= 4; j++)
            {
                _continuousChannelDutyCycleSliders[j - 1].Value = (int)(controlsObject.ContinuousStrobe.Channel((Channels)j).DutyCycle * 10.0);
                _continuousChannelPhaseShiftSliders[j - 1].Value = (int)(controlsObject.ContinuousStrobe.Channel((Channels)j).PhaseShift * 10.0);
                _continuousChannelActiveHighButton[j - 1].ToggleSet(controlsObject.ContinuousStrobe.Channel((Channels)j).WavePolarity == SignalPolarity.ActiveHigh);
            }

            #endregion

            #region Triggered Strobe

            TriggeredStrobeEnable.ToggleSet(controlsObject.TriggeredStrobe.Enable);
            TriggeredStrobeGangedEnable.ToggleSet(controlsObject.TriggeredStrobe.TriggerMode == TriggerModes.Combined);
            TriggeredSingleChannelDisplay(TriggeredSingleChannelEnable.ToggleSet(controlsObject.TriggeredStrobe.ChannelMode == ChannelModes.Single));

            for (var j = 1; j <= 4; j++)
            {
                _triggeredChannelDelaySliders[j - 1].Value = controlsObject.TriggeredStrobe.Channel((Channels)j).Delay;
                _triggeredChannelOnTimeSliders[j - 1].Value = controlsObject.TriggeredStrobe.Channel((Channels)j).OnTime;
                _triggeredChannelFallingEdgeButton[j - 1].ToggleSet(controlsObject.TriggeredStrobe.Channel((Channels)j).EdgeType == EdgeTypes.FallingEdge);
            }

            #endregion

            #region Equalizer Settings

            EqualizerEnable.ToggleSet(controlsObject.Equalizer.Enable);
            EqualizerDelay.Value = controlsObject.Equalizer.Delay;
            EqualizerTargetLight.Value = controlsObject.Equalizer.Target;

            EqualizerLightOutput.Text = controlsObject.Equalizer.LightOutput.ToString();
            EqualizerPowerOutput.Text = controlsObject.Equalizer.PowerOutput.ToString("0.0");

            #endregion

            #region Fan Settings

            FanManualControlEnable.ToggleSet(controlsObject.Fan.ManualOverride);
            FanSpeed.Value = (int)(controlsObject.Fan.Speed * 10.0);
            FanTargetTemp.Value = (int)(controlsObject.Fan.TargetTemperature * 10.0);

            #endregion
        }
        
        #endregion

        #region Events

        #region LED Settings

        private void LEDDemoMode_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorDemoEnabled,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Led.DemoMode = ((ToggleButton) sender).Toggle();
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&d" + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }
        }

        private void LEDCombinedTrigger_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorLedGangedTriggerEnabled,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Led.TriggerMode = ((ToggleButton) sender).Toggle()
                    ? TriggerModes.Combined
                    : TriggerModes.Independent;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&j0," + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }
        }

        private bool _knobModeSuspend;
        private int _knobModeSelected;
        private void knobMode_DropDown(object sender, EventArgs e)
        {
            _knobModeSelected = -1;
            _knobModeSuspend = true;
        }

        private void knobMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!knobMode.Focused)
                return;

            _knobModeSelected = knobMode.SelectedIndex;

            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorLedKnobMode,
                    true, new List<byte> { (byte)_knobModeSelected });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Led.KnobMode = (KnobControl)_knobModeSelected;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&n" + _knobModeSelected);
            }
        }
        
        private void LedSingleChannelDisplay(bool singleChannelEnabled)
        {
            if (singleChannelEnabled)
            {
                LEDShowChannel2.Visible = false;
                LEDShowChannel3.Visible = false;
                LEDShowChannel4.Visible = false;
                LEDShowChannelAll.Visible = false;

                LEDChannel1Panel.Visible = true;
                LEDChannel2Panel.Visible = false;
                LEDChannel3Panel.Visible = false;
                LEDChannel4Panel.Visible = false;
                LEDChannelSettings.ResizeGroupBox();
            }
            else
            {
                LEDShowChannel2.Visible = true;
                LEDShowChannel3.Visible = true;
                LEDShowChannel4.Visible = true;
                LEDShowChannelAll.Visible = true;

                //LEDChannel1Panel.Visible = true;
                //LEDChannel2Panel.Visible = true;
                //LEDChannel3Panel.Visible = true;
                //LEDChannel4Panel.Visible = true;
                LEDChannelSettings.ResizeGroupBox();
            }
        }

        private void LEDSingleChannelOperation_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorLedSingleChannelEnabled,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Led.ChannelMode = ((ToggleButton) sender).Toggle()
                    ? ChannelModes.Single
                    : ChannelModes.Quad;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&b" + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }

            LedSingleChannelDisplay(((ToggleButton)sender).ToggleGet());
        }

        private void LEDOutputPowerButton_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorLedOutputEnabled,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Led.Enable = ((ToggleButton) sender).Toggle();
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&l0," + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }
        }

        private void LEDOutput_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorLedOutputPower,
                    true, DataConversions.ConvertUInt16ToList((ushort)value));
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Led.Power = value * 0.1;
                //_cvlsThreadedComPortRef.SendCommandSingle($"&i0,{value}", echoComTraffic: true);
            }
        }
        
        private void LEDShowChannel1_Click(object sender, EventArgs e)
        {
            LEDChannel1Panel.Visible = true;
            LEDChannel2Panel.Visible = false;
            LEDChannel3Panel.Visible = false;
            LEDChannel4Panel.Visible = false;
            LEDChannelSettings.ResizeGroupBox();
        }

        private void LEDShowChannel2_Click(object sender, EventArgs e)
        {
            LEDChannel1Panel.Visible = false;
            LEDChannel2Panel.Visible = true;
            LEDChannel3Panel.Visible = false;
            LEDChannel4Panel.Visible = false;
            LEDChannelSettings.ResizeGroupBox();
        }

        private void LEDShowChannel3_Click(object sender, EventArgs e)
        {
            LEDChannel1Panel.Visible = false;
            LEDChannel2Panel.Visible = false;
            LEDChannel3Panel.Visible = true;
            LEDChannel4Panel.Visible = false;
            LEDChannelSettings.ResizeGroupBox();
        }

        private void LEDShowChannel4_Click(object sender, EventArgs e)
        {
            LEDChannel1Panel.Visible = false;
            LEDChannel2Panel.Visible = false;
            LEDChannel3Panel.Visible = false;
            LEDChannel4Panel.Visible = true;
            LEDChannelSettings.ResizeGroupBox();
        }

        private void LEDShowChannelAll_Click(object sender, EventArgs e)
        {
            LEDChannel1Panel.Visible = true;
            LEDChannel2Panel.Visible = true;
            LEDChannel3Panel.Visible = true;
            LEDChannel4Panel.Visible = true;
            LEDChannelSettings.ResizeGroupBox();
        }

        private void LEDChannelPowerButton_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorLedChannelEnabled,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Channel - 1), (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Led.Channel((Channels)((ToggleButton)sender).Channel).Enabled = ((ToggleButton) sender).Toggle();
                //_cvlsThreadedComPortRef.SendCommandWithEcho($"&l{((ToggleButton)sender).Channel},{(((ToggleButton)sender).Toggle() ? "1" : "0")}");
            }
        }

        private void LEDChannelOutput_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                var tempList = new List<byte> { (byte)(control.Channel - 1) };
                tempList.AddRange(DataConversions.ConvertUInt16ToList((ushort)value));
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorLedChannelPower,
                    true, tempList);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Led.Channel((Channels)control.Channel).Power = value * 0.1;
                //_cvlsThreadedComPortRef.SendCommandWithEcho($"&i{control.Channel},{value}");
            }
        }

        private void LEDChannelShutdownButton_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorLedChannelShutdownActiveHigh,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Channel - 1), (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Led.Channel((Channels) ((ToggleButton) sender).Channel)
                    .ShutdownPolarity = ((ToggleButton) sender).Toggle()
                    ? SignalPolarity.ActiveHigh
                    : SignalPolarity.ActiveLow;
                //_cvlsThreadedComPortRef.SendCommandWithEcho($"&j{((ToggleButton)sender).Channel},{(((ToggleButton)sender).Toggle() ? "1" : "0")}");
            }
        }
        
        #endregion

        #region Continuous Strobe

        private void ContinuousStrobeEnable_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorContinuousStrobeEnabled,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.ContinuousStrobe.Enable = ((ToggleButton) sender).Toggle();
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&rm" + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }
        }
        
        private void ContinuousSingleChannelDisplay(bool singleChannelEnabled)
        {
            if (singleChannelEnabled)
            {
                ContinuousShowChannel2.Visible = false;
                ContinuousShowChannel3.Visible = false;
                ContinuousShowChannel4.Visible = false;
                ContinuousShowChannelAll.Visible = false;

                ContinuousChannel1Panel.Visible = true;
                ContinuousChannel2Panel.Visible = false;
                ContinuousChannel3Panel.Visible = false;
                ContinuousChannel4Panel.Visible = false;
                ContinuousChannelSettings.ResizeGroupBox();
            }
            else
            {
                ContinuousShowChannel2.Visible = true;
                ContinuousShowChannel3.Visible = true;
                ContinuousShowChannel4.Visible = true;
                ContinuousShowChannelAll.Visible = true;

                //ContinuousChannel1Panel.Visible = true;
                //ContinuousChannel2Panel.Visible = true;
                //ContinuousChannel3Panel.Visible = true;
                //ContinuousChannel4Panel.Visible = true;
                ContinuousChannelSettings.ResizeGroupBox();
            }
        }

        private void ContinuousSingleChannelEnable_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorContinuousStrobeSingleChannelEnabled,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.ContinuousStrobe.ChannelMode = ((ToggleButton)sender).Toggle()
                    ? ChannelModes.Single
                    : ChannelModes.Quad;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&rb" + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }

            ContinuousSingleChannelDisplay(((ToggleButton)sender).ToggleGet());
        }

        private void ContinuousFrequency_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorContinuousStrobeFrequency,
                    true, DataConversions.ConvertUInt16ToList((ushort)value));
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.ContinuousStrobe.Frequency = value;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&rf" + value);
            }
        }
        
        private void ContinuousShowChannel1_Click(object sender, EventArgs e)
        {
            ContinuousChannel1Panel.Visible = true;
            ContinuousChannel2Panel.Visible = false;
            ContinuousChannel3Panel.Visible = false;
            ContinuousChannel4Panel.Visible = false;
            ContinuousChannelSettings.ResizeGroupBox();
        }

        private void ContinuousShowChannel2_Click(object sender, EventArgs e)
        {
            ContinuousChannel1Panel.Visible = false;
            ContinuousChannel2Panel.Visible = true;
            ContinuousChannel3Panel.Visible = false;
            ContinuousChannel4Panel.Visible = false;
            ContinuousChannelSettings.ResizeGroupBox();
        }

        private void ContinuousShowChannel3_Click(object sender, EventArgs e)
        {
            ContinuousChannel1Panel.Visible = false;
            ContinuousChannel2Panel.Visible = false;
            ContinuousChannel3Panel.Visible = true;
            ContinuousChannel4Panel.Visible = false;
            ContinuousChannelSettings.ResizeGroupBox();
        }

        private void ContinuousShowChannel4_Click(object sender, EventArgs e)
        {
            ContinuousChannel1Panel.Visible = false;
            ContinuousChannel2Panel.Visible = false;
            ContinuousChannel3Panel.Visible = false;
            ContinuousChannel4Panel.Visible = true;
            ContinuousChannelSettings.ResizeGroupBox();
        }

        private void ContinuousShowChannelAll_Click(object sender, EventArgs e)
        {
            ContinuousChannel1Panel.Visible = true;
            ContinuousChannel2Panel.Visible = true;
            ContinuousChannel3Panel.Visible = true;
            ContinuousChannel4Panel.Visible = true;
            ContinuousChannelSettings.ResizeGroupBox();
        }

        private void ContinuousChannelDutyCycle_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                var tempList = new List<byte> { (byte)(control.Channel - 1) };
                tempList.AddRange(DataConversions.ConvertUInt16ToList((ushort)value));
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorContinuousStrobeChannelDutyCycle,
                    true, tempList);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.ContinuousStrobe.Channel((Channels)control.Channel).DutyCycle = value * 0.1;
                //_cvlsThreadedComPortRef.SendCommandWithEcho($"&rd{control.Channel},{value}");
            }
        }

        private void ContinuousChannelPhaseShift_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                var tempList = new List<byte> { (byte)(control.Channel - 1) };
                tempList.AddRange(DataConversions.ConvertUInt16ToList((ushort)value));
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorContinuousStrobeChannelPhaseShift,
                    true, tempList);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.ContinuousStrobe.Channel((Channels)control.Channel).PhaseShift = value * 0.1;
                //_cvlsThreadedComPortRef.SendCommandWithEcho($"&rp{control.Channel},{value}");
            }
        }

        private void ContinuousChannelWaveformActiveHigh_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorContinuousStrobeChannelActiveHigh,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Channel - 1), (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.ContinuousStrobe.Channel((Channels)((ToggleButton)sender).Channel).WavePolarity = ((ToggleButton)sender).Toggle()
                    ? SignalPolarity.ActiveHigh
                    : SignalPolarity.ActiveLow;
                //_cvlsThreadedComPortRef.SendCommandWithEcho($"&rj{((ToggleButton)sender).Channel},{(((ToggleButton)sender).Toggle() ? "1" : "0")}");
            }
        }
        
        #endregion

        #region Triggered Strobe

        private void TriggeredStrobeEnable_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorTriggeredStrobeEnabled,
                       true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.TriggeredStrobe.Enable = ((ToggleButton) sender).Toggle();
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&pm" + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }
        }

        private void TriggeredStrobeGangedEnable_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorTriggeredStrobeGangedTriggerEnabled,
                       true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.TriggeredStrobe.TriggerMode = ((ToggleButton)sender).Toggle() ? TriggerModes.Combined : TriggerModes.Independent;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&pj0," + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }
        }
        
        private void TriggeredSingleChannelDisplay(bool singleChannelEnabled)
        {
            if (singleChannelEnabled)
            {
                TriggeredShowChannel2.Visible = false;
                TriggeredShowChannel3.Visible = false;
                TriggeredShowChannel4.Visible = false;
                TriggeredShowChannelAll.Visible = false;

                TriggeredChannel1Panel.Visible = true;
                TriggeredChannel2Panel.Visible = false;
                TriggeredChannel3Panel.Visible = false;
                TriggeredChannel4Panel.Visible = false;
                TriggeredChannelSettings.ResizeGroupBox();
            }
            else
            {
                TriggeredShowChannel2.Visible = true;
                TriggeredShowChannel3.Visible = true;
                TriggeredShowChannel4.Visible = true;
                TriggeredShowChannelAll.Visible = true;

                //TriggeredChannel1Panel.Visible = true;
                //TriggeredChannel2Panel.Visible = true;
                //TriggeredChannel3Panel.Visible = true;
                //TriggeredChannel4Panel.Visible = true;
                TriggeredChannelSettings.ResizeGroupBox();
            }
        }

        private void TriggeredSingleChannelEnable_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorTriggeredStrobeSingleChannelEnabled,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.TriggeredStrobe.ChannelMode = ((ToggleButton) sender).Toggle()
                    ? ChannelModes.Single
                    : ChannelModes.Quad;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&pb" + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }

            TriggeredSingleChannelDisplay(((ToggleButton)sender).ToggleGet());
        }

        private void TriggeredShowChannel1_Click(object sender, EventArgs e)
        {
            TriggeredChannel1Panel.Visible = true;
            TriggeredChannel2Panel.Visible = false;
            TriggeredChannel3Panel.Visible = false;
            TriggeredChannel4Panel.Visible = false;
            TriggeredChannelSettings.ResizeGroupBox();
        }

        private void TriggeredShowChannel2_Click(object sender, EventArgs e)
        {
            TriggeredChannel1Panel.Visible = false;
            TriggeredChannel2Panel.Visible = true;
            TriggeredChannel3Panel.Visible = false;
            TriggeredChannel4Panel.Visible = false;
            TriggeredChannelSettings.ResizeGroupBox();
        }

        private void TriggeredShowChannel3_Click(object sender, EventArgs e)
        {
            TriggeredChannel1Panel.Visible = false;
            TriggeredChannel2Panel.Visible = false;
            TriggeredChannel3Panel.Visible = true;
            TriggeredChannel4Panel.Visible = false;
            TriggeredChannelSettings.ResizeGroupBox();
        }

        private void TriggeredShowChannel4_Click(object sender, EventArgs e)
        {
            TriggeredChannel1Panel.Visible = false;
            TriggeredChannel2Panel.Visible = false;
            TriggeredChannel3Panel.Visible = false;
            TriggeredChannel4Panel.Visible = true;
            TriggeredChannelSettings.ResizeGroupBox();
        }

        private void TriggeredShowChannelAll_Click(object sender, EventArgs e)
        {
            TriggeredChannel1Panel.Visible = true;
            TriggeredChannel2Panel.Visible = true;
            TriggeredChannel3Panel.Visible = true;
            TriggeredChannel4Panel.Visible = true;
            TriggeredChannelSettings.ResizeGroupBox();
        }

        private void TriggeredChannelDelay_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                var tempList = new List<byte> { (byte)(control.Channel - 1) };
                tempList.AddRange(DataConversions.ConvertUInt32ToList((uint)value));
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorTriggeredStrobeChannelDelay,
                    true, tempList);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.TriggeredStrobe.Channel((Channels) control.Channel).Delay = value;
                //_cvlsThreadedComPortRef.SendCommandWithEcho($"&pd{control.Channel},{value}");
            }
        }

        private void TriggeredChannelOnTime_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                var tempList = new List<byte> { (byte)(control.Channel - 1) };
                tempList.AddRange(DataConversions.ConvertUInt32ToList((uint)value));
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorTriggeredStrobeChannelOnTime,
                    true, tempList);
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.TriggeredStrobe.Channel((Channels)control.Channel).OnTime = value;
                //_cvlsThreadedComPortRef.SendCommandWithEcho($"&po{control.Channel},{value}");
            }
        }

        private void TriggeredChannelFallingEdgeEnable_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorTriggeredStrobeChannelFallingEdgeTrigger,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Channel - 1), (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.TriggeredStrobe.Channel((Channels)((ToggleButton)sender).Channel).EdgeType = ((ToggleButton)sender).Toggle() 
                    ? EdgeTypes.FallingEdge 
                    : EdgeTypes.RisingEdge;
                //_cvlsThreadedComPortRef.SendCommandWithEcho($"&pj{((ToggleButton)sender).Channel},{(((ToggleButton)sender).Toggle() ? "1" : "0")}");
            }
        }
        
        #endregion

        #region Equalizer Settings

        private void EqualizerEnable_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorEqualizerEnabled,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Equalizer.Enable = ((ToggleButton) sender).Toggle();
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&e" + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }
        }

        private void EqualizerDelay_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorEqualizerDelay,
                    true, DataConversions.ConvertUInt16ToList((ushort)value));
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Equalizer.Delay = value;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&ei" + value);
            }
        }
        
        private void EqualizerTargetLight_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorEqualizerTarget,
                    true, DataConversions.ConvertUInt16ToList((ushort)value));
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Equalizer.Target = value;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&ee" + value.ToString("X"));
            }
        }
        
        #endregion

        #region Fan Settings

        private void FanManualControlEnable_Click(object sender, EventArgs e)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorFanManualOverride,
                    true, new List<byte> { (byte)(((ToggleButton)sender).Toggle() ? 1 : 0) });
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Fan.ManualOverride = ((ToggleButton) sender).Toggle();
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&ge" + (((ToggleButton)sender).Toggle() ? "1" : "0"));
            }
        }

        private void FanSpeed_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorFanMaxSpeed,
                    true, DataConversions.ConvertUInt16ToList((ushort)value));
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Fan.Speed = value * 0.1;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&gs" + value);
            }
        }
        
        private void FanTargetTemp_OnValueChanged(SliderNumericCombo control, int value)
        {
            if (_binarySocketRef.IsConnected)
            {
                _binarySocketRef.SendBinaryCommand(CommandSets.Operator, (ushort)OperatorCommands.OperatorFanTargetTemp,
                    true, DataConversions.ConvertUInt16ToList((ushort)value));
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                _cvlsThreadedComPortRef.ProtocolEcho.Controls.Fan.TargetTemperature = value * 0.1;
                //_cvlsThreadedComPortRef.SendCommandWithEcho("&gt" + value);
            }
        }
        
        #endregion

        #region Others

        private void configurationsWindow_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Configurations");
        }

        private void login_Click(object sender, EventArgs e)
        {
            GlobalFunctions.BinaryLogin(_binarySocketRef);
        }

        private void getSettings_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void formControls_VisibleChanged(object sender, EventArgs e)
        {
            DisplayControls();
        }

        #endregion

        #endregion
        
    }

}

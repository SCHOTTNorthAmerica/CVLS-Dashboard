using SCHOTT.WinForms.Controls.Buttons;
using SCHOTT.WinForms.Controls.Combo_Controls;
using SCHOTT.WinForms.Controls.Group_Boxes;
using SCHOTT.WinForms.Controls.Panels;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    partial class ControlsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlsForm));
            this.formLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UserLevel = new GrowGroupbox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.label56 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.Connection = new GrowGroupbox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.label59 = new System.Windows.Forms.Label();
            this.CurrentSettings = new GrowGroupbox();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.label60 = new System.Windows.Forms.Label();
            this.getSettings = new System.Windows.Forms.Button();
            this.scrollPanel = new ScrollingPanel();
            this.mainLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.FanSettings = new GrowGroupbox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.FanTargetTemp = new SliderNumericCombo();
            this.label55 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.FanSpeed = new SliderNumericCombo();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.FanManualControlEnable = new ToggleButton();
            this.TriggeredChannelSettings = new GrowGroupbox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TriggeredShowChannel1 = new System.Windows.Forms.Button();
            this.TriggeredShowChannel2 = new System.Windows.Forms.Button();
            this.TriggeredShowChannel3 = new System.Windows.Forms.Button();
            this.TriggeredShowChannel4 = new System.Windows.Forms.Button();
            this.TriggeredShowChannelAll = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.TriggeredStrobeEnable = new ToggleButton();
            this.label39 = new System.Windows.Forms.Label();
            this.TriggeredSingleChannelEnable = new ToggleButton();
            this.label40 = new System.Windows.Forms.Label();
            this.TriggeredChannel1Panel = new System.Windows.Forms.TableLayoutPanel();
            this.TriggeredChannel1Delay = new SliderNumericCombo();
            this.TriggeredChannel1OnTime = new SliderNumericCombo();
            this.label43 = new System.Windows.Forms.Label();
            this.TriggeredChannel1FallingEdgeEnable = new ToggleButton();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.TriggeredChannel2Panel = new System.Windows.Forms.TableLayoutPanel();
            this.TriggeredChannel2OnTime = new SliderNumericCombo();
            this.TriggeredChannel2Delay = new SliderNumericCombo();
            this.label46 = new System.Windows.Forms.Label();
            this.TriggeredChannel2FallingEdgeEnable = new ToggleButton();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.TriggeredChannel3Panel = new System.Windows.Forms.TableLayoutPanel();
            this.TriggeredChannel3OnTime = new SliderNumericCombo();
            this.label36 = new System.Windows.Forms.Label();
            this.TriggeredChannel3Delay = new SliderNumericCombo();
            this.TriggeredChannel3FallingEdgeEnable = new ToggleButton();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.TriggeredChannel4Panel = new System.Windows.Forms.TableLayoutPanel();
            this.TriggeredChannel4OnTime = new SliderNumericCombo();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.TriggeredChannel4Delay = new SliderNumericCombo();
            this.TriggeredChannel4FallingEdgeEnable = new ToggleButton();
            this.label33 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.TriggeredStrobeGangedEnable = new ToggleButton();
            this.LEDChannelSettings = new GrowGroupbox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.LEDChannel4Panel = new System.Windows.Forms.TableLayoutPanel();
            this.LEDChannel4ShutdownButton = new ToggleButton();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.LEDChannel4Output = new SliderNumericCombo();
            this.LEDChannel4PowerButton = new ToggleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LEDChannel1Panel = new System.Windows.Forms.TableLayoutPanel();
            this.LEDChannel1ShutdownButton = new ToggleButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LEDChannel1PowerButton = new ToggleButton();
            this.LEDChannel1Output = new SliderNumericCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LEDChannel3Panel = new System.Windows.Forms.TableLayoutPanel();
            this.LEDChannel3ShutdownButton = new ToggleButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.LEDChannel3PowerButton = new ToggleButton();
            this.LEDChannel3Output = new SliderNumericCombo();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LEDShowChannelAll = new System.Windows.Forms.Button();
            this.LEDChannel2Panel = new System.Windows.Forms.TableLayoutPanel();
            this.LEDChannel2ShutdownButton = new ToggleButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.LEDChannel2PowerButton = new ToggleButton();
            this.LEDChannel2Output = new SliderNumericCombo();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LEDOutput = new SliderNumericCombo();
            this.LEDOutputPowerButton = new ToggleButton();
            this.LEDShowChannel4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LEDShowChannel3 = new System.Windows.Forms.Button();
            this.LEDDemoMode = new ToggleButton();
            this.LEDShowChannel2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LEDShowChannel1 = new System.Windows.Forms.Button();
            this.LEDCombinedTrigger = new ToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.LEDSingleChannelOperation = new ToggleButton();
            this.knobMode = new System.Windows.Forms.ComboBox();
            this.ContinuousChannelSettings = new GrowGroupbox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ContinuousShowChannel1 = new System.Windows.Forms.Button();
            this.ContinuousShowChannel2 = new System.Windows.Forms.Button();
            this.ContinuousShowChannel3 = new System.Windows.Forms.Button();
            this.ContinuousShowChannel4 = new System.Windows.Forms.Button();
            this.ContinuousShowChannelAll = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.ContinuousStrobeEnable = new ToggleButton();
            this.ContinuousSingleChannelEnable = new ToggleButton();
            this.ContinuousFrequency = new SliderNumericCombo();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ContinuousChannel1Panel = new System.Windows.Forms.TableLayoutPanel();
            this.ContinuousChannel1WaveformActiveHigh = new ToggleButton();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ContinuousChannel1PhaseShift = new SliderNumericCombo();
            this.label23 = new System.Windows.Forms.Label();
            this.ContinuousChannel1DutyCycle = new SliderNumericCombo();
            this.ContinuousChannel2Panel = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.ContinuousChannel2WaveformActiveHigh = new ToggleButton();
            this.ContinuousChannel2PhaseShift = new SliderNumericCombo();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ContinuousChannel2DutyCycle = new SliderNumericCombo();
            this.ContinuousChannel3Panel = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.ContinuousChannel3PhaseShift = new SliderNumericCombo();
            this.ContinuousChannel3WaveformActiveHigh = new ToggleButton();
            this.label25 = new System.Windows.Forms.Label();
            this.ContinuousChannel3DutyCycle = new SliderNumericCombo();
            this.label26 = new System.Windows.Forms.Label();
            this.ContinuousChannel4Panel = new System.Windows.Forms.TableLayoutPanel();
            this.ContinuousChannel4PhaseShift = new SliderNumericCombo();
            this.label30 = new System.Windows.Forms.Label();
            this.ContinuousChannel4DutyCycle = new SliderNumericCombo();
            this.ContinuousChannel4WaveformActiveHigh = new ToggleButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.EqualizerSettings = new GrowGroupbox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label54 = new System.Windows.Forms.Label();
            this.EqualizerTargetLight = new SliderNumericCombo();
            this.label47 = new System.Windows.Forms.Label();
            this.EqualizerDelay = new SliderNumericCombo();
            this.label49 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.EqualizerEnable = new ToggleButton();
            this.label48 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.EqualizerPowerOutput = new System.Windows.Forms.Label();
            this.EqualizerLightOutput = new System.Windows.Forms.Label();
            this.PersistentMemory = new GrowGroupbox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.configurationsWindow = new System.Windows.Forms.Button();
            this.formLayoutPanel.SuspendLayout();
            this.UserLevel.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.Connection.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.CurrentSettings.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.mainLayoutTable.SuspendLayout();
            this.FanSettings.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.TriggeredChannelSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.TriggeredChannel1Panel.SuspendLayout();
            this.TriggeredChannel2Panel.SuspendLayout();
            this.TriggeredChannel3Panel.SuspendLayout();
            this.TriggeredChannel4Panel.SuspendLayout();
            this.LEDChannelSettings.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.LEDChannel4Panel.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.LEDChannel1Panel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.LEDChannel3Panel.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.LEDChannel2Panel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.ContinuousChannelSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ContinuousChannel1Panel.SuspendLayout();
            this.ContinuousChannel2Panel.SuspendLayout();
            this.ContinuousChannel3Panel.SuspendLayout();
            this.ContinuousChannel4Panel.SuspendLayout();
            this.EqualizerSettings.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.PersistentMemory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formLayoutPanel
            // 
            this.formLayoutPanel.ColumnCount = 1;
            this.formLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formLayoutPanel.Controls.Add(this.UserLevel, 0, 0);
            this.formLayoutPanel.Controls.Add(this.Connection, 0, 1);
            this.formLayoutPanel.Controls.Add(this.CurrentSettings, 0, 2);
            this.formLayoutPanel.Controls.Add(this.scrollPanel, 0, 3);
            this.formLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.formLayoutPanel.Name = "formLayoutPanel";
            this.formLayoutPanel.RowCount = 4;
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formLayoutPanel.Size = new System.Drawing.Size(334, 569);
            this.formLayoutPanel.TabIndex = 5;
            // 
            // UserLevel
            // 
            this.UserLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserLevel.Controls.Add(this.tableLayoutPanel21);
            this.UserLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserLevel.Location = new System.Drawing.Point(3, 3);
            this.UserLevel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.UserLevel.Name = "UserLevel";
            this.UserLevel.Padding = new System.Windows.Forms.Padding(7);
            this.UserLevel.Size = new System.Drawing.Size(328, 111);
            this.UserLevel.TabIndex = 3;
            this.UserLevel.TabStop = false;
            this.UserLevel.Text = "Authentication Required";
            this.UserLevel.Visible = false;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.AutoSize = true;
            this.tableLayoutPanel21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel21.ColumnCount = 1;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Controls.Add(this.label56, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.login, 0, 1);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 2;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel21.Size = new System.Drawing.Size(314, 76);
            this.tableLayoutPanel21.TabIndex = 2;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Location = new System.Drawing.Point(3, 3);
            this.label56.Margin = new System.Windows.Forms.Padding(3);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(308, 39);
            this.label56.TabIndex = 5;
            this.label56.Text = "You must be logged with a minimum of \"User\" rights to view the controls on this p" +
    "age. Click the login button below to use this page.";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login.Dock = System.Windows.Forms.DockStyle.Top;
            this.login.Location = new System.Drawing.Point(3, 48);
            this.login.MinimumSize = new System.Drawing.Size(0, 25);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(308, 25);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Connection
            // 
            this.Connection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Connection.Controls.Add(this.tableLayoutPanel26);
            this.Connection.Dock = System.Windows.Forms.DockStyle.Top;
            this.Connection.Location = new System.Drawing.Point(3, 127);
            this.Connection.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(7);
            this.Connection.Size = new System.Drawing.Size(328, 67);
            this.Connection.TabIndex = 3;
            this.Connection.TabStop = false;
            this.Connection.Text = "Connection Required";
            this.Connection.Visible = false;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.AutoSize = true;
            this.tableLayoutPanel26.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel26.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel26.ColumnCount = 1;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Controls.Add(this.label59, 0, 0);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(314, 32);
            this.tableLayoutPanel26.TabIndex = 2;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Location = new System.Drawing.Point(3, 3);
            this.label59.Margin = new System.Windows.Forms.Padding(3);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(308, 26);
            this.label59.TabIndex = 5;
            this.label59.Text = "You must be connected to a unit with USB or Ethernet to display controls on this " +
    "page.";
            // 
            // CurrentSettings
            // 
            this.CurrentSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CurrentSettings.Controls.Add(this.tableLayoutPanel27);
            this.CurrentSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentSettings.Location = new System.Drawing.Point(3, 207);
            this.CurrentSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.CurrentSettings.Name = "CurrentSettings";
            this.CurrentSettings.Padding = new System.Windows.Forms.Padding(7);
            this.CurrentSettings.Size = new System.Drawing.Size(328, 98);
            this.CurrentSettings.TabIndex = 4;
            this.CurrentSettings.TabStop = false;
            this.CurrentSettings.Text = "Current Settings";
            this.CurrentSettings.Visible = false;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.AutoSize = true;
            this.tableLayoutPanel27.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel27.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel27.ColumnCount = 1;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.Controls.Add(this.label60, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.getSettings, 0, 1);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 2;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel27.Size = new System.Drawing.Size(314, 63);
            this.tableLayoutPanel27.TabIndex = 2;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Location = new System.Drawing.Point(3, 3);
            this.label60.Margin = new System.Windows.Forms.Padding(3);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(308, 26);
            this.label60.TabIndex = 5;
            this.label60.Text = "This is not a live page. Click the button below to retrieve the current settings " +
    "from the connected unit.";
            // 
            // getSettings
            // 
            this.getSettings.AutoSize = true;
            this.getSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.getSettings.Location = new System.Drawing.Point(3, 35);
            this.getSettings.MinimumSize = new System.Drawing.Size(0, 25);
            this.getSettings.Name = "getSettings";
            this.getSettings.Size = new System.Drawing.Size(308, 25);
            this.getSettings.TabIndex = 6;
            this.getSettings.Text = "Refresh Page";
            this.getSettings.UseVisualStyleBackColor = true;
            this.getSettings.Click += new System.EventHandler(this.getSettings_Click);
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.AutoScrollMinSize = new System.Drawing.Size(0, 3421);
            this.scrollPanel.Controls.Add(this.mainLayoutTable);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(2, 317);
            this.scrollPanel.Margin = new System.Windows.Forms.Padding(2);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(2);
            this.scrollPanel.Size = new System.Drawing.Size(330, 250);
            this.scrollPanel.TabIndex = 1;
            // 
            // mainLayoutTable
            // 
            this.mainLayoutTable.AutoSize = true;
            this.mainLayoutTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLayoutTable.ColumnCount = 1;
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutTable.Controls.Add(this.FanSettings, 0, 5);
            this.mainLayoutTable.Controls.Add(this.TriggeredChannelSettings, 0, 3);
            this.mainLayoutTable.Controls.Add(this.LEDChannelSettings, 0, 1);
            this.mainLayoutTable.Controls.Add(this.ContinuousChannelSettings, 0, 2);
            this.mainLayoutTable.Controls.Add(this.EqualizerSettings, 0, 4);
            this.mainLayoutTable.Controls.Add(this.PersistentMemory, 0, 0);
            this.mainLayoutTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainLayoutTable.Location = new System.Drawing.Point(2, 2);
            this.mainLayoutTable.Margin = new System.Windows.Forms.Padding(1);
            this.mainLayoutTable.Name = "mainLayoutTable";
            this.mainLayoutTable.Padding = new System.Windows.Forms.Padding(1);
            this.mainLayoutTable.RowCount = 6;
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutTable.Size = new System.Drawing.Size(309, 3429);
            this.mainLayoutTable.TabIndex = 4;
            // 
            // FanSettings
            // 
            this.FanSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FanSettings.Controls.Add(this.tableLayoutPanel12);
            this.FanSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.FanSettings.Location = new System.Drawing.Point(4, 3138);
            this.FanSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.FanSettings.Name = "FanSettings";
            this.FanSettings.Padding = new System.Windows.Forms.Padding(7);
            this.FanSettings.Size = new System.Drawing.Size(301, 280);
            this.FanSettings.TabIndex = 9;
            this.FanSettings.TabStop = false;
            this.FanSettings.Text = "Fan Control";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.AutoSize = true;
            this.tableLayoutPanel12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.FanTargetTemp, 0, 8);
            this.tableLayoutPanel12.Controls.Add(this.label55, 0, 7);
            this.tableLayoutPanel12.Controls.Add(this.label38, 0, 2);
            this.tableLayoutPanel12.Controls.Add(this.FanSpeed, 0, 5);
            this.tableLayoutPanel12.Controls.Add(this.label51, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.label50, 0, 4);
            this.tableLayoutPanel12.Controls.Add(this.FanManualControlEnable, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 9;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.Size = new System.Drawing.Size(287, 245);
            this.tableLayoutPanel12.TabIndex = 2;
            // 
            // FanTargetTemp
            // 
            this.FanTargetTemp.AutoSize = true;
            this.FanTargetTemp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FanTargetTemp.Channel = 0;
            this.tableLayoutPanel12.SetColumnSpan(this.FanTargetTemp, 2);
            this.FanTargetTemp.DecimalPlaces = 1;
            this.FanTargetTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.FanTargetTemp.FontSize = 8.25F;
            this.FanTargetTemp.Location = new System.Drawing.Point(3, 216);
            this.FanTargetTemp.Maximum = 1000;
            this.FanTargetTemp.Minimum = 0;
            this.FanTargetTemp.Name = "FanTargetTemp";
            this.FanTargetTemp.Size = new System.Drawing.Size(281, 26);
            this.FanTargetTemp.TabIndex = 6;
            this.FanTargetTemp.Value = 0;
            this.FanTargetTemp.Visible = false;
            this.FanTargetTemp.OnValueChanged += new SliderNumericCombo.ValueChanged(this.FanTargetTemp_OnValueChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.tableLayoutPanel12.SetColumnSpan(this.label55, 2);
            this.label55.Dock = System.Windows.Forms.DockStyle.Top;
            this.label55.Location = new System.Drawing.Point(3, 200);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(281, 13);
            this.label55.TabIndex = 20;
            this.label55.Text = "LED Target Temp (C)";
            this.label55.Visible = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.tableLayoutPanel12.SetColumnSpan(this.label38, 2);
            this.label38.Location = new System.Drawing.Point(3, 44);
            this.label38.Margin = new System.Windows.Forms.Padding(3);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(281, 78);
            this.label38.TabIndex = 5;
            this.label38.Text = resources.GetString("label38.Text");
            // 
            // FanSpeed
            // 
            this.FanSpeed.AutoSize = true;
            this.FanSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FanSpeed.Channel = 0;
            this.tableLayoutPanel12.SetColumnSpan(this.FanSpeed, 2);
            this.FanSpeed.DecimalPlaces = 1;
            this.FanSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.FanSpeed.FontSize = 8.25F;
            this.FanSpeed.Location = new System.Drawing.Point(3, 161);
            this.FanSpeed.Maximum = 1000;
            this.FanSpeed.Minimum = 0;
            this.FanSpeed.Name = "FanSpeed";
            this.FanSpeed.Size = new System.Drawing.Size(281, 26);
            this.FanSpeed.TabIndex = 6;
            this.FanSpeed.Value = 0;
            this.FanSpeed.OnValueChanged += new SliderNumericCombo.ValueChanged(this.FanSpeed_OnValueChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label51.Location = new System.Drawing.Point(89, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(195, 31);
            this.label51.TabIndex = 3;
            this.label51.Text = "Fan Control";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.tableLayoutPanel12.SetColumnSpan(this.label50, 2);
            this.label50.Dock = System.Windows.Forms.DockStyle.Top;
            this.label50.Location = new System.Drawing.Point(3, 145);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(281, 13);
            this.label50.TabIndex = 18;
            this.label50.Text = "Fan Speed (%)";
            // 
            // FanManualControlEnable
            // 
            this.FanManualControlEnable.AutoSize = true;
            this.FanManualControlEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FanManualControlEnable.BackColor = System.Drawing.Color.LimeGreen;
            this.FanManualControlEnable.Channel = 0;
            this.FanManualControlEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.FanManualControlEnable.Location = new System.Drawing.Point(3, 3);
            this.FanManualControlEnable.MinimumSize = new System.Drawing.Size(80, 25);
            this.FanManualControlEnable.Name = "FanManualControlEnable";
            this.FanManualControlEnable.Size = new System.Drawing.Size(80, 25);
            this.FanManualControlEnable.TabIndex = 2;
            this.FanManualControlEnable.Text = "Auto";
            this.FanManualControlEnable.ToggleDisabledColor = System.Drawing.Color.LimeGreen;
            this.FanManualControlEnable.ToggleDisabledText = "Auto";
            this.FanManualControlEnable.ToggleEnabledColor = System.Drawing.Color.Red;
            this.FanManualControlEnable.ToggleEnabledText = "Manual";
            this.FanManualControlEnable.UseVisualStyleBackColor = false;
            this.FanManualControlEnable.Click += new System.EventHandler(this.FanManualControlEnable_Click);
            // 
            // TriggeredChannelSettings
            // 
            this.TriggeredChannelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannelSettings.BackColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannelSettings.Controls.Add(this.tableLayoutPanel3);
            this.TriggeredChannelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannelSettings.Location = new System.Drawing.Point(4, 1812);
            this.TriggeredChannelSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.TriggeredChannelSettings.Name = "TriggeredChannelSettings";
            this.TriggeredChannelSettings.Padding = new System.Windows.Forms.Padding(7);
            this.TriggeredChannelSettings.Size = new System.Drawing.Size(301, 872);
            this.TriggeredChannelSettings.TabIndex = 6;
            this.TriggeredChannelSettings.TabStop = false;
            this.TriggeredChannelSettings.Text = "Triggered Strobe";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.TriggeredShowChannel1, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredShowChannel2, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredShowChannel3, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredShowChannel4, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredShowChannelAll, 4, 5);
            this.tableLayoutPanel3.Controls.Add(this.label37, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredStrobeEnable, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label39, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredSingleChannelEnable, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label40, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredChannel1Panel, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredChannel2Panel, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredChannel3Panel, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredChannel4Panel, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.label58, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.TriggeredStrobeGangedEnable, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 837);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // TriggeredShowChannel1
            // 
            this.TriggeredShowChannel1.AutoSize = true;
            this.TriggeredShowChannel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredShowChannel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredShowChannel1.Location = new System.Drawing.Point(3, 119);
            this.TriggeredShowChannel1.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredShowChannel1.Name = "TriggeredShowChannel1";
            this.TriggeredShowChannel1.Size = new System.Drawing.Size(51, 25);
            this.TriggeredShowChannel1.TabIndex = 0;
            this.TriggeredShowChannel1.Text = "1";
            this.TriggeredShowChannel1.UseVisualStyleBackColor = true;
            this.TriggeredShowChannel1.Click += new System.EventHandler(this.TriggeredShowChannel1_Click);
            // 
            // TriggeredShowChannel2
            // 
            this.TriggeredShowChannel2.AutoSize = true;
            this.TriggeredShowChannel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredShowChannel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredShowChannel2.Location = new System.Drawing.Point(60, 119);
            this.TriggeredShowChannel2.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredShowChannel2.Name = "TriggeredShowChannel2";
            this.TriggeredShowChannel2.Size = new System.Drawing.Size(51, 25);
            this.TriggeredShowChannel2.TabIndex = 1;
            this.TriggeredShowChannel2.Text = "2";
            this.TriggeredShowChannel2.UseVisualStyleBackColor = true;
            this.TriggeredShowChannel2.Click += new System.EventHandler(this.TriggeredShowChannel2_Click);
            // 
            // TriggeredShowChannel3
            // 
            this.TriggeredShowChannel3.AutoSize = true;
            this.TriggeredShowChannel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredShowChannel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredShowChannel3.Location = new System.Drawing.Point(117, 119);
            this.TriggeredShowChannel3.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredShowChannel3.Name = "TriggeredShowChannel3";
            this.TriggeredShowChannel3.Size = new System.Drawing.Size(51, 25);
            this.TriggeredShowChannel3.TabIndex = 2;
            this.TriggeredShowChannel3.Text = "3";
            this.TriggeredShowChannel3.UseVisualStyleBackColor = true;
            this.TriggeredShowChannel3.Click += new System.EventHandler(this.TriggeredShowChannel3_Click);
            // 
            // TriggeredShowChannel4
            // 
            this.TriggeredShowChannel4.AutoSize = true;
            this.TriggeredShowChannel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredShowChannel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredShowChannel4.Location = new System.Drawing.Point(174, 119);
            this.TriggeredShowChannel4.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredShowChannel4.Name = "TriggeredShowChannel4";
            this.TriggeredShowChannel4.Size = new System.Drawing.Size(51, 25);
            this.TriggeredShowChannel4.TabIndex = 3;
            this.TriggeredShowChannel4.Text = "4";
            this.TriggeredShowChannel4.UseVisualStyleBackColor = true;
            this.TriggeredShowChannel4.Click += new System.EventHandler(this.TriggeredShowChannel4_Click);
            // 
            // TriggeredShowChannelAll
            // 
            this.TriggeredShowChannelAll.AutoSize = true;
            this.TriggeredShowChannelAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredShowChannelAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredShowChannelAll.Location = new System.Drawing.Point(231, 119);
            this.TriggeredShowChannelAll.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredShowChannelAll.Name = "TriggeredShowChannelAll";
            this.TriggeredShowChannelAll.Size = new System.Drawing.Size(53, 25);
            this.TriggeredShowChannelAll.TabIndex = 4;
            this.TriggeredShowChannelAll.Text = "All";
            this.TriggeredShowChannelAll.UseVisualStyleBackColor = true;
            this.TriggeredShowChannelAll.Click += new System.EventHandler(this.TriggeredShowChannelAll_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label37, 5);
            this.label37.Dock = System.Windows.Forms.DockStyle.Top;
            this.label37.Location = new System.Drawing.Point(3, 103);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(281, 13);
            this.label37.TabIndex = 11;
            this.label37.Text = "Channels";
            // 
            // TriggeredStrobeEnable
            // 
            this.TriggeredStrobeEnable.AutoSize = true;
            this.TriggeredStrobeEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredStrobeEnable.BackColor = System.Drawing.Color.Red;
            this.TriggeredStrobeEnable.Channel = 0;
            this.tableLayoutPanel3.SetColumnSpan(this.TriggeredStrobeEnable, 2);
            this.TriggeredStrobeEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredStrobeEnable.Location = new System.Drawing.Point(3, 3);
            this.TriggeredStrobeEnable.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredStrobeEnable.Name = "TriggeredStrobeEnable";
            this.TriggeredStrobeEnable.Size = new System.Drawing.Size(108, 25);
            this.TriggeredStrobeEnable.TabIndex = 0;
            this.TriggeredStrobeEnable.Text = "Disable";
            this.TriggeredStrobeEnable.ToggleDisabledColor = System.Drawing.Color.Red;
            this.TriggeredStrobeEnable.ToggleDisabledText = "Disabled";
            this.TriggeredStrobeEnable.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.TriggeredStrobeEnable.ToggleEnabledText = "Enabled";
            this.TriggeredStrobeEnable.UseVisualStyleBackColor = false;
            this.TriggeredStrobeEnable.Click += new System.EventHandler(this.TriggeredStrobeEnable_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label39, 3);
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Location = new System.Drawing.Point(117, 62);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(167, 31);
            this.label39.TabIndex = 5;
            this.label39.Text = "Channel Operation";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TriggeredSingleChannelEnable
            // 
            this.TriggeredSingleChannelEnable.AutoSize = true;
            this.TriggeredSingleChannelEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredSingleChannelEnable.BackColor = System.Drawing.SystemColors.Control;
            this.TriggeredSingleChannelEnable.Channel = 0;
            this.tableLayoutPanel3.SetColumnSpan(this.TriggeredSingleChannelEnable, 2);
            this.TriggeredSingleChannelEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredSingleChannelEnable.Location = new System.Drawing.Point(3, 65);
            this.TriggeredSingleChannelEnable.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredSingleChannelEnable.Name = "TriggeredSingleChannelEnable";
            this.TriggeredSingleChannelEnable.Size = new System.Drawing.Size(108, 25);
            this.TriggeredSingleChannelEnable.TabIndex = 4;
            this.TriggeredSingleChannelEnable.Text = "Single";
            this.TriggeredSingleChannelEnable.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredSingleChannelEnable.ToggleDisabledText = "Quad";
            this.TriggeredSingleChannelEnable.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredSingleChannelEnable.ToggleEnabledText = "Single";
            this.TriggeredSingleChannelEnable.UseVisualStyleBackColor = true;
            this.TriggeredSingleChannelEnable.Click += new System.EventHandler(this.TriggeredSingleChannelEnable_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label40, 3);
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Location = new System.Drawing.Point(117, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(167, 31);
            this.label40.TabIndex = 1;
            this.label40.Text = "Triggered Strobe";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TriggeredChannel1Panel
            // 
            this.TriggeredChannel1Panel.AutoSize = true;
            this.TriggeredChannel1Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel1Panel.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.TriggeredChannel1Panel, 5);
            this.TriggeredChannel1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TriggeredChannel1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TriggeredChannel1Panel.Controls.Add(this.TriggeredChannel1Delay, 0, 1);
            this.TriggeredChannel1Panel.Controls.Add(this.TriggeredChannel1OnTime, 0, 4);
            this.TriggeredChannel1Panel.Controls.Add(this.label43, 0, 0);
            this.TriggeredChannel1Panel.Controls.Add(this.TriggeredChannel1FallingEdgeEnable, 0, 7);
            this.TriggeredChannel1Panel.Controls.Add(this.label41, 0, 3);
            this.TriggeredChannel1Panel.Controls.Add(this.label42, 0, 6);
            this.TriggeredChannel1Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel1Panel.Location = new System.Drawing.Point(3, 160);
            this.TriggeredChannel1Panel.Name = "TriggeredChannel1Panel";
            this.TriggeredChannel1Panel.RowCount = 9;
            this.TriggeredChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel1Panel.Size = new System.Drawing.Size(281, 164);
            this.TriggeredChannel1Panel.TabIndex = 12;
            // 
            // TriggeredChannel1Delay
            // 
            this.TriggeredChannel1Delay.AutoSize = true;
            this.TriggeredChannel1Delay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel1Delay.Channel = 1;
            this.TriggeredChannel1Panel.SetColumnSpan(this.TriggeredChannel1Delay, 2);
            this.TriggeredChannel1Delay.DecimalPlaces = 0;
            this.TriggeredChannel1Delay.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel1Delay.FontSize = 8.25F;
            this.TriggeredChannel1Delay.Location = new System.Drawing.Point(3, 16);
            this.TriggeredChannel1Delay.Maximum = 1000000;
            this.TriggeredChannel1Delay.Minimum = 0;
            this.TriggeredChannel1Delay.Name = "TriggeredChannel1Delay";
            this.TriggeredChannel1Delay.Size = new System.Drawing.Size(275, 26);
            this.TriggeredChannel1Delay.TabIndex = 6;
            this.TriggeredChannel1Delay.Value = 0;
            this.TriggeredChannel1Delay.OnValueChanged += new SliderNumericCombo.ValueChanged(this.TriggeredChannelDelay_OnValueChanged);
            // 
            // TriggeredChannel1OnTime
            // 
            this.TriggeredChannel1OnTime.AutoSize = true;
            this.TriggeredChannel1OnTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel1OnTime.Channel = 1;
            this.TriggeredChannel1Panel.SetColumnSpan(this.TriggeredChannel1OnTime, 2);
            this.TriggeredChannel1OnTime.DecimalPlaces = 0;
            this.TriggeredChannel1OnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel1OnTime.FontSize = 8.25F;
            this.TriggeredChannel1OnTime.Location = new System.Drawing.Point(3, 71);
            this.TriggeredChannel1OnTime.Maximum = 1000000;
            this.TriggeredChannel1OnTime.Minimum = 25;
            this.TriggeredChannel1OnTime.Name = "TriggeredChannel1OnTime";
            this.TriggeredChannel1OnTime.Size = new System.Drawing.Size(275, 26);
            this.TriggeredChannel1OnTime.TabIndex = 7;
            this.TriggeredChannel1OnTime.Value = 25;
            this.TriggeredChannel1OnTime.OnValueChanged += new SliderNumericCombo.ValueChanged(this.TriggeredChannelOnTime_OnValueChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.TriggeredChannel1Panel.SetColumnSpan(this.label43, 2);
            this.label43.Dock = System.Windows.Forms.DockStyle.Top;
            this.label43.Location = new System.Drawing.Point(3, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(275, 13);
            this.label43.TabIndex = 13;
            this.label43.Text = "Ch 1 Delay";
            // 
            // TriggeredChannel1FallingEdgeEnable
            // 
            this.TriggeredChannel1FallingEdgeEnable.AutoSize = true;
            this.TriggeredChannel1FallingEdgeEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel1FallingEdgeEnable.BackColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel1FallingEdgeEnable.Channel = 1;
            this.TriggeredChannel1FallingEdgeEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel1FallingEdgeEnable.Location = new System.Drawing.Point(3, 126);
            this.TriggeredChannel1FallingEdgeEnable.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredChannel1FallingEdgeEnable.Name = "TriggeredChannel1FallingEdgeEnable";
            this.TriggeredChannel1FallingEdgeEnable.Size = new System.Drawing.Size(75, 25);
            this.TriggeredChannel1FallingEdgeEnable.TabIndex = 13;
            this.TriggeredChannel1FallingEdgeEnable.Text = "Falling Edge";
            this.TriggeredChannel1FallingEdgeEnable.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel1FallingEdgeEnable.ToggleDisabledText = "Rising Edge";
            this.TriggeredChannel1FallingEdgeEnable.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel1FallingEdgeEnable.ToggleEnabledText = "Falling Edge";
            this.TriggeredChannel1FallingEdgeEnable.UseVisualStyleBackColor = true;
            this.TriggeredChannel1FallingEdgeEnable.Click += new System.EventHandler(this.TriggeredChannelFallingEdgeEnable_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.TriggeredChannel1Panel.SetColumnSpan(this.label41, 2);
            this.label41.Dock = System.Windows.Forms.DockStyle.Top;
            this.label41.Location = new System.Drawing.Point(3, 55);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(275, 13);
            this.label41.TabIndex = 15;
            this.label41.Text = "Ch 1 On Time";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.TriggeredChannel1Panel.SetColumnSpan(this.label42, 2);
            this.label42.Dock = System.Windows.Forms.DockStyle.Top;
            this.label42.Location = new System.Drawing.Point(3, 110);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(275, 13);
            this.label42.TabIndex = 15;
            this.label42.Text = "Ch 1 Trigger On:";
            // 
            // TriggeredChannel2Panel
            // 
            this.TriggeredChannel2Panel.AutoSize = true;
            this.TriggeredChannel2Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel2Panel.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.TriggeredChannel2Panel, 5);
            this.TriggeredChannel2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TriggeredChannel2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TriggeredChannel2Panel.Controls.Add(this.TriggeredChannel2OnTime, 0, 4);
            this.TriggeredChannel2Panel.Controls.Add(this.TriggeredChannel2Delay, 0, 1);
            this.TriggeredChannel2Panel.Controls.Add(this.label46, 0, 0);
            this.TriggeredChannel2Panel.Controls.Add(this.TriggeredChannel2FallingEdgeEnable, 0, 7);
            this.TriggeredChannel2Panel.Controls.Add(this.label44, 0, 3);
            this.TriggeredChannel2Panel.Controls.Add(this.label45, 0, 6);
            this.TriggeredChannel2Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel2Panel.Location = new System.Drawing.Point(3, 330);
            this.TriggeredChannel2Panel.Name = "TriggeredChannel2Panel";
            this.TriggeredChannel2Panel.RowCount = 9;
            this.TriggeredChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel2Panel.Size = new System.Drawing.Size(281, 164);
            this.TriggeredChannel2Panel.TabIndex = 12;
            // 
            // TriggeredChannel2OnTime
            // 
            this.TriggeredChannel2OnTime.AutoSize = true;
            this.TriggeredChannel2OnTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel2OnTime.Channel = 2;
            this.TriggeredChannel2Panel.SetColumnSpan(this.TriggeredChannel2OnTime, 2);
            this.TriggeredChannel2OnTime.DecimalPlaces = 0;
            this.TriggeredChannel2OnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel2OnTime.FontSize = 8.25F;
            this.TriggeredChannel2OnTime.Location = new System.Drawing.Point(3, 71);
            this.TriggeredChannel2OnTime.Maximum = 1000000;
            this.TriggeredChannel2OnTime.Minimum = 25;
            this.TriggeredChannel2OnTime.Name = "TriggeredChannel2OnTime";
            this.TriggeredChannel2OnTime.Size = new System.Drawing.Size(275, 26);
            this.TriggeredChannel2OnTime.TabIndex = 7;
            this.TriggeredChannel2OnTime.Value = 25;
            this.TriggeredChannel2OnTime.OnValueChanged += new SliderNumericCombo.ValueChanged(this.TriggeredChannelOnTime_OnValueChanged);
            // 
            // TriggeredChannel2Delay
            // 
            this.TriggeredChannel2Delay.AutoSize = true;
            this.TriggeredChannel2Delay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel2Delay.Channel = 2;
            this.TriggeredChannel2Panel.SetColumnSpan(this.TriggeredChannel2Delay, 2);
            this.TriggeredChannel2Delay.DecimalPlaces = 0;
            this.TriggeredChannel2Delay.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel2Delay.FontSize = 8.25F;
            this.TriggeredChannel2Delay.Location = new System.Drawing.Point(3, 16);
            this.TriggeredChannel2Delay.Maximum = 1000000;
            this.TriggeredChannel2Delay.Minimum = 0;
            this.TriggeredChannel2Delay.Name = "TriggeredChannel2Delay";
            this.TriggeredChannel2Delay.Size = new System.Drawing.Size(275, 26);
            this.TriggeredChannel2Delay.TabIndex = 6;
            this.TriggeredChannel2Delay.Value = 0;
            this.TriggeredChannel2Delay.OnValueChanged += new SliderNumericCombo.ValueChanged(this.TriggeredChannelDelay_OnValueChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.TriggeredChannel2Panel.SetColumnSpan(this.label46, 2);
            this.label46.Dock = System.Windows.Forms.DockStyle.Top;
            this.label46.Location = new System.Drawing.Point(3, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(275, 13);
            this.label46.TabIndex = 13;
            this.label46.Text = "Ch 2 Delay";
            // 
            // TriggeredChannel2FallingEdgeEnable
            // 
            this.TriggeredChannel2FallingEdgeEnable.AutoSize = true;
            this.TriggeredChannel2FallingEdgeEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel2FallingEdgeEnable.BackColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel2FallingEdgeEnable.Channel = 2;
            this.TriggeredChannel2FallingEdgeEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel2FallingEdgeEnable.Location = new System.Drawing.Point(3, 126);
            this.TriggeredChannel2FallingEdgeEnable.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredChannel2FallingEdgeEnable.Name = "TriggeredChannel2FallingEdgeEnable";
            this.TriggeredChannel2FallingEdgeEnable.Size = new System.Drawing.Size(75, 25);
            this.TriggeredChannel2FallingEdgeEnable.TabIndex = 13;
            this.TriggeredChannel2FallingEdgeEnable.Text = "Falling Edge";
            this.TriggeredChannel2FallingEdgeEnable.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel2FallingEdgeEnable.ToggleDisabledText = "Rising Edge";
            this.TriggeredChannel2FallingEdgeEnable.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel2FallingEdgeEnable.ToggleEnabledText = "Falling Edge";
            this.TriggeredChannel2FallingEdgeEnable.UseVisualStyleBackColor = true;
            this.TriggeredChannel2FallingEdgeEnable.Click += new System.EventHandler(this.TriggeredChannelFallingEdgeEnable_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.TriggeredChannel2Panel.SetColumnSpan(this.label44, 2);
            this.label44.Dock = System.Windows.Forms.DockStyle.Top;
            this.label44.Location = new System.Drawing.Point(3, 55);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(275, 13);
            this.label44.TabIndex = 15;
            this.label44.Text = "Ch 2 On Time";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.TriggeredChannel2Panel.SetColumnSpan(this.label45, 2);
            this.label45.Dock = System.Windows.Forms.DockStyle.Top;
            this.label45.Location = new System.Drawing.Point(3, 110);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(275, 13);
            this.label45.TabIndex = 15;
            this.label45.Text = "Ch 2 Trigger On:";
            // 
            // TriggeredChannel3Panel
            // 
            this.TriggeredChannel3Panel.AutoSize = true;
            this.TriggeredChannel3Panel.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.TriggeredChannel3Panel, 5);
            this.TriggeredChannel3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TriggeredChannel3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TriggeredChannel3Panel.Controls.Add(this.TriggeredChannel3OnTime, 0, 4);
            this.TriggeredChannel3Panel.Controls.Add(this.label36, 0, 0);
            this.TriggeredChannel3Panel.Controls.Add(this.TriggeredChannel3Delay, 0, 1);
            this.TriggeredChannel3Panel.Controls.Add(this.TriggeredChannel3FallingEdgeEnable, 0, 7);
            this.TriggeredChannel3Panel.Controls.Add(this.label34, 0, 3);
            this.TriggeredChannel3Panel.Controls.Add(this.label35, 0, 6);
            this.TriggeredChannel3Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel3Panel.Location = new System.Drawing.Point(3, 500);
            this.TriggeredChannel3Panel.Name = "TriggeredChannel3Panel";
            this.TriggeredChannel3Panel.RowCount = 9;
            this.TriggeredChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel3Panel.Size = new System.Drawing.Size(281, 164);
            this.TriggeredChannel3Panel.TabIndex = 12;
            // 
            // TriggeredChannel3OnTime
            // 
            this.TriggeredChannel3OnTime.AutoSize = true;
            this.TriggeredChannel3OnTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel3OnTime.Channel = 3;
            this.TriggeredChannel3Panel.SetColumnSpan(this.TriggeredChannel3OnTime, 2);
            this.TriggeredChannel3OnTime.DecimalPlaces = 0;
            this.TriggeredChannel3OnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel3OnTime.FontSize = 8.25F;
            this.TriggeredChannel3OnTime.Location = new System.Drawing.Point(3, 71);
            this.TriggeredChannel3OnTime.Maximum = 1000000;
            this.TriggeredChannel3OnTime.Minimum = 25;
            this.TriggeredChannel3OnTime.Name = "TriggeredChannel3OnTime";
            this.TriggeredChannel3OnTime.Size = new System.Drawing.Size(275, 26);
            this.TriggeredChannel3OnTime.TabIndex = 7;
            this.TriggeredChannel3OnTime.Value = 25;
            this.TriggeredChannel3OnTime.OnValueChanged += new SliderNumericCombo.ValueChanged(this.TriggeredChannelOnTime_OnValueChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.TriggeredChannel3Panel.SetColumnSpan(this.label36, 2);
            this.label36.Dock = System.Windows.Forms.DockStyle.Top;
            this.label36.Location = new System.Drawing.Point(3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(275, 13);
            this.label36.TabIndex = 13;
            this.label36.Text = "Ch 3 Delay";
            // 
            // TriggeredChannel3Delay
            // 
            this.TriggeredChannel3Delay.AutoSize = true;
            this.TriggeredChannel3Delay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel3Delay.Channel = 3;
            this.TriggeredChannel3Panel.SetColumnSpan(this.TriggeredChannel3Delay, 2);
            this.TriggeredChannel3Delay.DecimalPlaces = 0;
            this.TriggeredChannel3Delay.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel3Delay.FontSize = 8.25F;
            this.TriggeredChannel3Delay.Location = new System.Drawing.Point(3, 16);
            this.TriggeredChannel3Delay.Maximum = 1000000;
            this.TriggeredChannel3Delay.Minimum = 0;
            this.TriggeredChannel3Delay.Name = "TriggeredChannel3Delay";
            this.TriggeredChannel3Delay.Size = new System.Drawing.Size(275, 26);
            this.TriggeredChannel3Delay.TabIndex = 6;
            this.TriggeredChannel3Delay.Value = 0;
            this.TriggeredChannel3Delay.OnValueChanged += new SliderNumericCombo.ValueChanged(this.TriggeredChannelDelay_OnValueChanged);
            // 
            // TriggeredChannel3FallingEdgeEnable
            // 
            this.TriggeredChannel3FallingEdgeEnable.AutoSize = true;
            this.TriggeredChannel3FallingEdgeEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel3FallingEdgeEnable.BackColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel3FallingEdgeEnable.Channel = 3;
            this.TriggeredChannel3FallingEdgeEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel3FallingEdgeEnable.Location = new System.Drawing.Point(3, 126);
            this.TriggeredChannel3FallingEdgeEnable.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredChannel3FallingEdgeEnable.Name = "TriggeredChannel3FallingEdgeEnable";
            this.TriggeredChannel3FallingEdgeEnable.Size = new System.Drawing.Size(75, 25);
            this.TriggeredChannel3FallingEdgeEnable.TabIndex = 13;
            this.TriggeredChannel3FallingEdgeEnable.Text = "Falling Edge";
            this.TriggeredChannel3FallingEdgeEnable.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel3FallingEdgeEnable.ToggleDisabledText = "Rising Edge";
            this.TriggeredChannel3FallingEdgeEnable.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel3FallingEdgeEnable.ToggleEnabledText = "Falling Edge";
            this.TriggeredChannel3FallingEdgeEnable.UseVisualStyleBackColor = true;
            this.TriggeredChannel3FallingEdgeEnable.Click += new System.EventHandler(this.TriggeredChannelFallingEdgeEnable_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.TriggeredChannel3Panel.SetColumnSpan(this.label34, 2);
            this.label34.Dock = System.Windows.Forms.DockStyle.Top;
            this.label34.Location = new System.Drawing.Point(3, 55);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(275, 13);
            this.label34.TabIndex = 15;
            this.label34.Text = "Ch 3 On Time";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.TriggeredChannel3Panel.SetColumnSpan(this.label35, 2);
            this.label35.Dock = System.Windows.Forms.DockStyle.Top;
            this.label35.Location = new System.Drawing.Point(3, 110);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(275, 13);
            this.label35.TabIndex = 15;
            this.label35.Text = "Ch 3 Trigger On:";
            // 
            // TriggeredChannel4Panel
            // 
            this.TriggeredChannel4Panel.AutoSize = true;
            this.TriggeredChannel4Panel.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.TriggeredChannel4Panel, 5);
            this.TriggeredChannel4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TriggeredChannel4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TriggeredChannel4Panel.Controls.Add(this.TriggeredChannel4OnTime, 0, 4);
            this.TriggeredChannel4Panel.Controls.Add(this.label31, 0, 3);
            this.TriggeredChannel4Panel.Controls.Add(this.label32, 0, 6);
            this.TriggeredChannel4Panel.Controls.Add(this.TriggeredChannel4Delay, 0, 1);
            this.TriggeredChannel4Panel.Controls.Add(this.TriggeredChannel4FallingEdgeEnable, 0, 7);
            this.TriggeredChannel4Panel.Controls.Add(this.label33, 0, 0);
            this.TriggeredChannel4Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel4Panel.Location = new System.Drawing.Point(3, 670);
            this.TriggeredChannel4Panel.Name = "TriggeredChannel4Panel";
            this.TriggeredChannel4Panel.RowCount = 9;
            this.TriggeredChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TriggeredChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TriggeredChannel4Panel.Size = new System.Drawing.Size(281, 164);
            this.TriggeredChannel4Panel.TabIndex = 12;
            // 
            // TriggeredChannel4OnTime
            // 
            this.TriggeredChannel4OnTime.AutoSize = true;
            this.TriggeredChannel4OnTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel4OnTime.Channel = 4;
            this.TriggeredChannel4Panel.SetColumnSpan(this.TriggeredChannel4OnTime, 2);
            this.TriggeredChannel4OnTime.DecimalPlaces = 0;
            this.TriggeredChannel4OnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel4OnTime.FontSize = 8.25F;
            this.TriggeredChannel4OnTime.Location = new System.Drawing.Point(3, 71);
            this.TriggeredChannel4OnTime.Maximum = 1000000;
            this.TriggeredChannel4OnTime.Minimum = 25;
            this.TriggeredChannel4OnTime.Name = "TriggeredChannel4OnTime";
            this.TriggeredChannel4OnTime.Size = new System.Drawing.Size(275, 26);
            this.TriggeredChannel4OnTime.TabIndex = 7;
            this.TriggeredChannel4OnTime.Value = 25;
            this.TriggeredChannel4OnTime.OnValueChanged += new SliderNumericCombo.ValueChanged(this.TriggeredChannelOnTime_OnValueChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.TriggeredChannel4Panel.SetColumnSpan(this.label31, 2);
            this.label31.Dock = System.Windows.Forms.DockStyle.Top;
            this.label31.Location = new System.Drawing.Point(3, 55);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(275, 13);
            this.label31.TabIndex = 15;
            this.label31.Text = "Ch 4 On Time";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.TriggeredChannel4Panel.SetColumnSpan(this.label32, 2);
            this.label32.Dock = System.Windows.Forms.DockStyle.Top;
            this.label32.Location = new System.Drawing.Point(3, 110);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(275, 13);
            this.label32.TabIndex = 15;
            this.label32.Text = "Ch 4 Trigger On:";
            // 
            // TriggeredChannel4Delay
            // 
            this.TriggeredChannel4Delay.AutoSize = true;
            this.TriggeredChannel4Delay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel4Delay.Channel = 4;
            this.TriggeredChannel4Panel.SetColumnSpan(this.TriggeredChannel4Delay, 2);
            this.TriggeredChannel4Delay.DecimalPlaces = 0;
            this.TriggeredChannel4Delay.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel4Delay.FontSize = 8.25F;
            this.TriggeredChannel4Delay.Location = new System.Drawing.Point(3, 16);
            this.TriggeredChannel4Delay.Maximum = 1000000;
            this.TriggeredChannel4Delay.Minimum = 0;
            this.TriggeredChannel4Delay.Name = "TriggeredChannel4Delay";
            this.TriggeredChannel4Delay.Size = new System.Drawing.Size(275, 26);
            this.TriggeredChannel4Delay.TabIndex = 6;
            this.TriggeredChannel4Delay.Value = 0;
            this.TriggeredChannel4Delay.OnValueChanged += new SliderNumericCombo.ValueChanged(this.TriggeredChannelDelay_OnValueChanged);
            // 
            // TriggeredChannel4FallingEdgeEnable
            // 
            this.TriggeredChannel4FallingEdgeEnable.AutoSize = true;
            this.TriggeredChannel4FallingEdgeEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredChannel4FallingEdgeEnable.BackColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel4FallingEdgeEnable.Channel = 4;
            this.TriggeredChannel4FallingEdgeEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredChannel4FallingEdgeEnable.Location = new System.Drawing.Point(3, 126);
            this.TriggeredChannel4FallingEdgeEnable.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredChannel4FallingEdgeEnable.Name = "TriggeredChannel4FallingEdgeEnable";
            this.TriggeredChannel4FallingEdgeEnable.Size = new System.Drawing.Size(75, 25);
            this.TriggeredChannel4FallingEdgeEnable.TabIndex = 13;
            this.TriggeredChannel4FallingEdgeEnable.Text = "Falling Edge";
            this.TriggeredChannel4FallingEdgeEnable.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel4FallingEdgeEnable.ToggleDisabledText = "Rising Edge";
            this.TriggeredChannel4FallingEdgeEnable.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.TriggeredChannel4FallingEdgeEnable.ToggleEnabledText = "Falling Edge";
            this.TriggeredChannel4FallingEdgeEnable.UseVisualStyleBackColor = true;
            this.TriggeredChannel4FallingEdgeEnable.Click += new System.EventHandler(this.TriggeredChannelFallingEdgeEnable_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.TriggeredChannel4Panel.SetColumnSpan(this.label33, 2);
            this.label33.Dock = System.Windows.Forms.DockStyle.Top;
            this.label33.Location = new System.Drawing.Point(3, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(275, 13);
            this.label33.TabIndex = 13;
            this.label33.Text = "Ch 4 Delay";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label58, 3);
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Location = new System.Drawing.Point(117, 31);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(167, 31);
            this.label58.TabIndex = 5;
            this.label58.Text = "Combined Trigger";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TriggeredStrobeGangedEnable
            // 
            this.TriggeredStrobeGangedEnable.AutoSize = true;
            this.TriggeredStrobeGangedEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TriggeredStrobeGangedEnable.BackColor = System.Drawing.Color.Red;
            this.TriggeredStrobeGangedEnable.Channel = 0;
            this.tableLayoutPanel3.SetColumnSpan(this.TriggeredStrobeGangedEnable, 2);
            this.TriggeredStrobeGangedEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.TriggeredStrobeGangedEnable.Location = new System.Drawing.Point(3, 34);
            this.TriggeredStrobeGangedEnable.MinimumSize = new System.Drawing.Size(0, 25);
            this.TriggeredStrobeGangedEnable.Name = "TriggeredStrobeGangedEnable";
            this.TriggeredStrobeGangedEnable.Size = new System.Drawing.Size(108, 25);
            this.TriggeredStrobeGangedEnable.TabIndex = 4;
            this.TriggeredStrobeGangedEnable.Text = "Disable";
            this.TriggeredStrobeGangedEnable.ToggleDisabledColor = System.Drawing.Color.Red;
            this.TriggeredStrobeGangedEnable.ToggleDisabledText = "Disabled";
            this.TriggeredStrobeGangedEnable.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.TriggeredStrobeGangedEnable.ToggleEnabledText = "Enabled";
            this.TriggeredStrobeGangedEnable.UseVisualStyleBackColor = false;
            this.TriggeredStrobeGangedEnable.Click += new System.EventHandler(this.TriggeredStrobeGangedEnable_Click);
            // 
            // LEDChannelSettings
            // 
            this.LEDChannelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannelSettings.BackColor = System.Drawing.SystemColors.Control;
            this.LEDChannelSettings.Controls.Add(this.tableLayoutPanel9);
            this.LEDChannelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannelSettings.Location = new System.Drawing.Point(4, 126);
            this.LEDChannelSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LEDChannelSettings.Name = "LEDChannelSettings";
            this.LEDChannelSettings.Padding = new System.Windows.Forms.Padding(7);
            this.LEDChannelSettings.Size = new System.Drawing.Size(301, 764);
            this.LEDChannelSettings.TabIndex = 4;
            this.LEDChannelSettings.TabStop = false;
            this.LEDChannelSettings.Text = "LED Channel Settings";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.AutoSize = true;
            this.tableLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel9.ColumnCount = 5;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.Controls.Add(this.LEDChannel4Panel, 0, 14);
            this.tableLayoutPanel9.Controls.Add(this.LEDChannel1Panel, 0, 11);
            this.tableLayoutPanel9.Controls.Add(this.LEDChannel3Panel, 0, 13);
            this.tableLayoutPanel9.Controls.Add(this.LEDShowChannelAll, 4, 9);
            this.tableLayoutPanel9.Controls.Add(this.LEDChannel2Panel, 0, 12);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel4, 0, 6);
            this.tableLayoutPanel9.Controls.Add(this.LEDShowChannel4, 3, 9);
            this.tableLayoutPanel9.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel9.Controls.Add(this.LEDShowChannel3, 2, 9);
            this.tableLayoutPanel9.Controls.Add(this.LEDDemoMode, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.LEDShowChannel2, 1, 9);
            this.tableLayoutPanel9.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel9.Controls.Add(this.LEDShowChannel1, 0, 9);
            this.tableLayoutPanel9.Controls.Add(this.LEDCombinedTrigger, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel9.Controls.Add(this.label57, 2, 3);
            this.tableLayoutPanel9.Controls.Add(this.LEDSingleChannelOperation, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.knobMode, 0, 2);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 15;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(287, 729);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // LEDChannel4Panel
            // 
            this.LEDChannel4Panel.AutoSize = true;
            this.LEDChannel4Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel4Panel.ColumnCount = 2;
            this.tableLayoutPanel9.SetColumnSpan(this.LEDChannel4Panel, 5);
            this.LEDChannel4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LEDChannel4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LEDChannel4Panel.Controls.Add(this.LEDChannel4ShutdownButton, 0, 4);
            this.LEDChannel4Panel.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.LEDChannel4Panel.Controls.Add(this.label12, 0, 3);
            this.LEDChannel4Panel.Controls.Add(this.label13, 0, 0);
            this.LEDChannel4Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel4Panel.Location = new System.Drawing.Point(3, 611);
            this.LEDChannel4Panel.Name = "LEDChannel4Panel";
            this.LEDChannel4Panel.RowCount = 6;
            this.LEDChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LEDChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LEDChannel4Panel.Size = new System.Drawing.Size(281, 115);
            this.LEDChannel4Panel.TabIndex = 6;
            // 
            // LEDChannel4ShutdownButton
            // 
            this.LEDChannel4ShutdownButton.AutoSize = true;
            this.LEDChannel4ShutdownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel4ShutdownButton.BackColor = System.Drawing.SystemColors.Control;
            this.LEDChannel4ShutdownButton.Channel = 4;
            this.LEDChannel4ShutdownButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel4ShutdownButton.Location = new System.Drawing.Point(3, 77);
            this.LEDChannel4ShutdownButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDChannel4ShutdownButton.Name = "LEDChannel4ShutdownButton";
            this.LEDChannel4ShutdownButton.Size = new System.Drawing.Size(72, 25);
            this.LEDChannel4ShutdownButton.TabIndex = 13;
            this.LEDChannel4ShutdownButton.Text = "Active High";
            this.LEDChannel4ShutdownButton.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.LEDChannel4ShutdownButton.ToggleDisabledText = "Active Low";
            this.LEDChannel4ShutdownButton.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.LEDChannel4ShutdownButton.ToggleEnabledText = "Active High";
            this.LEDChannel4ShutdownButton.UseVisualStyleBackColor = true;
            this.LEDChannel4ShutdownButton.Click += new System.EventHandler(this.LEDChannelShutdownButton_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.LEDChannel4Panel.SetColumnSpan(this.tableLayoutPanel8, 2);
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.LEDChannel4Output, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.LEDChannel4PowerButton, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(275, 32);
            this.tableLayoutPanel8.TabIndex = 10;
            // 
            // LEDChannel4Output
            // 
            this.LEDChannel4Output.AutoSize = true;
            this.LEDChannel4Output.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel4Output.Channel = 4;
            this.LEDChannel4Output.DecimalPlaces = 1;
            this.LEDChannel4Output.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel4Output.FontSize = 8.25F;
            this.LEDChannel4Output.Location = new System.Drawing.Point(63, 3);
            this.LEDChannel4Output.Maximum = 1000;
            this.LEDChannel4Output.Minimum = 0;
            this.LEDChannel4Output.Name = "LEDChannel4Output";
            this.LEDChannel4Output.Size = new System.Drawing.Size(209, 26);
            this.LEDChannel4Output.TabIndex = 6;
            this.LEDChannel4Output.Value = 0;
            this.LEDChannel4Output.OnValueChanged += new SliderNumericCombo.ValueChanged(this.LEDChannelOutput_OnValueChanged);
            // 
            // LEDChannel4PowerButton
            // 
            this.LEDChannel4PowerButton.AutoSize = true;
            this.LEDChannel4PowerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel4PowerButton.BackColor = System.Drawing.Color.Red;
            this.LEDChannel4PowerButton.Channel = 4;
            this.LEDChannel4PowerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEDChannel4PowerButton.Location = new System.Drawing.Point(0, 0);
            this.LEDChannel4PowerButton.Margin = new System.Windows.Forms.Padding(0);
            this.LEDChannel4PowerButton.MinimumSize = new System.Drawing.Size(60, 25);
            this.LEDChannel4PowerButton.Name = "LEDChannel4PowerButton";
            this.LEDChannel4PowerButton.Size = new System.Drawing.Size(60, 32);
            this.LEDChannel4PowerButton.TabIndex = 8;
            this.LEDChannel4PowerButton.Text = "Off";
            this.LEDChannel4PowerButton.ToggleDisabledColor = System.Drawing.Color.Red;
            this.LEDChannel4PowerButton.ToggleDisabledText = "Off";
            this.LEDChannel4PowerButton.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.LEDChannel4PowerButton.ToggleEnabledText = "On";
            this.LEDChannel4PowerButton.UseVisualStyleBackColor = false;
            this.LEDChannel4PowerButton.Click += new System.EventHandler(this.LEDChannelPowerButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.LEDChannel4Panel.SetColumnSpan(this.label12, 2);
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(3, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Ch 4 Shut-down Pin:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.LEDChannel4Panel.SetColumnSpan(this.label13, 2);
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ch 4 Power Limit";
            // 
            // LEDChannel1Panel
            // 
            this.LEDChannel1Panel.AutoSize = true;
            this.LEDChannel1Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel1Panel.ColumnCount = 2;
            this.tableLayoutPanel9.SetColumnSpan(this.LEDChannel1Panel, 5);
            this.LEDChannel1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LEDChannel1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LEDChannel1Panel.Controls.Add(this.LEDChannel1ShutdownButton, 0, 4);
            this.LEDChannel1Panel.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.LEDChannel1Panel.Controls.Add(this.label6, 0, 0);
            this.LEDChannel1Panel.Controls.Add(this.label7, 0, 3);
            this.LEDChannel1Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel1Panel.Location = new System.Drawing.Point(3, 248);
            this.LEDChannel1Panel.Name = "LEDChannel1Panel";
            this.LEDChannel1Panel.RowCount = 6;
            this.LEDChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LEDChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LEDChannel1Panel.Size = new System.Drawing.Size(281, 115);
            this.LEDChannel1Panel.TabIndex = 3;
            // 
            // LEDChannel1ShutdownButton
            // 
            this.LEDChannel1ShutdownButton.AutoSize = true;
            this.LEDChannel1ShutdownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel1ShutdownButton.BackColor = System.Drawing.SystemColors.Control;
            this.LEDChannel1ShutdownButton.Channel = 1;
            this.LEDChannel1ShutdownButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel1ShutdownButton.Location = new System.Drawing.Point(3, 77);
            this.LEDChannel1ShutdownButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDChannel1ShutdownButton.Name = "LEDChannel1ShutdownButton";
            this.LEDChannel1ShutdownButton.Size = new System.Drawing.Size(72, 25);
            this.LEDChannel1ShutdownButton.TabIndex = 13;
            this.LEDChannel1ShutdownButton.Text = "Active High";
            this.LEDChannel1ShutdownButton.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.LEDChannel1ShutdownButton.ToggleDisabledText = "Active Low";
            this.LEDChannel1ShutdownButton.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.LEDChannel1ShutdownButton.ToggleEnabledText = "Active High";
            this.LEDChannel1ShutdownButton.UseVisualStyleBackColor = true;
            this.LEDChannel1ShutdownButton.Click += new System.EventHandler(this.LEDChannelShutdownButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.LEDChannel1Panel.SetColumnSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.LEDChannel1PowerButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.LEDChannel1Output, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(275, 32);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // LEDChannel1PowerButton
            // 
            this.LEDChannel1PowerButton.AutoSize = true;
            this.LEDChannel1PowerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel1PowerButton.BackColor = System.Drawing.Color.Red;
            this.LEDChannel1PowerButton.Channel = 1;
            this.LEDChannel1PowerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEDChannel1PowerButton.Location = new System.Drawing.Point(0, 0);
            this.LEDChannel1PowerButton.Margin = new System.Windows.Forms.Padding(0);
            this.LEDChannel1PowerButton.MinimumSize = new System.Drawing.Size(60, 25);
            this.LEDChannel1PowerButton.Name = "LEDChannel1PowerButton";
            this.LEDChannel1PowerButton.Size = new System.Drawing.Size(60, 32);
            this.LEDChannel1PowerButton.TabIndex = 8;
            this.LEDChannel1PowerButton.Text = "Off";
            this.LEDChannel1PowerButton.ToggleDisabledColor = System.Drawing.Color.Red;
            this.LEDChannel1PowerButton.ToggleDisabledText = "Off";
            this.LEDChannel1PowerButton.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.LEDChannel1PowerButton.ToggleEnabledText = "On";
            this.LEDChannel1PowerButton.UseVisualStyleBackColor = false;
            this.LEDChannel1PowerButton.Click += new System.EventHandler(this.LEDChannelPowerButton_Click);
            // 
            // LEDChannel1Output
            // 
            this.LEDChannel1Output.AutoSize = true;
            this.LEDChannel1Output.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel1Output.Channel = 1;
            this.LEDChannel1Output.DecimalPlaces = 1;
            this.LEDChannel1Output.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel1Output.FontSize = 8.25F;
            this.LEDChannel1Output.Location = new System.Drawing.Point(63, 3);
            this.LEDChannel1Output.Maximum = 1000;
            this.LEDChannel1Output.Minimum = 0;
            this.LEDChannel1Output.Name = "LEDChannel1Output";
            this.LEDChannel1Output.Size = new System.Drawing.Size(209, 26);
            this.LEDChannel1Output.TabIndex = 6;
            this.LEDChannel1Output.Value = 0;
            this.LEDChannel1Output.OnValueChanged += new SliderNumericCombo.ValueChanged(this.LEDChannelOutput_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.LEDChannel1Panel.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ch 1 Power Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.LEDChannel1Panel.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ch 1 Shut-down Pin:";
            // 
            // LEDChannel3Panel
            // 
            this.LEDChannel3Panel.AutoSize = true;
            this.LEDChannel3Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel3Panel.ColumnCount = 2;
            this.tableLayoutPanel9.SetColumnSpan(this.LEDChannel3Panel, 5);
            this.LEDChannel3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LEDChannel3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LEDChannel3Panel.Controls.Add(this.LEDChannel3ShutdownButton, 0, 4);
            this.LEDChannel3Panel.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.LEDChannel3Panel.Controls.Add(this.label10, 0, 3);
            this.LEDChannel3Panel.Controls.Add(this.label11, 0, 0);
            this.LEDChannel3Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel3Panel.Location = new System.Drawing.Point(3, 490);
            this.LEDChannel3Panel.Name = "LEDChannel3Panel";
            this.LEDChannel3Panel.RowCount = 6;
            this.LEDChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LEDChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LEDChannel3Panel.Size = new System.Drawing.Size(281, 115);
            this.LEDChannel3Panel.TabIndex = 5;
            // 
            // LEDChannel3ShutdownButton
            // 
            this.LEDChannel3ShutdownButton.AutoSize = true;
            this.LEDChannel3ShutdownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel3ShutdownButton.BackColor = System.Drawing.SystemColors.Control;
            this.LEDChannel3ShutdownButton.Channel = 3;
            this.LEDChannel3ShutdownButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel3ShutdownButton.Location = new System.Drawing.Point(3, 77);
            this.LEDChannel3ShutdownButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDChannel3ShutdownButton.Name = "LEDChannel3ShutdownButton";
            this.LEDChannel3ShutdownButton.Size = new System.Drawing.Size(72, 25);
            this.LEDChannel3ShutdownButton.TabIndex = 13;
            this.LEDChannel3ShutdownButton.Text = "Active High";
            this.LEDChannel3ShutdownButton.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.LEDChannel3ShutdownButton.ToggleDisabledText = "Active Low";
            this.LEDChannel3ShutdownButton.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.LEDChannel3ShutdownButton.ToggleEnabledText = "Active High";
            this.LEDChannel3ShutdownButton.UseVisualStyleBackColor = true;
            this.LEDChannel3ShutdownButton.Click += new System.EventHandler(this.LEDChannelShutdownButton_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.LEDChannel3Panel.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.LEDChannel3PowerButton, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.LEDChannel3Output, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(275, 32);
            this.tableLayoutPanel7.TabIndex = 10;
            // 
            // LEDChannel3PowerButton
            // 
            this.LEDChannel3PowerButton.AutoSize = true;
            this.LEDChannel3PowerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel3PowerButton.BackColor = System.Drawing.Color.Red;
            this.LEDChannel3PowerButton.Channel = 3;
            this.LEDChannel3PowerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEDChannel3PowerButton.Location = new System.Drawing.Point(0, 0);
            this.LEDChannel3PowerButton.Margin = new System.Windows.Forms.Padding(0);
            this.LEDChannel3PowerButton.MinimumSize = new System.Drawing.Size(60, 25);
            this.LEDChannel3PowerButton.Name = "LEDChannel3PowerButton";
            this.LEDChannel3PowerButton.Size = new System.Drawing.Size(60, 32);
            this.LEDChannel3PowerButton.TabIndex = 8;
            this.LEDChannel3PowerButton.Text = "Off";
            this.LEDChannel3PowerButton.ToggleDisabledColor = System.Drawing.Color.Red;
            this.LEDChannel3PowerButton.ToggleDisabledText = "Off";
            this.LEDChannel3PowerButton.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.LEDChannel3PowerButton.ToggleEnabledText = "On";
            this.LEDChannel3PowerButton.UseVisualStyleBackColor = false;
            this.LEDChannel3PowerButton.Click += new System.EventHandler(this.LEDChannelPowerButton_Click);
            // 
            // LEDChannel3Output
            // 
            this.LEDChannel3Output.AutoSize = true;
            this.LEDChannel3Output.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel3Output.Channel = 3;
            this.LEDChannel3Output.DecimalPlaces = 1;
            this.LEDChannel3Output.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel3Output.FontSize = 8.25F;
            this.LEDChannel3Output.Location = new System.Drawing.Point(63, 3);
            this.LEDChannel3Output.Maximum = 1000;
            this.LEDChannel3Output.Minimum = 0;
            this.LEDChannel3Output.Name = "LEDChannel3Output";
            this.LEDChannel3Output.Size = new System.Drawing.Size(209, 26);
            this.LEDChannel3Output.TabIndex = 6;
            this.LEDChannel3Output.Value = 0;
            this.LEDChannel3Output.OnValueChanged += new SliderNumericCombo.ValueChanged(this.LEDChannelOutput_OnValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.LEDChannel3Panel.SetColumnSpan(this.label10, 2);
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(3, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ch 3 Shut-down Pin:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.LEDChannel3Panel.SetColumnSpan(this.label11, 2);
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ch 3 Power Limit";
            // 
            // LEDShowChannelAll
            // 
            this.LEDShowChannelAll.AutoSize = true;
            this.LEDShowChannelAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDShowChannelAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDShowChannelAll.Location = new System.Drawing.Point(231, 207);
            this.LEDShowChannelAll.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDShowChannelAll.Name = "LEDShowChannelAll";
            this.LEDShowChannelAll.Size = new System.Drawing.Size(53, 25);
            this.LEDShowChannelAll.TabIndex = 4;
            this.LEDShowChannelAll.Text = "All";
            this.LEDShowChannelAll.UseVisualStyleBackColor = true;
            this.LEDShowChannelAll.Click += new System.EventHandler(this.LEDShowChannelAll_Click);
            // 
            // LEDChannel2Panel
            // 
            this.LEDChannel2Panel.AutoSize = true;
            this.LEDChannel2Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel2Panel.ColumnCount = 2;
            this.tableLayoutPanel9.SetColumnSpan(this.LEDChannel2Panel, 5);
            this.LEDChannel2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LEDChannel2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LEDChannel2Panel.Controls.Add(this.LEDChannel2ShutdownButton, 0, 4);
            this.LEDChannel2Panel.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.LEDChannel2Panel.Controls.Add(this.label8, 0, 3);
            this.LEDChannel2Panel.Controls.Add(this.label9, 0, 0);
            this.LEDChannel2Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel2Panel.Location = new System.Drawing.Point(3, 369);
            this.LEDChannel2Panel.Name = "LEDChannel2Panel";
            this.LEDChannel2Panel.RowCount = 6;
            this.LEDChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LEDChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LEDChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LEDChannel2Panel.Size = new System.Drawing.Size(281, 115);
            this.LEDChannel2Panel.TabIndex = 4;
            // 
            // LEDChannel2ShutdownButton
            // 
            this.LEDChannel2ShutdownButton.AutoSize = true;
            this.LEDChannel2ShutdownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel2ShutdownButton.BackColor = System.Drawing.SystemColors.Control;
            this.LEDChannel2ShutdownButton.Channel = 2;
            this.LEDChannel2ShutdownButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel2ShutdownButton.Location = new System.Drawing.Point(3, 77);
            this.LEDChannel2ShutdownButton.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDChannel2ShutdownButton.Name = "LEDChannel2ShutdownButton";
            this.LEDChannel2ShutdownButton.Size = new System.Drawing.Size(72, 25);
            this.LEDChannel2ShutdownButton.TabIndex = 13;
            this.LEDChannel2ShutdownButton.Text = "Active High";
            this.LEDChannel2ShutdownButton.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.LEDChannel2ShutdownButton.ToggleDisabledText = "Active Low";
            this.LEDChannel2ShutdownButton.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.LEDChannel2ShutdownButton.ToggleEnabledText = "Active High";
            this.LEDChannel2ShutdownButton.UseVisualStyleBackColor = true;
            this.LEDChannel2ShutdownButton.Click += new System.EventHandler(this.LEDChannelShutdownButton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.LEDChannel2Panel.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.LEDChannel2PowerButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.LEDChannel2Output, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(275, 32);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // LEDChannel2PowerButton
            // 
            this.LEDChannel2PowerButton.AutoSize = true;
            this.LEDChannel2PowerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel2PowerButton.BackColor = System.Drawing.Color.Red;
            this.LEDChannel2PowerButton.Channel = 2;
            this.LEDChannel2PowerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEDChannel2PowerButton.Location = new System.Drawing.Point(0, 0);
            this.LEDChannel2PowerButton.Margin = new System.Windows.Forms.Padding(0);
            this.LEDChannel2PowerButton.MinimumSize = new System.Drawing.Size(60, 25);
            this.LEDChannel2PowerButton.Name = "LEDChannel2PowerButton";
            this.LEDChannel2PowerButton.Size = new System.Drawing.Size(60, 32);
            this.LEDChannel2PowerButton.TabIndex = 8;
            this.LEDChannel2PowerButton.Text = "Off";
            this.LEDChannel2PowerButton.ToggleDisabledColor = System.Drawing.Color.Red;
            this.LEDChannel2PowerButton.ToggleDisabledText = "Off";
            this.LEDChannel2PowerButton.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.LEDChannel2PowerButton.ToggleEnabledText = "On";
            this.LEDChannel2PowerButton.UseVisualStyleBackColor = false;
            this.LEDChannel2PowerButton.Click += new System.EventHandler(this.LEDChannelPowerButton_Click);
            // 
            // LEDChannel2Output
            // 
            this.LEDChannel2Output.AutoSize = true;
            this.LEDChannel2Output.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDChannel2Output.Channel = 2;
            this.LEDChannel2Output.DecimalPlaces = 1;
            this.LEDChannel2Output.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDChannel2Output.FontSize = 8.25F;
            this.LEDChannel2Output.Location = new System.Drawing.Point(63, 3);
            this.LEDChannel2Output.Maximum = 1000;
            this.LEDChannel2Output.Minimum = 0;
            this.LEDChannel2Output.Name = "LEDChannel2Output";
            this.LEDChannel2Output.Size = new System.Drawing.Size(209, 26);
            this.LEDChannel2Output.TabIndex = 6;
            this.LEDChannel2Output.Value = 0;
            this.LEDChannel2Output.OnValueChanged += new SliderNumericCombo.ValueChanged(this.LEDChannelOutput_OnValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.LEDChannel2Panel.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(3, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ch 2 Shut-down Pin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.LEDChannel2Panel.SetColumnSpan(this.label9, 2);
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ch 2 Power Limit";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel9.SetColumnSpan(this.tableLayoutPanel4, 5);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.LEDOutput, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.LEDOutputPowerButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 146);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(281, 32);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // LEDOutput
            // 
            this.LEDOutput.AutoSize = true;
            this.LEDOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDOutput.Channel = 0;
            this.LEDOutput.DecimalPlaces = 1;
            this.LEDOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDOutput.FontSize = 8.25F;
            this.LEDOutput.Location = new System.Drawing.Point(63, 3);
            this.LEDOutput.Maximum = 1000;
            this.LEDOutput.Minimum = 0;
            this.LEDOutput.Name = "LEDOutput";
            this.LEDOutput.Size = new System.Drawing.Size(215, 26);
            this.LEDOutput.TabIndex = 6;
            this.LEDOutput.Value = 0;
            this.LEDOutput.OnValueChanged += new SliderNumericCombo.ValueChanged(this.LEDOutput_OnValueChanged);
            // 
            // LEDOutputPowerButton
            // 
            this.LEDOutputPowerButton.AutoSize = true;
            this.LEDOutputPowerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDOutputPowerButton.BackColor = System.Drawing.Color.Red;
            this.LEDOutputPowerButton.Channel = 0;
            this.LEDOutputPowerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEDOutputPowerButton.Location = new System.Drawing.Point(0, 0);
            this.LEDOutputPowerButton.Margin = new System.Windows.Forms.Padding(0);
            this.LEDOutputPowerButton.MinimumSize = new System.Drawing.Size(60, 25);
            this.LEDOutputPowerButton.Name = "LEDOutputPowerButton";
            this.LEDOutputPowerButton.Size = new System.Drawing.Size(60, 32);
            this.LEDOutputPowerButton.TabIndex = 8;
            this.LEDOutputPowerButton.Text = "Off";
            this.LEDOutputPowerButton.ToggleDisabledColor = System.Drawing.Color.Red;
            this.LEDOutputPowerButton.ToggleDisabledText = "Off";
            this.LEDOutputPowerButton.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.LEDOutputPowerButton.ToggleEnabledText = "On";
            this.LEDOutputPowerButton.UseVisualStyleBackColor = false;
            this.LEDOutputPowerButton.Click += new System.EventHandler(this.LEDOutputPowerButton_Click);
            // 
            // LEDShowChannel4
            // 
            this.LEDShowChannel4.AutoSize = true;
            this.LEDShowChannel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDShowChannel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDShowChannel4.Location = new System.Drawing.Point(174, 207);
            this.LEDShowChannel4.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDShowChannel4.Name = "LEDShowChannel4";
            this.LEDShowChannel4.Size = new System.Drawing.Size(51, 25);
            this.LEDShowChannel4.TabIndex = 3;
            this.LEDShowChannel4.Text = "4";
            this.LEDShowChannel4.UseVisualStyleBackColor = true;
            this.LEDShowChannel4.Click += new System.EventHandler(this.LEDShowChannel4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel9.SetColumnSpan(this.label5, 5);
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Channels";
            // 
            // LEDShowChannel3
            // 
            this.LEDShowChannel3.AutoSize = true;
            this.LEDShowChannel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDShowChannel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDShowChannel3.Location = new System.Drawing.Point(117, 207);
            this.LEDShowChannel3.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDShowChannel3.Name = "LEDShowChannel3";
            this.LEDShowChannel3.Size = new System.Drawing.Size(51, 25);
            this.LEDShowChannel3.TabIndex = 2;
            this.LEDShowChannel3.Text = "3";
            this.LEDShowChannel3.UseVisualStyleBackColor = true;
            this.LEDShowChannel3.Click += new System.EventHandler(this.LEDShowChannel3_Click);
            // 
            // LEDDemoMode
            // 
            this.LEDDemoMode.AutoSize = true;
            this.LEDDemoMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDDemoMode.BackColor = System.Drawing.Color.Red;
            this.LEDDemoMode.Channel = 0;
            this.tableLayoutPanel9.SetColumnSpan(this.LEDDemoMode, 2);
            this.LEDDemoMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDDemoMode.Location = new System.Drawing.Point(3, 3);
            this.LEDDemoMode.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDDemoMode.Name = "LEDDemoMode";
            this.LEDDemoMode.Size = new System.Drawing.Size(108, 25);
            this.LEDDemoMode.TabIndex = 0;
            this.LEDDemoMode.Text = "Disable";
            this.LEDDemoMode.ToggleDisabledColor = System.Drawing.Color.Red;
            this.LEDDemoMode.ToggleDisabledText = "Disabled";
            this.LEDDemoMode.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.LEDDemoMode.ToggleEnabledText = "Enabled";
            this.LEDDemoMode.UseVisualStyleBackColor = false;
            this.LEDDemoMode.Click += new System.EventHandler(this.LEDDemoMode_Click);
            // 
            // LEDShowChannel2
            // 
            this.LEDShowChannel2.AutoSize = true;
            this.LEDShowChannel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDShowChannel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDShowChannel2.Location = new System.Drawing.Point(60, 207);
            this.LEDShowChannel2.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDShowChannel2.Name = "LEDShowChannel2";
            this.LEDShowChannel2.Size = new System.Drawing.Size(51, 25);
            this.LEDShowChannel2.TabIndex = 1;
            this.LEDShowChannel2.Text = "2";
            this.LEDShowChannel2.UseVisualStyleBackColor = true;
            this.LEDShowChannel2.Click += new System.EventHandler(this.LEDShowChannel2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel9.SetColumnSpan(this.label4, 5);
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Output Power";
            // 
            // LEDShowChannel1
            // 
            this.LEDShowChannel1.AutoSize = true;
            this.LEDShowChannel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDShowChannel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDShowChannel1.Location = new System.Drawing.Point(3, 207);
            this.LEDShowChannel1.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDShowChannel1.Name = "LEDShowChannel1";
            this.LEDShowChannel1.Size = new System.Drawing.Size(51, 25);
            this.LEDShowChannel1.TabIndex = 0;
            this.LEDShowChannel1.Text = "1";
            this.LEDShowChannel1.UseVisualStyleBackColor = true;
            this.LEDShowChannel1.Click += new System.EventHandler(this.LEDShowChannel1_Click);
            // 
            // LEDCombinedTrigger
            // 
            this.LEDCombinedTrigger.AutoSize = true;
            this.LEDCombinedTrigger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDCombinedTrigger.BackColor = System.Drawing.Color.Red;
            this.LEDCombinedTrigger.Channel = 0;
            this.tableLayoutPanel9.SetColumnSpan(this.LEDCombinedTrigger, 2);
            this.LEDCombinedTrigger.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDCombinedTrigger.Location = new System.Drawing.Point(3, 34);
            this.LEDCombinedTrigger.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDCombinedTrigger.Name = "LEDCombinedTrigger";
            this.LEDCombinedTrigger.Size = new System.Drawing.Size(108, 25);
            this.LEDCombinedTrigger.TabIndex = 2;
            this.LEDCombinedTrigger.Text = "Disable";
            this.LEDCombinedTrigger.ToggleDisabledColor = System.Drawing.Color.Red;
            this.LEDCombinedTrigger.ToggleDisabledText = "Disabled";
            this.LEDCombinedTrigger.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.LEDCombinedTrigger.ToggleEnabledText = "Enabled";
            this.LEDCombinedTrigger.UseVisualStyleBackColor = false;
            this.LEDCombinedTrigger.Click += new System.EventHandler(this.LEDCombinedTrigger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel9.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(117, 0);
            this.label1.MinimumSize = new System.Drawing.Size(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Demo Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel9.SetColumnSpan(this.label2, 3);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(117, 31);
            this.label2.MinimumSize = new System.Drawing.Size(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Combined Trigger";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel9.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(117, 62);
            this.label3.MinimumSize = new System.Drawing.Size(0, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Knob Mode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.tableLayoutPanel9.SetColumnSpan(this.label57, 3);
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.Location = new System.Drawing.Point(117, 89);
            this.label57.MinimumSize = new System.Drawing.Size(0, 25);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(167, 31);
            this.label57.TabIndex = 5;
            this.label57.Text = "Channel Operation";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LEDSingleChannelOperation
            // 
            this.LEDSingleChannelOperation.AutoSize = true;
            this.LEDSingleChannelOperation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LEDSingleChannelOperation.BackColor = System.Drawing.SystemColors.Control;
            this.LEDSingleChannelOperation.Channel = 0;
            this.tableLayoutPanel9.SetColumnSpan(this.LEDSingleChannelOperation, 2);
            this.LEDSingleChannelOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEDSingleChannelOperation.Location = new System.Drawing.Point(3, 92);
            this.LEDSingleChannelOperation.MinimumSize = new System.Drawing.Size(0, 25);
            this.LEDSingleChannelOperation.Name = "LEDSingleChannelOperation";
            this.LEDSingleChannelOperation.Size = new System.Drawing.Size(108, 25);
            this.LEDSingleChannelOperation.TabIndex = 4;
            this.LEDSingleChannelOperation.Text = "Single";
            this.LEDSingleChannelOperation.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.LEDSingleChannelOperation.ToggleDisabledText = "Quad";
            this.LEDSingleChannelOperation.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.LEDSingleChannelOperation.ToggleEnabledText = "Single";
            this.LEDSingleChannelOperation.UseVisualStyleBackColor = true;
            this.LEDSingleChannelOperation.Click += new System.EventHandler(this.LEDSingleChannelOperation_Click);
            // 
            // knobMode
            // 
            this.tableLayoutPanel9.SetColumnSpan(this.knobMode, 2);
            this.knobMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.knobMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.knobMode.FormattingEnabled = true;
            this.knobMode.Items.AddRange(new object[] {
            "Common",
            "Channel 1",
            "Channel 2",
            "Channel 3",
            "Channel 4",
            "Demo"});
            this.knobMode.Location = new System.Drawing.Point(3, 65);
            this.knobMode.Name = "knobMode";
            this.knobMode.Size = new System.Drawing.Size(108, 21);
            this.knobMode.TabIndex = 12;
            this.knobMode.DropDown += new System.EventHandler(this.knobMode_DropDown);
            this.knobMode.SelectedIndexChanged += new System.EventHandler(this.knobMode_SelectedIndexChanged);
            // 
            // ContinuousChannelSettings
            // 
            this.ContinuousChannelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannelSettings.BackColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannelSettings.Controls.Add(this.tableLayoutPanel2);
            this.ContinuousChannelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannelSettings.Location = new System.Drawing.Point(4, 903);
            this.ContinuousChannelSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ContinuousChannelSettings.Name = "ContinuousChannelSettings";
            this.ContinuousChannelSettings.Padding = new System.Windows.Forms.Padding(7);
            this.ContinuousChannelSettings.Size = new System.Drawing.Size(301, 896);
            this.ContinuousChannelSettings.TabIndex = 5;
            this.ContinuousChannelSettings.TabStop = false;
            this.ContinuousChannelSettings.Text = "Continuous Strobe";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ContinuousShowChannel1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousShowChannel2, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousShowChannel3, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousShowChannel4, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousShowChannelAll, 4, 7);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousStrobeEnable, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousSingleChannelEnable, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousFrequency, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousChannel1Panel, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousChannel2Panel, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousChannel3Panel, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.ContinuousChannel4Panel, 0, 12);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(287, 861);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ContinuousShowChannel1
            // 
            this.ContinuousShowChannel1.AutoSize = true;
            this.ContinuousShowChannel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousShowChannel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousShowChannel1.Location = new System.Drawing.Point(3, 143);
            this.ContinuousShowChannel1.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousShowChannel1.Name = "ContinuousShowChannel1";
            this.ContinuousShowChannel1.Size = new System.Drawing.Size(51, 25);
            this.ContinuousShowChannel1.TabIndex = 0;
            this.ContinuousShowChannel1.Text = "1";
            this.ContinuousShowChannel1.UseVisualStyleBackColor = true;
            this.ContinuousShowChannel1.Click += new System.EventHandler(this.ContinuousShowChannel1_Click);
            // 
            // ContinuousShowChannel2
            // 
            this.ContinuousShowChannel2.AutoSize = true;
            this.ContinuousShowChannel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousShowChannel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousShowChannel2.Location = new System.Drawing.Point(60, 143);
            this.ContinuousShowChannel2.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousShowChannel2.Name = "ContinuousShowChannel2";
            this.ContinuousShowChannel2.Size = new System.Drawing.Size(51, 25);
            this.ContinuousShowChannel2.TabIndex = 1;
            this.ContinuousShowChannel2.Text = "2";
            this.ContinuousShowChannel2.UseVisualStyleBackColor = true;
            this.ContinuousShowChannel2.Click += new System.EventHandler(this.ContinuousShowChannel2_Click);
            // 
            // ContinuousShowChannel3
            // 
            this.ContinuousShowChannel3.AutoSize = true;
            this.ContinuousShowChannel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousShowChannel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousShowChannel3.Location = new System.Drawing.Point(117, 143);
            this.ContinuousShowChannel3.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousShowChannel3.Name = "ContinuousShowChannel3";
            this.ContinuousShowChannel3.Size = new System.Drawing.Size(51, 25);
            this.ContinuousShowChannel3.TabIndex = 2;
            this.ContinuousShowChannel3.Text = "3";
            this.ContinuousShowChannel3.UseVisualStyleBackColor = true;
            this.ContinuousShowChannel3.Click += new System.EventHandler(this.ContinuousShowChannel3_Click);
            // 
            // ContinuousShowChannel4
            // 
            this.ContinuousShowChannel4.AutoSize = true;
            this.ContinuousShowChannel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousShowChannel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousShowChannel4.Location = new System.Drawing.Point(174, 143);
            this.ContinuousShowChannel4.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousShowChannel4.Name = "ContinuousShowChannel4";
            this.ContinuousShowChannel4.Size = new System.Drawing.Size(51, 25);
            this.ContinuousShowChannel4.TabIndex = 3;
            this.ContinuousShowChannel4.Text = "4";
            this.ContinuousShowChannel4.UseVisualStyleBackColor = true;
            this.ContinuousShowChannel4.Click += new System.EventHandler(this.ContinuousShowChannel4_Click);
            // 
            // ContinuousShowChannelAll
            // 
            this.ContinuousShowChannelAll.AutoSize = true;
            this.ContinuousShowChannelAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousShowChannelAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousShowChannelAll.Location = new System.Drawing.Point(231, 143);
            this.ContinuousShowChannelAll.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousShowChannelAll.Name = "ContinuousShowChannelAll";
            this.ContinuousShowChannelAll.Size = new System.Drawing.Size(53, 25);
            this.ContinuousShowChannelAll.TabIndex = 4;
            this.ContinuousShowChannelAll.Text = "All";
            this.ContinuousShowChannelAll.UseVisualStyleBackColor = true;
            this.ContinuousShowChannelAll.Click += new System.EventHandler(this.ContinuousShowChannelAll_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label17, 5);
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Location = new System.Drawing.Point(3, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(281, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Channels";
            // 
            // ContinuousStrobeEnable
            // 
            this.ContinuousStrobeEnable.AutoSize = true;
            this.ContinuousStrobeEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousStrobeEnable.BackColor = System.Drawing.Color.Red;
            this.ContinuousStrobeEnable.Channel = 0;
            this.tableLayoutPanel2.SetColumnSpan(this.ContinuousStrobeEnable, 2);
            this.ContinuousStrobeEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousStrobeEnable.Location = new System.Drawing.Point(3, 3);
            this.ContinuousStrobeEnable.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousStrobeEnable.Name = "ContinuousStrobeEnable";
            this.ContinuousStrobeEnable.Size = new System.Drawing.Size(108, 25);
            this.ContinuousStrobeEnable.TabIndex = 0;
            this.ContinuousStrobeEnable.Text = "Disable";
            this.ContinuousStrobeEnable.ToggleDisabledColor = System.Drawing.Color.Red;
            this.ContinuousStrobeEnable.ToggleDisabledText = "Disabled";
            this.ContinuousStrobeEnable.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.ContinuousStrobeEnable.ToggleEnabledText = "Enabled";
            this.ContinuousStrobeEnable.UseVisualStyleBackColor = false;
            this.ContinuousStrobeEnable.Click += new System.EventHandler(this.ContinuousStrobeEnable_Click);
            // 
            // ContinuousSingleChannelEnable
            // 
            this.ContinuousSingleChannelEnable.AutoSize = true;
            this.ContinuousSingleChannelEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousSingleChannelEnable.BackColor = System.Drawing.SystemColors.Control;
            this.ContinuousSingleChannelEnable.Channel = 0;
            this.tableLayoutPanel2.SetColumnSpan(this.ContinuousSingleChannelEnable, 2);
            this.ContinuousSingleChannelEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousSingleChannelEnable.Location = new System.Drawing.Point(3, 34);
            this.ContinuousSingleChannelEnable.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousSingleChannelEnable.Name = "ContinuousSingleChannelEnable";
            this.ContinuousSingleChannelEnable.Size = new System.Drawing.Size(108, 25);
            this.ContinuousSingleChannelEnable.TabIndex = 4;
            this.ContinuousSingleChannelEnable.Text = "Single";
            this.ContinuousSingleChannelEnable.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousSingleChannelEnable.ToggleDisabledText = "Quad";
            this.ContinuousSingleChannelEnable.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousSingleChannelEnable.ToggleEnabledText = "Single";
            this.ContinuousSingleChannelEnable.UseVisualStyleBackColor = true;
            this.ContinuousSingleChannelEnable.Click += new System.EventHandler(this.ContinuousSingleChannelEnable_Click);
            // 
            // ContinuousFrequency
            // 
            this.ContinuousFrequency.AutoSize = true;
            this.ContinuousFrequency.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousFrequency.Channel = 0;
            this.tableLayoutPanel2.SetColumnSpan(this.ContinuousFrequency, 5);
            this.ContinuousFrequency.DecimalPlaces = 0;
            this.ContinuousFrequency.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousFrequency.FontSize = 8.25F;
            this.ContinuousFrequency.Location = new System.Drawing.Point(3, 88);
            this.ContinuousFrequency.Maximum = 20000;
            this.ContinuousFrequency.Minimum = 6;
            this.ContinuousFrequency.Name = "ContinuousFrequency";
            this.ContinuousFrequency.Size = new System.Drawing.Size(281, 26);
            this.ContinuousFrequency.TabIndex = 6;
            this.ContinuousFrequency.Value = 6;
            this.ContinuousFrequency.OnValueChanged += new SliderNumericCombo.ValueChanged(this.ContinuousFrequency_OnValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label18, 5);
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Location = new System.Drawing.Point(3, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(281, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Frequency (Hz)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label21, 3);
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(117, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(167, 31);
            this.label21.TabIndex = 1;
            this.label21.Text = "Continuous Strobe";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label19, 3);
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(117, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(167, 31);
            this.label19.TabIndex = 5;
            this.label19.Text = "Channel Operation";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContinuousChannel1Panel
            // 
            this.ContinuousChannel1Panel.AutoSize = true;
            this.ContinuousChannel1Panel.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.ContinuousChannel1Panel, 5);
            this.ContinuousChannel1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ContinuousChannel1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContinuousChannel1Panel.Controls.Add(this.ContinuousChannel1WaveformActiveHigh, 0, 7);
            this.ContinuousChannel1Panel.Controls.Add(this.label22, 0, 6);
            this.ContinuousChannel1Panel.Controls.Add(this.label15, 0, 3);
            this.ContinuousChannel1Panel.Controls.Add(this.ContinuousChannel1PhaseShift, 0, 4);
            this.ContinuousChannel1Panel.Controls.Add(this.label23, 0, 0);
            this.ContinuousChannel1Panel.Controls.Add(this.ContinuousChannel1DutyCycle, 0, 1);
            this.ContinuousChannel1Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel1Panel.Location = new System.Drawing.Point(3, 184);
            this.ContinuousChannel1Panel.Name = "ContinuousChannel1Panel";
            this.ContinuousChannel1Panel.RowCount = 9;
            this.ContinuousChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel1Panel.Size = new System.Drawing.Size(281, 164);
            this.ContinuousChannel1Panel.TabIndex = 12;
            // 
            // ContinuousChannel1WaveformActiveHigh
            // 
            this.ContinuousChannel1WaveformActiveHigh.AutoSize = true;
            this.ContinuousChannel1WaveformActiveHigh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel1WaveformActiveHigh.BackColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel1WaveformActiveHigh.Channel = 1;
            this.ContinuousChannel1WaveformActiveHigh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel1WaveformActiveHigh.Location = new System.Drawing.Point(3, 126);
            this.ContinuousChannel1WaveformActiveHigh.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousChannel1WaveformActiveHigh.Name = "ContinuousChannel1WaveformActiveHigh";
            this.ContinuousChannel1WaveformActiveHigh.Size = new System.Drawing.Size(72, 25);
            this.ContinuousChannel1WaveformActiveHigh.TabIndex = 13;
            this.ContinuousChannel1WaveformActiveHigh.Text = "Active High";
            this.ContinuousChannel1WaveformActiveHigh.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel1WaveformActiveHigh.ToggleDisabledText = "Active Low";
            this.ContinuousChannel1WaveformActiveHigh.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel1WaveformActiveHigh.ToggleEnabledText = "Active High";
            this.ContinuousChannel1WaveformActiveHigh.UseVisualStyleBackColor = true;
            this.ContinuousChannel1WaveformActiveHigh.Click += new System.EventHandler(this.ContinuousChannelWaveformActiveHigh_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.ContinuousChannel1Panel.SetColumnSpan(this.label22, 2);
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Location = new System.Drawing.Point(3, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(275, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Ch 1 Waveform:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.ContinuousChannel1Panel.SetColumnSpan(this.label15, 2);
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(3, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(275, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Ch 1 Phase Shift (%)";
            // 
            // ContinuousChannel1PhaseShift
            // 
            this.ContinuousChannel1PhaseShift.AutoSize = true;
            this.ContinuousChannel1PhaseShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel1PhaseShift.Channel = 1;
            this.ContinuousChannel1Panel.SetColumnSpan(this.ContinuousChannel1PhaseShift, 2);
            this.ContinuousChannel1PhaseShift.DecimalPlaces = 1;
            this.ContinuousChannel1PhaseShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel1PhaseShift.FontSize = 8.25F;
            this.ContinuousChannel1PhaseShift.Location = new System.Drawing.Point(3, 71);
            this.ContinuousChannel1PhaseShift.Maximum = 1000;
            this.ContinuousChannel1PhaseShift.Minimum = 0;
            this.ContinuousChannel1PhaseShift.Name = "ContinuousChannel1PhaseShift";
            this.ContinuousChannel1PhaseShift.Size = new System.Drawing.Size(275, 26);
            this.ContinuousChannel1PhaseShift.TabIndex = 8;
            this.ContinuousChannel1PhaseShift.Value = 0;
            this.ContinuousChannel1PhaseShift.OnValueChanged += new SliderNumericCombo.ValueChanged(this.ContinuousChannelPhaseShift_OnValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.ContinuousChannel1Panel.SetColumnSpan(this.label23, 2);
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Location = new System.Drawing.Point(3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(275, 13);
            this.label23.TabIndex = 13;
            this.label23.Text = "Ch 1 Duty Cycle (%)";
            // 
            // ContinuousChannel1DutyCycle
            // 
            this.ContinuousChannel1DutyCycle.AutoSize = true;
            this.ContinuousChannel1DutyCycle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel1DutyCycle.Channel = 1;
            this.ContinuousChannel1Panel.SetColumnSpan(this.ContinuousChannel1DutyCycle, 2);
            this.ContinuousChannel1DutyCycle.DecimalPlaces = 1;
            this.ContinuousChannel1DutyCycle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel1DutyCycle.FontSize = 8.25F;
            this.ContinuousChannel1DutyCycle.Location = new System.Drawing.Point(3, 16);
            this.ContinuousChannel1DutyCycle.Maximum = 1000;
            this.ContinuousChannel1DutyCycle.Minimum = 0;
            this.ContinuousChannel1DutyCycle.Name = "ContinuousChannel1DutyCycle";
            this.ContinuousChannel1DutyCycle.Size = new System.Drawing.Size(275, 26);
            this.ContinuousChannel1DutyCycle.TabIndex = 7;
            this.ContinuousChannel1DutyCycle.Value = 0;
            this.ContinuousChannel1DutyCycle.OnValueChanged += new SliderNumericCombo.ValueChanged(this.ContinuousChannelDutyCycle_OnValueChanged);
            // 
            // ContinuousChannel2Panel
            // 
            this.ContinuousChannel2Panel.AutoSize = true;
            this.ContinuousChannel2Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel2Panel.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.ContinuousChannel2Panel, 5);
            this.ContinuousChannel2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ContinuousChannel2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContinuousChannel2Panel.Controls.Add(this.label24, 0, 0);
            this.ContinuousChannel2Panel.Controls.Add(this.ContinuousChannel2WaveformActiveHigh, 0, 7);
            this.ContinuousChannel2Panel.Controls.Add(this.ContinuousChannel2PhaseShift, 0, 4);
            this.ContinuousChannel2Panel.Controls.Add(this.label16, 0, 3);
            this.ContinuousChannel2Panel.Controls.Add(this.label20, 0, 6);
            this.ContinuousChannel2Panel.Controls.Add(this.ContinuousChannel2DutyCycle, 0, 1);
            this.ContinuousChannel2Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel2Panel.Location = new System.Drawing.Point(3, 354);
            this.ContinuousChannel2Panel.Name = "ContinuousChannel2Panel";
            this.ContinuousChannel2Panel.RowCount = 9;
            this.ContinuousChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel2Panel.Size = new System.Drawing.Size(281, 164);
            this.ContinuousChannel2Panel.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.ContinuousChannel2Panel.SetColumnSpan(this.label24, 2);
            this.label24.Dock = System.Windows.Forms.DockStyle.Top;
            this.label24.Location = new System.Drawing.Point(3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(275, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Ch 2 Duty Cycle (%)";
            // 
            // ContinuousChannel2WaveformActiveHigh
            // 
            this.ContinuousChannel2WaveformActiveHigh.AutoSize = true;
            this.ContinuousChannel2WaveformActiveHigh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel2WaveformActiveHigh.BackColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel2WaveformActiveHigh.Channel = 2;
            this.ContinuousChannel2WaveformActiveHigh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel2WaveformActiveHigh.Location = new System.Drawing.Point(3, 126);
            this.ContinuousChannel2WaveformActiveHigh.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousChannel2WaveformActiveHigh.Name = "ContinuousChannel2WaveformActiveHigh";
            this.ContinuousChannel2WaveformActiveHigh.Size = new System.Drawing.Size(72, 25);
            this.ContinuousChannel2WaveformActiveHigh.TabIndex = 13;
            this.ContinuousChannel2WaveformActiveHigh.Text = "Active High";
            this.ContinuousChannel2WaveformActiveHigh.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel2WaveformActiveHigh.ToggleDisabledText = "Active Low";
            this.ContinuousChannel2WaveformActiveHigh.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel2WaveformActiveHigh.ToggleEnabledText = "Active High";
            this.ContinuousChannel2WaveformActiveHigh.UseVisualStyleBackColor = true;
            this.ContinuousChannel2WaveformActiveHigh.Click += new System.EventHandler(this.ContinuousChannelWaveformActiveHigh_Click);
            // 
            // ContinuousChannel2PhaseShift
            // 
            this.ContinuousChannel2PhaseShift.AutoSize = true;
            this.ContinuousChannel2PhaseShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel2PhaseShift.Channel = 2;
            this.ContinuousChannel2Panel.SetColumnSpan(this.ContinuousChannel2PhaseShift, 2);
            this.ContinuousChannel2PhaseShift.DecimalPlaces = 1;
            this.ContinuousChannel2PhaseShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel2PhaseShift.FontSize = 8.25F;
            this.ContinuousChannel2PhaseShift.Location = new System.Drawing.Point(3, 71);
            this.ContinuousChannel2PhaseShift.Maximum = 1000;
            this.ContinuousChannel2PhaseShift.Minimum = 0;
            this.ContinuousChannel2PhaseShift.Name = "ContinuousChannel2PhaseShift";
            this.ContinuousChannel2PhaseShift.Size = new System.Drawing.Size(275, 26);
            this.ContinuousChannel2PhaseShift.TabIndex = 8;
            this.ContinuousChannel2PhaseShift.Value = 0;
            this.ContinuousChannel2PhaseShift.OnValueChanged += new SliderNumericCombo.ValueChanged(this.ContinuousChannelPhaseShift_OnValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.ContinuousChannel2Panel.SetColumnSpan(this.label16, 2);
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(3, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(275, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ch 2 Phase Shift (%)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.ContinuousChannel2Panel.SetColumnSpan(this.label20, 2);
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Location = new System.Drawing.Point(3, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(275, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Ch 2 Waveform:";
            // 
            // ContinuousChannel2DutyCycle
            // 
            this.ContinuousChannel2DutyCycle.AutoSize = true;
            this.ContinuousChannel2DutyCycle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel2DutyCycle.Channel = 2;
            this.ContinuousChannel2Panel.SetColumnSpan(this.ContinuousChannel2DutyCycle, 2);
            this.ContinuousChannel2DutyCycle.DecimalPlaces = 1;
            this.ContinuousChannel2DutyCycle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel2DutyCycle.FontSize = 8.25F;
            this.ContinuousChannel2DutyCycle.Location = new System.Drawing.Point(3, 16);
            this.ContinuousChannel2DutyCycle.Maximum = 1000;
            this.ContinuousChannel2DutyCycle.Minimum = 0;
            this.ContinuousChannel2DutyCycle.Name = "ContinuousChannel2DutyCycle";
            this.ContinuousChannel2DutyCycle.Size = new System.Drawing.Size(275, 26);
            this.ContinuousChannel2DutyCycle.TabIndex = 7;
            this.ContinuousChannel2DutyCycle.Value = 0;
            this.ContinuousChannel2DutyCycle.OnValueChanged += new SliderNumericCombo.ValueChanged(this.ContinuousChannelDutyCycle_OnValueChanged);
            // 
            // ContinuousChannel3Panel
            // 
            this.ContinuousChannel3Panel.AutoSize = true;
            this.ContinuousChannel3Panel.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.ContinuousChannel3Panel, 5);
            this.ContinuousChannel3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ContinuousChannel3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContinuousChannel3Panel.Controls.Add(this.label27, 0, 0);
            this.ContinuousChannel3Panel.Controls.Add(this.ContinuousChannel3PhaseShift, 0, 4);
            this.ContinuousChannel3Panel.Controls.Add(this.ContinuousChannel3WaveformActiveHigh, 0, 7);
            this.ContinuousChannel3Panel.Controls.Add(this.label25, 0, 3);
            this.ContinuousChannel3Panel.Controls.Add(this.ContinuousChannel3DutyCycle, 0, 1);
            this.ContinuousChannel3Panel.Controls.Add(this.label26, 0, 6);
            this.ContinuousChannel3Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel3Panel.Location = new System.Drawing.Point(3, 524);
            this.ContinuousChannel3Panel.Name = "ContinuousChannel3Panel";
            this.ContinuousChannel3Panel.RowCount = 9;
            this.ContinuousChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel3Panel.Size = new System.Drawing.Size(281, 164);
            this.ContinuousChannel3Panel.TabIndex = 12;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.ContinuousChannel3Panel.SetColumnSpan(this.label27, 2);
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Location = new System.Drawing.Point(3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(275, 13);
            this.label27.TabIndex = 13;
            this.label27.Text = "Ch 3 Duty Cycle (%)";
            // 
            // ContinuousChannel3PhaseShift
            // 
            this.ContinuousChannel3PhaseShift.AutoSize = true;
            this.ContinuousChannel3PhaseShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel3PhaseShift.Channel = 3;
            this.ContinuousChannel3Panel.SetColumnSpan(this.ContinuousChannel3PhaseShift, 2);
            this.ContinuousChannel3PhaseShift.DecimalPlaces = 1;
            this.ContinuousChannel3PhaseShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel3PhaseShift.FontSize = 8.25F;
            this.ContinuousChannel3PhaseShift.Location = new System.Drawing.Point(3, 71);
            this.ContinuousChannel3PhaseShift.Maximum = 1000;
            this.ContinuousChannel3PhaseShift.Minimum = 0;
            this.ContinuousChannel3PhaseShift.Name = "ContinuousChannel3PhaseShift";
            this.ContinuousChannel3PhaseShift.Size = new System.Drawing.Size(275, 26);
            this.ContinuousChannel3PhaseShift.TabIndex = 8;
            this.ContinuousChannel3PhaseShift.Value = 0;
            this.ContinuousChannel3PhaseShift.OnValueChanged += new SliderNumericCombo.ValueChanged(this.ContinuousChannelPhaseShift_OnValueChanged);
            // 
            // ContinuousChannel3WaveformActiveHigh
            // 
            this.ContinuousChannel3WaveformActiveHigh.AutoSize = true;
            this.ContinuousChannel3WaveformActiveHigh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel3WaveformActiveHigh.BackColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel3WaveformActiveHigh.Channel = 3;
            this.ContinuousChannel3WaveformActiveHigh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel3WaveformActiveHigh.Location = new System.Drawing.Point(3, 126);
            this.ContinuousChannel3WaveformActiveHigh.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousChannel3WaveformActiveHigh.Name = "ContinuousChannel3WaveformActiveHigh";
            this.ContinuousChannel3WaveformActiveHigh.Size = new System.Drawing.Size(72, 25);
            this.ContinuousChannel3WaveformActiveHigh.TabIndex = 13;
            this.ContinuousChannel3WaveformActiveHigh.Text = "Active High";
            this.ContinuousChannel3WaveformActiveHigh.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel3WaveformActiveHigh.ToggleDisabledText = "Active Low";
            this.ContinuousChannel3WaveformActiveHigh.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel3WaveformActiveHigh.ToggleEnabledText = "Active High";
            this.ContinuousChannel3WaveformActiveHigh.UseVisualStyleBackColor = true;
            this.ContinuousChannel3WaveformActiveHigh.Click += new System.EventHandler(this.ContinuousChannelWaveformActiveHigh_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.ContinuousChannel3Panel.SetColumnSpan(this.label25, 2);
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Location = new System.Drawing.Point(3, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(275, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "Ch 3 Phase Shift (%)";
            // 
            // ContinuousChannel3DutyCycle
            // 
            this.ContinuousChannel3DutyCycle.AutoSize = true;
            this.ContinuousChannel3DutyCycle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel3DutyCycle.Channel = 3;
            this.ContinuousChannel3Panel.SetColumnSpan(this.ContinuousChannel3DutyCycle, 2);
            this.ContinuousChannel3DutyCycle.DecimalPlaces = 1;
            this.ContinuousChannel3DutyCycle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel3DutyCycle.FontSize = 8.25F;
            this.ContinuousChannel3DutyCycle.Location = new System.Drawing.Point(3, 16);
            this.ContinuousChannel3DutyCycle.Maximum = 1000;
            this.ContinuousChannel3DutyCycle.Minimum = 0;
            this.ContinuousChannel3DutyCycle.Name = "ContinuousChannel3DutyCycle";
            this.ContinuousChannel3DutyCycle.Size = new System.Drawing.Size(275, 26);
            this.ContinuousChannel3DutyCycle.TabIndex = 7;
            this.ContinuousChannel3DutyCycle.Value = 0;
            this.ContinuousChannel3DutyCycle.OnValueChanged += new SliderNumericCombo.ValueChanged(this.ContinuousChannelDutyCycle_OnValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.ContinuousChannel3Panel.SetColumnSpan(this.label26, 2);
            this.label26.Dock = System.Windows.Forms.DockStyle.Top;
            this.label26.Location = new System.Drawing.Point(3, 110);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(275, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Ch 3 Waveform:";
            // 
            // ContinuousChannel4Panel
            // 
            this.ContinuousChannel4Panel.AutoSize = true;
            this.ContinuousChannel4Panel.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.ContinuousChannel4Panel, 5);
            this.ContinuousChannel4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ContinuousChannel4Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContinuousChannel4Panel.Controls.Add(this.ContinuousChannel4PhaseShift, 0, 4);
            this.ContinuousChannel4Panel.Controls.Add(this.label30, 0, 0);
            this.ContinuousChannel4Panel.Controls.Add(this.ContinuousChannel4DutyCycle, 0, 1);
            this.ContinuousChannel4Panel.Controls.Add(this.ContinuousChannel4WaveformActiveHigh, 0, 7);
            this.ContinuousChannel4Panel.Controls.Add(this.label28, 0, 3);
            this.ContinuousChannel4Panel.Controls.Add(this.label29, 0, 6);
            this.ContinuousChannel4Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel4Panel.Location = new System.Drawing.Point(3, 694);
            this.ContinuousChannel4Panel.Name = "ContinuousChannel4Panel";
            this.ContinuousChannel4Panel.RowCount = 9;
            this.ContinuousChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ContinuousChannel4Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ContinuousChannel4Panel.Size = new System.Drawing.Size(281, 164);
            this.ContinuousChannel4Panel.TabIndex = 12;
            // 
            // ContinuousChannel4PhaseShift
            // 
            this.ContinuousChannel4PhaseShift.AutoSize = true;
            this.ContinuousChannel4PhaseShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel4PhaseShift.Channel = 4;
            this.ContinuousChannel4Panel.SetColumnSpan(this.ContinuousChannel4PhaseShift, 2);
            this.ContinuousChannel4PhaseShift.DecimalPlaces = 1;
            this.ContinuousChannel4PhaseShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel4PhaseShift.FontSize = 8.25F;
            this.ContinuousChannel4PhaseShift.Location = new System.Drawing.Point(3, 71);
            this.ContinuousChannel4PhaseShift.Maximum = 1000;
            this.ContinuousChannel4PhaseShift.Minimum = 0;
            this.ContinuousChannel4PhaseShift.Name = "ContinuousChannel4PhaseShift";
            this.ContinuousChannel4PhaseShift.Size = new System.Drawing.Size(275, 26);
            this.ContinuousChannel4PhaseShift.TabIndex = 8;
            this.ContinuousChannel4PhaseShift.Value = 0;
            this.ContinuousChannel4PhaseShift.OnValueChanged += new SliderNumericCombo.ValueChanged(this.ContinuousChannelPhaseShift_OnValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.ContinuousChannel4Panel.SetColumnSpan(this.label30, 2);
            this.label30.Dock = System.Windows.Forms.DockStyle.Top;
            this.label30.Location = new System.Drawing.Point(3, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(275, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "Ch 4 Duty Cycle (%)";
            // 
            // ContinuousChannel4DutyCycle
            // 
            this.ContinuousChannel4DutyCycle.AutoSize = true;
            this.ContinuousChannel4DutyCycle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel4DutyCycle.Channel = 4;
            this.ContinuousChannel4Panel.SetColumnSpan(this.ContinuousChannel4DutyCycle, 2);
            this.ContinuousChannel4DutyCycle.DecimalPlaces = 1;
            this.ContinuousChannel4DutyCycle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel4DutyCycle.FontSize = 8.25F;
            this.ContinuousChannel4DutyCycle.Location = new System.Drawing.Point(3, 16);
            this.ContinuousChannel4DutyCycle.Maximum = 1000;
            this.ContinuousChannel4DutyCycle.Minimum = 0;
            this.ContinuousChannel4DutyCycle.Name = "ContinuousChannel4DutyCycle";
            this.ContinuousChannel4DutyCycle.Size = new System.Drawing.Size(275, 26);
            this.ContinuousChannel4DutyCycle.TabIndex = 7;
            this.ContinuousChannel4DutyCycle.Value = 0;
            this.ContinuousChannel4DutyCycle.OnValueChanged += new SliderNumericCombo.ValueChanged(this.ContinuousChannelDutyCycle_OnValueChanged);
            // 
            // ContinuousChannel4WaveformActiveHigh
            // 
            this.ContinuousChannel4WaveformActiveHigh.AutoSize = true;
            this.ContinuousChannel4WaveformActiveHigh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinuousChannel4WaveformActiveHigh.BackColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel4WaveformActiveHigh.Channel = 4;
            this.ContinuousChannel4WaveformActiveHigh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContinuousChannel4WaveformActiveHigh.Location = new System.Drawing.Point(3, 126);
            this.ContinuousChannel4WaveformActiveHigh.MinimumSize = new System.Drawing.Size(0, 25);
            this.ContinuousChannel4WaveformActiveHigh.Name = "ContinuousChannel4WaveformActiveHigh";
            this.ContinuousChannel4WaveformActiveHigh.Size = new System.Drawing.Size(72, 25);
            this.ContinuousChannel4WaveformActiveHigh.TabIndex = 13;
            this.ContinuousChannel4WaveformActiveHigh.Text = "Active High";
            this.ContinuousChannel4WaveformActiveHigh.ToggleDisabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel4WaveformActiveHigh.ToggleDisabledText = "Active Low";
            this.ContinuousChannel4WaveformActiveHigh.ToggleEnabledColor = System.Drawing.SystemColors.Control;
            this.ContinuousChannel4WaveformActiveHigh.ToggleEnabledText = "Active High";
            this.ContinuousChannel4WaveformActiveHigh.UseVisualStyleBackColor = true;
            this.ContinuousChannel4WaveformActiveHigh.Click += new System.EventHandler(this.ContinuousChannelWaveformActiveHigh_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.ContinuousChannel4Panel.SetColumnSpan(this.label28, 2);
            this.label28.Dock = System.Windows.Forms.DockStyle.Top;
            this.label28.Location = new System.Drawing.Point(3, 55);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(275, 13);
            this.label28.TabIndex = 15;
            this.label28.Text = "Ch 4 Phase Shift (%)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.ContinuousChannel4Panel.SetColumnSpan(this.label29, 2);
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Location = new System.Drawing.Point(3, 110);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(275, 13);
            this.label29.TabIndex = 15;
            this.label29.Text = "Ch 4 Waveform:";
            // 
            // EqualizerSettings
            // 
            this.EqualizerSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EqualizerSettings.Controls.Add(this.tableLayoutPanel10);
            this.EqualizerSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.EqualizerSettings.Location = new System.Drawing.Point(4, 2697);
            this.EqualizerSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.EqualizerSettings.Name = "EqualizerSettings";
            this.EqualizerSettings.Padding = new System.Windows.Forms.Padding(7);
            this.EqualizerSettings.Size = new System.Drawing.Size(301, 428);
            this.EqualizerSettings.TabIndex = 8;
            this.EqualizerSettings.TabStop = false;
            this.EqualizerSettings.Text = "Equalizer";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.AutoSize = true;
            this.tableLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.label54, 0, 11);
            this.tableLayoutPanel10.Controls.Add(this.EqualizerTargetLight, 0, 8);
            this.tableLayoutPanel10.Controls.Add(this.label47, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.EqualizerDelay, 0, 5);
            this.tableLayoutPanel10.Controls.Add(this.label49, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label53, 0, 10);
            this.tableLayoutPanel10.Controls.Add(this.EqualizerEnable, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label48, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.label52, 0, 7);
            this.tableLayoutPanel10.Controls.Add(this.EqualizerPowerOutput, 2, 11);
            this.tableLayoutPanel10.Controls.Add(this.EqualizerLightOutput, 2, 10);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 13;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(287, 393);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.tableLayoutPanel10.SetColumnSpan(this.label54, 2);
            this.label54.Dock = System.Windows.Forms.DockStyle.Top;
            this.label54.Location = new System.Drawing.Point(3, 361);
            this.label54.Margin = new System.Windows.Forms.Padding(3);
            this.label54.Name = "label54";
            this.label54.Padding = new System.Windows.Forms.Padding(3);
            this.label54.Size = new System.Drawing.Size(111, 19);
            this.label54.TabIndex = 22;
            this.label54.Text = "Equalizer Output:";
            // 
            // EqualizerTargetLight
            // 
            this.EqualizerTargetLight.AutoSize = true;
            this.EqualizerTargetLight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EqualizerTargetLight.Channel = 0;
            this.tableLayoutPanel10.SetColumnSpan(this.EqualizerTargetLight, 3);
            this.EqualizerTargetLight.DecimalPlaces = 0;
            this.EqualizerTargetLight.Dock = System.Windows.Forms.DockStyle.Top;
            this.EqualizerTargetLight.FontSize = 8.25F;
            this.EqualizerTargetLight.Location = new System.Drawing.Point(3, 294);
            this.EqualizerTargetLight.Maximum = 4095;
            this.EqualizerTargetLight.Minimum = 0;
            this.EqualizerTargetLight.Name = "EqualizerTargetLight";
            this.EqualizerTargetLight.Size = new System.Drawing.Size(281, 26);
            this.EqualizerTargetLight.TabIndex = 6;
            this.EqualizerTargetLight.Value = 0;
            this.EqualizerTargetLight.OnValueChanged += new SliderNumericCombo.ValueChanged(this.EqualizerTargetLight_OnValueChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.tableLayoutPanel10.SetColumnSpan(this.label47, 3);
            this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label47.Location = new System.Drawing.Point(3, 44);
            this.label47.Margin = new System.Windows.Forms.Padding(3);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(281, 156);
            this.label47.TabIndex = 5;
            this.label47.Text = resources.GetString("label47.Text");
            // 
            // EqualizerDelay
            // 
            this.EqualizerDelay.AutoSize = true;
            this.EqualizerDelay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EqualizerDelay.Channel = 0;
            this.tableLayoutPanel10.SetColumnSpan(this.EqualizerDelay, 3);
            this.EqualizerDelay.DecimalPlaces = 0;
            this.EqualizerDelay.Dock = System.Windows.Forms.DockStyle.Top;
            this.EqualizerDelay.FontSize = 8.25F;
            this.EqualizerDelay.Location = new System.Drawing.Point(3, 239);
            this.EqualizerDelay.Maximum = 300;
            this.EqualizerDelay.Minimum = 0;
            this.EqualizerDelay.Name = "EqualizerDelay";
            this.EqualizerDelay.Size = new System.Drawing.Size(281, 26);
            this.EqualizerDelay.TabIndex = 6;
            this.EqualizerDelay.Value = 0;
            this.EqualizerDelay.OnValueChanged += new SliderNumericCombo.ValueChanged(this.EqualizerDelay_OnValueChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.tableLayoutPanel10.SetColumnSpan(this.label49, 2);
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Location = new System.Drawing.Point(89, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(195, 31);
            this.label49.TabIndex = 3;
            this.label49.Text = "Equalizer";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.tableLayoutPanel10.SetColumnSpan(this.label53, 2);
            this.label53.Dock = System.Windows.Forms.DockStyle.Top;
            this.label53.Location = new System.Drawing.Point(3, 336);
            this.label53.Margin = new System.Windows.Forms.Padding(3);
            this.label53.Name = "label53";
            this.label53.Padding = new System.Windows.Forms.Padding(3);
            this.label53.Size = new System.Drawing.Size(111, 19);
            this.label53.TabIndex = 21;
            this.label53.Text = "Current Light Output:";
            // 
            // EqualizerEnable
            // 
            this.EqualizerEnable.AutoSize = true;
            this.EqualizerEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EqualizerEnable.BackColor = System.Drawing.Color.Red;
            this.EqualizerEnable.Channel = 0;
            this.EqualizerEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.EqualizerEnable.Location = new System.Drawing.Point(3, 3);
            this.EqualizerEnable.MinimumSize = new System.Drawing.Size(80, 25);
            this.EqualizerEnable.Name = "EqualizerEnable";
            this.EqualizerEnable.Size = new System.Drawing.Size(80, 25);
            this.EqualizerEnable.TabIndex = 2;
            this.EqualizerEnable.Text = "Disable";
            this.EqualizerEnable.ToggleDisabledColor = System.Drawing.Color.Red;
            this.EqualizerEnable.ToggleDisabledText = "Disable";
            this.EqualizerEnable.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.EqualizerEnable.ToggleEnabledText = "Enable";
            this.EqualizerEnable.UseVisualStyleBackColor = false;
            this.EqualizerEnable.Click += new System.EventHandler(this.EqualizerEnable_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.tableLayoutPanel10.SetColumnSpan(this.label48, 3);
            this.label48.Dock = System.Windows.Forms.DockStyle.Top;
            this.label48.Location = new System.Drawing.Point(3, 223);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(281, 13);
            this.label48.TabIndex = 18;
            this.label48.Text = "Start-up Delay (seconds)";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.tableLayoutPanel10.SetColumnSpan(this.label52, 3);
            this.label52.Dock = System.Windows.Forms.DockStyle.Top;
            this.label52.Location = new System.Drawing.Point(3, 278);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(281, 13);
            this.label52.TabIndex = 20;
            this.label52.Text = "Target Light Output";
            // 
            // EqualizerPowerOutput
            // 
            this.EqualizerPowerOutput.AutoSize = true;
            this.EqualizerPowerOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.EqualizerPowerOutput.Location = new System.Drawing.Point(120, 361);
            this.EqualizerPowerOutput.Margin = new System.Windows.Forms.Padding(3);
            this.EqualizerPowerOutput.Name = "EqualizerPowerOutput";
            this.EqualizerPowerOutput.Padding = new System.Windows.Forms.Padding(3);
            this.EqualizerPowerOutput.Size = new System.Drawing.Size(164, 19);
            this.EqualizerPowerOutput.TabIndex = 23;
            this.EqualizerPowerOutput.Text = "0";
            // 
            // EqualizerLightOutput
            // 
            this.EqualizerLightOutput.AutoSize = true;
            this.EqualizerLightOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.EqualizerLightOutput.Location = new System.Drawing.Point(120, 336);
            this.EqualizerLightOutput.Margin = new System.Windows.Forms.Padding(3);
            this.EqualizerLightOutput.Name = "EqualizerLightOutput";
            this.EqualizerLightOutput.Padding = new System.Windows.Forms.Padding(3);
            this.EqualizerLightOutput.Size = new System.Drawing.Size(164, 19);
            this.EqualizerLightOutput.TabIndex = 21;
            this.EqualizerLightOutput.Text = "0";
            // 
            // PersistentMemory
            // 
            this.PersistentMemory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PersistentMemory.Controls.Add(this.tableLayoutPanel1);
            this.PersistentMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersistentMemory.Location = new System.Drawing.Point(4, 4);
            this.PersistentMemory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PersistentMemory.Name = "PersistentMemory";
            this.PersistentMemory.Padding = new System.Windows.Forms.Padding(7);
            this.PersistentMemory.Size = new System.Drawing.Size(301, 109);
            this.PersistentMemory.TabIndex = 3;
            this.PersistentMemory.TabStop = false;
            this.PersistentMemory.Text = "Persistent Memory";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.configurationsWindow, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 74);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(281, 39);
            this.label14.TabIndex = 5;
            this.label14.Text = "Settings on this page are not persistent and will be cleared after power cycling " +
    "the unit. Go to the Configurations page by clicking the button below to save you" +
    "r changes.";
            // 
            // configurationsWindow
            // 
            this.configurationsWindow.AutoSize = true;
            this.configurationsWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.configurationsWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.configurationsWindow.Location = new System.Drawing.Point(3, 48);
            this.configurationsWindow.Name = "configurationsWindow";
            this.configurationsWindow.Size = new System.Drawing.Size(281, 23);
            this.configurationsWindow.TabIndex = 6;
            this.configurationsWindow.Text = "Configurations Window";
            this.configurationsWindow.UseVisualStyleBackColor = true;
            this.configurationsWindow.Click += new System.EventHandler(this.configurationsWindow_Click);
            // 
            // ControlsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(334, 569);
            this.Controls.Add(this.formLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "ControlsForm";
            this.Text = "Controls";
            this.Load += new System.EventHandler(this.formControls_Load);
            this.VisibleChanged += new System.EventHandler(this.formControls_VisibleChanged);
            this.formLayoutPanel.ResumeLayout(false);
            this.UserLevel.ResumeLayout(false);
            this.UserLevel.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.CurrentSettings.ResumeLayout(false);
            this.CurrentSettings.PerformLayout();
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.mainLayoutTable.ResumeLayout(false);
            this.FanSettings.ResumeLayout(false);
            this.FanSettings.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.TriggeredChannelSettings.ResumeLayout(false);
            this.TriggeredChannelSettings.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.TriggeredChannel1Panel.ResumeLayout(false);
            this.TriggeredChannel1Panel.PerformLayout();
            this.TriggeredChannel2Panel.ResumeLayout(false);
            this.TriggeredChannel2Panel.PerformLayout();
            this.TriggeredChannel3Panel.ResumeLayout(false);
            this.TriggeredChannel3Panel.PerformLayout();
            this.TriggeredChannel4Panel.ResumeLayout(false);
            this.TriggeredChannel4Panel.PerformLayout();
            this.LEDChannelSettings.ResumeLayout(false);
            this.LEDChannelSettings.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.LEDChannel4Panel.ResumeLayout(false);
            this.LEDChannel4Panel.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.LEDChannel1Panel.ResumeLayout(false);
            this.LEDChannel1Panel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.LEDChannel3Panel.ResumeLayout(false);
            this.LEDChannel3Panel.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.LEDChannel2Panel.ResumeLayout(false);
            this.LEDChannel2Panel.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ContinuousChannelSettings.ResumeLayout(false);
            this.ContinuousChannelSettings.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ContinuousChannel1Panel.ResumeLayout(false);
            this.ContinuousChannel1Panel.PerformLayout();
            this.ContinuousChannel2Panel.ResumeLayout(false);
            this.ContinuousChannel2Panel.PerformLayout();
            this.ContinuousChannel3Panel.ResumeLayout(false);
            this.ContinuousChannel3Panel.PerformLayout();
            this.ContinuousChannel4Panel.ResumeLayout(false);
            this.ContinuousChannel4Panel.PerformLayout();
            this.EqualizerSettings.ResumeLayout(false);
            this.EqualizerSettings.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.PersistentMemory.ResumeLayout(false);
            this.PersistentMemory.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel mainLayoutTable;
        private GrowGroupbox LEDChannelSettings;
        private ToggleButton LEDChannel4ShutdownButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private ToggleButton LEDChannel4PowerButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button LEDShowChannelAll;
        private System.Windows.Forms.Button LEDShowChannel4;
        private System.Windows.Forms.Button LEDShowChannel3;
        private System.Windows.Forms.Button LEDShowChannel2;
        private System.Windows.Forms.Button LEDShowChannel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ToggleButton LEDSingleChannelOperation;
        private System.Windows.Forms.Label label2;
        private ToggleButton LEDCombinedTrigger;
        private System.Windows.Forms.Label label1;
        private ToggleButton LEDDemoMode;
        private ToggleButton LEDChannel1ShutdownButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ToggleButton LEDChannel1PowerButton;
        private System.Windows.Forms.Label label6;
        private ToggleButton LEDChannel3ShutdownButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private ToggleButton LEDChannel3PowerButton;
        private System.Windows.Forms.Label label11;
        private ToggleButton LEDChannel2ShutdownButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private ToggleButton LEDChannel2PowerButton;
        private System.Windows.Forms.Label label9;
        private ScrollingPanel scrollPanel;
        private GrowGroupbox ContinuousChannelSettings;
        private System.Windows.Forms.Button ContinuousShowChannelAll;
        private System.Windows.Forms.Button ContinuousShowChannel4;
        private System.Windows.Forms.Button ContinuousShowChannel3;
        private System.Windows.Forms.Button ContinuousShowChannel2;
        private System.Windows.Forms.Button ContinuousShowChannel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private ToggleButton ContinuousSingleChannelEnable;
        private System.Windows.Forms.Label label21;
        private ToggleButton ContinuousStrobeEnable;
        private ToggleButton ContinuousChannel1WaveformActiveHigh;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label15;
        private ToggleButton ContinuousChannel4WaveformActiveHigh;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private ToggleButton ContinuousChannel3WaveformActiveHigh;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private ToggleButton ContinuousChannel2WaveformActiveHigh;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private GrowGroupbox TriggeredChannelSettings;
        private ToggleButton TriggeredChannel4FallingEdgeEnable;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private ToggleButton TriggeredChannel3FallingEdgeEnable;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button TriggeredShowChannelAll;
        private System.Windows.Forms.Button TriggeredShowChannel4;
        private System.Windows.Forms.Button TriggeredShowChannel3;
        private System.Windows.Forms.Button TriggeredShowChannel2;
        private System.Windows.Forms.Button TriggeredShowChannel1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private ToggleButton TriggeredSingleChannelEnable;
        private System.Windows.Forms.Label label40;
        private ToggleButton TriggeredStrobeEnable;
        private ToggleButton TriggeredChannel1FallingEdgeEnable;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private ToggleButton TriggeredChannel2FallingEdgeEnable;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private GrowGroupbox FanSettings;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private ToggleButton FanManualControlEnable;
        private GrowGroupbox EqualizerSettings;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label EqualizerPowerOutput;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label EqualizerLightOutput;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private ToggleButton EqualizerEnable;
        private System.Windows.Forms.Label label55;
        private ToggleButton LEDOutputPowerButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel LEDChannel4Panel;
        private System.Windows.Forms.TableLayoutPanel LEDChannel1Panel;
        private System.Windows.Forms.TableLayoutPanel LEDChannel3Panel;
        private System.Windows.Forms.TableLayoutPanel LEDChannel2Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel ContinuousChannel1Panel;
        private System.Windows.Forms.TableLayoutPanel ContinuousChannel2Panel;
        private System.Windows.Forms.TableLayoutPanel ContinuousChannel3Panel;
        private System.Windows.Forms.TableLayoutPanel ContinuousChannel4Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel TriggeredChannel1Panel;
        private System.Windows.Forms.TableLayoutPanel TriggeredChannel2Panel;
        private System.Windows.Forms.TableLayoutPanel TriggeredChannel3Panel;
        private System.Windows.Forms.TableLayoutPanel TriggeredChannel4Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private GrowGroupbox PersistentMemory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private GrowGroupbox UserLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox knobMode;
        private System.Windows.Forms.Label label58;
        private ToggleButton TriggeredStrobeGangedEnable;
        private GrowGroupbox Connection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Button configurationsWindow;
        private GrowGroupbox CurrentSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button getSettings;
        private System.Windows.Forms.TableLayoutPanel formLayoutPanel;
        private SliderNumericCombo LEDOutput;
        private SliderNumericCombo LEDChannel1Output;
        private SliderNumericCombo LEDChannel2Output;
        private SliderNumericCombo LEDChannel3Output;
        private SliderNumericCombo LEDChannel4Output;
        private SliderNumericCombo ContinuousFrequency;
        private SliderNumericCombo ContinuousChannel1DutyCycle;
        private SliderNumericCombo ContinuousChannel1PhaseShift;
        private SliderNumericCombo ContinuousChannel2DutyCycle;
        private SliderNumericCombo ContinuousChannel2PhaseShift;
        private SliderNumericCombo ContinuousChannel3DutyCycle;
        private SliderNumericCombo ContinuousChannel3PhaseShift;
        private SliderNumericCombo ContinuousChannel4DutyCycle;
        private SliderNumericCombo ContinuousChannel4PhaseShift;
        private SliderNumericCombo TriggeredChannel1Delay;
        private SliderNumericCombo TriggeredChannel1OnTime;
        private SliderNumericCombo TriggeredChannel2Delay;
        private SliderNumericCombo TriggeredChannel2OnTime;
        private SliderNumericCombo TriggeredChannel3Delay;
        private SliderNumericCombo TriggeredChannel3OnTime;
        private SliderNumericCombo TriggeredChannel4Delay;
        private SliderNumericCombo TriggeredChannel4OnTime;
        private SliderNumericCombo EqualizerDelay;
        private SliderNumericCombo EqualizerTargetLight;
        private SliderNumericCombo FanSpeed;
        private SliderNumericCombo FanTargetTemp;
    }
}
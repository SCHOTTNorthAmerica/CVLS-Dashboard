using SCHOTT.WinForms.Controls.Buttons;
using SCHOTT.WinForms.Controls.Combo_Controls;
using SCHOTT.WinForms.Controls.Group_Boxes;
using SCHOTT.WinForms.Controls.Panels;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    partial class Settings
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
            this.formLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.UserLevel = new GrowGroupbox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.label56 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.scrollPanel = new ScrollingPanel();
            this.mainLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.General = new GrowGroupbox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginTimeoutSlider = new SliderNumericCombo();
            this.enableLoginTimeout = new ToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.requireUser = new ToggleButton();
            this.requireAdmin = new ToggleButton();
            this.enableSavePrompt = new ToggleButton();
            this.enableFrontControls = new ToggleButton();
            this.enableMultiport = new ToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NetworkBox = new GrowGroupbox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.hostName = new System.Windows.Forms.TextBox();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.subnetMask = new System.Windows.Forms.TextBox();
            this.gateway = new System.Windows.Forms.TextBox();
            this.primaryDNS = new System.Windows.Forms.TextBox();
            this.secondaryDNS = new System.Windows.Forms.TextBox();
            this.enableDHCP = new ToggleButton();
            this.buttonIPAddress = new System.Windows.Forms.Button();
            this.buttonSubnetMask = new System.Windows.Forms.Button();
            this.buttonGateway = new System.Windows.Forms.Button();
            this.buttonPrimaryDNS = new System.Windows.Forms.Button();
            this.buttonSecondaryDNS = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Sockets = new GrowGroupbox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.growGroupbox2 = new GrowGroupbox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.enableBinarySocket = new ToggleButton();
            this.label20 = new System.Windows.Forms.Label();
            this.binaryPort = new System.Windows.Forms.NumericUpDown();
            this.growGroupbox1 = new GrowGroupbox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.enableLegacySocket = new ToggleButton();
            this.label17 = new System.Windows.Forms.Label();
            this.legacyPort = new System.Windows.Forms.NumericUpDown();
            this.UART = new GrowGroupbox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.parity = new System.Windows.Forms.ComboBox();
            this.stopBits = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Connection = new GrowGroupbox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.label59 = new System.Windows.Forms.Label();
            this.CurrentSettings = new GrowGroupbox();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.label60 = new System.Windows.Forms.Label();
            this.getSettings = new System.Windows.Forms.Button();
            this.writeSettings = new System.Windows.Forms.Button();
            this.formLayoutPanel.SuspendLayout();
            this.UserLevel.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.mainLayoutTable.SuspendLayout();
            this.General.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.NetworkBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Sockets.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.growGroupbox2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPort)).BeginInit();
            this.growGroupbox1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legacyPort)).BeginInit();
            this.UART.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.Connection.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.CurrentSettings.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.SuspendLayout();
            // 
            // formLayoutPanel
            // 
            this.formLayoutPanel.ColumnCount = 1;
            this.formLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formLayoutPanel.Controls.Add(this.UserLevel, 0, 0);
            this.formLayoutPanel.Controls.Add(this.scrollPanel, 0, 3);
            this.formLayoutPanel.Controls.Add(this.Connection, 0, 1);
            this.formLayoutPanel.Controls.Add(this.CurrentSettings, 0, 2);
            this.formLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.formLayoutPanel.Name = "formLayoutPanel";
            this.formLayoutPanel.RowCount = 4;
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.formLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formLayoutPanel.Size = new System.Drawing.Size(364, 573);
            this.formLayoutPanel.TabIndex = 1;
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
            this.UserLevel.Size = new System.Drawing.Size(358, 98);
            this.UserLevel.TabIndex = 4;
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
            this.tableLayoutPanel21.Size = new System.Drawing.Size(344, 63);
            this.tableLayoutPanel21.TabIndex = 2;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(3, 3);
            this.label56.Margin = new System.Windows.Forms.Padding(3);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(338, 26);
            this.label56.TabIndex = 5;
            this.label56.Text = "You must be logged with a minimum of \"Admin\" rights to view the controls on this " +
    "page. Click the login button below to use this page.";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login.Dock = System.Windows.Forms.DockStyle.Top;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(3, 35);
            this.login.MinimumSize = new System.Drawing.Size(0, 25);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(338, 25);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.AutoScrollMinSize = new System.Drawing.Size(0, 1258);
            this.scrollPanel.Controls.Add(this.mainLayoutTable);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(2, 317);
            this.scrollPanel.Margin = new System.Windows.Forms.Padding(2);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(2);
            this.scrollPanel.Size = new System.Drawing.Size(360, 254);
            this.scrollPanel.TabIndex = 0;
            // 
            // mainLayoutTable
            // 
            this.mainLayoutTable.AutoSize = true;
            this.mainLayoutTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLayoutTable.ColumnCount = 1;
            this.mainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutTable.Controls.Add(this.General, 0, 2);
            this.mainLayoutTable.Controls.Add(this.NetworkBox, 0, 3);
            this.mainLayoutTable.Controls.Add(this.Sockets, 0, 4);
            this.mainLayoutTable.Controls.Add(this.UART, 0, 5);
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
            this.mainLayoutTable.Size = new System.Drawing.Size(339, 1258);
            this.mainLayoutTable.TabIndex = 0;
            // 
            // General
            // 
            this.General.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.General.Controls.Add(this.tableLayoutPanel3);
            this.General.Dock = System.Windows.Forms.DockStyle.Top;
            this.General.Location = new System.Drawing.Point(4, 4);
            this.General.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(7);
            this.General.Size = new System.Drawing.Size(331, 320);
            this.General.TabIndex = 6;
            this.General.TabStop = false;
            this.General.Text = "General";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 11);
            this.tableLayoutPanel3.Controls.Add(this.requireUser, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.requireAdmin, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.enableSavePrompt, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.enableFrontControls, 0, 12);
            this.tableLayoutPanel3.Controls.Add(this.enableMultiport, 0, 13);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 12);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 13);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 14;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(317, 285);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.LoginTimeoutSlider, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.enableLoginTimeout, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(311, 32);
            this.tableLayoutPanel7.TabIndex = 11;
            // 
            // LoginTimeoutSlider
            // 
            this.LoginTimeoutSlider.AutoSize = true;
            this.LoginTimeoutSlider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginTimeoutSlider.Channel = 0;
            this.LoginTimeoutSlider.DecimalPlaces = 0;
            this.LoginTimeoutSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginTimeoutSlider.FontSize = 8.25F;
            this.LoginTimeoutSlider.Location = new System.Drawing.Point(63, 3);
            this.LoginTimeoutSlider.Maximum = 30;
            this.LoginTimeoutSlider.Minimum = 1;
            this.LoginTimeoutSlider.Name = "LoginTimeoutSlider";
            this.LoginTimeoutSlider.Size = new System.Drawing.Size(245, 26);
            this.LoginTimeoutSlider.TabIndex = 1;
            this.LoginTimeoutSlider.Value = 30;
            // 
            // enableLoginTimeout
            // 
            this.enableLoginTimeout.AutoSize = true;
            this.enableLoginTimeout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enableLoginTimeout.BackColor = System.Drawing.Color.Red;
            this.enableLoginTimeout.Channel = 0;
            this.enableLoginTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enableLoginTimeout.Location = new System.Drawing.Point(0, 0);
            this.enableLoginTimeout.Margin = new System.Windows.Forms.Padding(0);
            this.enableLoginTimeout.MinimumSize = new System.Drawing.Size(60, 25);
            this.enableLoginTimeout.Name = "enableLoginTimeout";
            this.enableLoginTimeout.Size = new System.Drawing.Size(60, 32);
            this.enableLoginTimeout.TabIndex = 8;
            this.enableLoginTimeout.Text = "Disable";
            this.enableLoginTimeout.ToggleDisabledColor = System.Drawing.Color.Red;
            this.enableLoginTimeout.ToggleDisabledText = "Disable";
            this.enableLoginTimeout.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.enableLoginTimeout.ToggleEnabledText = "Enable";
            this.enableLoginTimeout.UseVisualStyleBackColor = false;
            this.enableLoginTimeout.Click += new System.EventHandler(this.enableToggle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login Time-Out (minutes)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Require Login For";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Allow Browser Save Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Control Lockouts";
            // 
            // requireUser
            // 
            this.requireUser.AutoSize = true;
            this.requireUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.requireUser.BackColor = System.Drawing.Color.Red;
            this.requireUser.Channel = 0;
            this.requireUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.requireUser.Location = new System.Drawing.Point(3, 87);
            this.requireUser.MinimumSize = new System.Drawing.Size(60, 25);
            this.requireUser.Name = "requireUser";
            this.requireUser.Size = new System.Drawing.Size(60, 25);
            this.requireUser.TabIndex = 16;
            this.requireUser.Text = "Disable";
            this.requireUser.ToggleDisabledColor = System.Drawing.Color.Red;
            this.requireUser.ToggleDisabledText = "Disable";
            this.requireUser.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.requireUser.ToggleEnabledText = "Enable";
            this.requireUser.UseVisualStyleBackColor = false;
            this.requireUser.Click += new System.EventHandler(this.enableToggle_Click);
            // 
            // requireAdmin
            // 
            this.requireAdmin.AutoSize = true;
            this.requireAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.requireAdmin.BackColor = System.Drawing.Color.Red;
            this.requireAdmin.Channel = 0;
            this.requireAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.requireAdmin.Location = new System.Drawing.Point(3, 118);
            this.requireAdmin.MinimumSize = new System.Drawing.Size(60, 25);
            this.requireAdmin.Name = "requireAdmin";
            this.requireAdmin.Size = new System.Drawing.Size(60, 25);
            this.requireAdmin.TabIndex = 16;
            this.requireAdmin.Text = "Disable";
            this.requireAdmin.ToggleDisabledColor = System.Drawing.Color.Red;
            this.requireAdmin.ToggleDisabledText = "Disable";
            this.requireAdmin.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.requireAdmin.ToggleEnabledText = "Enable";
            this.requireAdmin.UseVisualStyleBackColor = false;
            this.requireAdmin.Click += new System.EventHandler(this.enableAdminToggle_Click);
            // 
            // enableSavePrompt
            // 
            this.enableSavePrompt.AutoSize = true;
            this.enableSavePrompt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enableSavePrompt.BackColor = System.Drawing.Color.Red;
            this.enableSavePrompt.Channel = 0;
            this.enableSavePrompt.Dock = System.Windows.Forms.DockStyle.Top;
            this.enableSavePrompt.Location = new System.Drawing.Point(3, 172);
            this.enableSavePrompt.MinimumSize = new System.Drawing.Size(60, 25);
            this.enableSavePrompt.Name = "enableSavePrompt";
            this.enableSavePrompt.Size = new System.Drawing.Size(60, 25);
            this.enableSavePrompt.TabIndex = 16;
            this.enableSavePrompt.Text = "Disable";
            this.enableSavePrompt.ToggleDisabledColor = System.Drawing.Color.Red;
            this.enableSavePrompt.ToggleDisabledText = "Disable";
            this.enableSavePrompt.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.enableSavePrompt.ToggleEnabledText = "Enable";
            this.enableSavePrompt.UseVisualStyleBackColor = false;
            this.enableSavePrompt.Click += new System.EventHandler(this.enableToggle_Click);
            // 
            // enableFrontControls
            // 
            this.enableFrontControls.AutoSize = true;
            this.enableFrontControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enableFrontControls.BackColor = System.Drawing.Color.Red;
            this.enableFrontControls.Channel = 0;
            this.enableFrontControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.enableFrontControls.Location = new System.Drawing.Point(3, 226);
            this.enableFrontControls.MinimumSize = new System.Drawing.Size(60, 25);
            this.enableFrontControls.Name = "enableFrontControls";
            this.enableFrontControls.Size = new System.Drawing.Size(60, 25);
            this.enableFrontControls.TabIndex = 16;
            this.enableFrontControls.Text = "Disable";
            this.enableFrontControls.ToggleDisabledColor = System.Drawing.Color.Red;
            this.enableFrontControls.ToggleDisabledText = "Disable";
            this.enableFrontControls.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.enableFrontControls.ToggleEnabledText = "Enable";
            this.enableFrontControls.UseVisualStyleBackColor = false;
            this.enableFrontControls.Click += new System.EventHandler(this.enableToggle_Click);
            // 
            // enableMultiport
            // 
            this.enableMultiport.AutoSize = true;
            this.enableMultiport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enableMultiport.BackColor = System.Drawing.Color.Red;
            this.enableMultiport.Channel = 0;
            this.enableMultiport.Dock = System.Windows.Forms.DockStyle.Top;
            this.enableMultiport.Location = new System.Drawing.Point(3, 257);
            this.enableMultiport.MinimumSize = new System.Drawing.Size(60, 25);
            this.enableMultiport.Name = "enableMultiport";
            this.enableMultiport.Size = new System.Drawing.Size(60, 25);
            this.enableMultiport.TabIndex = 16;
            this.enableMultiport.Text = "Disable";
            this.enableMultiport.ToggleDisabledColor = System.Drawing.Color.Red;
            this.enableMultiport.ToggleDisabledText = "Disable";
            this.enableMultiport.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.enableMultiport.ToggleEnabledText = "Enable";
            this.enableMultiport.UseVisualStyleBackColor = false;
            this.enableMultiport.Click += new System.EventHandler(this.enableToggle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(69, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Controls";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(69, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Administration";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(69, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Save Prompt ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(69, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Front Controls ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(69, 257);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Multiport";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NetworkBox
            // 
            this.NetworkBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NetworkBox.Controls.Add(this.tableLayoutPanel4);
            this.NetworkBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NetworkBox.Location = new System.Drawing.Point(4, 337);
            this.NetworkBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.NetworkBox.Name = "NetworkBox";
            this.NetworkBox.Padding = new System.Windows.Forms.Padding(7);
            this.NetworkBox.Size = new System.Drawing.Size(331, 395);
            this.NetworkBox.TabIndex = 6;
            this.NetworkBox.TabStop = false;
            this.NetworkBox.Text = "Network Settings";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 12);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 15);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 18);
            this.tableLayoutPanel4.Controls.Add(this.hostName, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.ipAddress, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.subnetMask, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.gateway, 0, 13);
            this.tableLayoutPanel4.Controls.Add(this.primaryDNS, 0, 16);
            this.tableLayoutPanel4.Controls.Add(this.secondaryDNS, 0, 19);
            this.tableLayoutPanel4.Controls.Add(this.enableDHCP, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.buttonIPAddress, 2, 7);
            this.tableLayoutPanel4.Controls.Add(this.buttonSubnetMask, 2, 10);
            this.tableLayoutPanel4.Controls.Add(this.buttonGateway, 2, 13);
            this.tableLayoutPanel4.Controls.Add(this.buttonPrimaryDNS, 2, 16);
            this.tableLayoutPanel4.Controls.Add(this.buttonSecondaryDNS, 2, 19);
            this.tableLayoutPanel4.Controls.Add(this.label18, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 20;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(317, 360);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label10, 3);
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Hostname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label11, 3);
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(3, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(311, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "IP Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label12, 3);
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(3, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(311, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Subnet Mask";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label13, 3);
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(3, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(311, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Default Gateway";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label14, 3);
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(3, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(311, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Preferred DNS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label15, 3);
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(3, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(311, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Alternate DNS";
            // 
            // hostName
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.hostName, 3);
            this.hostName.Dock = System.Windows.Forms.DockStyle.Top;
            this.hostName.Location = new System.Drawing.Point(3, 26);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(311, 20);
            this.hostName.TabIndex = 1;
            // 
            // ipAddress
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.ipAddress, 2);
            this.ipAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.ipAddress.Location = new System.Drawing.Point(3, 116);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(240, 20);
            this.ipAddress.TabIndex = 1;
            // 
            // subnetMask
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.subnetMask, 2);
            this.subnetMask.Dock = System.Windows.Forms.DockStyle.Top;
            this.subnetMask.Location = new System.Drawing.Point(3, 170);
            this.subnetMask.Name = "subnetMask";
            this.subnetMask.Size = new System.Drawing.Size(240, 20);
            this.subnetMask.TabIndex = 1;
            // 
            // gateway
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.gateway, 2);
            this.gateway.Dock = System.Windows.Forms.DockStyle.Top;
            this.gateway.Location = new System.Drawing.Point(3, 224);
            this.gateway.Name = "gateway";
            this.gateway.Size = new System.Drawing.Size(240, 20);
            this.gateway.TabIndex = 1;
            // 
            // primaryDNS
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.primaryDNS, 2);
            this.primaryDNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.primaryDNS.Location = new System.Drawing.Point(3, 278);
            this.primaryDNS.Name = "primaryDNS";
            this.primaryDNS.Size = new System.Drawing.Size(240, 20);
            this.primaryDNS.TabIndex = 1;
            // 
            // secondaryDNS
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.secondaryDNS, 2);
            this.secondaryDNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondaryDNS.Location = new System.Drawing.Point(3, 332);
            this.secondaryDNS.Name = "secondaryDNS";
            this.secondaryDNS.Size = new System.Drawing.Size(240, 20);
            this.secondaryDNS.TabIndex = 1;
            // 
            // enableDHCP
            // 
            this.enableDHCP.AutoSize = true;
            this.enableDHCP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enableDHCP.BackColor = System.Drawing.Color.LimeGreen;
            this.enableDHCP.Channel = 0;
            this.enableDHCP.Location = new System.Drawing.Point(3, 62);
            this.enableDHCP.MinimumSize = new System.Drawing.Size(60, 25);
            this.enableDHCP.Name = "enableDHCP";
            this.enableDHCP.Size = new System.Drawing.Size(60, 25);
            this.enableDHCP.TabIndex = 2;
            this.enableDHCP.Text = "Enable";
            this.enableDHCP.ToggleDisabledColor = System.Drawing.Color.Red;
            this.enableDHCP.ToggleDisabledText = "Disable";
            this.enableDHCP.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.enableDHCP.ToggleEnabledText = "Enable";
            this.enableDHCP.UseVisualStyleBackColor = false;
            this.enableDHCP.Click += new System.EventHandler(this.enableToggle_Click);
            // 
            // buttonIPAddress
            // 
            this.buttonIPAddress.AutoSize = true;
            this.buttonIPAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIPAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPAddress.Location = new System.Drawing.Point(249, 116);
            this.buttonIPAddress.MinimumSize = new System.Drawing.Size(65, 25);
            this.buttonIPAddress.Name = "buttonIPAddress";
            this.buttonIPAddress.Size = new System.Drawing.Size(65, 25);
            this.buttonIPAddress.TabIndex = 2;
            this.buttonIPAddress.Text = " ";
            this.buttonIPAddress.UseVisualStyleBackColor = true;
            this.buttonIPAddress.Click += new System.EventHandler(this.buttonIPAddress_Click);
            // 
            // buttonSubnetMask
            // 
            this.buttonSubnetMask.AutoSize = true;
            this.buttonSubnetMask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSubnetMask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubnetMask.Location = new System.Drawing.Point(249, 170);
            this.buttonSubnetMask.MinimumSize = new System.Drawing.Size(65, 25);
            this.buttonSubnetMask.Name = "buttonSubnetMask";
            this.buttonSubnetMask.Size = new System.Drawing.Size(65, 25);
            this.buttonSubnetMask.TabIndex = 2;
            this.buttonSubnetMask.Text = " ";
            this.buttonSubnetMask.UseVisualStyleBackColor = true;
            this.buttonSubnetMask.Click += new System.EventHandler(this.buttonSubnetMask_Click);
            // 
            // buttonGateway
            // 
            this.buttonGateway.AutoSize = true;
            this.buttonGateway.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGateway.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGateway.Location = new System.Drawing.Point(249, 224);
            this.buttonGateway.MinimumSize = new System.Drawing.Size(65, 25);
            this.buttonGateway.Name = "buttonGateway";
            this.buttonGateway.Size = new System.Drawing.Size(65, 25);
            this.buttonGateway.TabIndex = 2;
            this.buttonGateway.Text = " ";
            this.buttonGateway.UseVisualStyleBackColor = true;
            this.buttonGateway.Click += new System.EventHandler(this.buttonGateway_Click);
            // 
            // buttonPrimaryDNS
            // 
            this.buttonPrimaryDNS.AutoSize = true;
            this.buttonPrimaryDNS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPrimaryDNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPrimaryDNS.Location = new System.Drawing.Point(249, 278);
            this.buttonPrimaryDNS.MinimumSize = new System.Drawing.Size(65, 25);
            this.buttonPrimaryDNS.Name = "buttonPrimaryDNS";
            this.buttonPrimaryDNS.Size = new System.Drawing.Size(65, 25);
            this.buttonPrimaryDNS.TabIndex = 2;
            this.buttonPrimaryDNS.Text = " ";
            this.buttonPrimaryDNS.UseVisualStyleBackColor = true;
            this.buttonPrimaryDNS.Click += new System.EventHandler(this.buttonPrimaryDNS_Click);
            // 
            // buttonSecondaryDNS
            // 
            this.buttonSecondaryDNS.AutoSize = true;
            this.buttonSecondaryDNS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSecondaryDNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSecondaryDNS.Location = new System.Drawing.Point(249, 332);
            this.buttonSecondaryDNS.MinimumSize = new System.Drawing.Size(65, 25);
            this.buttonSecondaryDNS.Name = "buttonSecondaryDNS";
            this.buttonSecondaryDNS.Size = new System.Drawing.Size(65, 25);
            this.buttonSecondaryDNS.TabIndex = 2;
            this.buttonSecondaryDNS.Text = " ";
            this.buttonSecondaryDNS.UseVisualStyleBackColor = true;
            this.buttonSecondaryDNS.Click += new System.EventHandler(this.buttonSecondaryDNS_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label18, 2);
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(69, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(245, 31);
            this.label18.TabIndex = 0;
            this.label18.Text = "DHCP";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sockets
            // 
            this.Sockets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sockets.Controls.Add(this.tableLayoutPanel5);
            this.Sockets.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sockets.Location = new System.Drawing.Point(4, 745);
            this.Sockets.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Sockets.Name = "Sockets";
            this.Sockets.Padding = new System.Windows.Forms.Padding(7);
            this.Sockets.Size = new System.Drawing.Size(331, 297);
            this.Sockets.TabIndex = 6;
            this.Sockets.TabStop = false;
            this.Sockets.Text = "Sockets";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.growGroupbox2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.growGroupbox1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(317, 262);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // growGroupbox2
            // 
            this.growGroupbox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.growGroupbox2.Controls.Add(this.tableLayoutPanel9);
            this.growGroupbox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.growGroupbox2.Location = new System.Drawing.Point(3, 134);
            this.growGroupbox2.Name = "growGroupbox2";
            this.growGroupbox2.Size = new System.Drawing.Size(311, 125);
            this.growGroupbox2.TabIndex = 1;
            this.growGroupbox2.TabStop = false;
            this.growGroupbox2.Text = "Binary Ethernet Socket";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.AutoSize = true;
            this.tableLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel9.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.enableBinarySocket, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label20, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.binaryPort, 0, 4);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 5;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(305, 90);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.tableLayoutPanel9.SetColumnSpan(this.label19, 2);
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Location = new System.Drawing.Point(3, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(299, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Port";
            // 
            // enableBinarySocket
            // 
            this.enableBinarySocket.AutoSize = true;
            this.enableBinarySocket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enableBinarySocket.BackColor = System.Drawing.Color.LimeGreen;
            this.enableBinarySocket.Channel = 0;
            this.enableBinarySocket.Dock = System.Windows.Forms.DockStyle.Top;
            this.enableBinarySocket.Location = new System.Drawing.Point(3, 13);
            this.enableBinarySocket.MinimumSize = new System.Drawing.Size(60, 25);
            this.enableBinarySocket.Name = "enableBinarySocket";
            this.enableBinarySocket.Size = new System.Drawing.Size(95, 25);
            this.enableBinarySocket.TabIndex = 2;
            this.enableBinarySocket.Text = "Enable";
            this.enableBinarySocket.ToggleDisabledColor = System.Drawing.Color.Red;
            this.enableBinarySocket.ToggleDisabledText = "Disable";
            this.enableBinarySocket.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.enableBinarySocket.ToggleEnabledText = "Enable";
            this.enableBinarySocket.UseVisualStyleBackColor = false;
            this.enableBinarySocket.Click += new System.EventHandler(this.enableToggle_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(104, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(198, 31);
            this.label20.TabIndex = 0;
            this.label20.Text = "Socket";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // binaryPort
            // 
            this.tableLayoutPanel9.SetColumnSpan(this.binaryPort, 2);
            this.binaryPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.binaryPort.Location = new System.Drawing.Point(3, 67);
            this.binaryPort.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.binaryPort.Name = "binaryPort";
            this.binaryPort.Size = new System.Drawing.Size(299, 20);
            this.binaryPort.TabIndex = 3;
            // 
            // growGroupbox1
            // 
            this.growGroupbox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.growGroupbox1.Controls.Add(this.tableLayoutPanel8);
            this.growGroupbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.growGroupbox1.Location = new System.Drawing.Point(3, 3);
            this.growGroupbox1.Name = "growGroupbox1";
            this.growGroupbox1.Size = new System.Drawing.Size(311, 125);
            this.growGroupbox1.TabIndex = 0;
            this.growGroupbox1.TabStop = false;
            this.growGroupbox1.Text = "Legacy Ethernet Socket";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel8.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.enableLegacySocket, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label17, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.legacyPort, 0, 4);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(305, 90);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.tableLayoutPanel8.SetColumnSpan(this.label16, 2);
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(3, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(299, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Port";
            // 
            // enableLegacySocket
            // 
            this.enableLegacySocket.AutoSize = true;
            this.enableLegacySocket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enableLegacySocket.BackColor = System.Drawing.Color.LimeGreen;
            this.enableLegacySocket.Channel = 0;
            this.enableLegacySocket.Dock = System.Windows.Forms.DockStyle.Top;
            this.enableLegacySocket.Location = new System.Drawing.Point(3, 13);
            this.enableLegacySocket.MinimumSize = new System.Drawing.Size(60, 25);
            this.enableLegacySocket.Name = "enableLegacySocket";
            this.enableLegacySocket.Size = new System.Drawing.Size(95, 25);
            this.enableLegacySocket.TabIndex = 2;
            this.enableLegacySocket.Text = "Enable";
            this.enableLegacySocket.ToggleDisabledColor = System.Drawing.Color.Red;
            this.enableLegacySocket.ToggleDisabledText = "Disable";
            this.enableLegacySocket.ToggleEnabledColor = System.Drawing.Color.LimeGreen;
            this.enableLegacySocket.ToggleEnabledText = "Enable";
            this.enableLegacySocket.UseVisualStyleBackColor = false;
            this.enableLegacySocket.Click += new System.EventHandler(this.enableToggle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(104, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(198, 31);
            this.label17.TabIndex = 0;
            this.label17.Text = "Socket";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // legacyPort
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.legacyPort, 2);
            this.legacyPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.legacyPort.Location = new System.Drawing.Point(3, 67);
            this.legacyPort.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.legacyPort.Name = "legacyPort";
            this.legacyPort.Size = new System.Drawing.Size(299, 20);
            this.legacyPort.TabIndex = 3;
            // 
            // UART
            // 
            this.UART.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UART.Controls.Add(this.tableLayoutPanel6);
            this.UART.Dock = System.Windows.Forms.DockStyle.Top;
            this.UART.Location = new System.Drawing.Point(4, 1055);
            this.UART.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.UART.Name = "UART";
            this.UART.Padding = new System.Windows.Forms.Padding(7);
            this.UART.Size = new System.Drawing.Size(331, 192);
            this.UART.TabIndex = 6;
            this.UART.TabStop = false;
            this.UART.Text = "UART";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label22, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label23, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label24, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.label25, 0, 9);
            this.tableLayoutPanel6.Controls.Add(this.baudRate, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.parity, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.stopBits, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.label26, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label27, 1, 9);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 10;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(317, 157);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(3, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 27);
            this.label21.TabIndex = 0;
            this.label21.Text = "Baud Rate:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Location = new System.Drawing.Point(3, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Data Bits:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(3, 70);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 27);
            this.label23.TabIndex = 0;
            this.label23.Text = "Parity:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(3, 107);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 27);
            this.label24.TabIndex = 0;
            this.label24.Text = "Stop Bits:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Location = new System.Drawing.Point(3, 144);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Flow Control:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baudRate
            // 
            this.baudRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.baudRate.Location = new System.Drawing.Point(77, 13);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(237, 21);
            this.baudRate.TabIndex = 1;
            // 
            // parity
            // 
            this.parity.Dock = System.Windows.Forms.DockStyle.Top;
            this.parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parity.FormattingEnabled = true;
            this.parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.parity.Location = new System.Drawing.Point(77, 73);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(237, 21);
            this.parity.TabIndex = 1;
            // 
            // stopBits
            // 
            this.stopBits.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBits.FormattingEnabled = true;
            this.stopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopBits.Location = new System.Drawing.Point(77, 110);
            this.stopBits.Name = "stopBits";
            this.stopBits.Size = new System.Drawing.Size(237, 21);
            this.stopBits.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Top;
            this.label26.Location = new System.Drawing.Point(77, 47);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(237, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "8";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Location = new System.Drawing.Point(77, 144);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(237, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "None";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Connection
            // 
            this.Connection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Connection.Controls.Add(this.tableLayoutPanel26);
            this.Connection.Dock = System.Windows.Forms.DockStyle.Top;
            this.Connection.Location = new System.Drawing.Point(3, 114);
            this.Connection.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(7);
            this.Connection.Size = new System.Drawing.Size(358, 67);
            this.Connection.TabIndex = 5;
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
            this.tableLayoutPanel26.Size = new System.Drawing.Size(344, 32);
            this.tableLayoutPanel26.TabIndex = 2;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(3, 3);
            this.label59.Margin = new System.Windows.Forms.Padding(3);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(338, 26);
            this.label59.TabIndex = 5;
            this.label59.Text = "You must be connected to a unit with USB or Ethernet to display controls on this " +
    "page.";
            // 
            // CurrentSettings
            // 
            this.CurrentSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CurrentSettings.Controls.Add(this.tableLayoutPanel27);
            this.CurrentSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentSettings.Location = new System.Drawing.Point(3, 194);
            this.CurrentSettings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.CurrentSettings.Name = "CurrentSettings";
            this.CurrentSettings.Padding = new System.Windows.Forms.Padding(7);
            this.CurrentSettings.Size = new System.Drawing.Size(358, 111);
            this.CurrentSettings.TabIndex = 5;
            this.CurrentSettings.TabStop = false;
            this.CurrentSettings.Text = "Current Settings";
            this.CurrentSettings.Visible = false;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.AutoSize = true;
            this.tableLayoutPanel27.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel27.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel27.ColumnCount = 2;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.Controls.Add(this.label60, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.getSettings, 0, 1);
            this.tableLayoutPanel27.Controls.Add(this.writeSettings, 1, 1);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 2;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel27.Size = new System.Drawing.Size(344, 76);
            this.tableLayoutPanel27.TabIndex = 2;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.tableLayoutPanel27.SetColumnSpan(this.label60, 2);
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(3, 3);
            this.label60.Margin = new System.Windows.Forms.Padding(3);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(338, 39);
            this.label60.TabIndex = 5;
            this.label60.Text = "This is not a live page. Use the buttons below to retrieve the current settings f" +
    "rom the connected unit, or write all settings from this window to the connected " +
    "unit.";
            // 
            // getSettings
            // 
            this.getSettings.AutoSize = true;
            this.getSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.getSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSettings.Location = new System.Drawing.Point(3, 48);
            this.getSettings.MinimumSize = new System.Drawing.Size(0, 25);
            this.getSettings.Name = "getSettings";
            this.getSettings.Size = new System.Drawing.Size(166, 25);
            this.getSettings.TabIndex = 6;
            this.getSettings.Text = "Refresh Page";
            this.getSettings.UseVisualStyleBackColor = true;
            this.getSettings.Click += new System.EventHandler(this.getSettings_Click);
            // 
            // writeSettings
            // 
            this.writeSettings.AutoSize = true;
            this.writeSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.writeSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.writeSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeSettings.Location = new System.Drawing.Point(175, 48);
            this.writeSettings.MinimumSize = new System.Drawing.Size(0, 25);
            this.writeSettings.Name = "writeSettings";
            this.writeSettings.Size = new System.Drawing.Size(166, 25);
            this.writeSettings.TabIndex = 7;
            this.writeSettings.Text = "Write All";
            this.writeSettings.UseVisualStyleBackColor = true;
            this.writeSettings.Click += new System.EventHandler(this.writeSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 573);
            this.Controls.Add(this.formLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.formControls_Load);
            this.VisibleChanged += new System.EventHandler(this.formSettings_VisibleChanged);
            this.formLayoutPanel.ResumeLayout(false);
            this.UserLevel.ResumeLayout(false);
            this.UserLevel.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.mainLayoutTable.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.NetworkBox.ResumeLayout(false);
            this.NetworkBox.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.Sockets.ResumeLayout(false);
            this.Sockets.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.growGroupbox2.ResumeLayout(false);
            this.growGroupbox2.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPort)).EndInit();
            this.growGroupbox1.ResumeLayout(false);
            this.growGroupbox1.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legacyPort)).EndInit();
            this.UART.ResumeLayout(false);
            this.UART.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.CurrentSettings.ResumeLayout(false);
            this.CurrentSettings.PerformLayout();
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ScrollingPanel scrollPanel;
        private GrowGroupbox CurrentSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button getSettings;
        private System.Windows.Forms.Button writeSettings;
        private System.Windows.Forms.TableLayoutPanel mainLayoutTable;
        private GrowGroupbox UserLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button login;
        private GrowGroupbox Connection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.Label label59;
        private GrowGroupbox General;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private GrowGroupbox NetworkBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private GrowGroupbox Sockets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private GrowGroupbox UART;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private ToggleButton enableLoginTimeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ToggleButton requireUser;
        private ToggleButton requireAdmin;
        private ToggleButton enableSavePrompt;
        private ToggleButton enableFrontControls;
        private ToggleButton enableMultiport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox hostName;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.TextBox subnetMask;
        private System.Windows.Forms.TextBox gateway;
        private System.Windows.Forms.TextBox primaryDNS;
        private System.Windows.Forms.TextBox secondaryDNS;
        private ToggleButton enableDHCP;
        private System.Windows.Forms.Button buttonIPAddress;
        private System.Windows.Forms.Button buttonSubnetMask;
        private System.Windows.Forms.Button buttonGateway;
        private System.Windows.Forms.Button buttonPrimaryDNS;
        private System.Windows.Forms.Button buttonSecondaryDNS;
        private System.Windows.Forms.Label label18;
        private GrowGroupbox growGroupbox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label16;
        private ToggleButton enableLegacySocket;
        private System.Windows.Forms.Label label17;
        private GrowGroupbox growGroupbox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label19;
        private ToggleButton enableBinarySocket;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.ComboBox parity;
        private System.Windows.Forms.ComboBox stopBits;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown binaryPort;
        private System.Windows.Forms.NumericUpDown legacyPort;
        private SliderNumericCombo LoginTimeoutSlider;
        private System.Windows.Forms.TableLayoutPanel formLayoutPanel;
    }
}
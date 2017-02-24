namespace SCHOTT.CVLS.Dashboard.Forms
{
    partial class Connections
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
            this.socketConnectBtn = new System.Windows.Forms.Button();
            this.socketDisconnectBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Serial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firmware = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LEDTemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LEDTempStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoardTemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoardTempStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Monitor5V = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Monitor24V = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FanRPM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EqualizerMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SystemMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LightOutput = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KnobControl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SystemTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MACAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discover = new System.Windows.Forms.Button();
            this.stopDiscover = new System.Windows.Forms.Button();
            this.socketPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.socketAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.loginMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usbStatus = new System.Windows.Forms.Label();
            this.commList = new System.Windows.Forms.ComboBox();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // socketConnectBtn
            // 
            this.socketConnectBtn.AutoSize = true;
            this.socketConnectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.socketConnectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.socketConnectBtn.Location = new System.Drawing.Point(3, 190);
            this.socketConnectBtn.Name = "socketConnectBtn";
            this.socketConnectBtn.Size = new System.Drawing.Size(105, 23);
            this.socketConnectBtn.TabIndex = 50;
            this.socketConnectBtn.Text = "Connect";
            this.socketConnectBtn.UseVisualStyleBackColor = true;
            this.socketConnectBtn.Click += new System.EventHandler(this.socketConnectBtn_Click);
            // 
            // socketDisconnectBtn
            // 
            this.socketDisconnectBtn.AutoSize = true;
            this.socketDisconnectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.socketDisconnectBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.socketDisconnectBtn.Enabled = false;
            this.socketDisconnectBtn.Location = new System.Drawing.Point(114, 190);
            this.socketDisconnectBtn.Name = "socketDisconnectBtn";
            this.socketDisconnectBtn.Size = new System.Drawing.Size(105, 23);
            this.socketDisconnectBtn.TabIndex = 51;
            this.socketDisconnectBtn.Text = "Disconnect";
            this.socketDisconnectBtn.UseVisualStyleBackColor = true;
            this.socketDisconnectBtn.Click += new System.EventHandler(this.socketDisconnectBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IPAddress,
            this.HostName,
            this.MACAddress,
            this.Serial,
            this.Firmware,
            this.Model,
            this.LEDTemp,
            this.LEDTempStatus,
            this.BoardTemp,
            this.BoardTempStatus,
            this.Monitor5V,
            this.Monitor24V,
            this.FanRPM,
            this.EqualizerMode,
            this.SystemMode,
            this.LightOutput,
            this.LastCommand,
            this.UserMode,
            this.KnobControl,
            this.SystemTime});
            this.tableLayoutPanel4.SetColumnSpan(this.listView1, 2);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(216, 107);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 69;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // IPAddress
            // 
            this.IPAddress.Text = "IP Address";
            this.IPAddress.Width = 93;
            // 
            // Serial
            // 
            this.Serial.Text = "Serial";
            this.Serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Serial.Width = 50;
            // 
            // Firmware
            // 
            this.Firmware.Text = "Firmware";
            this.Firmware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Model.Width = 78;
            // 
            // HostName
            // 
            this.HostName.Text = "Host Name";
            this.HostName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HostName.Width = 130;
            // 
            // LEDTemp
            // 
            this.LEDTemp.Text = "LED Temp (C)";
            this.LEDTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LEDTemp.Width = 81;
            // 
            // LEDTempStatus
            // 
            this.LEDTempStatus.Text = "LED Temp Status";
            this.LEDTempStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LEDTempStatus.Width = 106;
            // 
            // BoardTemp
            // 
            this.BoardTemp.Text = "Board Temp";
            // 
            // BoardTempStatus
            // 
            this.BoardTempStatus.Text = "Board Temp Status";
            // 
            // Monitor5V
            // 
            this.Monitor5V.Text = "5V Output";
            // 
            // Monitor24V
            // 
            this.Monitor24V.Text = "Input Voltage";
            // 
            // FanRPM
            // 
            this.FanRPM.Text = "Fan RPM";
            // 
            // EqualizerMode
            // 
            this.EqualizerMode.Text = "Equalizer Mode";
            // 
            // SystemMode
            // 
            this.SystemMode.Text = "System Mode";
            // 
            // LightOutput
            // 
            this.LightOutput.Text = "Light Output";
            // 
            // LastCommand
            // 
            this.LastCommand.Text = "Last Command";
            // 
            // UserMode
            // 
            this.UserMode.Text = "User Mode";
            // 
            // KnobControl
            // 
            this.KnobControl.Text = "Knob Control";
            // 
            // SystemTime
            // 
            this.SystemTime.Text = "System Time";
            // 
            // MACAddress
            // 
            this.MACAddress.Text = "MAC Address";
            this.MACAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MACAddress.Width = 119;
            // 
            // discover
            // 
            this.discover.AutoSize = true;
            this.discover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.discover.Dock = System.Windows.Forms.DockStyle.Top;
            this.discover.Location = new System.Drawing.Point(3, 116);
            this.discover.Name = "discover";
            this.discover.Size = new System.Drawing.Size(105, 23);
            this.discover.TabIndex = 50;
            this.discover.Text = "Discover Units";
            this.discover.UseVisualStyleBackColor = true;
            this.discover.Click += new System.EventHandler(this.discover_Click);
            // 
            // stopDiscover
            // 
            this.stopDiscover.AutoSize = true;
            this.stopDiscover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopDiscover.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopDiscover.Enabled = false;
            this.stopDiscover.Location = new System.Drawing.Point(114, 116);
            this.stopDiscover.Name = "stopDiscover";
            this.stopDiscover.Size = new System.Drawing.Size(105, 23);
            this.stopDiscover.TabIndex = 50;
            this.stopDiscover.Text = "Stop Listener";
            this.stopDiscover.UseVisualStyleBackColor = true;
            this.stopDiscover.Click += new System.EventHandler(this.stopDiscover_Click);
            // 
            // socketPort
            // 
            this.socketPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.socketPort.Location = new System.Drawing.Point(114, 164);
            this.socketPort.Name = "socketPort";
            this.socketPort.Size = new System.Drawing.Size(105, 20);
            this.socketPort.TabIndex = 65;
            this.socketPort.Text = "5000";
            this.socketPort.TextChanged += new System.EventHandler(this.socketPort_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(114, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // socketAddress
            // 
            this.socketAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.socketAddress.Location = new System.Drawing.Point(3, 164);
            this.socketAddress.Name = "socketAddress";
            this.socketAddress.Size = new System.Drawing.Size(105, 20);
            this.socketAddress.TabIndex = 66;
            this.socketAddress.Text = "10.0.0.12";
            this.socketAddress.TextChanged += new System.EventHandler(this.socketAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login.Dock = System.Windows.Forms.DockStyle.Top;
            this.login.Enabled = false;
            this.login.Location = new System.Drawing.Point(3, 219);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(105, 23);
            this.login.TabIndex = 50;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout.Enabled = false;
            this.logout.Location = new System.Drawing.Point(114, 219);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(105, 23);
            this.logout.TabIndex = 50;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // loginMessage
            // 
            this.loginMessage.AutoSize = true;
            this.loginMessage.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel4.SetColumnSpan(this.loginMessage, 2);
            this.loginMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginMessage.Location = new System.Drawing.Point(3, 248);
            this.loginMessage.Margin = new System.Windows.Forms.Padding(3);
            this.loginMessage.Name = "loginMessage";
            this.loginMessage.Padding = new System.Windows.Forms.Padding(3);
            this.loginMessage.Size = new System.Drawing.Size(216, 19);
            this.loginMessage.TabIndex = 70;
            this.loginMessage.Text = "Not Logged In";
            this.loginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 289);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ethernet Connections";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.stopDiscover, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.socketPort, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.socketDisconnectBtn, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.socketAddress, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.socketConnectBtn, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.discover, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.logout, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.login, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.loginMessage, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(222, 270);
            this.tableLayoutPanel4.TabIndex = 75;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 382);
            this.tableLayoutPanel2.TabIndex = 73;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 71);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ComPort Connections";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.usbStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.commList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usbStatus
            // 
            this.usbStatus.AutoSize = true;
            this.usbStatus.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.SetColumnSpan(this.usbStatus, 2);
            this.usbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.usbStatus.Location = new System.Drawing.Point(3, 3);
            this.usbStatus.Margin = new System.Windows.Forms.Padding(3);
            this.usbStatus.Name = "usbStatus";
            this.usbStatus.Padding = new System.Windows.Forms.Padding(3);
            this.usbStatus.Size = new System.Drawing.Size(216, 19);
            this.usbStatus.TabIndex = 0;
            this.usbStatus.Text = "Not Detected";
            this.usbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.commList, 2);
            this.commList.Dock = System.Windows.Forms.DockStyle.Top;
            this.commList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commList.FormattingEnabled = true;
            this.commList.Location = new System.Drawing.Point(3, 28);
            this.commList.Name = "commList";
            this.commList.Size = new System.Drawing.Size(216, 21);
            this.commList.TabIndex = 1;
            this.commList.DropDown += new System.EventHandler(this.commList_DropDown);
            this.commList.SelectedIndexChanged += new System.EventHandler(this.commList_SelectedIndexChanged);
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollPanel.Controls.Add(this.tableLayoutPanel2);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(3);
            this.scrollPanel.Size = new System.Drawing.Size(240, 388);
            this.scrollPanel.TabIndex = 74;
            // 
            // Connections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 388);
            this.Controls.Add(this.scrollPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "Connections";
            this.Text = "Connections";
            this.Load += new System.EventHandler(this.formConnections_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button socketConnectBtn;
        private System.Windows.Forms.Button stopDiscover;
        private System.Windows.Forms.Button socketDisconnectBtn;
        private System.Windows.Forms.Button discover;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IPAddress;
        private System.Windows.Forms.ColumnHeader HostName;
        private System.Windows.Forms.ColumnHeader MACAddress;
        private System.Windows.Forms.ColumnHeader Serial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox socketPort;
        private System.Windows.Forms.TextBox socketAddress;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usbStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.Label loginMessage;
        private System.Windows.Forms.ComboBox commList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Firmware;
        private System.Windows.Forms.ColumnHeader LEDTemp;
        private System.Windows.Forms.ColumnHeader LEDTempStatus;
        private System.Windows.Forms.ColumnHeader BoardTemp;
        private System.Windows.Forms.ColumnHeader BoardTempStatus;
        private System.Windows.Forms.ColumnHeader Monitor5V;
        private System.Windows.Forms.ColumnHeader Monitor24V;
        private System.Windows.Forms.ColumnHeader FanRPM;
        private System.Windows.Forms.ColumnHeader SystemMode;
        private System.Windows.Forms.ColumnHeader EqualizerMode;
        private System.Windows.Forms.ColumnHeader LightOutput;
        private System.Windows.Forms.ColumnHeader LastCommand;
        private System.Windows.Forms.ColumnHeader UserMode;
        private System.Windows.Forms.ColumnHeader KnobControl;
        private System.Windows.Forms.ColumnHeader SystemTime;
    }
}
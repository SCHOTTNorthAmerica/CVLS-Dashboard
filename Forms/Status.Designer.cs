using SCHOTT.WinForms.Controls.Group_Boxes;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    partial class Status
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
            this.statusTable = new System.Windows.Forms.TableLayoutPanel();
            this.label38 = new System.Windows.Forms.Label();
            this.ErrorLogCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LEDTemp = new System.Windows.Forms.Label();
            this.LEDSensor = new System.Windows.Forms.Label();
            this.BoardTemp = new System.Windows.Forms.Label();
            this.BoardSensor = new System.Windows.Forms.Label();
            this.RefVoltage = new System.Windows.Forms.Label();
            this.InputVoltage = new System.Windows.Forms.Label();
            this.FanSpeed = new System.Windows.Forms.Label();
            this.Equalizer = new System.Windows.Forms.Label();
            this.LightFeedBack = new System.Windows.Forms.Label();
            this.LastCommand = new System.Windows.Forms.Label();
            this.SystemMode = new System.Windows.Forms.Label();
            this.UserModeLabel = new System.Windows.Forms.Label();
            this.KnobMode = new System.Windows.Forms.Label();
            this.SystemDate = new System.Windows.Forms.Label();
            this.Serial = new System.Windows.Forms.Label();
            this.SettingsWriteCount = new System.Windows.Forms.Label();
            this.FactoryWriteCount = new System.Windows.Forms.Label();
            this.SPIEraseCount = new System.Windows.Forms.Label();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentStatusRefresh = new GrowGroupbox();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.label60 = new System.Windows.Forms.Label();
            this.getSettings = new System.Windows.Forms.Button();
            this.ConnectionRequired = new GrowGroupbox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.label59 = new System.Windows.Forms.Label();
            this.statusTable.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CurrentStatusRefresh.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.ConnectionRequired.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.statusTable.AutoSize = true;
            this.statusTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusTable.ColumnCount = 2;
            this.statusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.statusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusTable.Controls.Add(this.label38, 0, 18);
            this.statusTable.Controls.Add(this.ErrorLogCount, 0, 18);
            this.statusTable.Controls.Add(this.label1, 0, 0);
            this.statusTable.Controls.Add(this.label2, 0, 1);
            this.statusTable.Controls.Add(this.label3, 0, 2);
            this.statusTable.Controls.Add(this.label4, 0, 3);
            this.statusTable.Controls.Add(this.label16, 0, 17);
            this.statusTable.Controls.Add(this.label15, 0, 16);
            this.statusTable.Controls.Add(this.label14, 0, 15);
            this.statusTable.Controls.Add(this.label13, 0, 14);
            this.statusTable.Controls.Add(this.label12, 0, 13);
            this.statusTable.Controls.Add(this.label11, 0, 12);
            this.statusTable.Controls.Add(this.label10, 0, 11);
            this.statusTable.Controls.Add(this.label9, 0, 10);
            this.statusTable.Controls.Add(this.label8, 0, 9);
            this.statusTable.Controls.Add(this.label7, 0, 8);
            this.statusTable.Controls.Add(this.label6, 0, 7);
            this.statusTable.Controls.Add(this.label5, 0, 6);
            this.statusTable.Controls.Add(this.label18, 0, 4);
            this.statusTable.Controls.Add(this.label19, 0, 5);
            this.statusTable.Controls.Add(this.LEDTemp, 1, 0);
            this.statusTable.Controls.Add(this.LEDSensor, 1, 1);
            this.statusTable.Controls.Add(this.BoardTemp, 1, 2);
            this.statusTable.Controls.Add(this.BoardSensor, 1, 3);
            this.statusTable.Controls.Add(this.RefVoltage, 1, 4);
            this.statusTable.Controls.Add(this.InputVoltage, 1, 5);
            this.statusTable.Controls.Add(this.FanSpeed, 1, 6);
            this.statusTable.Controls.Add(this.Equalizer, 1, 7);
            this.statusTable.Controls.Add(this.LightFeedBack, 1, 8);
            this.statusTable.Controls.Add(this.LastCommand, 1, 9);
            this.statusTable.Controls.Add(this.SystemMode, 1, 10);
            this.statusTable.Controls.Add(this.UserModeLabel, 1, 11);
            this.statusTable.Controls.Add(this.KnobMode, 1, 12);
            this.statusTable.Controls.Add(this.SystemDate, 1, 13);
            this.statusTable.Controls.Add(this.Serial, 1, 14);
            this.statusTable.Controls.Add(this.SettingsWriteCount, 1, 15);
            this.statusTable.Controls.Add(this.FactoryWriteCount, 1, 16);
            this.statusTable.Controls.Add(this.SPIEraseCount, 1, 17);
            this.statusTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusTable.Location = new System.Drawing.Point(3, 207);
            this.statusTable.Name = "statusTable";
            this.statusTable.RowCount = 19;
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statusTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.statusTable.Size = new System.Drawing.Size(273, 323);
            this.statusTable.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Location = new System.Drawing.Point(10, 308);
            this.label38.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(104, 13);
            this.label38.TabIndex = 37;
            this.label38.Text = "Error Log Count";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorLogCount
            // 
            this.ErrorLogCount.AutoSize = true;
            this.ErrorLogCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorLogCount.Location = new System.Drawing.Point(126, 308);
            this.ErrorLogCount.Margin = new System.Windows.Forms.Padding(2);
            this.ErrorLogCount.Name = "ErrorLogCount";
            this.ErrorLogCount.Size = new System.Drawing.Size(145, 13);
            this.ErrorLogCount.TabIndex = 36;
            this.ErrorLogCount.Text = "-";
            this.ErrorLogCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(10, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LED Temp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LED Sensor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Board Temp";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(10, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Board Sensor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(10, 291);
            this.label16.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "SPI Erase Count";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(10, 274);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Factory Write Count";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(10, 257);
            this.label14.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Settings Write Count";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(10, 240);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Serial";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(10, 223);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "System Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(10, 206);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Knob Mode";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(10, 189);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "User Mode";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(10, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "System Mode";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(10, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Last Command";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(10, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Light Feed Back";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(10, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Equalizer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(10, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fan Speed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(10, 70);
            this.label18.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "5V Ref Voltage";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(10, 87);
            this.label19.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Input Voltage";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LEDTemp
            // 
            this.LEDTemp.AutoSize = true;
            this.LEDTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEDTemp.Location = new System.Drawing.Point(126, 2);
            this.LEDTemp.Margin = new System.Windows.Forms.Padding(2);
            this.LEDTemp.Name = "LEDTemp";
            this.LEDTemp.Size = new System.Drawing.Size(145, 13);
            this.LEDTemp.TabIndex = 16;
            this.LEDTemp.Text = "-";
            this.LEDTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LEDSensor
            // 
            this.LEDSensor.AutoSize = true;
            this.LEDSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEDSensor.Location = new System.Drawing.Point(126, 19);
            this.LEDSensor.Margin = new System.Windows.Forms.Padding(2);
            this.LEDSensor.Name = "LEDSensor";
            this.LEDSensor.Size = new System.Drawing.Size(145, 13);
            this.LEDSensor.TabIndex = 19;
            this.LEDSensor.Text = "-";
            this.LEDSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoardTemp
            // 
            this.BoardTemp.AutoSize = true;
            this.BoardTemp.BackColor = System.Drawing.SystemColors.Control;
            this.BoardTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardTemp.Location = new System.Drawing.Point(126, 36);
            this.BoardTemp.Margin = new System.Windows.Forms.Padding(2);
            this.BoardTemp.Name = "BoardTemp";
            this.BoardTemp.Size = new System.Drawing.Size(145, 13);
            this.BoardTemp.TabIndex = 20;
            this.BoardTemp.Text = "-";
            this.BoardTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoardSensor
            // 
            this.BoardSensor.AutoSize = true;
            this.BoardSensor.BackColor = System.Drawing.SystemColors.Control;
            this.BoardSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardSensor.Location = new System.Drawing.Point(126, 53);
            this.BoardSensor.Margin = new System.Windows.Forms.Padding(2);
            this.BoardSensor.Name = "BoardSensor";
            this.BoardSensor.Size = new System.Drawing.Size(145, 13);
            this.BoardSensor.TabIndex = 21;
            this.BoardSensor.Text = "-";
            this.BoardSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefVoltage
            // 
            this.RefVoltage.AutoSize = true;
            this.RefVoltage.BackColor = System.Drawing.SystemColors.Control;
            this.RefVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefVoltage.Location = new System.Drawing.Point(126, 70);
            this.RefVoltage.Margin = new System.Windows.Forms.Padding(2);
            this.RefVoltage.Name = "RefVoltage";
            this.RefVoltage.Size = new System.Drawing.Size(145, 13);
            this.RefVoltage.TabIndex = 22;
            this.RefVoltage.Text = "-";
            this.RefVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputVoltage
            // 
            this.InputVoltage.AutoSize = true;
            this.InputVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputVoltage.Location = new System.Drawing.Point(126, 87);
            this.InputVoltage.Margin = new System.Windows.Forms.Padding(2);
            this.InputVoltage.Name = "InputVoltage";
            this.InputVoltage.Size = new System.Drawing.Size(145, 13);
            this.InputVoltage.TabIndex = 23;
            this.InputVoltage.Text = "-";
            this.InputVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FanSpeed
            // 
            this.FanSpeed.AutoSize = true;
            this.FanSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FanSpeed.Location = new System.Drawing.Point(126, 104);
            this.FanSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.FanSpeed.Name = "FanSpeed";
            this.FanSpeed.Size = new System.Drawing.Size(145, 13);
            this.FanSpeed.TabIndex = 25;
            this.FanSpeed.Text = "-";
            this.FanSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Equalizer
            // 
            this.Equalizer.AutoSize = true;
            this.Equalizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equalizer.Location = new System.Drawing.Point(126, 121);
            this.Equalizer.Margin = new System.Windows.Forms.Padding(2);
            this.Equalizer.Name = "Equalizer";
            this.Equalizer.Size = new System.Drawing.Size(145, 13);
            this.Equalizer.TabIndex = 24;
            this.Equalizer.Text = "-";
            this.Equalizer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LightFeedBack
            // 
            this.LightFeedBack.AutoSize = true;
            this.LightFeedBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightFeedBack.Location = new System.Drawing.Point(126, 138);
            this.LightFeedBack.Margin = new System.Windows.Forms.Padding(2);
            this.LightFeedBack.Name = "LightFeedBack";
            this.LightFeedBack.Size = new System.Drawing.Size(145, 13);
            this.LightFeedBack.TabIndex = 26;
            this.LightFeedBack.Text = "-";
            this.LightFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastCommand
            // 
            this.LastCommand.AutoSize = true;
            this.LastCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastCommand.Location = new System.Drawing.Point(126, 155);
            this.LastCommand.Margin = new System.Windows.Forms.Padding(2);
            this.LastCommand.Name = "LastCommand";
            this.LastCommand.Size = new System.Drawing.Size(145, 13);
            this.LastCommand.TabIndex = 27;
            this.LastCommand.Text = "-";
            this.LastCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SystemMode
            // 
            this.SystemMode.AutoSize = true;
            this.SystemMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemMode.Location = new System.Drawing.Point(126, 172);
            this.SystemMode.Margin = new System.Windows.Forms.Padding(2);
            this.SystemMode.Name = "SystemMode";
            this.SystemMode.Size = new System.Drawing.Size(145, 13);
            this.SystemMode.TabIndex = 28;
            this.SystemMode.Text = "-";
            this.SystemMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserModeLabel
            // 
            this.UserModeLabel.AutoSize = true;
            this.UserModeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserModeLabel.Location = new System.Drawing.Point(126, 189);
            this.UserModeLabel.Margin = new System.Windows.Forms.Padding(2);
            this.UserModeLabel.Name = "UserModeLabel";
            this.UserModeLabel.Size = new System.Drawing.Size(145, 13);
            this.UserModeLabel.TabIndex = 29;
            this.UserModeLabel.Text = "-";
            this.UserModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KnobMode
            // 
            this.KnobMode.AutoSize = true;
            this.KnobMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KnobMode.Location = new System.Drawing.Point(126, 206);
            this.KnobMode.Margin = new System.Windows.Forms.Padding(2);
            this.KnobMode.Name = "KnobMode";
            this.KnobMode.Size = new System.Drawing.Size(145, 13);
            this.KnobMode.TabIndex = 30;
            this.KnobMode.Text = "-";
            this.KnobMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SystemDate
            // 
            this.SystemDate.AutoSize = true;
            this.SystemDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemDate.Location = new System.Drawing.Point(126, 223);
            this.SystemDate.Margin = new System.Windows.Forms.Padding(2);
            this.SystemDate.Name = "SystemDate";
            this.SystemDate.Size = new System.Drawing.Size(145, 13);
            this.SystemDate.TabIndex = 31;
            this.SystemDate.Text = "-";
            this.SystemDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Serial
            // 
            this.Serial.AutoSize = true;
            this.Serial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Serial.Location = new System.Drawing.Point(126, 240);
            this.Serial.Margin = new System.Windows.Forms.Padding(2);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(145, 13);
            this.Serial.TabIndex = 32;
            this.Serial.Text = "-";
            this.Serial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsWriteCount
            // 
            this.SettingsWriteCount.AutoSize = true;
            this.SettingsWriteCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsWriteCount.Location = new System.Drawing.Point(126, 257);
            this.SettingsWriteCount.Margin = new System.Windows.Forms.Padding(2);
            this.SettingsWriteCount.Name = "SettingsWriteCount";
            this.SettingsWriteCount.Size = new System.Drawing.Size(145, 13);
            this.SettingsWriteCount.TabIndex = 33;
            this.SettingsWriteCount.Text = "-";
            this.SettingsWriteCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FactoryWriteCount
            // 
            this.FactoryWriteCount.AutoSize = true;
            this.FactoryWriteCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FactoryWriteCount.Location = new System.Drawing.Point(126, 274);
            this.FactoryWriteCount.Margin = new System.Windows.Forms.Padding(2);
            this.FactoryWriteCount.Name = "FactoryWriteCount";
            this.FactoryWriteCount.Size = new System.Drawing.Size(145, 13);
            this.FactoryWriteCount.TabIndex = 34;
            this.FactoryWriteCount.Text = "-";
            this.FactoryWriteCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SPIEraseCount
            // 
            this.SPIEraseCount.AutoSize = true;
            this.SPIEraseCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPIEraseCount.Location = new System.Drawing.Point(126, 291);
            this.SPIEraseCount.Margin = new System.Windows.Forms.Padding(2);
            this.SPIEraseCount.Name = "SPIEraseCount";
            this.SPIEraseCount.Size = new System.Drawing.Size(145, 13);
            this.SPIEraseCount.TabIndex = 35;
            this.SPIEraseCount.Text = "-";
            this.SPIEraseCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.tableLayoutPanel2);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(3);
            this.scrollPanel.Size = new System.Drawing.Size(302, 423);
            this.scrollPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.CurrentStatusRefresh, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.statusTable, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ConnectionRequired, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 533);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // CurrentStatusRefresh
            // 
            this.CurrentStatusRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CurrentStatusRefresh.Controls.Add(this.tableLayoutPanel27);
            this.CurrentStatusRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentStatusRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStatusRefresh.Location = new System.Drawing.Point(3, 96);
            this.CurrentStatusRefresh.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.CurrentStatusRefresh.Name = "CurrentStatusRefresh";
            this.CurrentStatusRefresh.Padding = new System.Windows.Forms.Padding(7);
            this.CurrentStatusRefresh.Size = new System.Drawing.Size(273, 98);
            this.CurrentStatusRefresh.TabIndex = 4;
            this.CurrentStatusRefresh.TabStop = false;
            this.CurrentStatusRefresh.Text = "Current Status";
            this.CurrentStatusRefresh.Visible = false;
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
            this.tableLayoutPanel27.Size = new System.Drawing.Size(259, 63);
            this.tableLayoutPanel27.TabIndex = 2;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(3, 3);
            this.label60.Margin = new System.Windows.Forms.Padding(3);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(253, 26);
            this.label60.TabIndex = 5;
            this.label60.Text = "This is not a live page. Click the button below to retrieve the current status fr" +
    "om the connected unit.";
            // 
            // getSettings
            // 
            this.getSettings.AutoSize = true;
            this.getSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.getSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSettings.Location = new System.Drawing.Point(3, 35);
            this.getSettings.MinimumSize = new System.Drawing.Size(0, 25);
            this.getSettings.Name = "getSettings";
            this.getSettings.Size = new System.Drawing.Size(253, 25);
            this.getSettings.TabIndex = 6;
            this.getSettings.Text = "Refresh Page";
            this.getSettings.UseVisualStyleBackColor = true;
            this.getSettings.Click += new System.EventHandler(this.getSettings_Click);
            // 
            // ConnectionRequired
            // 
            this.ConnectionRequired.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectionRequired.Controls.Add(this.tableLayoutPanel26);
            this.ConnectionRequired.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectionRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionRequired.Location = new System.Drawing.Point(3, 3);
            this.ConnectionRequired.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ConnectionRequired.Name = "ConnectionRequired";
            this.ConnectionRequired.Padding = new System.Windows.Forms.Padding(7);
            this.ConnectionRequired.Size = new System.Drawing.Size(273, 80);
            this.ConnectionRequired.TabIndex = 38;
            this.ConnectionRequired.TabStop = false;
            this.ConnectionRequired.Text = "Connection Required";
            this.ConnectionRequired.Visible = false;
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
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(259, 45);
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
            this.label59.Size = new System.Drawing.Size(253, 39);
            this.label59.TabIndex = 5;
            this.label59.Text = "You must be connected to a unit with Ethernet with any Firmware, or by USB with F" +
    "irmware V1.12 to display live unit status.";
            // 
            // formStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 423);
            this.Controls.Add(this.scrollPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.formStatus_Load);
            this.statusTable.ResumeLayout(false);
            this.statusTable.PerformLayout();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.CurrentStatusRefresh.ResumeLayout(false);
            this.CurrentStatusRefresh.PerformLayout();
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.ConnectionRequired.ResumeLayout(false);
            this.ConnectionRequired.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel statusTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label ErrorLogCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label LEDTemp;
        private System.Windows.Forms.Label LEDSensor;
        private System.Windows.Forms.Label BoardTemp;
        private System.Windows.Forms.Label BoardSensor;
        private System.Windows.Forms.Label RefVoltage;
        private System.Windows.Forms.Label InputVoltage;
        private System.Windows.Forms.Label FanSpeed;
        private System.Windows.Forms.Label Equalizer;
        private System.Windows.Forms.Label LightFeedBack;
        private System.Windows.Forms.Label LastCommand;
        private System.Windows.Forms.Label SystemMode;
        private System.Windows.Forms.Label UserModeLabel;
        private System.Windows.Forms.Label KnobMode;
        private System.Windows.Forms.Label SystemDate;
        private System.Windows.Forms.Label Serial;
        private System.Windows.Forms.Label SettingsWriteCount;
        private System.Windows.Forms.Label FactoryWriteCount;
        private System.Windows.Forms.Label SPIEraseCount;
        private System.Windows.Forms.Panel scrollPanel;
        private GrowGroupbox ConnectionRequired;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private GrowGroupbox CurrentStatusRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button getSettings;
    }
}
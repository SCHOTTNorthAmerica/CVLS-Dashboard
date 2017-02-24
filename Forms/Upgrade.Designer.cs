using SCHOTT.WinForms.Controls.Group_Boxes;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    partial class Upgrade
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
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExceptionLogs = new GrowGroupbox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.logsRead = new System.Windows.Forms.Button();
            this.logsClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.logStatus = new System.Windows.Forms.Label();
            this.LoginRequired = new GrowGroupbox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Firmware = new GrowGroupbox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.firmwareSPIProgress = new System.Windows.Forms.ProgressBar();
            this.firmwareSPIButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firmwareUnit = new System.Windows.Forms.Label();
            this.firmwareLatest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firmwareVersions = new System.Windows.Forms.ComboBox();
            this.Connection = new GrowGroupbox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.label59 = new System.Windows.Forms.Label();
            this.scrollPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ExceptionLogs.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.LoginRequired.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Firmware.SuspendLayout();
            this.table.SuspendLayout();
            this.Connection.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.tableLayoutPanel1);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(3);
            this.scrollPanel.Size = new System.Drawing.Size(287, 506);
            this.scrollPanel.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ExceptionLogs, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LoginRequired, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Firmware, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Connection, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 479);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // ExceptionLogs
            // 
            this.ExceptionLogs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExceptionLogs.Controls.Add(this.tableLayoutPanel3);
            this.ExceptionLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExceptionLogs.Location = new System.Drawing.Point(3, 358);
            this.ExceptionLogs.Name = "ExceptionLogs";
            this.ExceptionLogs.Size = new System.Drawing.Size(275, 118);
            this.ExceptionLogs.TabIndex = 41;
            this.ExceptionLogs.TabStop = false;
            this.ExceptionLogs.Text = "Exception Logs";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.logsRead, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.logsClear, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.logStatus, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(269, 83);
            this.tableLayoutPanel3.TabIndex = 40;
            // 
            // logsRead
            // 
            this.logsRead.AutoSize = true;
            this.logsRead.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.SetColumnSpan(this.logsRead, 2);
            this.logsRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.logsRead.Location = new System.Drawing.Point(6, 25);
            this.logsRead.Name = "logsRead";
            this.logsRead.Size = new System.Drawing.Size(257, 23);
            this.logsRead.TabIndex = 25;
            this.logsRead.Text = "Read Logs";
            this.logsRead.UseVisualStyleBackColor = true;
            this.logsRead.Click += new System.EventHandler(this.logsRead_Click);
            // 
            // logsClear
            // 
            this.logsClear.AutoSize = true;
            this.logsClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.SetColumnSpan(this.logsClear, 2);
            this.logsClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.logsClear.Location = new System.Drawing.Point(6, 54);
            this.logsClear.Name = "logsClear";
            this.logsClear.Size = new System.Drawing.Size(257, 23);
            this.logsClear.TabIndex = 26;
            this.logsClear.Text = "Clear Logs";
            this.logsClear.UseVisualStyleBackColor = true;
            this.logsClear.Click += new System.EventHandler(this.logsClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Current Log";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logStatus
            // 
            this.logStatus.AutoSize = true;
            this.logStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logStatus.Location = new System.Drawing.Point(74, 3);
            this.logStatus.Name = "logStatus";
            this.logStatus.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.logStatus.Size = new System.Drawing.Size(189, 19);
            this.logStatus.TabIndex = 28;
            this.logStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginRequired
            // 
            this.LoginRequired.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginRequired.Controls.Add(this.tableLayoutPanel2);
            this.LoginRequired.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginRequired.Location = new System.Drawing.Point(3, 96);
            this.LoginRequired.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LoginRequired.Name = "LoginRequired";
            this.LoginRequired.Padding = new System.Windows.Forms.Padding(7);
            this.LoginRequired.Size = new System.Drawing.Size(275, 67);
            this.LoginRequired.TabIndex = 40;
            this.LoginRequired.TabStop = false;
            this.LoginRequired.Text = "Admin Access Required";
            this.LoginRequired.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(261, 32);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "You must be logged in with Admin rights to upgrade the firmware.";
            // 
            // Firmware
            // 
            this.Firmware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Firmware.Controls.Add(this.table);
            this.Firmware.Dock = System.Windows.Forms.DockStyle.Top;
            this.Firmware.Location = new System.Drawing.Point(3, 176);
            this.Firmware.Name = "Firmware";
            this.Firmware.Size = new System.Drawing.Size(275, 176);
            this.Firmware.TabIndex = 27;
            this.Firmware.TabStop = false;
            this.Firmware.Text = "Firmware";
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Controls.Add(this.firmwareSPIProgress, 0, 3);
            this.table.Controls.Add(this.firmwareSPIButton, 0, 4);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.firmwareUnit, 1, 1);
            this.table.Controls.Add(this.firmwareLatest, 1, 0);
            this.table.Controls.Add(this.label4, 0, 2);
            this.table.Controls.Add(this.firmwareVersions, 1, 2);
            this.table.Dock = System.Windows.Forms.DockStyle.Top;
            this.table.Location = new System.Drawing.Point(3, 16);
            this.table.Name = "table";
            this.table.Padding = new System.Windows.Forms.Padding(3);
            this.table.RowCount = 5;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.Size = new System.Drawing.Size(269, 141);
            this.table.TabIndex = 40;
            // 
            // firmwareSPIProgress
            // 
            this.table.SetColumnSpan(this.firmwareSPIProgress, 2);
            this.firmwareSPIProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.firmwareSPIProgress.Location = new System.Drawing.Point(6, 83);
            this.firmwareSPIProgress.Name = "firmwareSPIProgress";
            this.firmwareSPIProgress.Size = new System.Drawing.Size(257, 23);
            this.firmwareSPIProgress.TabIndex = 24;
            // 
            // firmwareSPIButton
            // 
            this.firmwareSPIButton.AutoSize = true;
            this.firmwareSPIButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table.SetColumnSpan(this.firmwareSPIButton, 2);
            this.firmwareSPIButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.firmwareSPIButton.Location = new System.Drawing.Point(6, 112);
            this.firmwareSPIButton.Name = "firmwareSPIButton";
            this.firmwareSPIButton.Size = new System.Drawing.Size(257, 23);
            this.firmwareSPIButton.TabIndex = 25;
            this.firmwareSPIButton.Text = "Update Firmware";
            this.firmwareSPIButton.UseVisualStyleBackColor = true;
            this.firmwareSPIButton.Click += new System.EventHandler(this.firmwareSPIButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Latest Firmware Version";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Unit Firmware Version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firmwareUnit
            // 
            this.firmwareUnit.AutoSize = true;
            this.firmwareUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.firmwareUnit.Location = new System.Drawing.Point(131, 31);
            this.firmwareUnit.Margin = new System.Windows.Forms.Padding(3);
            this.firmwareUnit.Name = "firmwareUnit";
            this.firmwareUnit.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.firmwareUnit.Size = new System.Drawing.Size(132, 19);
            this.firmwareUnit.TabIndex = 26;
            // 
            // firmwareLatest
            // 
            this.firmwareLatest.AutoSize = true;
            this.firmwareLatest.Dock = System.Windows.Forms.DockStyle.Top;
            this.firmwareLatest.Location = new System.Drawing.Point(131, 6);
            this.firmwareLatest.Margin = new System.Windows.Forms.Padding(3);
            this.firmwareLatest.Name = "firmwareLatest";
            this.firmwareLatest.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.firmwareLatest.Size = new System.Drawing.Size(132, 19);
            this.firmwareLatest.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Firmware to Upload";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firmwareVersions
            // 
            this.firmwareVersions.Dock = System.Windows.Forms.DockStyle.Top;
            this.firmwareVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmwareVersions.FormattingEnabled = true;
            this.firmwareVersions.Location = new System.Drawing.Point(131, 56);
            this.firmwareVersions.Name = "firmwareVersions";
            this.firmwareVersions.Size = new System.Drawing.Size(132, 21);
            this.firmwareVersions.TabIndex = 27;
            // 
            // Connection
            // 
            this.Connection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Connection.Controls.Add(this.tableLayoutPanel26);
            this.Connection.Dock = System.Windows.Forms.DockStyle.Top;
            this.Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection.Location = new System.Drawing.Point(3, 3);
            this.Connection.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(7);
            this.Connection.Size = new System.Drawing.Size(275, 80);
            this.Connection.TabIndex = 39;
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
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(261, 45);
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
            this.label59.Size = new System.Drawing.Size(255, 39);
            this.label59.TabIndex = 5;
            this.label59.Text = "You must be connected to a unit with Firmware V1.14 or later, or by Ethernet, to " +
    "upgrade the firmware.";
            // 
            // Upgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 506);
            this.Controls.Add(this.scrollPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "Upgrade";
            this.Text = "Upgrade";
            this.Load += new System.EventHandler(this.form_Load);
            this.VisibleChanged += new System.EventHandler(this.formUnitDiagnostics_VisibleChanged);
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ExceptionLogs.ResumeLayout(false);
            this.ExceptionLogs.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.LoginRequired.ResumeLayout(false);
            this.LoginRequired.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Firmware.ResumeLayout(false);
            this.Firmware.PerformLayout();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar firmwareSPIProgress;
        private System.Windows.Forms.Button firmwareSPIButton;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label firmwareLatest;
        private GrowGroupbox Firmware;
        private System.Windows.Forms.Label firmwareUnit;
        private GrowGroupbox Connection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.Label label59;
        private GrowGroupbox LoginRequired;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox firmwareVersions;
        private GrowGroupbox ExceptionLogs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button logsRead;
        private System.Windows.Forms.Button logsClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label logStatus;
    }
}
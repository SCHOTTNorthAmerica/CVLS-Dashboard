using SCHOTT.WinForms.Controls.TextBoxes;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    partial class CommDialog
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.msgClear = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.command = new System.Windows.Forms.TextBox();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.MessageBox = new AdvancedRichTextBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.command, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.MessageBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(279, 317);
            this.tableLayoutPanel3.TabIndex = 65;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.msgClear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.send, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 31);
            this.tableLayoutPanel1.TabIndex = 64;
            // 
            // msgClear
            // 
            this.msgClear.AutoSize = true;
            this.msgClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.msgClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.msgClear.Location = new System.Drawing.Point(139, 3);
            this.msgClear.MinimumSize = new System.Drawing.Size(0, 25);
            this.msgClear.Name = "msgClear";
            this.msgClear.Size = new System.Drawing.Size(131, 25);
            this.msgClear.TabIndex = 63;
            this.msgClear.Text = "Clear";
            this.msgClear.UseVisualStyleBackColor = true;
            this.msgClear.Click += new System.EventHandler(this.msgClear_Click);
            // 
            // send
            // 
            this.send.AutoSize = true;
            this.send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.send.Dock = System.Windows.Forms.DockStyle.Top;
            this.send.Location = new System.Drawing.Point(3, 3);
            this.send.MinimumSize = new System.Drawing.Size(0, 25);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(130, 25);
            this.send.TabIndex = 64;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // command
            // 
            this.command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.command.Location = new System.Drawing.Point(3, 257);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(273, 20);
            this.command.TabIndex = 65;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.tableLayoutPanel3);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(279, 317);
            this.scrollPanel.TabIndex = 66;
            // 
            // MessageBox
            // 
            this.MessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBox.Location = new System.Drawing.Point(3, 3);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MessageBox.Size = new System.Drawing.Size(273, 248);
            this.MessageBox.TabIndex = 66;
            this.MessageBox.Text = "";
            // 
            // formCommDialog
            // 
            this.AcceptButton = this.send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 317);
            this.Controls.Add(this.scrollPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "CommDialog";
            this.Text = "Comm Dialog";
            this.Load += new System.EventHandler(this.formCommDialog_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.scrollPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button msgClear;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Panel scrollPanel;
        private AdvancedRichTextBox MessageBox;
    }
}
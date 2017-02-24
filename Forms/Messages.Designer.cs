using SCHOTT.WinForms.Controls.TextBoxes;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    partial class Messages
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
            this.msgClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MessageBox = new AdvancedRichTextBox();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgClear
            // 
            this.msgClear.AutoSize = true;
            this.msgClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.msgClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.msgClear.Location = new System.Drawing.Point(3, 297);
            this.msgClear.MinimumSize = new System.Drawing.Size(0, 25);
            this.msgClear.Name = "msgClear";
            this.msgClear.Size = new System.Drawing.Size(228, 25);
            this.msgClear.TabIndex = 63;
            this.msgClear.Text = "Clear";
            this.msgClear.UseVisualStyleBackColor = true;
            this.msgClear.Click += new System.EventHandler(this.msgClear_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.MessageBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.msgClear, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 325);
            this.tableLayoutPanel3.TabIndex = 64;
            // 
            // MessageBox
            // 
            this.MessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBox.Location = new System.Drawing.Point(3, 3);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MessageBox.Size = new System.Drawing.Size(228, 288);
            this.MessageBox.TabIndex = 67;
            this.MessageBox.Text = "";
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.tableLayoutPanel3);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(234, 325);
            this.scrollPanel.TabIndex = 64;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 325);
            this.Controls.Add(this.scrollPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "Messages";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.formMessages_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.scrollPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button msgClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel scrollPanel;
        private AdvancedRichTextBox MessageBox;
    }
}
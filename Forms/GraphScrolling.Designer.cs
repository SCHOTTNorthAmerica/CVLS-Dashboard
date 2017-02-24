namespace SCHOTT.CVLS.Dashboard.Forms
{
    partial class GraphScrolling
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
            this.components = new System.ComponentModel.Container();
            this.graphDisplay = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // graphDisplay
            // 
            this.graphDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphDisplay.IsEnableHZoom = false;
            this.graphDisplay.Location = new System.Drawing.Point(0, 0);
            this.graphDisplay.Name = "graphDisplay";
            this.graphDisplay.ScrollGrace = 0D;
            this.graphDisplay.ScrollMaxX = 0D;
            this.graphDisplay.ScrollMaxY = 0D;
            this.graphDisplay.ScrollMaxY2 = 0D;
            this.graphDisplay.ScrollMinX = 0D;
            this.graphDisplay.ScrollMinY = 0D;
            this.graphDisplay.ScrollMinY2 = 0D;
            this.graphDisplay.Size = new System.Drawing.Size(330, 264);
            this.graphDisplay.TabIndex = 2;
            this.graphDisplay.ContextMenuBuilder += new ZedGraph.ZedGraphControl.ContextMenuBuilderEventHandler(this.graphDisplay_ContextMenuBuilder);
            // 
            // formGraphScrolling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 264);
            this.Controls.Add(this.graphDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "GraphScrolling";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGraphScrolling_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.formGraphScrolling_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private ZedGraph.ZedGraphControl graphDisplay;
    }
}
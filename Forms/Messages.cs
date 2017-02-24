using System;
using System.Windows.Forms;
using SCHOTT.WinForms.Controls.TextBoxes;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    public partial class Messages : DockContent
    {
        public Messages()
        {
            InitializeComponent();
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }
        
        private void formMessages_Load(object sender, EventArgs e)
        {
            var controlMonitor = new DetectEnterExit(scrollPanel);
            controlMonitor.ControlEnter += ControlMonitor_ControlEnter;
        }

        private void ControlMonitor_ControlEnter(Control pnl)
        {
            MessageBox.Focus();
        }
        
        private void msgClear_Click(object sender, EventArgs e)
        {
            MessageBox.ClearMessages();
        }

        public AdvancedRichTextBox GetMessageBox => MessageBox;

    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SCHOTT.Core.Utilities;
using SCHOTT.CVLS.Serial;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    public partial class CommDialog : DockContent
    {
        private readonly CVLSThreadedComPort _cvlsThreadedComPortRef;

        public CommDialog(CVLSThreadedComPort cvlsThreadedComPort, string title)
        {
            InitializeComponent();
            Text = title;

            // store com reference
            _cvlsThreadedComPortRef = cvlsThreadedComPort;
            _cvlsThreadedComPortRef.RegisterMessageOutput(MessageBroker.MessageContext.NewThreadToGui, message => MessageBox.WriteLine(message));
            
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }
        
        private void formCommDialog_Load(object sender, EventArgs e)
        {
            var controlMonitor = new DetectEnterExit(scrollPanel);
            controlMonitor.ControlEnter += ControlMonitor_ControlEnter;
        }
        
        private void ControlMonitor_ControlEnter(Control pnl)
        {
            MessageBox.Focus();
        }
        
        #region Events

        private string _lastCommand = "";
        private void send_Click(object sender, EventArgs e)
        {
            if (command.Text.Length > 0)
            {
                _lastCommand = command.Text.Replace("\\r", "\r");
                command.Text = "";
            }
            var commands = new List<string>();
            commands.AddRange(_lastCommand.Split(new[] { ';', '\r' }, StringSplitOptions.RemoveEmptyEntries));
            foreach (var comm in commands)
            {
                _cvlsThreadedComPortRef.SendCommand(comm, echoComTraffic: true);
            }
        }

        private void msgClear_Click(object sender, EventArgs e)
        {
            MessageBox.ClearMessages();
        }

        #endregion

    }
}

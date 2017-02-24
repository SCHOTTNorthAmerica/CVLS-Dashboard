using System;
using System.Drawing;
using System.Windows.Forms;
using SCHOTT.Core.Communication.Serial;
using SCHOTT.Core.Utilities;
using SCHOTT.CVLS.Dashboard.Utilities;
using SCHOTT.CVLS.Enums;
using SCHOTT.CVLS.Ethernet.Binary;
using SCHOTT.CVLS.Ethernet.Discovery;
using SCHOTT.CVLS.Serial;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    public partial class Connections : DockContent
    {
        private readonly BinarySocket _binarySocketRef;
        private readonly CVLSThreadedComPort _cvlsThreadedComPortRef;
        private readonly Discovery _discovery;
        private readonly ConnectionSettings _settings;

        public Connections(CVLSThreadedComPort cvlsThreadedComPort, BinarySocket binarySocket, ConnectionSettings settingsRef)
        {
            InitializeComponent();

            // apply the settings file
            _settings = settingsRef;
            socketAddress.Text = _settings.HostName;
            socketPort.Text = _settings.HostPort;

            _binarySocketRef = binarySocket;
            _binarySocketRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => UpdateControls());
            _binarySocketRef.RegisterLoginUpdate(MessageBroker.MessageContext.NewThreadToGui, args => UpdateLogin());

            _cvlsThreadedComPortRef = cvlsThreadedComPort;
            _cvlsThreadedComPortRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => UpdateComStatus());
            UpdateComStatus();

            PopulateCommList();
            commList.SelectedIndex = 0;

            _discovery = new Discovery();
            _discovery.RegisterDiscoveredUnit(MessageBroker.MessageContext.NewThreadToGui, DiscoveryAddUint);
            _discovery.RegisterListeningStatusUpdate(MessageBroker.MessageContext.NewThreadToGui, UpdateListenerStatus);
            _discovery.DiscoverDevices();

        }

        private void UpdateLogin()
        {
            if (_binarySocketRef.AdminPermissions == BinarySocket.LoginPermissions.LoggedIn)
            {
                loginMessage.Text = @"Logged in as Admin Level";
                loginMessage.BackColor = Color.LimeGreen;
            }
            else if (_binarySocketRef.UserPermissions == BinarySocket.LoginPermissions.LoggedIn)
            {
                loginMessage.Text = @"Logged in as User Level";
                loginMessage.BackColor = Color.LimeGreen;
            }
            else
            {
                loginMessage.Text = @"Not Logged In";
                loginMessage.BackColor = Color.Red;
            }
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }
        
        private void formConnections_Load(object sender, EventArgs e)
        {
            var controlMonitor = new DetectEnterExit(scrollPanel);
            controlMonitor.ControlEnter += ControlMonitor_ControlEnter;
        }

        private void ControlMonitor_ControlEnter(Control pnl)
        {
            scrollPanel.Focus();
        }

        #region Internal Functions

        private void PopulateCommList()
        {
            var current = commList.Text;

            commList.Items.Clear();
            commList.Items.Add(new ComPortInfo { Name = "Auto Connect (USB Only)" });
            commList.Items.Add(new ComPortInfo { Name = "Auto Connect (Rs232 Only)" });
            commList.Items.Add(new ComPortInfo { Name = "Auto Connect (Any Com Port)" });

            ComPortInfo.GetDescriptions().ForEach(s => commList.Items.Add(s));

            commList.DisplayMember = "Name";

            commList.SelectedIndex = commList.Items.IndexOf(current);
        }

        private void UpdateComMode()
        {
            switch (((ComPortInfo)commList.SelectedItem).Name)
            {
                case "Auto Connect (Any Com Port)":
                    _cvlsThreadedComPortRef.ChangeMode(CVLSPortType.Usb | CVLSPortType.Rs232);
                    break;

                case "Auto Connect (USB Only)":
                    _cvlsThreadedComPortRef.ChangeMode(CVLSPortType.Usb);
                    break;

                case "Auto Connect (Rs232 Only)":
                    _cvlsThreadedComPortRef.ChangeMode(CVLSPortType.Rs232);
                    break;
                    
                default:
                    _cvlsThreadedComPortRef.ChangeMode(((ComPortInfo)commList.SelectedItem).Port);
                    break;
            }
        }
        
        private void UpdateComStatus()
        {
            if (_cvlsThreadedComPortRef.IsConnected)
            {
                usbStatus.Text = $@"Connected to {_cvlsThreadedComPortRef.PortName}";
                usbStatus.BackColor = Color.LimeGreen;
            }
            else
            {
                usbStatus.Text = @"ComPort Not Detected";
                usbStatus.BackColor = Color.Red;
            }
        }

        private void UpdateListenerStatus(bool listening)
        {
            stopDiscover.Enabled = listening;
        }
        
        private void UpdateControls()
        {
            if (_binarySocketRef.IsConnected)
            {
                socketAddress.Text = _binarySocketRef.IpEndpoint.Address.ToString();
                socketPort.Text = _binarySocketRef.IpEndpoint.Port.ToString();
                socketConnectBtn.Enabled = false;
                socketDisconnectBtn.Enabled = true;
                login.Enabled = true;
                logout.Enabled = true;
                socketAddress.Enabled = false;
                socketPort.Enabled = false;
            }
            else
            {
                socketDisconnectBtn.Enabled = false;
                login.Enabled = false;
                logout.Enabled = false;
                socketConnectBtn.Enabled = true;
                socketAddress.Enabled = true;
                socketPort.Enabled = true;
                loginMessage.Text = @"Not Logged In";
                loginMessage.BackColor = Color.Red;
            }
        }

        #endregion
        
        #region Events

        #region Unit Discovery
        
        private void DiscoveryAddUint(DiscoveryObject args)
        {
            ListViewItem newUnit;

            if (args.Firmware != null)
            {
                newUnit = new ListViewItem(new[]
                {
                    args.IpAddress,
                    args.HostName,
                    args.MacAddress,
                    args.Serial,
                    args.Firmware,
                    args.Model,
                    args.StatusObject.TemperatureLed.Temperature.ToString("0.0"),
                    EnumConversion.ThermistorIndicatorStrings[(int) args.StatusObject.TemperatureLed.ThermistorStatus],
                    args.StatusObject.TemperatureBoard.Temperature.ToString("0.0"),
                    EnumConversion.ThermistorIndicatorStrings[(int) args.StatusObject.TemperatureBoard.ThermistorStatus],
                    args.StatusObject.VoltageRefOut.Voltage.ToString("0.0"),
                    args.StatusObject.VoltageInput.Voltage.ToString("0.0"),
                    args.StatusObject.Fan.Speed != 0 ? args.StatusObject.Fan.Speed.ToString() : "Off",
                    args.StatusObject.System.Mode == Enums.SystemMode.Equalizer
                        ? EnumConversion.EqualizerStrings[(int) args.StatusObject.Equalizer.Mode]
                        : "Off",
                    EnumConversion.SystemModeStrings[(int) args.StatusObject.System.Mode],
                    args.StatusObject.System.LightFeedBack.ToString(),
                    EnumConversion.CommandSourceStrings[(int) args.StatusObject.System.LastCommandSource],
                    EnumConversion.UserModeStrings[(int) args.StatusObject.System.UserMode],
                    EnumConversion.KnobControlStrings[(int) args.StatusObject.System.KnobMode],
                    args.StatusObject.System.Time.TimeString
                });

                var i = 6;
                newUnit.UseItemStyleForSubItems = false;
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(args.StatusObject.TemperatureLed.Status);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(args.StatusObject.TemperatureLed.ThermistorStatus);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(args.StatusObject.TemperatureBoard.Status);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(args.StatusObject.TemperatureBoard.ThermistorStatus);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(args.StatusObject.VoltageRefOut.Status);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(args.StatusObject.VoltageInput.Status);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(args.StatusObject.Fan.Status);
                newUnit.SubItems[i++].BackColor = args.StatusObject.System.Mode == Enums.SystemMode.Equalizer ?
                    EnumConversion.StatusColor(args.StatusObject.Equalizer.Status) :
                    EnumConversion.StatusColor(StatusIndicators.Off);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                newUnit.SubItems[i++].BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
                newUnit.SubItems[i].BackColor = EnumConversion.StatusColor(StatusIndicators.Info);
            }
            else
            {
                newUnit = new ListViewItem(new[]
                {
                    args.IpAddress,
                    args.HostName,
                    args.MacAddress,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                });
            }

            listView1.Items.Add(newUnit);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //if (Globals.ethernetAutoConnect && !BinarySocketRef.IsConnected)
            //    BinarySocketRef.Connect(args.IPAddress);
        }
        
        private void stopDiscover_Click(object sender, EventArgs e)
        {
            _discovery.ListenerStop();
        }

        private void discover_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            _discovery.DiscoverDevices();
        }

        #endregion

        #region Binary Socket

        private void socketAddress_TextChanged(object sender, EventArgs e)
        {
            _settings.HostName = socketAddress.Text;
        }

        private void socketPort_TextChanged(object sender, EventArgs e)
        {
            _settings.HostPort = socketPort.Text;
        }

        private void socketDisconnectBtn_Click(object sender, EventArgs e)
        {
            _binarySocketRef.Disconnect();
        }

        private void socketConnectBtn_Click(object sender, EventArgs e)
        {
            if (socketPort.Text.Length > 0)
            {
                _binarySocketRef.Connect(socketAddress.Text, socketPort.Text);
            }
            else
            {
                _binarySocketRef.Connect(socketAddress.Text);
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            GlobalFunctions.BinaryLogin(_binarySocketRef);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            _binarySocketRef.Logout();
        }
        
        #endregion
        
        #region Form Events

        private void commList_DropDown(object sender, EventArgs e)
        {
            PopulateCommList();
        }

        private void commList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComMode();
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            var info = listView1.HitTest(e.X, e.Y);
            var item = info.Item;

            if (!socketAddress.Enabled)
                return;

            if (item != null)
            {
                socketAddress.Text = item.Text;
            }
            else
            {
                listView1.SelectedItems.Clear();
                socketAddress.Text = "";
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var info = listView1.HitTest(e.X, e.Y);
            var item = info.Item;

            if (item != null)
            {
                System.Diagnostics.Process.Start("http://" + item.Text);
            }
            else
            {
                listView1.SelectedItems.Clear();
            }
        }

        #endregion

        #endregion
        
    }

    public class ConnectionSettings
    {
        public string HostName { get; set; } = "192.168.0.2";
        public string HostPort { get; set; } = "5000";
    }

}

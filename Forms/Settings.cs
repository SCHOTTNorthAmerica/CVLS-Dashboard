using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using SCHOTT.Core.Communication.Ethernet;
using SCHOTT.Core.Utilities;
using SCHOTT.CVLS.Dashboard.Utilities;
using SCHOTT.CVLS.Ethernet.Binary;
using SCHOTT.CVLS.Ethernet.Binary.Enums;
using SCHOTT.CVLS.Serial;
using SCHOTT.CVLS.Utilities;
using SCHOTT.WinForms.Controls.Buttons;
using SCHOTT.WinForms.Controls.Utilities;
using SCHOTT.WinForms.Dialogs;
using SCHOTT.WinForms.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    public partial class Settings : DockContent
    {
        private readonly BinarySocket _binarySocketRef;
        private readonly CVLSThreadedComPort _cvlsThreadedComPortRef;
        
        public Settings(CVLSThreadedComPort cvlsThreadedComPort, BinarySocket binarySocket)
        {
            InitializeComponent();
            DisplayControls();

            _binarySocketRef = binarySocket;
            _binarySocketRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());
            _binarySocketRef.RegisterLoginUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());

            _cvlsThreadedComPortRef = cvlsThreadedComPort;
            _cvlsThreadedComPortRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => DisplayControls());
            
        }

        protected override string GetPersistString()
        {
            return Docking.GetDockingString(this);
        }
        
        private void formControls_Load(object sender, EventArgs e)
        {
            var controlMonitor = new DetectEnterExit(scrollPanel);
            controlMonitor.ControlEnter += ControlMonitor_ControlEnter;
        }

        private void ControlMonitor_ControlEnter(Control pnl)
        {
            scrollPanel.Focus();
        }

        #region Display Functions

        public void ResizeTable()
        {
            typeof(Control).GetMethod("OnResize",
             BindingFlags.Instance | BindingFlags.NonPublic)
             .Invoke(formLayoutPanel, new object[] { EventArgs.Empty });
        }

        private void DisplayControls()
        {
            if (_binarySocketRef?.IsConnected == true)
            {
                Connection.Visible = false;

                if (_binarySocketRef?.AdminPermissions == BinarySocket.LoginPermissions.Disabled)
                {
                    UserLevel.Visible = true;

                    DisplaySubControls(false);
                }
                else
                {
                    UserLevel.Visible = false;

                    DisplaySubControls(true);
                }
            }
            else if(_cvlsThreadedComPortRef?.IsConnected == true)
            {
                UserLevel.Visible = false;
                Connection.Visible = false;

                DisplaySubControls(true);

                RefreshPage();
            }
            else
            {
                UserLevel.Visible = false;
                Connection.Visible = true;

                DisplaySubControls(false);
            }

            formLayoutPanel.Invalidate();
        }

        private void DisplaySubControls(bool display)
        {
            CurrentSettings.Visible = display;
            scrollPanel.Visible = display;
        }

        #endregion

        #region Utility Functions
        
        public void RefreshPage()
        {
            Cursor.Current = Cursors.WaitCursor;

            if (_binarySocketRef.IsConnected && (_binarySocketRef.AdminPermissions != BinarySocket.LoginPermissions.Disabled))
            {
                var settings = _binarySocketRef.GetSettings();
                if (settings == null)
                {
                    CrossThreadDialogs.MessageBoxBlocking(new DialogConfiguration
                    {
                        Message = "Unable to get settings from unit. Please try again!",
                        Title = "Socket Error!"
                    });
                    return;
                }

                enableLoginTimeout.ToggleSet(settings.GeneralLoginTimeoutEnable);
                LoginTimeoutSlider.Value = settings.GeneralLoginTimeoutMinutes;

                requireUser.ToggleSet(settings.GeneralRequireUser);
                requireAdmin.ToggleSet(settings.GeneralRequireAdmin);
                enableSavePrompt.ToggleSet(settings.GeneralAllowSavePassword);
                enableFrontControls.ToggleSet(settings.GeneralLockoutFront);
                enableMultiport.ToggleSet(settings.GeneralLockoutMultiport);
                
                hostName.Text = settings.NetworkHostname;

                enableDHCP.ToggleSet(settings.NetworkDhcpEnabled);

                ipAddress.Text = settings.NetworkIpAddress;
                buttonIPAddress.Text = settings.NetworkDhcpIpAddress;
                subnetMask.Text = settings.NetworkSubnetMask;
                buttonSubnetMask.Text = settings.NetworkDhcpSubnetMask;
                gateway.Text = settings.NetworkGateway;
                buttonGateway.Text = settings.NetworkDhcpGateway;
                primaryDNS.Text = settings.NetworkPrimaryDns;
                buttonPrimaryDNS.Text = settings.NetworkDhcpPrimaryDns;
                secondaryDNS.Text = settings.NetworkSecondaryDns;
                buttonSecondaryDNS.Text = settings.NetworkDhcpSecondaryDns;

                enableLegacySocket.ToggleSet(settings.SocketsLegacyEnable);
                legacyPort.Value = settings.SocketsLegacyPort;

                enableBinarySocket.ToggleSet(settings.SocketsBinaryEnable);
                binaryPort.Value = settings.SocketsBinaryPort;

                baudRate.SelectedIndex = (int)settings.UartBaudrate;
                stopBits.SelectedIndex = (int)settings.UartStopBits;
                parity.SelectedIndex = (int)settings.UartParity;
            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                #region Set Controls

                try
                {
                    mainLayoutTable.Enabled = false;

                    enableLoginTimeout.ToggleSet(_cvlsThreadedComPortRef.SendCommandSingle("&hte?").Contains("&hte1"));
                    LoginTimeoutSlider.Value = int.Parse(_cvlsThreadedComPortRef.SendCommandSingle("&ht?").Substring(3));

                    requireUser.ToggleSet(_cvlsThreadedComPortRef.SendCommandSingle("&hrc?").Contains("&hrc1"));
                    requireAdmin.ToggleSet(_cvlsThreadedComPortRef.SendCommandSingle("&hra?").Contains("&hra1"));
                    enableSavePrompt.ToggleSet(_cvlsThreadedComPortRef.SendCommandSingle("&hs?").Contains("&hs1"));
                    enableFrontControls.ToggleSet(_cvlsThreadedComPortRef.SendCommandSingle("&hlf?").Contains("&hlf1"));
                    enableMultiport.ToggleSet(_cvlsThreadedComPortRef.SendCommandSingle("&hlm?").Contains("&hlm1"));

                    hostName.Text = _cvlsThreadedComPortRef.SendCommandSingle("&ah?").Substring(3);
                    enableDHCP.ToggleSet(_cvlsThreadedComPortRef.SendCommandSingle("&am?").Contains("&am1"));

                    ipAddress.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&ais?").Substring(4));
                    buttonIPAddress.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&aid?").Substring(4));

                    subnetMask.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&ass?").Substring(4));
                    buttonSubnetMask.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&asd?").Substring(4));

                    gateway.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&ags?").Substring(4));
                    buttonGateway.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&agd?").Substring(4));

                    primaryDNS.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&ads?").Substring(4));
                    buttonPrimaryDNS.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&add?").Substring(4));
                    
                    secondaryDNS.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&aes?").Substring(4));
                    buttonSecondaryDNS.Text = Network.CleanIp(_cvlsThreadedComPortRef.SendCommandSingle("&aed?").Substring(4));

                    enableLegacySocket.ToggleSet(_cvlsThreadedComPortRef.SendCommandSingle("&ale?").Contains("&ale1"));
                    legacyPort.Value = int.Parse(_cvlsThreadedComPortRef.SendCommandSingle("&alp?").Substring(4));

                    enableBinarySocket.ToggleSet(_cvlsThreadedComPortRef.SendCommandSingle("&abe?").Contains("&abe1"));
                    binaryPort.Value = int.Parse(_cvlsThreadedComPortRef.SendCommandSingle("&abp?").Substring(4));

                    baudRate.SelectedIndex = int.Parse(_cvlsThreadedComPortRef.SendCommandSingle("&ub?").Substring(3));
                    stopBits.SelectedIndex = int.Parse(_cvlsThreadedComPortRef.SendCommandSingle("&us?").Substring(3));
                    parity.SelectedIndex = int.Parse(_cvlsThreadedComPortRef.SendCommandSingle("&up?").Substring(3));

                    mainLayoutTable.Enabled = true;

                }
                catch (Exception)
                {
                    //CrossThreadDialogs.MessageBoxBlocking(new DialogConfiguration
                    //{
                    //    Message = "Unable to set all control values!",
                    //    Title = "Refresh Page Error!"
                    //});
                }

                #endregion
            }
            
            Cursor.Current = Cursors.Default;
        }

        public void WritePage()
        {
            var restartStack = false;
            var restartUart = false;
            var settingsChanged = false;

            Cursor.Current = Cursors.WaitCursor;

            if (_binarySocketRef.IsConnected && (_binarySocketRef.AdminPermissions != BinarySocket.LoginPermissions.Disabled))
            {
                // get current values for validation
                var currentSettings = _binarySocketRef.GetSettings();

                try
                {
                    #region Set Values

                    if (requireAdmin.ToggleGet() != currentSettings.GeneralRequireAdmin)
                    {
                        if (requireAdmin.ToggleGet() && !currentSettings.GeneralRequireAdmin)
                        {
                            // we didn't have admin requirements before, but will after which will mess up writing settings
                            // warn the user and exit the method

                            CrossThreadDialogs.MessageBoxBlocking(new DialogConfiguration
                            {
                                Message =
                                    "You have selected to require admin logins. You are not currently logged in as an admin, " +
                                    "so all of the settings would not be applied correctly. Please Log In before writing settings to memory.",
                                Title = "User Level Error"
                            });

                            Cursor.Current = Cursors.Default;
                            return;
                        }

                        settingsChanged = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsLoginRequireAdmin, true,
                            new List<byte> { (byte)(requireAdmin.ToggleGet() ? 1 : 0) });
                    }

                    if (enableLoginTimeout.ToggleGet() != currentSettings.GeneralLoginTimeoutEnable)
                    {
                        settingsChanged = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsLoginTimeoutEnable, true, 
                            new List<byte> { (byte)(enableLoginTimeout.ToggleGet() ? 1 : 0) });
                    }

                    if (LoginTimeoutSlider.Value != currentSettings.GeneralLoginTimeoutMinutes)
                    {
                        settingsChanged = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsLoginTimeoutMinutes, true, 
                            new List<byte> { (byte)LoginTimeoutSlider.Value }); 
                    }

                    if (requireUser.ToggleGet() != currentSettings.GeneralRequireUser)
                    {
                        settingsChanged = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsLoginRequireUser, true,
                            new List<byte> { (byte)(requireUser.ToggleGet() ? 1 : 0) });
                    }

                    if (enableSavePrompt.ToggleGet() != currentSettings.GeneralAllowSavePassword)
                    {
                        settingsChanged = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsLoginAllowRememberPassword, true,
                            new List<byte> { (byte)(enableSavePrompt.ToggleGet() ? 1 : 0) });
                    }

                    if (enableFrontControls.ToggleGet() != currentSettings.GeneralLockoutFront)
                    {
                        settingsChanged = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsLockoutFrontControlsEnabled, true,
                            new List<byte> { (byte)(enableFrontControls.ToggleGet() ? 1 : 0) });
                    }

                    if (enableMultiport.ToggleGet() != currentSettings.GeneralLockoutMultiport)
                    {
                        settingsChanged = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsLockoutMultiportControlsEnabled, true,
                            new List<byte> { (byte)(enableMultiport.ToggleGet() ? 1 : 0) });
                    }

                    


                    if (hostName.Text != currentSettings.NetworkHostname)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsNetworkHostname, true,
                            System.Text.Encoding.UTF8.GetBytes(hostName.Text).ToList());
                    }

                    if (enableDHCP.ToggleGet() != currentSettings.NetworkDhcpEnabled)
                    {
                        settingsChanged = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsNetworkDhcpEnabled, true,
                            new List<byte> { (byte)(enableDHCP.ToggleGet() ? 1 : 0) });
                    }

                    if (ipAddress.Text != currentSettings.NetworkIpAddress)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsNetworkIpAddress, true,
                            System.Text.Encoding.UTF8.GetBytes(ipAddress.Text).ToList());
                    }

                    if (subnetMask.Text != currentSettings.NetworkSubnetMask)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsNetworkMask, true,
                            System.Text.Encoding.UTF8.GetBytes(subnetMask.Text).ToList());
                    }

                    if (gateway.Text != currentSettings.NetworkGateway)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsNetworkGateway, true,
                            System.Text.Encoding.UTF8.GetBytes(gateway.Text).ToList());
                    }

                    if (primaryDNS.Text != currentSettings.NetworkPrimaryDns)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsPrimaryDns, true,
                            System.Text.Encoding.UTF8.GetBytes(primaryDNS.Text).ToList());
                    }

                    if (secondaryDNS.Text != currentSettings.NetworkSecondaryDns)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSettingsSecondaryDns, true,
                            System.Text.Encoding.UTF8.GetBytes(secondaryDNS.Text).ToList());
                    }




                    if (enableLegacySocket.ToggleGet() != currentSettings.SocketsLegacyEnable)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSocketLegacyEnabled, true,
                            new List<byte> { (byte)(enableLegacySocket.ToggleGet() ? 1 : 0) });
                    }

                    if (legacyPort.Value != currentSettings.SocketsLegacyPort)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSocketLegacyPort, true,
                            DataConversions.ConvertUInt16ToList((ushort)legacyPort.Value));
                    }

                    if (enableBinarySocket.ToggleGet() != currentSettings.SocketsBinaryEnable)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSocketBinaryEnabled, true,
                            new List<byte> { (byte)(enableBinarySocket.ToggleGet() ? 1 : 0) });
                    }

                    if (binaryPort.Value != currentSettings.SocketsBinaryPort)
                    {
                        restartStack = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSocketBinaryPort, true,
                            DataConversions.ConvertUInt16ToList((ushort)binaryPort.Value));
                    }





                    if (baudRate.SelectedIndex != (int)currentSettings.UartBaudrate)
                    {
                        restartUart = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminUartBaudRateIndex, true,
                            new List<byte> { (byte)baudRate.SelectedIndex });
                    }

                    if (stopBits.SelectedIndex != (int)currentSettings.UartStopBits)
                    {
                        restartUart = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminUartStopBits, true,
                            new List<byte> { (byte)stopBits.SelectedIndex });
                    }

                    if (parity.SelectedIndex != (int)currentSettings.UartParity)
                    {
                        restartUart = true;
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminUartParity, true,
                            new List<byte> { (byte)parity.SelectedIndex });
                    }
                    
                    #endregion
                    
                    if (settingsChanged || restartUart || restartStack)
                    {
                        _binarySocketRef.SendBinaryCommand(CommandSets.Admin, (ushort)AdminCommands.AdminSaveSettings, true);

                        if (restartUart || restartStack)
                        {
                            var config = new DialogConfiguration
                            {
                                Message = "The unit must be restarted for the new settings to take effect. Would you like to restart the system now?",
                                Title = "Write All Complete",
                                ButtonOptions = MessageBoxButtons.YesNo
                            };

                            if (CrossThreadDialogs.MessageBoxBlocking(config) == DialogResult.Yes)
                            {
                                _binarySocketRef.SendBinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReboot, true);
                            }
                        }
                    }

                    RefreshPage();
                    CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                    {
                        Message = "Write Settings Passed!",
                        Title = "Settings Status"
                    });
                }
                catch (Exception)
                {
                    CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                    {
                        Message = "Write Settings Failed!",
                        Title = "Settings Status"
                    });
                }

            }
            else if (_cvlsThreadedComPortRef.IsConnected)
            {
                try
                {
                    #region Set Values

                    string tempString;

                    string compareString = $"&hte{(enableLoginTimeout.ToggleGet() ? "1" : "0")}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&hte?").Contains(compareString))
                    {
                        settingsChanged = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&ht{LoginTimeoutSlider.Value}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&ht?").Contains(compareString))
                    {
                        settingsChanged = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&hrc{(requireUser.ToggleGet() ? "1" : "0")}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&hrc?").Contains(compareString))
                    {
                        settingsChanged = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&hra{(requireAdmin.ToggleGet() ? "1" : "0")}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&hra?").Contains(compareString))
                    {
                        settingsChanged = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&hs{(enableSavePrompt.ToggleGet() ? "1" : "0")}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&hs?").Contains(compareString))
                    {
                        settingsChanged = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&hlf{(enableFrontControls.ToggleGet() ? "1" : "0")}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&hlf?").Contains(compareString))
                    {
                        settingsChanged = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&hlm{(enableMultiport.ToggleGet() ? "1" : "0")}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&hlm?").Contains(compareString))
                    {
                        settingsChanged = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }

                    compareString = $"&ah{hostName.Text}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&ah?").Contains(compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&am{(enableDHCP.ToggleGet() ? "1" : "0")}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&am?").Contains(compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }

                    compareString = Network.CleanIp(ipAddress.Text);
                    if (!(_cvlsThreadedComPortRef.SendCommandSingleTest("&ais?", "&ais", out tempString, true) && Network.CleanIp(tempString) == compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle("&ais" + compareString);
                    }
                    compareString = Network.CleanIp(subnetMask.Text);
                    if (!(_cvlsThreadedComPortRef.SendCommandSingleTest("&ass?", "&ass", out tempString, true) && Network.CleanIp(tempString) == compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle("&ass" + compareString);
                    }
                    compareString = Network.CleanIp(gateway.Text);
                    if (!(_cvlsThreadedComPortRef.SendCommandSingleTest("&ags?", "&ags", out tempString, true) && Network.CleanIp(tempString) == compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle("&ags" + compareString);
                    }
                    compareString = Network.CleanIp(primaryDNS.Text);
                    if (!(_cvlsThreadedComPortRef.SendCommandSingleTest("&ads?", "&ads", out tempString, true) && Network.CleanIp(tempString) == compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle("&ads" + compareString);
                    }
                    compareString = Network.CleanIp(secondaryDNS.Text);
                    if (!(_cvlsThreadedComPortRef.SendCommandSingleTest("&aes?", "&aes", out tempString, true) && Network.CleanIp(tempString) == compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle("&aes" + compareString);
                    }

                    compareString = $"&ale{(enableLegacySocket.ToggleGet() ? "1" : "0")}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&ale?").Contains(compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&abe{(enableBinarySocket.ToggleGet() ? "1" : "0")}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&abe?").Contains(compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }

                    compareString = $"&alp{legacyPort.Value}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&alp?").Contains(compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&abp{binaryPort.Value}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&abp?").Contains(compareString))
                    {
                        restartStack = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }

                    compareString = $"&ub{baudRate.SelectedIndex}";
                    if (!_cvlsThreadedComPortRef.SendCommandSingle("&ub?").Contains(compareString))
                    {
                        restartUart = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&us{stopBits.SelectedIndex}";
                    if (_cvlsThreadedComPortRef.SendCommandSingle("&us?").Contains(compareString))
                    {
                        restartUart = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }
                    compareString = $"&up{parity.SelectedIndex}";
                    if (_cvlsThreadedComPortRef.SendCommandSingle("&up?").Contains(compareString))
                    {
                        restartUart = true;
                        _cvlsThreadedComPortRef.SendCommandSingle(compareString);
                    }

                    #endregion
                    
                    if (settingsChanged || restartUart || restartStack)
                    {
                        _cvlsThreadedComPortRef.SendCommandSingle("&s");

                        if (restartUart)
                        {
                            _cvlsThreadedComPortRef.SendCommandSingle("&ur");
                        }

                        if (restartStack)
                        {
                            _cvlsThreadedComPortRef.SendCommandSingle("&am2");
                        }
                    }

                    RefreshPage();
                    CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                    {
                        Message = "Write Settings Passed!",
                        Title = "Settings Status"
                    });
                }
                catch (Exception)
                {
                    CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                    {
                        Message = "Write Settings Failed!",
                        Title = "Settings Status"
                    });
                }
            }
            
            Cursor.Current = Cursors.Default;

        }

        #endregion

        #region Events
        
        private void login_Click(object sender, EventArgs e)
        {
            GlobalFunctions.BinaryLogin(_binarySocketRef);
        }

        private void getSettings_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void writeSettings_Click(object sender, EventArgs e)
        {
            WritePage();
        }

        private void enableAdminToggle_Click(object sender, EventArgs e)
        {
            ((ToggleButton)sender).Toggle();

            if (_binarySocketRef.IsConnected && (_binarySocketRef.AdminPermissions != BinarySocket.LoginPermissions.LoggedIn))
            {
                CrossThreadDialogs.MessageBoxNonBlocking(new DialogConfiguration
                {
                    Message = "You have selected to require admin logins. You are not currently logged in as an admin, " +
                    "so all of the settings would not be applied correctly. Please Log In before writing settings to memory.",
                    Title = "User Level Error"
                });
            }
        }

        private void enableToggle_Click(object sender, EventArgs e)
        {
            ((ToggleButton)sender).Toggle();
        }

        private void buttonIPAddress_Click(object sender, EventArgs e)
        {
            ipAddress.Text = buttonIPAddress.Text;
        }

        private void buttonSubnetMask_Click(object sender, EventArgs e)
        {
            subnetMask.Text = buttonSubnetMask.Text;
        }

        private void buttonGateway_Click(object sender, EventArgs e)
        {
            gateway.Text = buttonGateway.Text;
        }

        private void buttonPrimaryDNS_Click(object sender, EventArgs e)
        {
            primaryDNS.Text = buttonPrimaryDNS.Text;
        }

        private void buttonSecondaryDNS_Click(object sender, EventArgs e)
        {
            secondaryDNS.Text = buttonSecondaryDNS.Text;
        }
        
        private void formSettings_VisibleChanged(object sender, EventArgs e)
        {
            DisplayControls();
        }

        #endregion

        private void configurationsWindow_Click(object sender, EventArgs e)
        {

        }
    }
}

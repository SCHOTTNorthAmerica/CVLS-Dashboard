using SCHOTT.Core.Extensions;
using SCHOTT.Core.Settings;
using SCHOTT.Core.Threading;
using SCHOTT.CVLS.Dashboard.Dialogs;
using SCHOTT.CVLS.Dashboard.Forms;
using SCHOTT.CVLS.Dashboard.PluginInterface;
using SCHOTT.CVLS.Dashboard.Utilities;
using SCHOTT.CVLS.Ethernet.Binary;
using SCHOTT.CVLS.Ethernet.Binary.Enums;
using SCHOTT.CVLS.Serial;
using SCHOTT.WinForms.Dialogs;
using SCHOTT.WinForms.Docking;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SCHOTT.CVLS.Dashboard
{
    public partial class Dashboard : Form
    {
        private readonly ClosingWorker _closingWorker;
        private readonly Docking _dockingObject;

        // main application settings
        private readonly ApplicationSettings _applicationSettings = new ApplicationSettings();
        
        // Threaded Support Items
        private readonly BinarySocket _unitBinarySocket;
        private readonly CVLSThreadedComPort _unitComPort;
        
        public Dashboard()
        {
            InitializeComponent();

            // initialize docking
            _dockingObject = new Docking(this, dockPanel, menuStrip1);

            // load form position
            _applicationSettings.ReadSettings();
            _applicationSettings.FormSettings.LoadLocation(this);

            // this allows dialogs to be called from the DLLs
            CrossThreadDialogs.InitializeDialogs(this);

            // establish the closing worker
            _closingWorker = new ClosingWorker();

            // start child threads
            _unitBinarySocket = new BinarySocket("Binary Socket", _closingWorker);
            _unitComPort = new CVLSThreadedComPort("Com Port", _closingWorker, CVLSPortType.Usb);
            
            // Modify form title to swhow application and firmware versions
            AppendDashboardVersionToFormTitle();
            AppendFirmwareVersionToFormTitle();

            // initialize all forms
            InitializeDockableForms();

            // redirect console output to message window
            var consoleOutput = new AdvancedStringWriter(true, true);
            consoleOutput.Flushed += ConsoleOutput_Flushed;
            Console.SetOut(consoleOutput);

            // initialize all plugins
            InitializePlugins();

            // subscribe to form events
            Application.Idle += OnLoaded;
            FormClosing += Dashboard_FormClosing;
        }

        private void ConsoleOutput_Flushed(object sender, EventArgs args)
        {
            ((Messages)_dockingObject.GetForm("Messages")).GetMessageBox.WriteLine(sender.ToString());
        }

        private void InitializePlugins()
        {
            var dashboardInterfaceType = typeof(IDashboard);
            var pluginFiles = Directory.GetFiles(Application.StartupPath, "*.DLL", SearchOption.AllDirectories).ToList();
            var dashboardPlugins = new List<IDashboard>();
            Assembly assembly = null;

            foreach (var file in pluginFiles.Where(a=>a.Contains("Tester")).ToList())
            {
                try
                {
                    var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);

                    if (fileNameWithoutExtension != null )
                        assembly = Assembly.Load(fileNameWithoutExtension);

                    if (assembly == null)
                        continue;

                    var types = assembly.GetTypes().Where(t => dashboardInterfaceType.IsAssignableFrom(t) && !t.IsInterface).ToList();
                    types.ForEach(t =>
                    {
                        dashboardPlugins.Add((IDashboard)Activator.CreateInstance(t));
                    });
                }
                catch
                {
                    // ignored
                }
            }

            dashboardPlugins.ForEach(p => 
            {
                p.InitializePlugin(_closingWorker, _dockingObject, _unitBinarySocket, _unitComPort);
            });
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;
            if (!_dockingObject.LoadLayout())
                _dockingObject.LoadLayout(Layouts.Layouts.GetStream("CustomerLayout.xml"));

            // because the controls, configurations, and settings forms have many elements that resize themselves, 
            // they cannot size properly until the layout has been loaded. This calls the resize
            // functions to make sure they look right on load.
            ((Settings)_dockingObject.GetForm("Settings")).ResizeTable();
            ((ControlsForm)_dockingObject.GetForm("Controls")).ResizeTable();
            ((Configurations)_dockingObject.GetForm("Configurations")).ResizeTable();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save current settings
            _applicationSettings.FormSettings.SaveLocation(this);
            _applicationSettings.WriteSettings();
            _dockingObject.SaveLayout();

            // run the closing worker until all child threads are closed
            _closingWorker.WaitForThreadsToCloseDialogOutput();
        }
        
        #region Initialization Functions

        [Conditional("DEBUG")]
        public void AppendDebugToFormTitle()
        {
            Text += @" - Debug Mode";
        }

        public void AppendDashboardVersionToFormTitle()
        {
            Text += $@" V{Assembly.GetEntryAssembly().GetName().Version.Major}.{Assembly.GetEntryAssembly().GetName().Version.Minor}";
        }

        public void AppendFirmwareVersionToFormTitle()
        {
            Text += $@" - Firmware V{CustomerFirmware.CurrentVersion}";
        }

        private void InitializeDockableForms()
        {
            #region Setup Forms

            _dockingObject.AddForm(new Settings(_unitComPort, _unitBinarySocket));
            _dockingObject.AddForm(new ControlsForm(_dockingObject, _unitComPort, _unitBinarySocket));
            _dockingObject.AddForm(new Upgrade(_unitComPort, _unitBinarySocket));
            _dockingObject.AddForm(new Configurations(_unitComPort, _unitBinarySocket));
            _dockingObject.AddForm(new CommDialog(_unitComPort, "Comm Dialog"));
            _dockingObject.AddForm(new Status(_unitComPort, _unitBinarySocket));
            _dockingObject.AddForm(new Connections(_unitComPort, _unitBinarySocket, _applicationSettings.ConnectionSettings));
            _dockingObject.AddForm(new Messages());

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportBuffer))
            {
                Text = @"Buffer State",
                YAxisTitle = "% Full",
                YAxisMax = 100
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportFault))
            {
                Text = @"Fault Output",
                YAxisTitle = "State",
                YAxisMin = -0.5,
                YAxisMax = 1.5,
                GraphLabels = new[] { "Grounded", "Floating" }
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportLedTemp))
            {
                Text = @"LED Temperature",
                YAxisTitle = "Temperature (C)",
                YAxisMin = -40,
                YAxisMax = 120
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportBoardTemp))
            {
                Text = @"Board Temperature",
                YAxisTitle = "Temperature (C)",
                YAxisMin = -40,
                YAxisMax = 120
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportFanSpeed))
            {
                Text = @"Fan Speed",
                YAxisTitle = "Speed (1000x RPM)",
                YAxisMax = 25
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportLightFeedBack))
            {
                Text = @"Light Feed Back",
                YAxisTitle = "Counts",
                YAxisMax = 4095
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportEqualizerLightFeedBack))
            {
                Text = @"Equalizer Light Feed Back",
                YAxisTitle = "Counts",
                YAxisMax = 4095
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportEqualizerOutputPower))
            {
                Text = @"Equalizer Output Power",
                YAxisTitle = "Power (%)",
                YAxisMax = 100
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportEqualizerStatus))
            {
                Text = @"Equalizer Status",
                YAxisTitle = "",
                YAxisMin = -0.5,
                YAxisMax = 10.5,
                GraphLabels = new[] { "Off", "Locked", "Initializing", "", "Light Low", "", "Light High", "", "Over Range", "", "Under Range" }
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReport5VMonitor))
            {
                Text = @"5V Output Monitor",
                YAxisTitle = "Output (V)",
                YAxisMin = 4,
                YAxisMax = 6
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReport24VMonitor))
            {
                Text = @"Input Voltage Monitor",
                YAxisTitle = "Input Voltage (V)",
                YAxisMin = 16,
                YAxisMax = 32
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportFrontKnob))
            {
                Text = @"Front Knob Position",
                YAxisTitle = "Value (%)",
                YAxisMin = -5,
                YAxisMax = 105
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportFrontSwitch))
            {
                Text = @"Front Switch State",
                YAxisTitle = "State",
                YAxisMin = -0.5,
                YAxisMax = 1.5,
                GraphLabels = new[] { "Released", "Pressed" }
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportMultiportAnalogCh1))
            {
                Text = @"Multiport Analog CH 1",
                YAxisTitle = "Value (%)",
                YAxisMin = -5,
                YAxisMax = 105
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportMultiportAnalogCh2))
            {
                Text = @"Multiport Analog CH 2",
                YAxisTitle = "Value (%)",
                YAxisMin = -5,
                YAxisMax = 105
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportMultiportAnalogCh3))
            {
                Text = @"Multiport Analog CH 3",
                YAxisTitle = "Value (%)",
                YAxisMin = -5,
                YAxisMax = 105
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportMultiportAnalogCh4))
            {
                Text = @"Multiport Analog CH 4",
                YAxisTitle = "Value (%)",
                YAxisMin = -5,
                YAxisMax = 105
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportMultiportDigitalCh1))
            {
                Text = @"Multiport Digital CH 1 State",
                YAxisTitle = "State",
                YAxisMin = -0.5,
                YAxisMax = 1.5,
                GraphLabels = new[] { "Low", "High" }
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportMultiportDigitalCh2))
            {
                Text = @"Multiport Digital CH 2 State",
                YAxisTitle = "State",
                YAxisMin = -0.5,
                YAxisMax = 1.5,
                GraphLabels = new[] { "Low", "High" }
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportMultiportDigitalCh3))
            {
                Text = @"Multiport Digital CH 3 State",
                YAxisTitle = "State",
                YAxisMin = -0.5,
                YAxisMax = 1.5,
                GraphLabels = new[] { "Low", "High" }
            });

            _dockingObject.AddForm(new GraphScrolling(_unitBinarySocket, new BinaryCommand(CommandSets.System, (ushort)SystemCommands.SystemReportMultiportDigitalCh4))
            {
                Text = @"Multiport Digital CH 4 State",
                YAxisTitle = "State",
                YAxisMin = -0.5,
                YAxisMax = 1.5,
                GraphLabels = new[] { "Low", "High" }
            });

            #endregion
        }

        #endregion

        #region Utility Functions

        private void SetFrequencies(int index)
        {
            _dockingObject.DockedForms.Where(f => f is GraphScrolling)
                .Cast<GraphScrolling>()
                .ToList()
                .ForEach(g => g.PollingFrequencyIndex = (byte)index);
        }

        private void SetRefreshRates(int hz)
        {
            _dockingObject.DockedForms.Where(f => f is GraphScrolling)
                .Cast<GraphScrolling>()
                .ToList()
                .ForEach(g => g.RefreshHertz = hz);
        }

        private void SetTimespans(int seconds)
        {
            _dockingObject.DockedForms.Where(f => f is GraphScrolling)
                .Cast<GraphScrolling>()
                .ToList()
                .ForEach(g => g.TimeSpanSeconds = seconds);
        }

        private void ShowAllInputGraphs()
        {
            ShowAllDigitalGraphs();
            ShowAllAnalogGraphs();
        }

        private void HideAllInputGraphs()
        {
            HideAllDigitalGraphs();
            HideAllAnalogGraphs();
        }

        private void ShowAllDigitalGraphs()
        {
            _dockingObject.DockedForms.Where(f => f.Text.Contains("Multiport Digital CH") || f.Text.Contains("Front Switch"))
                .ToList()
                .ForEach(g => g.Show(dockPanel));
        }

        private void HideAllDigitalGraphs()
        {
            _dockingObject.DockedForms.Where(f => f.Text.Contains("Multiport Digital CH") || f.Text.Contains("Front Switch"))
                .ToList()
                .ForEach(g => g.Close());
        }

        private void ShowAllAnalogGraphs()
        {
            _dockingObject.DockedForms.Where(f => f.Text.Contains("Multiport Analog CH") || f.Text.Contains("Front Knob"))
                .ToList()
                .ForEach(g => g.Show(dockPanel));
        }

        private void HideAllAnalogGraphs()
        {
            _dockingObject.DockedForms.Where(f => f.Text.Contains("Multiport Analog CH") || f.Text.Contains("Front Knob"))
                .ToList()
                .ForEach(g => g.Close());
        }

        #endregion
        
        #region Events

        private void configurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Configurations");
        }
        
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Settings");
        }

        private void commDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Comm Dialog");
        }

        private void diagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Upgrade");
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Status");
        }
        
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Controls");
        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Connections");
        }

        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Messages");
        }

        private void loadDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.LoadLayout(Layouts.Layouts.GetStream("CustomerLayout.xml"));
        }

        private void bytesInBufferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Buffer State");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Fault Output");
        }

        private void lEDTemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("LED Temperature");
        }

        private void boardTemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Board Temperature");
        }

        private void fanSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Fan Speed");
        }

        private void lightFeedBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Light Feed Back");
        }

        private void equalizerLightFeedBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Equalizer Light Feed Back");
        }

        private void equalizerOutputPowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Equalizer Output Power");
        }

        private void equalizerStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Equalizer Status");
        }

        private void Monitor5VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("5V Output Monitor");
        }

        private void Monitor24VToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Input Voltage Monitor");
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.DockedForms.Where(f => f is GraphScrolling && f.IsActivated == false)
                .Cast<GraphScrolling>()
                .ToList()
                .ForEach(g=>g.Close());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _dockingObject.DockedForms.Where(f => f is GraphScrolling)
                .Cast<GraphScrolling>()
                .ToList()
                .ForEach(g => g.Close());
        }
        
        private void frontKnobToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Front Knob Position");
        }

        private void multiportAnalogCh1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Multiport Analog CH 1");
        }

        private void multiportAnalogCh2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Multiport Analog CH 2");
        }

        private void multiportAnalogCh3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Multiport Analog CH 3");
        }

        private void multiportAnalogCh4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Multiport Analog CH 4");
        }

        private void openAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllAnalogGraphs();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            HideAllAnalogGraphs();
        }

        private void frontSwitchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Front Switch State");
        }

        private void multiportDigitalCh1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Multiport Digital CH 1 State");
        }

        private void multiportDigitalCh2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Multiport Digital CH 2 State");
        }

        private void multiportDigitalCh3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Multiport Digital CH 3 State");
        }

        private void multiportDigitalCh4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _dockingObject.ShowDockedForm("Multiport Digital CH 4 State");
        }

        private void openAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowAllDigitalGraphs();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllDigitalGraphs();
        }
        
        private void SetFrequencyMenuItem_Click(object sender, EventArgs e)
        {
            SetFrequencies(int.Parse(((ToolStripMenuItem)sender).Name.Substring("FrequencyIndex".Length)));
        }
        
        private void SetRefreshRateMenuItem_Click(object sender, EventArgs e)
        {
            SetRefreshRates(int.Parse(((ToolStripMenuItem)sender).Name.Substring("RefreshRate".Length)));
        }

        private void SetTimespanMenuItem_Click(object sender, EventArgs e)
        {
            SetTimespans(int.Parse(((ToolStripMenuItem)sender).Name.Substring("Timespan".Length)));
        }
        
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ShowAllInputGraphs();
        }

        #endregion

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.ResetLayout();
        }

        private void hideAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dockingObject.HideAllForms();
        }

        private void installUSBDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var info = new ProcessStartInfo(Application.StartupPath +
                $@"\Driver\Driver Installer x{(Environment.Is64BitOperatingSystem? "64": "86")}.exe")
            {
                UseShellExecute = true,
                Verb = "runas"
            };

            Process.Start(info);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var licenseInfo = new LicenseInfo(this);
            licenseInfo.ShowDialog();
        }
    }

}

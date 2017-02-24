using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SCHOTT.Core.Extensions;
using SCHOTT.Core.Utilities;
using SCHOTT.CVLS.Enums;
using SCHOTT.CVLS.Ethernet.Binary;
using WeifenLuo.WinFormsUI.Docking;
using ZedGraph;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    public partial class GraphScrolling : DockContent
    {
        private readonly BinarySocket _binarySocketRef;

        private GraphPane _graphPane;
        private PointPairList _graphPoints;
        private LineItem _graphCurve;

        private readonly Timer _refreshTimer;
        private XDate _timeSeed;
        private const int TickMajor = 1;
        private const int TickMinor = 1;
        private readonly TimeSpan _tickSpan = new TimeSpan(0, 0, 0, TickMajor, 0);

        private const int SamplesPerSecond = 5000;
        private const double TimePart = 0.2;
        private int _totalPoints;

        private XDate _currentTime;
        private DateTime _currentDate;
        private double _timeJump;
        
        public GraphScrolling(BinarySocket binarySocket, BinaryCommand pollingCommand)
        {
            InitializeComponent();
            
            // setup class links
            _pollerCommand = new BinaryCommand(pollingCommand.CommandSet, pollingCommand.Command, true); 
            _binarySocketRef = binarySocket;
            _binarySocketRef.RegisterDataPointUpdate((BinarySocket.DataPointOptions)pollingCommand.Command, MessageBroker.MessageContext.DirectToData, AddPoint);
            _binarySocketRef.RegisterConnectionUpdate(MessageBroker.MessageContext.NewThreadToGui, args => { if (args.IsConnected) SendPollingFrequency(); });

            // set default settings
            TimeSpanSeconds = 5;
            PollingFrequencyIndex = 10;

            // create zoom event
            graphDisplay.ZoomEvent += ZoomEvent;
            graphDisplay.GraphPane.YAxis.ScaleFormatEvent += YAxis_ScaleFormatEvent;

            // setup the graph
            InitializeGraph();

            // start the update timer
            _refreshTimer = new Timer();
            _refreshTimer.Tick += RefreshTimer_Tick;
            RefreshHertz = 10;
            _refreshTimer.Start();
        }

        protected override string GetPersistString()
        {
            return GetType() + "," + Text;
        }

        #region Initialization

        private void InitializeGraph()
        {
            // setup the pane variables
            _graphPane = graphDisplay.GraphPane;

            // setup point list variables
            _graphPoints = new PointPairList();

            // setup line variables
            _graphCurve = _graphPane.AddCurve("", _graphPoints, Color.Blue, SymbolType.None);
            GraphLabels = new string[] { };

            // speed up drawing of the line
            _graphCurve.Line.IsOptimizedDraw = true;

            // format title & legend
            _graphPane.Title.IsVisible = true;
            _graphPane.Title.Text = " ";
            _graphPane.Title.FontSpec.Size = 16;
            _graphPane.Legend.IsVisible = false;
            _graphPane.YAxis.Scale.MagAuto = false;

            #region Y axis

            // is axis visible
            _graphPane.YAxis.IsVisible = true;
            _graphPane.YAxis.Scale.Format = "0";
            _graphPane.YAxis.Title.Text = " ";

            // set zero line visiblity
            _graphPane.YAxis.MajorGrid.IsZeroLine = false;

            // set scale range
            _graphPane.YAxis.Scale.Min = 0;
            _graphPane.YAxis.Scale.Max = 5000;

            // if opposite axis is visible, turn on mirrored ticks
            _graphPane.YAxis.MajorTic.IsOpposite = true;
            _graphPane.YAxis.MinorTic.IsOpposite = true;

            // set axis font sizes
            _graphPane.YAxis.Title.FontSpec.Size = 14;
            _graphPane.YAxis.Scale.FontSpec.Size = 12;

            // format axis major tic settings
            _graphPane.YAxis.MajorTic.Size = 4;
            _graphPane.YAxis.MajorTic.Color = Color.Black;
            _graphPane.YAxis.MajorTic.PenWidth = 1;

            // format axis minor tic settings
            _graphPane.YAxis.MinorTic.Size = 2;
            _graphPane.YAxis.MinorTic.Color = Color.Black;
            _graphPane.YAxis.MinorTic.PenWidth = 1;

            // format y axis grid 
            _graphPane.YAxis.MajorGrid.IsVisible = false;
            _graphPane.YAxis.MajorGrid.DashOff = 0;
            _graphPane.YAxis.MajorGrid.Color = Color.Black;
            _graphPane.YAxis.MajorGrid.PenWidth = 1;
            
            #endregion

            #region x axis

            // format labels
            _graphPane.XAxis.Title.IsVisible = false;
            _graphPane.XAxis.Type = AxisType.Date;
            _graphPane.XAxis.Scale.Format = "yyyy/MM/dd\r\nHH:mm:ss:fff";
            _graphPane.XAxis.Scale.FontSpec.Angle = 60;
            _graphPane.XAxis.Scale.FontSpec.Size = 12;

            // format axis grid
            _graphPane.XAxis.MajorGrid.IsVisible = false;
            _graphPane.XAxis.MajorGrid.DashOff = 0;
            _graphPane.XAxis.MajorGrid.Color = Color.Black;
            _graphPane.XAxis.MajorGrid.PenWidth = 1;

            // format axis major tic settings
            _graphPane.XAxis.Scale.MajorUnit = DateUnit.Second;
            _graphPane.XAxis.Scale.MajorStep = TickMajor;
            _graphPane.XAxis.MajorTic.Size = 4;
            _graphPane.XAxis.MajorTic.Color = Color.Black;
            _graphPane.XAxis.MajorTic.PenWidth = 1;

            // format x axis minor tic settings
            _graphPane.XAxis.Scale.MinorUnit = DateUnit.Second;
            _graphPane.XAxis.Scale.MinorStep = TickMinor;
            _graphPane.XAxis.MinorTic.Size = 4;
            _graphPane.XAxis.MinorTic.Color = Color.Black;
            _graphPane.XAxis.MinorTic.PenWidth = 2;

            #endregion
            
        }

        #endregion

        #region Events
        
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            _currentDate = DateTime.Now;
            if (Math.Abs((_currentDate - _currentTime.DateTime).TotalMilliseconds) > 500)
                _currentTime = new XDate(_currentDate);

            RefreshGraph();
        }

        private string YAxis_ScaleFormatEvent(GraphPane pane, Axis axis, double val, int index)
        {
            var i = (int)val;

            if (GraphLabels.Length > 0 && i >= 0 && i < GraphLabels.Length)
            {
                return GraphLabels[i] + " (" + i + ")";
            }

            return val.ToString(CultureInfo.CurrentCulture);
        }

        private void ZoomEvent(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {
            RefreshGraph();
        }

        private void graphDisplay_ContextMenuBuilder(ZedGraphControl sender, ContextMenuStrip menuStrip, Point mousePt, ZedGraphControl.ContextMenuObjectState objState)
        {
            menuStrip.Items.RemoveAt(7);
            menuStrip.Items.RemoveAt(4);
            menuStrip.Items.RemoveAt(3);
            menuStrip.Items.RemoveAt(2);

            var menu = new ToolStripMenuItem("Refresh Rate", null);
            menu.DropDownItems.Add(new ToolStripMenuItem("2 Hz", null, ChangeRefreshRate, "2"));
            menu.DropDownItems.Add(new ToolStripMenuItem("5 Hz", null, ChangeRefreshRate, "5"));
            menu.DropDownItems.Add(new ToolStripMenuItem("10 Hz", null, ChangeRefreshRate, "10"));
            var index = menu.DropDownItems.IndexOfKey(RefreshHertz.ToString());
            if (index >= 0)
            {
                ((ToolStripMenuItem)menu.DropDownItems[index]).Checked = true;
            }
            menuStrip.Items.Insert(0, menu);

            menu = new ToolStripMenuItem("Timespan", null);
            menu.DropDownItems.Add(new ToolStripMenuItem("1 Second", null, ChangeTimespan, "1"));
            menu.DropDownItems.Add(new ToolStripMenuItem("3 Seconds", null, ChangeTimespan, "3"));
            menu.DropDownItems.Add(new ToolStripMenuItem("5 Seconds", null, ChangeTimespan, "5"));
            menu.DropDownItems.Add(new ToolStripMenuItem("10 Seconds", null, ChangeTimespan, "10"));
            index = menu.DropDownItems.IndexOfKey(TimeSpanSeconds.ToString());
            if (index >= 0)
            {
                ((ToolStripMenuItem)menu.DropDownItems[index]).Checked = true;
            }
            menuStrip.Items.Insert(0, menu);

            menu = new ToolStripMenuItem("Polling Rate", null);
            var i = 0;
            menu.DropDownItems.Add(new ToolStripMenuItem("Off", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("5000 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("2500 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("1250 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("1000 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("625 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("500 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("250 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("200 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("125 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("100 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("50 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("40 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("25 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("20 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("10 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("8 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("5 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("4 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("2 Hz", null, ChangePollingFrequencyIndex, i++.ToString()));
            menu.DropDownItems.Add(new ToolStripMenuItem("1 Hz", null, ChangePollingFrequencyIndex, i.ToString()));
            ((ToolStripMenuItem)menu.DropDownItems[PollingFrequencyIndex]).Checked = true;
            menuStrip.Items.Insert(0, menu);
        }

        private void ChangePollingFrequencyIndex(object sender, EventArgs e)
        {
            PollingFrequencyIndex = byte.Parse(((ToolStripItem)sender).Name);
        }

        private void ChangeTimespan(object sender, EventArgs e)
        {
            var name = sender.ToString();
            TimeSpanSeconds = int.Parse(name.Substring(0, name.IndexOf(" ", StringComparison.Ordinal)));
        }

        private void ChangeRefreshRate(object sender, EventArgs e)
        {
            var name = sender.ToString();
            RefreshHertz = int.Parse(name.Substring(0, name.IndexOf(" ", StringComparison.Ordinal)));
        }

        private void formGraphScrolling_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.MdiFormClosing)
                return;

            Hide();
            SendPollingStop();
            e.Cancel = true; // this cancels the close event.
        }

        private void formGraphScrolling_VisibleChanged(object sender, EventArgs e)
        {
            if (!IsHidden)
                SendPollingFrequency();
            else
                SendPollingStop();
        }

        #endregion

        #region Properties

        private readonly BinaryCommand _pollerCommand;

        public string[] GraphLabels { get; set; }

        public string GraphTitle
        {
            get { return _graphPane.Title.Text; }
            set { _graphPane.Title.Text = value; }
        }

        public string YAxisTitle
        {
            get { return _graphPane.YAxis.Title.Text; }
            set { _graphPane.YAxis.Title.Text = value; }
        }

        public double YAxisMin
        {
            get { return _graphPane.YAxis.Scale.Min; }
            set { _graphPane.YAxis.Scale.Min = value; }
        }

        public double YAxisMax
        {
            get { return _graphPane.YAxis.Scale.Max; }
            set { _graphPane.YAxis.Scale.Max = value; }
        }

        public int RefreshHertz
        {
            get { return (int)(1000.0 / _refreshTimer.Interval); }
            set { _refreshTimer.Interval = (int)(1000.0 / value); }
        }

        public int TimeSpanSeconds
        {
            get { return _totalPoints / SamplesPerSecond; }
            set { _totalPoints = value * SamplesPerSecond; }
        }

        private byte _pollingFrequencyIndex;
        public byte PollingFrequencyIndex
        {
            get { return _pollingFrequencyIndex; }
            set
            {
                _pollingFrequencyIndex = value;
                _timeJump = TimePart * EnumConversion.PollerDividers[value];
                SendPollingFrequency();
            }
        }

        #endregion

        #region Graph Data
        
        public void AddPoint(BinarySocket.DataPoint point)
        {
            _currentTime.AddMilliseconds(_timeJump);
            _graphPoints.Add(_currentTime, point.Value, point.CounterIndex);

            if (_graphPoints.Count > _totalPoints)
            {
                _graphPoints.RemoveRange(0, _graphPoints.Count - _totalPoints);
            }
        }

        public void ClearPoints()
        {
            _graphPoints.Clear();
        }

        #endregion

        #region Graph Utilities

        private void SendPollingFrequency()
        {
            _binarySocketRef.SendBinaryCommand(_pollerCommand, new List<byte> { PollingFrequencyIndex });
        }

        private void SendPollingStop()
        {
            _binarySocketRef.SendBinaryCommand(_pollerCommand, new List<byte> { 0 });
        }

        private void RefreshGraph()
        {
            if (_graphPoints.Count > 0)
            {
                // get last date in the data curves
                _timeSeed = _currentTime;
            }

            // set end of the x axis to current time
            _graphPane.XAxis.Scale.Max = _timeSeed;

            // get the minimum date to show the right timespan
            _timeSeed.AddSeconds(-TimeSpanSeconds);
            _graphPane.XAxis.Scale.Min = _timeSeed;

            // set the base tick mark appropriatly
            _graphPane.XAxis.Scale.BaseTic = new XDate(_timeSeed.DateTime.Floor(_tickSpan));

            // set the tick marks for the Y axis
            var yRangeTic = Math.Max(Math.Pow(10, Math.Floor(Math.Log10((_graphPane.YAxis.Scale.Max - _graphPane.YAxis.Scale.Min) * 0.2))), 1);
            _graphPane.YAxis.Scale.BaseTic = Math.Floor(_graphPane.YAxis.Scale.Min / yRangeTic) * yRangeTic;
            _graphPane.YAxis.Scale.MajorStep = yRangeTic;
            _graphPane.YAxis.Scale.MinorStep = yRangeTic;

            // draw the graph
            graphDisplay.Invalidate();
        }

        #endregion
        
    }
}

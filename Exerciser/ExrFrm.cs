// Decompiled with JetBrains decompiler
// Type: Exerciser.ExrFrm
// Assembly: Exerciser, Version=1.7.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A209899A-3E48-4746-B638-8A7F24C27623
// Assembly location: D:\temp\guidetech\Exerciser.exe

using Exerciser.My;
using GT668Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace Exerciser
{
  [DesignerGenerated]
  public class ExrFrm : Form
  {
    private IContainer components;
    [AccessedThroughProperty("MeasCntUD")]
    private NumericUpDown _MeasCntUD;
    [AccessedThroughProperty("MeasCntLbl")]
    private Label _MeasCntLbl;
    [AccessedThroughProperty("FreqOpt")]
    private RadioButton _FreqOpt;
    [AccessedThroughProperty("PeriodOpt")]
    private RadioButton _PeriodOpt;
    [AccessedThroughProperty("TIEOpt")]
    private RadioButton _TIEOpt;
    [AccessedThroughProperty("InitBtn")]
    private Button _InitBtn;
    [AccessedThroughProperty("CfgBtn")]
    private Button _CfgBtn;
    [AccessedThroughProperty("TimeOpt")]
    private RadioButton _TimeOpt;
    [AccessedThroughProperty("RunBtn")]
    private Button _RunBtn;
    [AccessedThroughProperty("MeanLbl")]
    private Label _MeanLbl;
    [AccessedThroughProperty("Mean0Txt")]
    private TextBox _Mean0Txt;
    [AccessedThroughProperty("StdDev0Txt")]
    private TextBox _StdDev0Txt;
    [AccessedThroughProperty("StdDevLbl")]
    private Label _StdDevLbl;
    [AccessedThroughProperty("Min0Txt")]
    private TextBox _Min0Txt;
    [AccessedThroughProperty("MinLbl")]
    private Label _MinLbl;
    [AccessedThroughProperty("Max0Txt")]
    private TextBox _Max0Txt;
    [AccessedThroughProperty("MaxLbl")]
    private Label _MaxLbl;
    [AccessedThroughProperty("Pk0Txt")]
    private TextBox _Pk0Txt;
    [AccessedThroughProperty("PkLbl")]
    private Label _PkLbl;
    [AccessedThroughProperty("Cnt0Txt")]
    private TextBox _Cnt0Txt;
    [AccessedThroughProperty("CntLbl")]
    private Label _CntLbl;
    [AccessedThroughProperty("Cnt1Txt")]
    private TextBox _Cnt1Txt;
    [AccessedThroughProperty("Pk1Txt")]
    private TextBox _Pk1Txt;
    [AccessedThroughProperty("Max1Txt")]
    private TextBox _Max1Txt;
    [AccessedThroughProperty("Min1Txt")]
    private TextBox _Min1Txt;
    [AccessedThroughProperty("StdDev1Txt")]
    private TextBox _StdDev1Txt;
    [AccessedThroughProperty("Mean1Txt")]
    private TextBox _Mean1Txt;
    [AccessedThroughProperty("MeasTmr")]
    private System.Windows.Forms.Timer _MeasTmr;
    [AccessedThroughProperty("ViewBtn")]
    private Button _ViewBtn;
    [AccessedThroughProperty("GraphBtn")]
    private Button _GraphBtn;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("RepeatChk")]
    private CheckBox _RepeatChk;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("RepeatUD")]
    private NumericUpDown _RepeatUD;
    [AccessedThroughProperty("StableBtn")]
    private System.Windows.Forms.Button _StableBtn;
    [AccessedThroughProperty("CalBtn")]
    private Button _CalBtn;
    [AccessedThroughProperty("TimeoutUD")]
    private NumericUpDown _TimeoutUD;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("TimeoutLbl")]
    private Label _TimeoutLbl;
    [AccessedThroughProperty("PreSc1Txt")]
    private TextBox _PreSc1Txt;
    [AccessedThroughProperty("PreSc0Txt")]
    private TextBox _PreSc0Txt;
    [AccessedThroughProperty("PreScLbl")]
    private Label _PreScLbl;
    [AccessedThroughProperty("Thr1Txt")]
    private TextBox _Thr1Txt;
    [AccessedThroughProperty("Thr0Txt")]
    private TextBox _Thr0Txt;
    [AccessedThroughProperty("ThrLbl")]
    private Label _ThrLbl;
    [AccessedThroughProperty("MaxPk1Txt")]
    private TextBox _MaxPk1Txt;
    [AccessedThroughProperty("MaxPk0Txt")]
    private TextBox _MaxPk0Txt;
    [AccessedThroughProperty("MaxPkLbl")]
    private Label _MaxPkLbl;
    [AccessedThroughProperty("MinPk1Txt")]
    private TextBox _MinPk1Txt;
    [AccessedThroughProperty("MinPk0Txt")]
    private TextBox _MinPk0Txt;
    [AccessedThroughProperty("MinPkLbl")]
    private Label _MinPkLbl;
    [AccessedThroughProperty("DevCbo")]
    private ComboBox _DevCbo;
    [AccessedThroughProperty("DevLbl")]
    private Label _DevLbl;
    [AccessedThroughProperty("WrapChk")]
    private CheckBox _WrapChk;
    [AccessedThroughProperty("SaveRawBtn")]
    private Button _SaveRawBtn;
    [AccessedThroughProperty("SaveFileDialog1")]
    private SaveFileDialog _SaveFileDialog1;
    [AccessedThroughProperty("ColTxt")]
    private TextBox _ColTxt;
    [AccessedThroughProperty("ColLbl")]
    private Label _ColLbl;
    [AccessedThroughProperty("ContOpt")]
    private RadioButton _ContOpt;
    [AccessedThroughProperty("InfoBtn")]
    private Button _InfoBtn;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("TIEPnl")]
    private Panel _TIEPnl;
    [AccessedThroughProperty("TIELbl")]
    private Label _TIELbl;
    [AccessedThroughProperty("TIEFreqTxt")]
    private TextBox _TIEFreqTxt;
    [AccessedThroughProperty("TIEFreqOpt")]
    private RadioButton _TIEFreqOpt;
    [AccessedThroughProperty("TIEAutoOpt")]
    private RadioButton _TIEAutoOpt;
    [AccessedThroughProperty("AutoSaveChk")]
    private CheckBox _AutoSaveChk;
    [AccessedThroughProperty("RealTimeTmr")]
    private System.Windows.Forms.Timer _RealTimeTmr;
    [AccessedThroughProperty("RealTimeLbl")]
    private Label _RealTimeLbl;
    [AccessedThroughProperty("UTCLbl")]
    private Label _UTCLbl;
    [AccessedThroughProperty("SyncBtn")]
    private Button _SyncBtn;
    [AccessedThroughProperty("ShowUTCChk")]
    private CheckBox _ShowUTCChk;
    [AccessedThroughProperty("GateLbl")]
    private Label _GateLbl;
    [AccessedThroughProperty("Gate0UD")]
    private NumericUpDown _Gate0UD;
    [AccessedThroughProperty("Gate1UD")]
    private NumericUpDown _Gate1UD;
    [AccessedThroughProperty("DefBtn")]
    private Button _DefBtn;
    [AccessedThroughProperty("BrdLbl")]
    private Label _BrdLbl;
    [AccessedThroughProperty("BrdNumLbl")]
    private Label _BrdNumLbl;
    [AccessedThroughProperty("MapBtn")]
    private Button _MapBtn;
    [AccessedThroughProperty("Timer1")]
    private System.Windows.Forms.Timer _Timer1;
    [AccessedThroughProperty("MasterLbl")]
    private Label _MasterLbl;
    private const double TestCTIResults = 0.0;
    private const uint ReadChunk = 131072;
    private string RecoveredMeas;
    private string RecoveredTIEFreq;
    private GT668Class.GtiRealTime[] RecoveredTimetags0Ex;
    private GT668Class.GtiRealTime[] RecoveredTimetags1Ex;
    private uint[] RecoveredCount;
    private uint[] RecoveredPrescale;
    private uint[] RecoveredNumTags;
    private string[] RecoveredFileName;
    private uint[] RawData;
    private uint RawCount;
    private uint RawRead;
    private uint RawConverted;
    public int Res0Cnt;
    public double[] Results0;
    public double Res0Interval;
    public double[] Time0;
    public int Res1Cnt;
    public double[] Results1;
    public double Res1Interval;
    public double Res1Delta;
    public double[] Time1;
    private bool Initialized;
    private string ConfigFileName;
    private Point CurLoc;
    private bool UserFile;
    private int BrdNum;
    public int NumBoards;
    private int[] Boards;
    private int[] Devices;
    public int DevNum;
    public uint BrdRev;
    public bool ShowCfg;
    public bool ShowResults;
    public bool ShowGraph;
    public bool ShowStable;
    private FileStream StableFile;
    private int StableSaved;
    private string MeasName;
    private string Units;
    private FileStream[] SaveFile;
    private StreamWriter[] SaveWr;
    private StreamReader[] SaveRd;
    private bool running;
    private FormWindowState CurState;
    private bool IgnoreCalErr;
    private int last_digits;
    private double last_interval;
    private bool Recover;
    private double TIEFreq;
    private int FormHeight;
    private bool IsUSB;
    private GT668Class.GtiRefClkSrc LastRef;
    private bool back_door_in_progress;
    private string back_door;
    public bool DebugShow;
    private const string back_door_key = "Debug!1";
        /*
    [SpecialName]
    private Static LocalInitFlag MeasTmr_Tick\u002420211C1249\u0024Corr\u0024Init;
    [SpecialName]
    private Static LocalInitFlag RealTimeTmr_Tick\u002420211C1249\u0024last_sec\u0024Init;
    [SpecialName]
    private Static LocalInitFlag RealTimeTmr_Tick\u002420211C1249\u0024epoch0\u0024Init;
    [SpecialName]
    private double \u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr;
    [SpecialName]
    private bool \u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corrected;
    [SpecialName]
    private uint \u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec;
    [SpecialName]
    private bool \u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError;
    [SpecialName]
    private StaticLocalInitFlag \u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError\u0024Init;
    [SpecialName]
    private DateTime \u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0;
        */
    public ExrFrm()
    {
      this.Load += new EventHandler(this.ExrFrm_Load);
      this.FormClosing += new FormClosingEventHandler(this.ExrFrm_FormClosing);
      this.SizeChanged += new EventHandler(this.ExrFrm_Resize);
      this.LocationChanged += new EventHandler(this.ExrFrm_LocationChanged);
      this.KeyDown += new KeyEventHandler(this.ExrFrm_KeyDown);
      this.KeyPress += new KeyPressEventHandler(this.ExrFrm_KeyPress);
      this.RecoveredCount = new uint[2];
      this.RecoveredPrescale = new uint[2];
      this.RecoveredNumTags = new uint[2];
      this.RecoveredFileName = new string[2];
      this.Initialized = false;
      this.UserFile = false;
      this.BrdNum = -1;
      this.NumBoards = 0;
      this.Boards = new int[32];
      this.Devices = new int[32];
      this.DevNum = -1;
      this.BrdRev = 0U;
      this.MeasName = "Frequency";
      this.Units = "Hz";
      this.SaveFile = new FileStream[2];
      this.SaveWr = new StreamWriter[2];
      this.SaveRd = new StreamReader[2];
      this.running = false;
      this.IgnoreCalErr = false;
      this.last_digits = -1;
      this.last_interval = 0.0;
      this.Recover = false;
      this.TIEFreq = 10000000.0;
      this.FormHeight = 0;
      this.IsUSB = false;
      this.LastRef = GT668Class.GtiRefClkSrc.GT_REF_INTERNAL;
      this.back_door_in_progress = false;
      this.back_door = "";
      this.DebugShow = false;
            /*
      this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr\u0024Init = new StaticLocalInitFlag();
      this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec\u0024Init = new StaticLocalInitFlag();
      this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0\u0024Init = new StaticLocalInitFlag();
      this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError\u0024Init = new StaticLocalInitFlag();
            */
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ExrFrm));
      this.MeasCntUD = new NumericUpDown();
      this.MeasCntLbl = new Label();
      this.FreqOpt = new RadioButton();
      this.PeriodOpt = new RadioButton();
      this.TIEOpt = new RadioButton();
      this.InitBtn = new Button();
      this.CfgBtn = new Button();
      this.TimeOpt = new RadioButton();
      this.RunBtn = new Button();
      this.MeanLbl = new Label();
      this.Mean0Txt = new TextBox();
      this.StdDev0Txt = new TextBox();
      this.StdDevLbl = new Label();
      this.Min0Txt = new TextBox();
      this.MinLbl = new Label();
      this.Max0Txt = new TextBox();
      this.MaxLbl = new Label();
      this.Pk0Txt = new TextBox();
      this.PkLbl = new Label();
      this.Cnt0Txt = new TextBox();
      this.CntLbl = new Label();
      this.Cnt1Txt = new TextBox();
      this.Pk1Txt = new TextBox();
      this.Max1Txt = new TextBox();
      this.Min1Txt = new TextBox();
      this.StdDev1Txt = new TextBox();
      this.Mean1Txt = new TextBox();
      this.MeasTmr = new System.Windows.Forms.Timer(this.components);
      this.ViewBtn = new Button();
      this.GraphBtn = new Button();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.RepeatChk = new CheckBox();
      this.Label3 = new Label();
      this.RepeatUD = new NumericUpDown();
      this.StableBtn = new Button();
      this.CalBtn = new Button();
      this.TimeoutUD = new NumericUpDown();
      this.Label4 = new Label();
      this.TimeoutLbl = new Label();
      this.PreSc1Txt = new TextBox();
      this.PreSc0Txt = new TextBox();
      this.PreScLbl = new Label();
      this.Thr1Txt = new TextBox();
      this.Thr0Txt = new TextBox();
      this.ThrLbl = new Label();
      this.MaxPk1Txt = new TextBox();
      this.MaxPk0Txt = new TextBox();
      this.MaxPkLbl = new Label();
      this.MinPk1Txt = new TextBox();
      this.MinPk0Txt = new TextBox();
      this.MinPkLbl = new Label();
      this.DevCbo = new ComboBox();
      this.DevLbl = new Label();
      this.WrapChk = new CheckBox();
      this.SaveRawBtn = new Button();
      this.SaveFileDialog1 = new SaveFileDialog();
      this.ColTxt = new TextBox();
      this.ColLbl = new Label();
      this.ContOpt = new RadioButton();
      this.InfoBtn = new Button();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.TIEPnl = new Panel();
      this.TIELbl = new Label();
      this.TIEFreqTxt = new TextBox();
      this.TIEFreqOpt = new RadioButton();
      this.TIEAutoOpt = new RadioButton();
      this.AutoSaveChk = new CheckBox();
      this.RealTimeTmr = new System.Windows.Forms.Timer(this.components);
      this.RealTimeLbl = new Label();
      this.UTCLbl = new Label();
      this.SyncBtn = new Button();
      this.ShowUTCChk = new CheckBox();
      this.GateLbl = new Label();
      this.Gate0UD = new NumericUpDown();
      this.Gate1UD = new NumericUpDown();
      this.DefBtn = new Button();
      this.BrdLbl = new Label();
      this.BrdNumLbl = new Label();
      this.MapBtn = new Button();
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.MasterLbl = new Label();
      this.MeasCntUD.BeginInit();
      this.RepeatUD.BeginInit();
      this.TimeoutUD.BeginInit();
      this.TIEPnl.SuspendLayout();
      this.Gate0UD.BeginInit();
      this.Gate1UD.BeginInit();
      this.SuspendLayout();
      NumericUpDown measCntUd1 = this.MeasCntUD;
      Point point1 = new Point(92, 14);
      Point point2 = point1;
      measCntUd1.Location = point2;
      NumericUpDown measCntUd2 = this.MeasCntUD;
      Decimal num1 = new Decimal(new int[4]
      {
        1000000000,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      measCntUd2.Maximum = num2;
      NumericUpDown measCntUd3 = this.MeasCntUD;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num3 = num1;
      measCntUd3.Minimum = num3;
      this.MeasCntUD.Name = "MeasCntUD";
      NumericUpDown measCntUd4 = this.MeasCntUD;
      Size size1 = new Size(119, 20);
      Size size2 = size1;
      measCntUd4.Size = size2;
      this.MeasCntUD.TabIndex = 18;
      NumericUpDown measCntUd5 = this.MeasCntUD;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num4 = num1;
      measCntUd5.Value = num4;
      this.MeasCntLbl.AutoSize = true;
      Label measCntLbl1 = this.MeasCntLbl;
      point1 = new Point(10, 16);
      Point point3 = point1;
      measCntLbl1.Location = point3;
      this.MeasCntLbl.Name = "MeasCntLbl";
      Label measCntLbl2 = this.MeasCntLbl;
      size1 = new Size(76, 13);
      Size size3 = size1;
      measCntLbl2.Size = size3;
      this.MeasCntLbl.TabIndex = 17;
      this.MeasCntLbl.Text = "Measurements";
      this.FreqOpt.AutoSize = true;
      this.FreqOpt.Checked = true;
      RadioButton freqOpt1 = this.FreqOpt;
      point1 = new Point(13, 40);
      Point point4 = point1;
      freqOpt1.Location = point4;
      this.FreqOpt.Name = "FreqOpt";
      RadioButton freqOpt2 = this.FreqOpt;
      size1 = new Size(75, 17);
      Size size4 = size1;
      freqOpt2.Size = size4;
      this.FreqOpt.TabIndex = 19;
      this.FreqOpt.TabStop = true;
      this.FreqOpt.Text = "Frequency";
      this.FreqOpt.UseVisualStyleBackColor = true;
      this.PeriodOpt.AutoSize = true;
      RadioButton periodOpt1 = this.PeriodOpt;
      point1 = new Point(13, 63);
      Point point5 = point1;
      periodOpt1.Location = point5;
      this.PeriodOpt.Name = "PeriodOpt";
      RadioButton periodOpt2 = this.PeriodOpt;
      size1 = new Size(55, 17);
      Size size5 = size1;
      periodOpt2.Size = size5;
      this.PeriodOpt.TabIndex = 20;
      this.PeriodOpt.Text = "Period";
      this.PeriodOpt.UseVisualStyleBackColor = true;
      this.TIEOpt.AutoSize = true;
      RadioButton tieOpt1 = this.TIEOpt;
      point1 = new Point(13, 109);
      Point point6 = point1;
      tieOpt1.Location = point6;
      this.TIEOpt.Name = "TIEOpt";
      RadioButton tieOpt2 = this.TIEOpt;
      size1 = new Size(42, 17);
      Size size6 = size1;
      tieOpt2.Size = size6;
      this.TIEOpt.TabIndex = 21;
      this.TIEOpt.Text = "TIE";
      this.TIEOpt.UseVisualStyleBackColor = true;
      Button initBtn1 = this.InitBtn;
      point1 = new Point(320, 12);
      Point point7 = point1;
      initBtn1.Location = point7;
      this.InitBtn.Name = "InitBtn";
      Button initBtn2 = this.InitBtn;
      size1 = new Size(97, 29);
      Size size7 = size1;
      initBtn2.Size = size7;
      this.InitBtn.TabIndex = 22;
      this.InitBtn.Text = "Initialize";
      this.InitBtn.UseVisualStyleBackColor = true;
      this.CfgBtn.Enabled = false;
      Button cfgBtn1 = this.CfgBtn;
      point1 = new Point(320, 47);
      Point point8 = point1;
      cfgBtn1.Location = point8;
      this.CfgBtn.Name = "CfgBtn";
      Button cfgBtn2 = this.CfgBtn;
      size1 = new Size(97, 29);
      Size size8 = size1;
      cfgBtn2.Size = size8;
      this.CfgBtn.TabIndex = 23;
      this.CfgBtn.Text = "Configure...";
      this.CfgBtn.UseVisualStyleBackColor = true;
      this.TimeOpt.AutoSize = true;
      RadioButton timeOpt1 = this.TimeOpt;
      point1 = new Point(13, 132);
      Point point9 = point1;
      timeOpt1.Location = point9;
      this.TimeOpt.Name = "TimeOpt";
      RadioButton timeOpt2 = this.TimeOpt;
      size1 = new Size(86, 17);
      Size size9 = size1;
      timeOpt2.Size = size9;
      this.TimeOpt.TabIndex = 24;
      this.TimeOpt.Text = "Time Interval";
      this.TimeOpt.UseVisualStyleBackColor = true;
      this.RunBtn.Enabled = false;
      Button runBtn1 = this.RunBtn;
      point1 = new Point(320, 219);
      Point point10 = point1;
      runBtn1.Location = point10;
      this.RunBtn.Name = "RunBtn";
      Button runBtn2 = this.RunBtn;
      size1 = new Size(97, 29);
      Size size10 = size1;
      runBtn2.Size = size10;
      this.RunBtn.TabIndex = 25;
      this.RunBtn.Text = "Run";
      this.RunBtn.UseVisualStyleBackColor = true;
      this.MeanLbl.AutoSize = true;
      Label meanLbl1 = this.MeanLbl;
      point1 = new Point(5, 222);
      Point point11 = point1;
      meanLbl1.Location = point11;
      this.MeanLbl.Name = "MeanLbl";
      Label meanLbl2 = this.MeanLbl;
      size1 = new Size(34, 13);
      Size size11 = size1;
      meanLbl2.Size = size11;
      this.MeanLbl.TabIndex = 26;
      this.MeanLbl.Text = "Mean";
      TextBox mean0Txt1 = this.Mean0Txt;
      point1 = new Point(60, 219);
      Point point12 = point1;
      mean0Txt1.Location = point12;
      this.Mean0Txt.Name = "Mean0Txt";
      this.Mean0Txt.ReadOnly = true;
      TextBox mean0Txt2 = this.Mean0Txt;
      size1 = new Size(122, 20);
      Size size12 = size1;
      mean0Txt2.Size = size12;
      this.Mean0Txt.TabIndex = 27;
      TextBox stdDev0Txt1 = this.StdDev0Txt;
      point1 = new Point(60, 245);
      Point point13 = point1;
      stdDev0Txt1.Location = point13;
      this.StdDev0Txt.Name = "StdDev0Txt";
      this.StdDev0Txt.ReadOnly = true;
      TextBox stdDev0Txt2 = this.StdDev0Txt;
      size1 = new Size(122, 20);
      Size size13 = size1;
      stdDev0Txt2.Size = size13;
      this.StdDev0Txt.TabIndex = 29;
      this.StdDevLbl.AutoSize = true;
      Label stdDevLbl1 = this.StdDevLbl;
      point1 = new Point(5, 248);
      Point point14 = point1;
      stdDevLbl1.Location = point14;
      this.StdDevLbl.Name = "StdDevLbl";
      Label stdDevLbl2 = this.StdDevLbl;
      size1 = new Size(43, 13);
      Size size14 = size1;
      stdDevLbl2.Size = size14;
      this.StdDevLbl.TabIndex = 28;
      this.StdDevLbl.Text = "StdDev";
      TextBox min0Txt1 = this.Min0Txt;
      point1 = new Point(60, 271);
      Point point15 = point1;
      min0Txt1.Location = point15;
      this.Min0Txt.Name = "Min0Txt";
      this.Min0Txt.ReadOnly = true;
      TextBox min0Txt2 = this.Min0Txt;
      size1 = new Size(122, 20);
      Size size15 = size1;
      min0Txt2.Size = size15;
      this.Min0Txt.TabIndex = 31;
      this.MinLbl.AutoSize = true;
      Label minLbl1 = this.MinLbl;
      point1 = new Point(5, 274);
      Point point16 = point1;
      minLbl1.Location = point16;
      this.MinLbl.Name = "MinLbl";
      Label minLbl2 = this.MinLbl;
      size1 = new Size(48, 13);
      Size size16 = size1;
      minLbl2.Size = size16;
      this.MinLbl.TabIndex = 30;
      this.MinLbl.Text = "Minimum";
      TextBox max0Txt1 = this.Max0Txt;
      point1 = new Point(60, 297);
      Point point17 = point1;
      max0Txt1.Location = point17;
      this.Max0Txt.Name = "Max0Txt";
      this.Max0Txt.ReadOnly = true;
      TextBox max0Txt2 = this.Max0Txt;
      size1 = new Size(122, 20);
      Size size17 = size1;
      max0Txt2.Size = size17;
      this.Max0Txt.TabIndex = 33;
      this.MaxLbl.AutoSize = true;
      Label maxLbl1 = this.MaxLbl;
      point1 = new Point(5, 300);
      Point point18 = point1;
      maxLbl1.Location = point18;
      this.MaxLbl.Name = "MaxLbl";
      Label maxLbl2 = this.MaxLbl;
      size1 = new Size(51, 13);
      Size size18 = size1;
      maxLbl2.Size = size18;
      this.MaxLbl.TabIndex = 32;
      this.MaxLbl.Text = "Maximum";
      TextBox pk0Txt1 = this.Pk0Txt;
      point1 = new Point(60, 323);
      Point point19 = point1;
      pk0Txt1.Location = point19;
      this.Pk0Txt.Name = "Pk0Txt";
      this.Pk0Txt.ReadOnly = true;
      TextBox pk0Txt2 = this.Pk0Txt;
      size1 = new Size(122, 20);
      Size size19 = size1;
      pk0Txt2.Size = size19;
      this.Pk0Txt.TabIndex = 35;
      this.PkLbl.AutoSize = true;
      Label pkLbl1 = this.PkLbl;
      point1 = new Point(5, 326);
      Point point20 = point1;
      pkLbl1.Location = point20;
      this.PkLbl.Name = "PkLbl";
      Label pkLbl2 = this.PkLbl;
      size1 = new Size(48, 13);
      Size size20 = size1;
      pkLbl2.Size = size20;
      this.PkLbl.TabIndex = 34;
      this.PkLbl.Text = "Pk to Pk";
      TextBox cnt0Txt1 = this.Cnt0Txt;
      point1 = new Point(60, 349);
      Point point21 = point1;
      cnt0Txt1.Location = point21;
      this.Cnt0Txt.Name = "Cnt0Txt";
      this.Cnt0Txt.ReadOnly = true;
      TextBox cnt0Txt2 = this.Cnt0Txt;
      size1 = new Size(122, 20);
      Size size21 = size1;
      cnt0Txt2.Size = size21;
      this.Cnt0Txt.TabIndex = 37;
      this.CntLbl.AutoSize = true;
      Label cntLbl1 = this.CntLbl;
      point1 = new Point(5, 352);
      Point point22 = point1;
      cntLbl1.Location = point22;
      this.CntLbl.Name = "CntLbl";
      Label cntLbl2 = this.CntLbl;
      size1 = new Size(35, 13);
      Size size22 = size1;
      cntLbl2.Size = size22;
      this.CntLbl.TabIndex = 36;
      this.CntLbl.Text = "Count";
      TextBox cnt1Txt1 = this.Cnt1Txt;
      point1 = new Point(189, 349);
      Point point23 = point1;
      cnt1Txt1.Location = point23;
      this.Cnt1Txt.Name = "Cnt1Txt";
      this.Cnt1Txt.ReadOnly = true;
      TextBox cnt1Txt2 = this.Cnt1Txt;
      size1 = new Size(122, 20);
      Size size23 = size1;
      cnt1Txt2.Size = size23;
      this.Cnt1Txt.TabIndex = 43;
      TextBox pk1Txt1 = this.Pk1Txt;
      point1 = new Point(189, 323);
      Point point24 = point1;
      pk1Txt1.Location = point24;
      this.Pk1Txt.Name = "Pk1Txt";
      this.Pk1Txt.ReadOnly = true;
      TextBox pk1Txt2 = this.Pk1Txt;
      size1 = new Size(122, 20);
      Size size24 = size1;
      pk1Txt2.Size = size24;
      this.Pk1Txt.TabIndex = 42;
      TextBox max1Txt1 = this.Max1Txt;
      point1 = new Point(189, 297);
      Point point25 = point1;
      max1Txt1.Location = point25;
      this.Max1Txt.Name = "Max1Txt";
      this.Max1Txt.ReadOnly = true;
      TextBox max1Txt2 = this.Max1Txt;
      size1 = new Size(122, 20);
      Size size25 = size1;
      max1Txt2.Size = size25;
      this.Max1Txt.TabIndex = 41;
      TextBox min1Txt1 = this.Min1Txt;
      point1 = new Point(189, 271);
      Point point26 = point1;
      min1Txt1.Location = point26;
      this.Min1Txt.Name = "Min1Txt";
      this.Min1Txt.ReadOnly = true;
      TextBox min1Txt2 = this.Min1Txt;
      size1 = new Size(122, 20);
      Size size26 = size1;
      min1Txt2.Size = size26;
      this.Min1Txt.TabIndex = 40;
      TextBox stdDev1Txt1 = this.StdDev1Txt;
      point1 = new Point(189, 245);
      Point point27 = point1;
      stdDev1Txt1.Location = point27;
      this.StdDev1Txt.Name = "StdDev1Txt";
      this.StdDev1Txt.ReadOnly = true;
      TextBox stdDev1Txt2 = this.StdDev1Txt;
      size1 = new Size(122, 20);
      Size size27 = size1;
      stdDev1Txt2.Size = size27;
      this.StdDev1Txt.TabIndex = 39;
      TextBox mean1Txt1 = this.Mean1Txt;
      point1 = new Point(189, 219);
      Point point28 = point1;
      mean1Txt1.Location = point28;
      this.Mean1Txt.Name = "Mean1Txt";
      this.Mean1Txt.ReadOnly = true;
      TextBox mean1Txt2 = this.Mean1Txt;
      size1 = new Size(122, 20);
      Size size28 = size1;
      mean1Txt2.Size = size28;
      this.Mean1Txt.TabIndex = 38;
      this.MeasTmr.Interval = 1000;
      this.ViewBtn.Enabled = false;
      Button viewBtn1 = this.ViewBtn;
      point1 = new Point(320, 254);
      Point point29 = point1;
      viewBtn1.Location = point29;
      this.ViewBtn.Name = "ViewBtn";
      Button viewBtn2 = this.ViewBtn;
      size1 = new Size(97, 29);
      Size size29 = size1;
      viewBtn2.Size = size29;
      this.ViewBtn.TabIndex = 45;
      this.ViewBtn.Text = "View All";
      this.ViewBtn.UseVisualStyleBackColor = true;
      this.GraphBtn.Enabled = false;
      Button graphBtn1 = this.GraphBtn;
      point1 = new Point(320, 289);
      Point point30 = point1;
      graphBtn1.Location = point30;
      this.GraphBtn.Name = "GraphBtn";
      Button graphBtn2 = this.GraphBtn;
      size1 = new Size(97, 29);
      Size size30 = size1;
      graphBtn2.Size = size30;
      this.GraphBtn.TabIndex = 46;
      this.GraphBtn.Text = "Graph";
      this.GraphBtn.UseVisualStyleBackColor = true;
      Label label1_1 = this.Label1;
      point1 = new Point(57, 200);
      Point point31 = point1;
      label1_1.Location = point31;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(125, 16);
      Size size31 = size1;
      label1_2.Size = size31;
      this.Label1.TabIndex = 47;
      this.Label1.Text = "Channel 0";
      this.Label1.TextAlign = ContentAlignment.MiddleCenter;
      Label label2_1 = this.Label2;
      point1 = new Point(186, 200);
      Point point32 = point1;
      label2_1.Location = point32;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(125, 16);
      Size size32 = size1;
      label2_2.Size = size32;
      this.Label2.TabIndex = 48;
      this.Label2.Text = "Channel 1";
      this.Label2.TextAlign = ContentAlignment.MiddleCenter;
      this.RepeatChk.AutoSize = true;
      this.RepeatChk.Enabled = false;
      CheckBox repeatChk1 = this.RepeatChk;
      point1 = new Point(320, 167);
      Point point33 = point1;
      repeatChk1.Location = point33;
      this.RepeatChk.Name = "RepeatChk";
      CheckBox repeatChk2 = this.RepeatChk;
      size1 = new Size(90, 17);
      Size size33 = size1;
      repeatChk2.Size = size33;
      this.RepeatChk.TabIndex = 49;
      this.RepeatChk.Text = "Repeat every";
      this.RepeatChk.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(382, 193);
      Point point34 = point1;
      label3_1.Location = point34;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(32, 13);
      Size size34 = size1;
      label3_2.Size = size34;
      this.Label3.TabIndex = 51;
      this.Label3.Text = "msec";
      this.RepeatUD.Enabled = false;
      NumericUpDown repeatUd1 = this.RepeatUD;
      point1 = new Point(319, 190);
      Point point35 = point1;
      repeatUd1.Location = point35;
      NumericUpDown repeatUd2 = this.RepeatUD;
      num1 = new Decimal(new int[4]{ 1000000, 0, 0, 0 });
      Decimal num5 = num1;
      repeatUd2.Maximum = num5;
      NumericUpDown repeatUd3 = this.RepeatUD;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num6 = num1;
      repeatUd3.Minimum = num6;
      this.RepeatUD.Name = "RepeatUD";
      NumericUpDown repeatUd4 = this.RepeatUD;
      size1 = new Size(57, 20);
      Size size35 = size1;
      repeatUd4.Size = size35;
      this.RepeatUD.TabIndex = 52;
      NumericUpDown repeatUd5 = this.RepeatUD;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num7 = num1;
      repeatUd5.Value = num7;
      Button stableBtn1 = this.StableBtn;
      point1 = new Point(320, 492);
      Point point36 = point1;
      stableBtn1.Location = point36;
      this.StableBtn.Name = "StableBtn";
      Button stableBtn2 = this.StableBtn;
      size1 = new Size(97, 29);
      Size size36 = size1;
      stableBtn2.Size = size36;
      this.StableBtn.TabIndex = 53;
      this.StableBtn.Text = "Run Stable32";
      this.StableBtn.UseVisualStyleBackColor = true;
      this.StableBtn.Visible = false;
      this.CalBtn.Enabled = false;
      Button calBtn1 = this.CalBtn;
      point1 = new Point(320, 80);
      Point point37 = point1;
      calBtn1.Location = point37;
      this.CalBtn.Name = "CalBtn";
      Button calBtn2 = this.CalBtn;
      size1 = new Size(97, 29);
      Size size37 = size1;
      calBtn2.Size = size37;
      this.CalBtn.TabIndex = 54;
      this.CalBtn.Text = "Calibrate";
      this.CalBtn.UseVisualStyleBackColor = true;
      this.TimeoutUD.Enabled = false;
      NumericUpDown timeoutUd1 = this.TimeoutUD;
      point1 = new Point(56, 165);
      Point point38 = point1;
      timeoutUd1.Location = point38;
      NumericUpDown timeoutUd2 = this.TimeoutUD;
      num1 = new Decimal(new int[4]{ 10000000, 0, 0, 0 });
      Decimal num8 = num1;
      timeoutUd2.Maximum = num8;
      NumericUpDown timeoutUd3 = this.TimeoutUD;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num9 = num1;
      timeoutUd3.Minimum = num9;
      this.TimeoutUD.Name = "TimeoutUD";
      NumericUpDown timeoutUd4 = this.TimeoutUD;
      size1 = new Size(57, 20);
      Size size38 = size1;
      timeoutUd4.Size = size38;
      this.TimeoutUD.TabIndex = 56;
      NumericUpDown timeoutUd5 = this.TimeoutUD;
      num1 = new Decimal(new int[4]{ 2000, 0, 0, 0 });
      Decimal num10 = num1;
      timeoutUd5.Value = num10;
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(113, 167);
      Point point39 = point1;
      label4_1.Location = point39;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(32, 13);
      Size size39 = size1;
      label4_2.Size = size39;
      this.Label4.TabIndex = 55;
      this.Label4.Text = "msec";
      this.TimeoutLbl.AutoSize = true;
      Label timeoutLbl1 = this.TimeoutLbl;
      point1 = new Point(5, 167);
      Point point40 = point1;
      timeoutLbl1.Location = point40;
      this.TimeoutLbl.Name = "TimeoutLbl";
      Label timeoutLbl2 = this.TimeoutLbl;
      size1 = new Size(45, 13);
      Size size40 = size1;
      timeoutLbl2.Size = size40;
      this.TimeoutLbl.TabIndex = 57;
      this.TimeoutLbl.Text = "Timeout";
      TextBox preSc1Txt1 = this.PreSc1Txt;
      point1 = new Point(189, 375);
      Point point41 = point1;
      preSc1Txt1.Location = point41;
      this.PreSc1Txt.Name = "PreSc1Txt";
      this.PreSc1Txt.ReadOnly = true;
      TextBox preSc1Txt2 = this.PreSc1Txt;
      size1 = new Size(122, 20);
      Size size41 = size1;
      preSc1Txt2.Size = size41;
      this.PreSc1Txt.TabIndex = 60;
      TextBox preSc0Txt1 = this.PreSc0Txt;
      point1 = new Point(60, 375);
      Point point42 = point1;
      preSc0Txt1.Location = point42;
      this.PreSc0Txt.Name = "PreSc0Txt";
      this.PreSc0Txt.ReadOnly = true;
      TextBox preSc0Txt2 = this.PreSc0Txt;
      size1 = new Size(122, 20);
      Size size42 = size1;
      preSc0Txt2.Size = size42;
      this.PreSc0Txt.TabIndex = 59;
      this.PreScLbl.AutoSize = true;
      Label preScLbl1 = this.PreScLbl;
      point1 = new Point(5, 378);
      Point point43 = point1;
      preScLbl1.Location = point43;
      this.PreScLbl.Name = "PreScLbl";
      Label preScLbl2 = this.PreScLbl;
      size1 = new Size(48, 13);
      Size size43 = size1;
      preScLbl2.Size = size43;
      this.PreScLbl.TabIndex = 58;
      this.PreScLbl.Text = "Prescale";
      TextBox thr1Txt1 = this.Thr1Txt;
      point1 = new Point(189, 449);
      Point point44 = point1;
      thr1Txt1.Location = point44;
      this.Thr1Txt.Name = "Thr1Txt";
      this.Thr1Txt.ReadOnly = true;
      TextBox thr1Txt2 = this.Thr1Txt;
      size1 = new Size(122, 20);
      Size size44 = size1;
      thr1Txt2.Size = size44;
      this.Thr1Txt.TabIndex = 63;
      TextBox thr0Txt1 = this.Thr0Txt;
      point1 = new Point(60, 449);
      Point point45 = point1;
      thr0Txt1.Location = point45;
      this.Thr0Txt.Name = "Thr0Txt";
      this.Thr0Txt.ReadOnly = true;
      TextBox thr0Txt2 = this.Thr0Txt;
      size1 = new Size(122, 20);
      Size size45 = size1;
      thr0Txt2.Size = size45;
      this.Thr0Txt.TabIndex = 62;
      this.ThrLbl.AutoSize = true;
      Label thrLbl1 = this.ThrLbl;
      point1 = new Point(5, 452);
      Point point46 = point1;
      thrLbl1.Location = point46;
      this.ThrLbl.Name = "ThrLbl";
      Label thrLbl2 = this.ThrLbl;
      size1 = new Size(54, 13);
      Size size46 = size1;
      thrLbl2.Size = size46;
      this.ThrLbl.TabIndex = 61;
      this.ThrLbl.Text = "Threshold";
      TextBox maxPk1Txt1 = this.MaxPk1Txt;
      point1 = new Point(189, 475);
      Point point47 = point1;
      maxPk1Txt1.Location = point47;
      this.MaxPk1Txt.Name = "MaxPk1Txt";
      this.MaxPk1Txt.ReadOnly = true;
      TextBox maxPk1Txt2 = this.MaxPk1Txt;
      size1 = new Size(122, 20);
      Size size47 = size1;
      maxPk1Txt2.Size = size47;
      this.MaxPk1Txt.TabIndex = 66;
      TextBox maxPk0Txt1 = this.MaxPk0Txt;
      point1 = new Point(60, 475);
      Point point48 = point1;
      maxPk0Txt1.Location = point48;
      this.MaxPk0Txt.Name = "MaxPk0Txt";
      this.MaxPk0Txt.ReadOnly = true;
      TextBox maxPk0Txt2 = this.MaxPk0Txt;
      size1 = new Size(122, 20);
      Size size48 = size1;
      maxPk0Txt2.Size = size48;
      this.MaxPk0Txt.TabIndex = 65;
      this.MaxPkLbl.AutoSize = true;
      Label maxPkLbl1 = this.MaxPkLbl;
      point1 = new Point(5, 478);
      Point point49 = point1;
      maxPkLbl1.Location = point49;
      this.MaxPkLbl.Name = "MaxPkLbl";
      Label maxPkLbl2 = this.MaxPkLbl;
      size1 = new Size(43, 13);
      Size size49 = size1;
      maxPkLbl2.Size = size49;
      this.MaxPkLbl.TabIndex = 64;
      this.MaxPkLbl.Text = "Max Pk";
      TextBox minPk1Txt1 = this.MinPk1Txt;
      point1 = new Point(189, 501);
      Point point50 = point1;
      minPk1Txt1.Location = point50;
      this.MinPk1Txt.Name = "MinPk1Txt";
      this.MinPk1Txt.ReadOnly = true;
      TextBox minPk1Txt2 = this.MinPk1Txt;
      size1 = new Size(122, 20);
      Size size50 = size1;
      minPk1Txt2.Size = size50;
      this.MinPk1Txt.TabIndex = 69;
      TextBox minPk0Txt1 = this.MinPk0Txt;
      point1 = new Point(60, 501);
      Point point51 = point1;
      minPk0Txt1.Location = point51;
      this.MinPk0Txt.Name = "MinPk0Txt";
      this.MinPk0Txt.ReadOnly = true;
      TextBox minPk0Txt2 = this.MinPk0Txt;
      size1 = new Size(122, 20);
      Size size51 = size1;
      minPk0Txt2.Size = size51;
      this.MinPk0Txt.TabIndex = 68;
      this.MinPkLbl.AutoSize = true;
      Label minPkLbl1 = this.MinPkLbl;
      point1 = new Point(5, 504);
      Point point52 = point1;
      minPkLbl1.Location = point52;
      this.MinPkLbl.Name = "MinPkLbl";
      Label minPkLbl2 = this.MinPkLbl;
      size1 = new Size(40, 13);
      Size size52 = size1;
      minPkLbl2.Size = size52;
      this.MinPkLbl.TabIndex = 67;
      this.MinPkLbl.Text = "Min Pk";
      this.DevCbo.FormattingEnabled = true;
      ComboBox devCbo1 = this.DevCbo;
      point1 = new Point(274, 13);
      Point point53 = point1;
      devCbo1.Location = point53;
      this.DevCbo.Name = "DevCbo";
      ComboBox devCbo2 = this.DevCbo;
      size1 = new Size(37, 21);
      Size size53 = size1;
      devCbo2.Size = size53;
      this.DevCbo.TabIndex = 70;
      this.DevCbo.Visible = false;
      this.DevLbl.AutoSize = true;
      Label devLbl1 = this.DevLbl;
      point1 = new Point(227, 16);
      Point point54 = point1;
      devLbl1.Location = point54;
      this.DevLbl.Name = "DevLbl";
      Label devLbl2 = this.DevLbl;
      size1 = new Size(41, 13);
      Size size54 = size1;
      devLbl2.Size = size54;
      this.DevLbl.TabIndex = 71;
      this.DevLbl.Text = "Device";
      this.DevLbl.Visible = false;
      this.WrapChk.AutoSize = true;
      this.WrapChk.Enabled = false;
      CheckBox wrapChk1 = this.WrapChk;
      point1 = new Point(164, 168);
      Point point55 = point1;
      wrapChk1.Location = point55;
      this.WrapChk.Name = "WrapChk";
      CheckBox wrapChk2 = this.WrapChk;
      size1 = new Size(122, 17);
      Size size55 = size1;
      wrapChk2.Size = size55;
      this.WrapChk.TabIndex = 72;
      this.WrapChk.Text = "Memory Wrap Mode";
      this.WrapChk.UseVisualStyleBackColor = true;
      this.SaveRawBtn.Enabled = false;
      Button saveRawBtn1 = this.SaveRawBtn;
      point1 = new Point(320, 388);
      Point point56 = point1;
      saveRawBtn1.Location = point56;
      this.SaveRawBtn.Name = "SaveRawBtn";
      Button saveRawBtn2 = this.SaveRawBtn;
      size1 = new Size(97, 29);
      Size size56 = size1;
      saveRawBtn2.Size = size56;
      this.SaveRawBtn.TabIndex = 73;
      this.SaveRawBtn.Text = "Save Raw...";
      this.SaveRawBtn.UseVisualStyleBackColor = true;
      this.SaveRawBtn.Visible = false;
      TextBox colTxt1 = this.ColTxt;
      point1 = new Point(375, 426);
      Point point57 = point1;
      colTxt1.Location = point57;
      this.ColTxt.Name = "ColTxt";
      TextBox colTxt2 = this.ColTxt;
      size1 = new Size(42, 20);
      Size size57 = size1;
      colTxt2.Size = size57;
      this.ColTxt.TabIndex = 74;
      this.ColTxt.Text = "1";
      this.ColTxt.Visible = false;
      this.ColLbl.AutoSize = true;
      Label colLbl1 = this.ColLbl;
      point1 = new Point(322, 428);
      Point point58 = point1;
      colLbl1.Location = point58;
      this.ColLbl.Name = "ColLbl";
      Label colLbl2 = this.ColLbl;
      size1 = new Size(47, 13);
      Size size58 = size1;
      colLbl2.Size = size58;
      this.ColLbl.TabIndex = 75;
      this.ColLbl.Text = "Columns";
      this.ColLbl.Visible = false;
      this.ContOpt.AutoSize = true;
      RadioButton contOpt1 = this.ContOpt;
      point1 = new Point(13, 86);
      Point point59 = point1;
      contOpt1.Location = point59;
      this.ContOpt.Name = "ContOpt";
      RadioButton contOpt2 = this.ContOpt;
      size1 = new Size(98, 17);
      Size size59 = size1;
      contOpt2.Size = size59;
      this.ContOpt.TabIndex = 76;
      this.ContOpt.Text = "Contiuous Time";
      this.ContOpt.UseVisualStyleBackColor = true;
      this.InfoBtn.Enabled = false;
      Button infoBtn1 = this.InfoBtn;
      point1 = new Point(320, 115);
      Point point60 = point1;
      infoBtn1.Location = point60;
      this.InfoBtn.Name = "InfoBtn";
      Button infoBtn2 = this.InfoBtn;
      size1 = new Size(97, 29);
      Size size60 = size1;
      infoBtn2.Size = size60;
      this.InfoBtn.TabIndex = 77;
      this.InfoBtn.Text = "Info...";
      this.InfoBtn.UseVisualStyleBackColor = true;
      Label label5_1 = this.Label5;
      point1 = new Point(57, 430);
      Point point61 = point1;
      label5_1.Location = point61;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(125, 16);
      Size size61 = size1;
      label5_2.Size = size61;
      this.Label5.TabIndex = 78;
      this.Label5.Text = "Input A";
      this.Label5.TextAlign = ContentAlignment.MiddleCenter;
      Label label6_1 = this.Label6;
      point1 = new Point(186, 430);
      Point point62 = point1;
      label6_1.Location = point62;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(125, 16);
      Size size62 = size1;
      label6_2.Size = size62;
      this.Label6.TabIndex = 79;
      this.Label6.Text = "Input B";
      this.Label6.TextAlign = ContentAlignment.MiddleCenter;
      this.TIEPnl.Controls.Add((Control) this.TIELbl);
      this.TIEPnl.Controls.Add((Control) this.TIEFreqTxt);
      this.TIEPnl.Controls.Add((Control) this.TIEFreqOpt);
      this.TIEPnl.Controls.Add((Control) this.TIEAutoOpt);
      this.TIEPnl.Enabled = false;
      Panel tiePnl1 = this.TIEPnl;
      point1 = new Point(56, 105);
      Point point63 = point1;
      tiePnl1.Location = point63;
      this.TIEPnl.Name = "TIEPnl";
      Panel tiePnl2 = this.TIEPnl;
      size1 = new Size(264, 29);
      Size size63 = size1;
      tiePnl2.Size = size63;
      this.TIEPnl.TabIndex = 80;
      this.TIELbl.AutoSize = true;
      Label tieLbl1 = this.TIELbl;
      point1 = new Point(2, 6);
      Point point64 = point1;
      tieLbl1.Location = point64;
      this.TIELbl.Name = "TIELbl";
      Label tieLbl2 = this.TIELbl;
      size1 = new Size(60, 13);
      Size size64 = size1;
      tieLbl2.Size = size64;
      this.TIELbl.TabIndex = 87;
      this.TIELbl.Text = "Frequency:";
      this.TIEFreqTxt.HideSelection = false;
      TextBox tieFreqTxt1 = this.TIEFreqTxt;
      point1 = new Point(140, 3);
      Point point65 = point1;
      tieFreqTxt1.Location = point65;
      this.TIEFreqTxt.Name = "TIEFreqTxt";
      TextBox tieFreqTxt2 = this.TIEFreqTxt;
      size1 = new Size(115, 20);
      Size size65 = size1;
      tieFreqTxt2.Size = size65;
      this.TIEFreqTxt.TabIndex = 86;
      this.TIEFreqTxt.Text = "10 MHz";
      this.TIEFreqOpt.AutoSize = true;
      RadioButton tieFreqOpt1 = this.TIEFreqOpt;
      point1 = new Point(120, 6);
      Point point66 = point1;
      tieFreqOpt1.Location = point66;
      this.TIEFreqOpt.Name = "TIEFreqOpt";
      RadioButton tieFreqOpt2 = this.TIEFreqOpt;
      size1 = new Size(14, 13);
      Size size66 = size1;
      tieFreqOpt2.Size = size66;
      this.TIEFreqOpt.TabIndex = 85;
      this.TIEFreqOpt.UseVisualStyleBackColor = true;
      this.TIEAutoOpt.AutoSize = true;
      this.TIEAutoOpt.Checked = true;
      RadioButton tieAutoOpt1 = this.TIEAutoOpt;
      point1 = new Point(67, 4);
      Point point67 = point1;
      tieAutoOpt1.Location = point67;
      this.TIEAutoOpt.Name = "TIEAutoOpt";
      RadioButton tieAutoOpt2 = this.TIEAutoOpt;
      size1 = new Size(47, 17);
      Size size67 = size1;
      tieAutoOpt2.Size = size67;
      this.TIEAutoOpt.TabIndex = 84;
      this.TIEAutoOpt.TabStop = true;
      this.TIEAutoOpt.Text = "Auto";
      this.TIEAutoOpt.UseVisualStyleBackColor = true;
      this.AutoSaveChk.AutoSize = true;
      this.AutoSaveChk.CheckAlign = ContentAlignment.MiddleRight;
      this.AutoSaveChk.Enabled = false;
      CheckBox autoSaveChk1 = this.AutoSaveChk;
      point1 = new Point(135, 41);
      Point point68 = point1;
      autoSaveChk1.Location = point68;
      this.AutoSaveChk.Name = "AutoSaveChk";
      CheckBox autoSaveChk2 = this.AutoSaveChk;
      size1 = new Size(76, 17);
      Size size68 = size1;
      autoSaveChk2.Size = size68;
      this.AutoSaveChk.TabIndex = 81;
      this.AutoSaveChk.Text = "Auto Save";
      this.AutoSaveChk.UseVisualStyleBackColor = true;
      this.RealTimeTmr.Interval = 250;
      this.RealTimeLbl.BorderStyle = BorderStyle.Fixed3D;
      Label realTimeLbl1 = this.RealTimeLbl;
      point1 = new Point(60, 536);
      Point point69 = point1;
      realTimeLbl1.Location = point69;
      this.RealTimeLbl.Name = "RealTimeLbl";
      Label realTimeLbl2 = this.RealTimeLbl;
      size1 = new Size(135, 21);
      Size size69 = size1;
      realTimeLbl2.Size = size69;
      this.RealTimeLbl.TabIndex = 82;
      this.RealTimeLbl.TextAlign = ContentAlignment.MiddleRight;
      this.UTCLbl.AutoSize = true;
      Label utcLbl1 = this.UTCLbl;
      point1 = new Point(5, 540);
      Point point70 = point1;
      utcLbl1.Location = point70;
      this.UTCLbl.Name = "UTCLbl";
      Label utcLbl2 = this.UTCLbl;
      size1 = new Size(29, 13);
      Size size70 = size1;
      utcLbl2.Size = size70;
      this.UTCLbl.TabIndex = 83;
      this.UTCLbl.Text = "UTC";
      Button syncBtn1 = this.SyncBtn;
      point1 = new Point(312, 532);
      Point point71 = point1;
      syncBtn1.Location = point71;
      this.SyncBtn.Name = "SyncBtn";
      Button syncBtn2 = this.SyncBtn;
      size1 = new Size(105, 29);
      Size size71 = size1;
      syncBtn2.Size = size71;
      this.SyncBtn.TabIndex = 84;
      this.SyncBtn.Text = "Sync to Computer";
      this.SyncBtn.UseVisualStyleBackColor = true;
      this.SyncBtn.Visible = false;
      this.ShowUTCChk.AutoSize = true;
      CheckBox showUtcChk1 = this.ShowUTCChk;
      point1 = new Point(205, 539);
      Point point72 = point1;
      showUtcChk1.Location = point72;
      this.ShowUTCChk.Name = "ShowUTCChk";
      CheckBox showUtcChk2 = this.ShowUTCChk;
      size1 = new Size(53, 17);
      Size size72 = size1;
      showUtcChk2.Size = size72;
      this.ShowUTCChk.TabIndex = 85;
      this.ShowUTCChk.Text = "Show";
      this.ShowUTCChk.UseVisualStyleBackColor = true;
      this.GateLbl.AutoSize = true;
      Label gateLbl1 = this.GateLbl;
      point1 = new Point(5, 404);
      Point point73 = point1;
      gateLbl1.Location = point73;
      this.GateLbl.Name = "GateLbl";
      Label gateLbl2 = this.GateLbl;
      size1 = new Size(30, 13);
      Size size73 = size1;
      gateLbl2.Size = size73;
      this.GateLbl.TabIndex = 88;
      this.GateLbl.Text = "Gate";
      this.Gate0UD.Enabled = false;
      NumericUpDown gate0Ud1 = this.Gate0UD;
      point1 = new Point(60, 401);
      Point point74 = point1;
      gate0Ud1.Location = point74;
      NumericUpDown gate0Ud2 = this.Gate0UD;
      num1 = new Decimal(new int[4]{ 1000000000, 0, 0, 0 });
      Decimal num11 = num1;
      gate0Ud2.Maximum = num11;
      NumericUpDown gate0Ud3 = this.Gate0UD;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num12 = num1;
      gate0Ud3.Minimum = num12;
      this.Gate0UD.Name = "Gate0UD";
      NumericUpDown gate0Ud4 = this.Gate0UD;
      size1 = new Size(122, 20);
      Size size74 = size1;
      gate0Ud4.Size = size74;
      this.Gate0UD.TabIndex = 89;
      NumericUpDown gate0Ud5 = this.Gate0UD;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num13 = num1;
      gate0Ud5.Value = num13;
      this.Gate1UD.Enabled = false;
      NumericUpDown gate1Ud1 = this.Gate1UD;
      point1 = new Point(189, 401);
      Point point75 = point1;
      gate1Ud1.Location = point75;
      NumericUpDown gate1Ud2 = this.Gate1UD;
      num1 = new Decimal(new int[4]{ 1000000000, 0, 0, 0 });
      Decimal num14 = num1;
      gate1Ud2.Maximum = num14;
      NumericUpDown gate1Ud3 = this.Gate1UD;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num15 = num1;
      gate1Ud3.Minimum = num15;
      this.Gate1UD.Name = "Gate1UD";
      NumericUpDown gate1Ud4 = this.Gate1UD;
      size1 = new Size(122, 20);
      Size size75 = size1;
      gate1Ud4.Size = size75;
      this.Gate1UD.TabIndex = 90;
      NumericUpDown gate1Ud5 = this.Gate1UD;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num16 = num1;
      gate1Ud5.Value = num16;
      this.DefBtn.Enabled = false;
      Button defBtn1 = this.DefBtn;
      point1 = new Point(320, 340);
      Point point76 = point1;
      defBtn1.Location = point76;
      this.DefBtn.Name = "DefBtn";
      Button defBtn2 = this.DefBtn;
      size1 = new Size(97, 29);
      Size size76 = size1;
      defBtn2.Size = size76;
      this.DefBtn.TabIndex = 91;
      this.DefBtn.Text = "Set Deafults";
      this.DefBtn.UseVisualStyleBackColor = true;
      this.BrdLbl.AutoSize = true;
      Label brdLbl1 = this.BrdLbl;
      point1 = new Point(227, 42);
      Point point77 = point1;
      brdLbl1.Location = point77;
      this.BrdLbl.Name = "BrdLbl";
      Label brdLbl2 = this.BrdLbl;
      size1 = new Size(45, 13);
      Size size77 = size1;
      brdLbl2.Size = size77;
      this.BrdLbl.TabIndex = 92;
      this.BrdLbl.Text = "Board #";
      this.BrdLbl.Visible = false;
      Label brdNumLbl1 = this.BrdNumLbl;
      point1 = new Point(274, 42);
      Point point78 = point1;
      brdNumLbl1.Location = point78;
      this.BrdNumLbl.Name = "BrdNumLbl";
      Label brdNumLbl2 = this.BrdNumLbl;
      size1 = new Size(31, 13);
      Size size78 = size1;
      brdNumLbl2.Size = size78;
      this.BrdNumLbl.TabIndex = 93;
      this.BrdNumLbl.Visible = false;
      Button mapBtn1 = this.MapBtn;
      point1 = new Point(230, 59);
      Point point79 = point1;
      mapBtn1.Location = point79;
      this.MapBtn.Name = "MapBtn";
      Button mapBtn2 = this.MapBtn;
      size1 = new Size(81, 24);
      Size size79 = size1;
      mapBtn2.Size = size79;
      this.MapBtn.TabIndex = 94;
      this.MapBtn.Text = "Remap...";
      this.MapBtn.UseVisualStyleBackColor = true;
      this.MapBtn.Visible = false;
      this.Timer1.Interval = 2000;
      this.MasterLbl.AutoSize = true;
      Label masterLbl1 = this.MasterLbl;
      point1 = new Point(227, 88);
      Point point80 = point1;
      masterLbl1.Location = point80;
      this.MasterLbl.Name = "MasterLbl";
      Label masterLbl2 = this.MasterLbl;
      size1 = new Size(39, 13);
      Size size80 = size1;
      masterLbl2.Size = size80;
      this.MasterLbl.TabIndex = 95;
      this.MasterLbl.Text = "Master";
      this.MasterLbl.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(426, 528);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.MasterLbl);
      this.Controls.Add((Control) this.MapBtn);
      this.Controls.Add((Control) this.BrdNumLbl);
      this.Controls.Add((Control) this.BrdLbl);
      this.Controls.Add((Control) this.DefBtn);
      this.Controls.Add((Control) this.Gate1UD);
      this.Controls.Add((Control) this.Gate0UD);
      this.Controls.Add((Control) this.GateLbl);
      this.Controls.Add((Control) this.ShowUTCChk);
      this.Controls.Add((Control) this.SyncBtn);
      this.Controls.Add((Control) this.UTCLbl);
      this.Controls.Add((Control) this.RealTimeLbl);
      this.Controls.Add((Control) this.AutoSaveChk);
      this.Controls.Add((Control) this.TIEPnl);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.InfoBtn);
      this.Controls.Add((Control) this.ContOpt);
      this.Controls.Add((Control) this.ColLbl);
      this.Controls.Add((Control) this.ColTxt);
      this.Controls.Add((Control) this.SaveRawBtn);
      this.Controls.Add((Control) this.WrapChk);
      this.Controls.Add((Control) this.DevLbl);
      this.Controls.Add((Control) this.DevCbo);
      this.Controls.Add((Control) this.MinPk1Txt);
      this.Controls.Add((Control) this.MinPk0Txt);
      this.Controls.Add((Control) this.MinPkLbl);
      this.Controls.Add((Control) this.MaxPk1Txt);
      this.Controls.Add((Control) this.MaxPk0Txt);
      this.Controls.Add((Control) this.MaxPkLbl);
      this.Controls.Add((Control) this.Thr1Txt);
      this.Controls.Add((Control) this.Thr0Txt);
      this.Controls.Add((Control) this.ThrLbl);
      this.Controls.Add((Control) this.PreSc1Txt);
      this.Controls.Add((Control) this.PreSc0Txt);
      this.Controls.Add((Control) this.PreScLbl);
      this.Controls.Add((Control) this.TimeoutLbl);
      this.Controls.Add((Control) this.TimeoutUD);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.CalBtn);
      this.Controls.Add((Control) this.StableBtn);
      this.Controls.Add((Control) this.RepeatUD);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.RepeatChk);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.GraphBtn);
      this.Controls.Add((Control) this.ViewBtn);
      this.Controls.Add((Control) this.Cnt1Txt);
      this.Controls.Add((Control) this.Pk1Txt);
      this.Controls.Add((Control) this.Max1Txt);
      this.Controls.Add((Control) this.Min1Txt);
      this.Controls.Add((Control) this.StdDev1Txt);
      this.Controls.Add((Control) this.Mean1Txt);
      this.Controls.Add((Control) this.Cnt0Txt);
      this.Controls.Add((Control) this.CntLbl);
      this.Controls.Add((Control) this.Pk0Txt);
      this.Controls.Add((Control) this.PkLbl);
      this.Controls.Add((Control) this.Max0Txt);
      this.Controls.Add((Control) this.MaxLbl);
      this.Controls.Add((Control) this.Min0Txt);
      this.Controls.Add((Control) this.MinLbl);
      this.Controls.Add((Control) this.StdDev0Txt);
      this.Controls.Add((Control) this.StdDevLbl);
      this.Controls.Add((Control) this.Mean0Txt);
      this.Controls.Add((Control) this.MeanLbl);
      this.Controls.Add((Control) this.RunBtn);
      this.Controls.Add((Control) this.TimeOpt);
      this.Controls.Add((Control) this.CfgBtn);
      this.Controls.Add((Control) this.InitBtn);
      this.Controls.Add((Control) this.TIEOpt);
      this.Controls.Add((Control) this.PeriodOpt);
      this.Controls.Add((Control) this.FreqOpt);
      this.Controls.Add((Control) this.MeasCntUD);
      this.Controls.Add((Control) this.MeasCntLbl);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = nameof (ExrFrm);
      this.Text = "GT668 Exerciser";
      this.MeasCntUD.EndInit();
      this.RepeatUD.EndInit();
      this.TimeoutUD.EndInit();
      this.TIEPnl.ResumeLayout(false);
      this.TIEPnl.PerformLayout();
      this.Gate0UD.EndInit();
      this.Gate1UD.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual NumericUpDown MeasCntUD
    {
      get => this._MeasCntUD;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MeasCntUD = value;
    }

    internal virtual Label MeasCntLbl
    {
      get => this._MeasCntLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MeasCntLbl = value;
    }

    internal virtual RadioButton FreqOpt
    {
      get => this._FreqOpt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Opt_CheckedChanged);
        if (this._FreqOpt != null)
          this._FreqOpt.CheckedChanged -= eventHandler;
        this._FreqOpt = value;
        if (this._FreqOpt == null)
          return;
        this._FreqOpt.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton PeriodOpt
    {
      get => this._PeriodOpt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Opt_CheckedChanged);
        if (this._PeriodOpt != null)
          this._PeriodOpt.CheckedChanged -= eventHandler;
        this._PeriodOpt = value;
        if (this._PeriodOpt == null)
          return;
        this._PeriodOpt.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton TIEOpt
    {
      get => this._TIEOpt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Opt_CheckedChanged);
        if (this._TIEOpt != null)
          this._TIEOpt.CheckedChanged -= eventHandler;
        this._TIEOpt = value;
        if (this._TIEOpt == null)
          return;
        this._TIEOpt.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button InitBtn
    {
      get => this._InitBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.InitBtn_Click);
        if (this._InitBtn != null)
          this._InitBtn.Click -= eventHandler;
        this._InitBtn = value;
        if (this._InitBtn == null)
          return;
        this._InitBtn.Click += eventHandler;
      }
    }

    internal virtual Button CfgBtn
    {
      get => this._CfgBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CfgBtn_Click);
        if (this._CfgBtn != null)
          this._CfgBtn.Click -= eventHandler;
        this._CfgBtn = value;
        if (this._CfgBtn == null)
          return;
        this._CfgBtn.Click += eventHandler;
      }
    }

    internal virtual RadioButton TimeOpt
    {
      get => this._TimeOpt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Opt_CheckedChanged);
        if (this._TimeOpt != null)
          this._TimeOpt.CheckedChanged -= eventHandler;
        this._TimeOpt = value;
        if (this._TimeOpt == null)
          return;
        this._TimeOpt.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button RunBtn
    {
      get => this._RunBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RunBtn_Click);
        if (this._RunBtn != null)
          this._RunBtn.Click -= eventHandler;
        this._RunBtn = value;
        if (this._RunBtn == null)
          return;
        this._RunBtn.Click += eventHandler;
      }
    }

    internal virtual Label MeanLbl
    {
      get => this._MeanLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MeanLbl = value;
    }

    internal virtual TextBox Mean0Txt
    {
      get => this._Mean0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Mean0Txt = value;
    }

    internal virtual TextBox StdDev0Txt
    {
      get => this._StdDev0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._StdDev0Txt = value;
    }

    internal virtual Label StdDevLbl
    {
      get => this._StdDevLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._StdDevLbl = value;
    }

    internal virtual TextBox Min0Txt
    {
      get => this._Min0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Min0Txt = value;
    }

    internal virtual Label MinLbl
    {
      get => this._MinLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MinLbl = value;
    }

    internal virtual TextBox Max0Txt
    {
      get => this._Max0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Max0Txt = value;
    }

    internal virtual Label MaxLbl
    {
      get => this._MaxLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MaxLbl = value;
    }

    internal virtual TextBox Pk0Txt
    {
      get => this._Pk0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Pk0Txt = value;
    }

    internal virtual Label PkLbl
    {
      get => this._PkLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._PkLbl = value;
    }

    internal virtual TextBox Cnt0Txt
    {
      get => this._Cnt0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Cnt0Txt = value;
    }

    internal virtual Label CntLbl
    {
      get => this._CntLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._CntLbl = value;
    }

    internal virtual TextBox Cnt1Txt
    {
      get => this._Cnt1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Cnt1Txt = value;
    }

    internal virtual TextBox Pk1Txt
    {
      get => this._Pk1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Pk1Txt = value;
    }

    internal virtual TextBox Max1Txt
    {
      get => this._Max1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Max1Txt = value;
    }

    internal virtual TextBox Min1Txt
    {
      get => this._Min1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Min1Txt = value;
    }

    internal virtual TextBox StdDev1Txt
    {
      get => this._StdDev1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._StdDev1Txt = value;
    }

    internal virtual TextBox Mean1Txt
    {
      get => this._Mean1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Mean1Txt = value;
    }

    internal virtual System.Windows.Forms.Timer MeasTmr
    {
      get => this._MeasTmr;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MeasTmr_Tick);
        if (this._MeasTmr != null)
          this._MeasTmr.Tick -= eventHandler;
        this._MeasTmr = value;
        if (this._MeasTmr == null)
          return;
        this._MeasTmr.Tick += eventHandler;
      }
    }

    internal virtual Button ViewBtn
    {
      get => this._ViewBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ViewBtn_Click);
        if (this._ViewBtn != null)
          this._ViewBtn.Click -= eventHandler;
        this._ViewBtn = value;
        if (this._ViewBtn == null)
          return;
        this._ViewBtn.Click += eventHandler;
      }
    }

    internal virtual Button GraphBtn
    {
      get => this._GraphBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GraphBtn_Click);
        if (this._GraphBtn != null)
          this._GraphBtn.Click -= eventHandler;
        this._GraphBtn = value;
        if (this._GraphBtn == null)
          return;
        this._GraphBtn.Click += eventHandler;
      }
    }

    internal virtual Label Label1
    {
      get => this._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Label Label2
    {
      get => this._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual CheckBox RepeatChk
    {
      get => this._RepeatChk;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RepeatChk_CheckedChanged);
        if (this._RepeatChk != null)
          this._RepeatChk.CheckedChanged -= eventHandler;
        this._RepeatChk = value;
        if (this._RepeatChk == null)
          return;
        this._RepeatChk.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label Label3
    {
      get => this._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual NumericUpDown RepeatUD
    {
      get => this._RepeatUD;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RepeatUD_ValueChanged);
        if (this._RepeatUD != null)
          this._RepeatUD.ValueChanged -= eventHandler;
        this._RepeatUD = value;
        if (this._RepeatUD == null)
          return;
        this._RepeatUD.ValueChanged += eventHandler;
      }
    }

    internal virtual Button StableBtn
    {
      get => this._StableBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.StableBtn_Click);
        if (this._StableBtn != null)
          this._StableBtn.Click -= eventHandler;
        this._StableBtn = value;
        if (this._StableBtn == null)
          return;
        this._StableBtn.Click += eventHandler;
      }
    }

    internal virtual Button CalBtn
    {
      get => this._CalBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CalBtn_Click);
        if (this._CalBtn != null)
          this._CalBtn.Click -= eventHandler;
        this._CalBtn = value;
        if (this._CalBtn == null)
          return;
        this._CalBtn.Click += eventHandler;
      }
    }

    internal virtual NumericUpDown TimeoutUD
    {
      get => this._TimeoutUD;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._TimeoutUD = value;
    }

    internal virtual Label Label4
    {
      get => this._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal virtual Label TimeoutLbl
    {
      get => this._TimeoutLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._TimeoutLbl = value;
    }

    internal virtual TextBox PreSc1Txt
    {
      get => this._PreSc1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._PreSc1Txt = value;
    }

    internal virtual TextBox PreSc0Txt
    {
      get => this._PreSc0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._PreSc0Txt = value;
    }

    internal virtual Label PreScLbl
    {
      get => this._PreScLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._PreScLbl = value;
    }

    internal virtual TextBox Thr1Txt
    {
      get => this._Thr1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Thr1Txt = value;
    }

    internal virtual TextBox Thr0Txt
    {
      get => this._Thr0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Thr0Txt = value;
    }

    internal virtual Label ThrLbl
    {
      get => this._ThrLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ThrLbl = value;
    }

    internal virtual TextBox MaxPk1Txt
    {
      get => this._MaxPk1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MaxPk1Txt = value;
    }

    internal virtual TextBox MaxPk0Txt
    {
      get => this._MaxPk0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MaxPk0Txt = value;
    }

    internal virtual Label MaxPkLbl
    {
      get => this._MaxPkLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MaxPkLbl = value;
    }

    internal virtual TextBox MinPk1Txt
    {
      get => this._MinPk1Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MinPk1Txt = value;
    }

    internal virtual TextBox MinPk0Txt
    {
      get => this._MinPk0Txt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MinPk0Txt = value;
    }

    internal virtual Label MinPkLbl
    {
      get => this._MinPkLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MinPkLbl = value;
    }

    internal virtual ComboBox DevCbo
    {
      get => this._DevCbo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DevCbo_SelectedIndexChanged);
        if (this._DevCbo != null)
          this._DevCbo.SelectedIndexChanged -= eventHandler;
        this._DevCbo = value;
        if (this._DevCbo == null)
          return;
        this._DevCbo.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label DevLbl
    {
      get => this._DevLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._DevLbl = value;
    }

    internal virtual CheckBox WrapChk
    {
      get => this._WrapChk;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.WrapChk_CheckedChanged);
        if (this._WrapChk != null)
          this._WrapChk.CheckedChanged -= eventHandler;
        this._WrapChk = value;
        if (this._WrapChk == null)
          return;
        this._WrapChk.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button SaveRawBtn
    {
      get => this._SaveRawBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SaveRawBtn_Click);
        if (this._SaveRawBtn != null)
          this._SaveRawBtn.Click -= eventHandler;
        this._SaveRawBtn = value;
        if (this._SaveRawBtn == null)
          return;
        this._SaveRawBtn.Click += eventHandler;
      }
    }

    internal virtual SaveFileDialog SaveFileDialog1
    {
      get => this._SaveFileDialog1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._SaveFileDialog1 = value;
    }

    internal virtual TextBox ColTxt
    {
      get => this._ColTxt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ColTxt_Validating);
        if (this._ColTxt != null)
          this._ColTxt.Validating -= cancelEventHandler;
        this._ColTxt = value;
        if (this._ColTxt == null)
          return;
        this._ColTxt.Validating += cancelEventHandler;
      }
    }

    internal virtual Label ColLbl
    {
      get => this._ColLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ColLbl = value;
    }

    internal virtual RadioButton ContOpt
    {
      get => this._ContOpt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Opt_CheckedChanged);
        if (this._ContOpt != null)
          this._ContOpt.CheckedChanged -= eventHandler;
        this._ContOpt = value;
        if (this._ContOpt == null)
          return;
        this._ContOpt.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button InfoBtn
    {
      get => this._InfoBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.InfoBtn_Click);
        if (this._InfoBtn != null)
          this._InfoBtn.Click -= eventHandler;
        this._InfoBtn = value;
        if (this._InfoBtn == null)
          return;
        this._InfoBtn.Click += eventHandler;
      }
    }

    internal virtual Label Label5
    {
      get => this._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal virtual Label Label6
    {
      get => this._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    internal virtual Panel TIEPnl
    {
      get => this._TIEPnl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._TIEPnl = value;
    }

    internal virtual Label TIELbl
    {
      get => this._TIELbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._TIELbl = value;
    }

    internal virtual TextBox TIEFreqTxt
    {
      get => this._TIEFreqTxt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TIEFreqTxt_Validated);
        CancelEventHandler cancelEventHandler = new CancelEventHandler(this.TIEFreqTxt_Validating);
        if (this._TIEFreqTxt != null)
        {
          this._TIEFreqTxt.Validated -= eventHandler;
          this._TIEFreqTxt.Validating -= cancelEventHandler;
        }
        this._TIEFreqTxt = value;
        if (this._TIEFreqTxt == null)
          return;
        this._TIEFreqTxt.Validated += eventHandler;
        this._TIEFreqTxt.Validating += cancelEventHandler;
      }
    }

    internal virtual RadioButton TIEFreqOpt
    {
      get => this._TIEFreqOpt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._TIEFreqOpt = value;
    }

    internal virtual RadioButton TIEAutoOpt
    {
      get => this._TIEAutoOpt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TIEAutoOpt_CheckedChanged);
        if (this._TIEAutoOpt != null)
          this._TIEAutoOpt.CheckedChanged -= eventHandler;
        this._TIEAutoOpt = value;
        if (this._TIEAutoOpt == null)
          return;
        this._TIEAutoOpt.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox AutoSaveChk
    {
      get => this._AutoSaveChk;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._AutoSaveChk = value;
    }

    internal virtual System.Windows.Forms.Timer RealTimeTmr
    {
      get => this._RealTimeTmr;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RealTimeTmr_Tick);
        if (this._RealTimeTmr != null)
          this._RealTimeTmr.Tick -= eventHandler;
        this._RealTimeTmr = value;
        if (this._RealTimeTmr == null)
          return;
        this._RealTimeTmr.Tick += eventHandler;
      }
    }

    internal virtual Label RealTimeLbl
    {
      get => this._RealTimeLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._RealTimeLbl = value;
    }

    internal virtual Label UTCLbl
    {
      get => this._UTCLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._UTCLbl = value;
    }

    internal virtual Button SyncBtn
    {
      get => this._SyncBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SyncBtn_Click);
        if (this._SyncBtn != null)
          this._SyncBtn.Click -= eventHandler;
        this._SyncBtn = value;
        if (this._SyncBtn == null)
          return;
        this._SyncBtn.Click += eventHandler;
      }
    }

    internal virtual CheckBox ShowUTCChk
    {
      get => this._ShowUTCChk;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ShowUTCChk_CheckedChanged);
        if (this._ShowUTCChk != null)
          this._ShowUTCChk.CheckedChanged -= eventHandler;
        this._ShowUTCChk = value;
        if (this._ShowUTCChk == null)
          return;
        this._ShowUTCChk.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label GateLbl
    {
      get => this._GateLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._GateLbl = value;
    }

    internal virtual NumericUpDown Gate0UD
    {
      get => this._Gate0UD;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Gate0UD = value;
    }

    internal virtual NumericUpDown Gate1UD
    {
      get => this._Gate1UD;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Gate1UD = value;
    }

    internal virtual Button DefBtn
    {
      get => this._DefBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DefBtn_Click);
        if (this._DefBtn != null)
          this._DefBtn.Click -= eventHandler;
        this._DefBtn = value;
        if (this._DefBtn == null)
          return;
        this._DefBtn.Click += eventHandler;
      }
    }

    internal virtual Label BrdLbl
    {
      get => this._BrdLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._BrdLbl = value;
    }

    internal virtual Label BrdNumLbl
    {
      get => this._BrdNumLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._BrdNumLbl = value;
    }

    internal virtual Button MapBtn
    {
      get => this._MapBtn;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MapBtn_Click);
        if (this._MapBtn != null)
          this._MapBtn.Click -= eventHandler;
        this._MapBtn = value;
        if (this._MapBtn == null)
          return;
        this._MapBtn.Click += eventHandler;
      }
    }

    internal virtual System.Windows.Forms.Timer Timer1
    {
      get => this._Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        if (this._Timer1 != null)
          this._Timer1.Tick -= eventHandler;
        this._Timer1 = value;
        if (this._Timer1 == null)
          return;
        this._Timer1.Tick += eventHandler;
      }
    }

    internal virtual Label MasterLbl
    {
      get => this._MasterLbl;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._MasterLbl = value;
    }

    private int RecoveredNumMeas { get; set; }

    private GT668Def.GtiRealTime ParseRealTime(string s)
    {
      double d = Conversion.Val(s);
      GT668Def.GtiRealTime gtiRealTime;
      gtiRealTime.Seconds = checked ((uint) Math.Round(Math.Truncate(d)));
      gtiRealTime.Fraction = d - (double) gtiRealTime.Seconds;
      return gtiRealTime;
    }

    private void ClearAll()
    {
      this.Text = "GT668 Exerciser";
      this.DefBtn.Enabled = false;
      this.RunBtn.Enabled = false;
      this.CfgBtn.Enabled = false;
      this.CalBtn.Enabled = false;
      this.InfoBtn.Enabled = false;
      this.GateLbl.Enabled = false;
      this.Gate0UD.Enabled = false;
      this.Gate1UD.Enabled = false;
      this.FreqOpt.Enabled = false;
      this.PeriodOpt.Enabled = false;
      this.ContOpt.Enabled = false;
      this.TIEOpt.Enabled = false;
      this.TIEPnl.Enabled = false;
      this.TimeOpt.Enabled = false;
      this.MeasCntUD.Enabled = false;
      this.RepeatChk.Enabled = false;
      this.RepeatUD.Enabled = false;
      this.TimeoutUD.Enabled = false;
      this.ViewBtn.Enabled = false;
      this.GraphBtn.Enabled = false;
      this.StableBtn.Enabled = false;
      this.AutoSaveChk.Enabled = false;
      this.WrapChk.Enabled = false;
      this.SaveRawBtn.Enabled = false;
      if (this.ShowCfg)
      {
        MyProject.Forms.ConfigFrm.Close();
        this.ShowCfg = false;
      }
      if (this.ShowResults)
      {
        MyProject.Forms.ResultsFrm.Close();
        this.ShowResults = false;
      }
      if (this.ShowGraph)
      {
        MyProject.Forms.GraphFrm.Close();
        this.ShowGraph = false;
      }
      this.WriteConfigValues();
      ConfigOpt.Store();
    }

    private bool RecoverResults()
    {
      string Left = "";
      GT668Class.GtiRealTime[] gtiRealTimeArray1 = (GT668Class.GtiRealTime[]) null;
      GT668Class.GtiRealTime[] gtiRealTimeArray2 = (GT668Class.GtiRealTime[]) null;
      uint[] numArray1 = new uint[2]{ 0U, 0U };
      uint[] numArray2 = new uint[2]{ 1U, 1U };
      string str = "";
      bool[] flagArray = new bool[2]{ false, false };
      uint num1;
      if (File.Exists(this.RecoveredFileName[0]))
      {
        try
        {
          this.SaveFile[0] = new FileStream(this.RecoveredFileName[0], FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 16384, FileOptions.SequentialScan);
          this.SaveRd[0] = new StreamReader((Stream) this.SaveFile[0]);
          Left = this.SaveRd[0].ReadLine();
          string InputStr1 = this.SaveRd[0].ReadLine();
          numArray2[0] = checked ((uint) Math.Round(Conversion.Val(InputStr1)));
          if (Operators.CompareString(Left, "TIE", false) == 0)
            str = this.SaveRd[0].ReadLine();
          string InputStr2 = this.SaveRd[0].ReadLine();
          numArray1[0] = checked ((uint) Math.Round(Conversion.Val(InputStr2)));
          gtiRealTimeArray1 = new GT668Def.GtiRealTime[checked ((int) ((long) numArray1[0] - 1L) + 1)];
          int num2 = checked ((int) ((long) numArray1[0] - 1L));
          int index = 0;
          while (index <= num2 && !this.SaveRd[0].EndOfStream)
          {
            string[] strArray = this.SaveRd[0].ReadLine().Split('.');
            gtiRealTimeArray1[index].Seconds = checked ((uint) Math.Round(Conversion.Val(strArray[0])));
            if (strArray.Length > 1)
              gtiRealTimeArray1[index].Fraction = Conversion.Val("0." + strArray[1]);
            checked { ++index; }
          }
          num1 = checked ((uint) index);
        }
        finally
        {
          if (num1 > 0U)
            gtiRealTimeArray1 = (GT668Def.GtiRealTime[]) Utils.CopyArray((Array) gtiRealTimeArray1, (Array) new GT668Def.GtiRealTime[checked ((int) ((long) num1 - 1L) + 1)]);
          this.SaveFile[0].Close();
          File.Delete(this.RecoveredFileName[0]);
        }
        if (num1 > 0U)
          flagArray[0] = true;
      }
      uint num3;
      if (File.Exists(this.RecoveredFileName[1]))
      {
        try
        {
          this.SaveFile[1] = new FileStream(this.RecoveredFileName[1], FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 16384, FileOptions.SequentialScan);
          this.SaveRd[1] = new StreamReader((Stream) this.SaveFile[1]);
          Left = this.SaveRd[1].ReadLine();
          string InputStr1 = this.SaveRd[1].ReadLine();
          numArray2[1] = checked ((uint) Math.Round(Conversion.Val(InputStr1)));
          if (Operators.CompareString(Left, "TIE", false) == 0)
            str = this.SaveRd[1].ReadLine();
          string InputStr2 = this.SaveRd[1].ReadLine();
          numArray1[1] = checked ((uint) Math.Round(Conversion.Val(InputStr2)));
          gtiRealTimeArray2 = new GT900USBClass.GtiRealTime[checked ((int) ((long) numArray1[1] - 1L) + 1)];
          int num2 = checked ((int) ((long) numArray1[1] - 1L));
          int index = 0;
          while (index <= num2 && !this.SaveRd[1].EndOfStream)
          {
            string[] strArray = this.SaveRd[1].ReadLine().Split('.');
            gtiRealTimeArray2[index].Seconds = checked ((uint) Math.Round(Conversion.Val(strArray[0])));
            gtiRealTimeArray2[index].Fraction = Conversion.Val("0." + strArray[1]);
            checked { ++index; }
          }
          num3 = checked ((uint) index);
        }
        finally
        {
          if (num3 > 0U)
            gtiRealTimeArray2 = (GT668Def.GtiRealTime[]) Utils.CopyArray((Array) gtiRealTimeArray2, (Array) new GT668Def.GtiRealTime[checked ((int) ((long) num3 - 1L) + 1)]);
          this.SaveFile[1].Close();
          File.Delete(this.RecoveredFileName[1]);
        }
        if (num3 > 0U)
          flagArray[1] = true;
      }
      if (flagArray[0] && flagArray[1] && (int) numArray1[0] != (int) numArray1[1] || !flagArray[0] && !flagArray[1])
        return false;
      this.RecoveredMeas = Left;
      this.RecoveredTIEFreq = str;
      if (flagArray[0])
      {
        this.RecoveredTimetags0Ex = gtiRealTimeArray1;
        this.RecoveredPrescale[0] = numArray2[0];
        this.RecoveredNumTags[0] = numArray1[0];
        this.RecoveredCount[0] = num1;
      }
      else
      {
        this.RecoveredTimetags0Ex = (GT668Def.GtiRealTime[]) null;
        this.RecoveredPrescale[0] = 1U;
        this.RecoveredNumTags[0] = 0U;
        this.RecoveredCount[0] = 0U;
      }
      if (flagArray[1])
      {
        this.RecoveredTimetags1Ex = gtiRealTimeArray2;
        this.RecoveredPrescale[1] = numArray2[1];
        this.RecoveredNumTags[1] = numArray1[1];
        this.RecoveredCount[1] = num3;
      }
      else
      {
        this.RecoveredTimetags1Ex = (GT668Def.GtiRealTime[]) null;
        this.RecoveredPrescale[1] = 1U;
        this.RecoveredNumTags[1] = 0U;
        this.RecoveredCount[1] = 0U;
      }
      return true;
    }

    private double ParseFrequency(string str)
    {
      double num = 1.0;
      if (str == null)
        return -1.0;
      str = str.Trim();
      if (Operators.CompareString(str, "", false) == 0)
        return -1.0;
      if (str.Length >= 2 && Operators.CompareString(Microsoft.VisualBasic.Strings.Right(str, 2).ToLower(), "hz", false) == 0)
        str = Microsoft.VisualBasic.Strings.Left(str, checked (str.Length - 2)).Trim();
      if (Operators.CompareString(str, "", false) == 0)
        return -1.0;
      string Left = Microsoft.VisualBasic.Strings.Right(str, 1);
      if (!Versioned.IsNumeric((object) Left))
      {
        str = Microsoft.VisualBasic.Strings.Left(str, checked (str.Length - 1)).Trim();
        if (Operators.CompareString(str, "", false) == 0)
          return -1.0;
        if (Operators.CompareString(Left, "k", false) == 0 || Operators.CompareString(Left, "K", false) == 0)
          num = 1000.0;
        else if (Operators.CompareString(Left, "m", false) == 0)
          num = 0.001;
        else if (Operators.CompareString(Left, "M", false) == 0)
        {
          num = 1000000.0;
        }
        else
        {
          if (Operators.CompareString(Left, "G", false) != 0)
            return -1.0;
          num = 1000000000.0;
        }
      }
      return !Versioned.IsNumeric((object) str) ? -1.0 : Conversion.Val(str) * num;
    }

    private void Clear()
    {
      this.Results0 = (double[]) null;
      this.Results1 = (double[]) null;
      this.Time0 = (double[]) null;
      this.Time1 = (double[]) null;
      this.Res0Cnt = 0;
      this.Res1Cnt = 0;
      this.Mean0Txt.Text = "";
      this.StdDev0Txt.Text = "";
      this.Min0Txt.Text = "";
      this.Max0Txt.Text = "";
      this.Pk0Txt.Text = "";
      this.Cnt0Txt.Text = "";
      this.PreSc0Txt.Text = "";
      this.Thr0Txt.Text = "";
      this.MaxPk0Txt.Text = "";
      this.MinPk0Txt.Text = "";
      this.Mean1Txt.Text = "";
      this.StdDev1Txt.Text = "";
      this.Min1Txt.Text = "";
      this.Max1Txt.Text = "";
      this.Pk1Txt.Text = "";
      this.Cnt1Txt.Text = "";
      this.PreSc1Txt.Text = "";
      this.Thr1Txt.Text = "";
      this.MaxPk1Txt.Text = "";
      this.MinPk1Txt.Text = "";
      if (this.ShowResults)
        MyProject.Forms.ResultsFrm.Clear();
      if (this.ShowGraph)
        MyProject.Forms.GraphFrm.Clear();
      this.Refresh();
    }

    private void ReadConfigValues()
    {
      this.DevNum = this.BrdNum;
      string option1 = ConfigOpt.GetOption("Main.Device");
      if (option1 != null && Versioned.IsNumeric((object) option1))
      {
        int num = int.Parse(option1);
        if (num >= 0 && num < 32)
          this.DevNum = num;
      }
      this.CurLoc = this.Location;
      string option2 = ConfigOpt.GetOption("Main.Location.X");
      if (option2 != null && Versioned.IsNumeric((object) option2))
        this.CurLoc.X = int.Parse(option2);
      string option3 = ConfigOpt.GetOption("Main.Location.Y");
      if (option3 != null && Versioned.IsNumeric((object) option3))
        this.CurLoc.Y = int.Parse(option3);
      string option4 = ConfigOpt.GetOption("Main.WindowState");
      if (option4 != null && Versioned.IsNumeric((object) option4))
        this.CurState = (FormWindowState) int.Parse(option4);
      string option5 = ConfigOpt.GetOption("Main.Configure");
      if (option5 == null || !bool.TryParse(option5, out this.ShowCfg))
        this.ShowCfg = false;
      string option6 = ConfigOpt.GetOption("Main.Results");
      if (option6 == null || !bool.TryParse(option6, out this.ShowResults))
        this.ShowResults = false;
      string option7 = ConfigOpt.GetOption("Main.Graph");
      if (option7 == null || !bool.TryParse(option7, out this.ShowGraph))
        this.ShowGraph = false;
      string option8 = ConfigOpt.GetOption("Main.Stable");
      if (option8 == null || !bool.TryParse(option8, out this.ShowStable))
        this.ShowStable = false;
      string option9 = ConfigOpt.GetOption("Main.MeasCnt");
      if (option9 != null && Versioned.IsNumeric((object) option9))
        this.MeasCntUD.Value = new Decimal(int.Parse(option9));
      string option10 = ConfigOpt.GetOption("Main.Gate0Cnt");
      if (option10 != null && Versioned.IsNumeric((object) option10))
        this.Gate0UD.Value = new Decimal(int.Parse(option10));
      string option11 = ConfigOpt.GetOption("Main.Gate1Cnt");
      if (option11 != null && Versioned.IsNumeric((object) option11))
        this.Gate1UD.Value = new Decimal(int.Parse(option11));
      string option12 = ConfigOpt.GetOption("Main.AutoSave");
      if (option12 != null)
      {
        string str = option12;
        CheckBox autoSaveChk = this.AutoSaveChk;
        bool flag = autoSaveChk.Checked;
        ref bool local = ref flag;
        int num = bool.TryParse(str, out local) ? 1 : 0;
        autoSaveChk.Checked = flag;
        if (num != 0)
          goto label_26;
      }
      this.AutoSaveChk.Checked = false;
label_26:
      string option13 = ConfigOpt.GetOption("Main.Wrap");
      if (option13 != null)
      {
        string str = option13;
        CheckBox wrapChk = this.WrapChk;
        bool flag = wrapChk.Checked;
        ref bool local = ref flag;
        int num = bool.TryParse(str, out local) ? 1 : 0;
        wrapChk.Checked = flag;
        if (num != 0)
          goto label_29;
      }
      this.WrapChk.Checked = false;
label_29:
      string option14 = ConfigOpt.GetOption("Main.Function");
      if (option14 == null)
      {
        this.FreqOpt.Checked = true;
      }
      else
      {
        string lower = option14.ToLower();
        if (Operators.CompareString(lower, "frequency", false) == 0)
          this.FreqOpt.Checked = true;
        else if (Operators.CompareString(lower, "period", false) == 0)
          this.PeriodOpt.Checked = true;
        else if (Operators.CompareString(lower, "cont", false) == 0)
          this.ContOpt.Checked = true;
        else if (Operators.CompareString(lower, "tie", false) == 0)
          this.TIEOpt.Checked = true;
        else if (Operators.CompareString(lower, "time", false) == 0)
          this.TimeOpt.Checked = true;
        else
          this.FreqOpt.Checked = true;
      }
      string option15 = ConfigOpt.GetOption("Main.TIE");
      if (option15 != null && Operators.CompareString(option15.ToLower(), "auto", false) == 0)
        this.TIEAutoOpt.Checked = true;
      else
        this.TIEFreqOpt.Checked = true;
      string str1 = ConfigOpt.GetOption("Main.TIEFreq");
      this.TIEFreq = this.ParseFrequency(str1);
      if (this.TIEFreq < 0.0)
      {
        str1 = "10 MHz";
        this.TIEFreq = 10000000.0;
      }
      this.TIEFreqTxt.Text = str1;
      string option16 = ConfigOpt.GetOption("Main.RptEnb");
      if (option16 != null)
      {
        string str2 = option16;
        CheckBox repeatChk = this.RepeatChk;
        bool flag = repeatChk.Checked;
        ref bool local = ref flag;
        int num = bool.TryParse(str2, out local) ? 1 : 0;
        repeatChk.Checked = flag;
        if (num != 0)
          goto label_50;
      }
      this.RepeatChk.Checked = false;
label_50:
      string option17 = ConfigOpt.GetOption("Main.RptTime");
      if (option17 != null && Versioned.IsNumeric((object) option17))
        this.RepeatUD.Value = new Decimal(Conversion.Val(option17));
      string InputStr = Conversions.ToString(option17 != null && Conversions.ToBoolean(ConfigOpt.GetOption("Main.Timeout")));
      if (!Versioned.IsNumeric((object) InputStr))
        return;
      this.TimeoutUD.Value = new Decimal(Conversion.Val(InputStr));
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void ReadDeviceNumber(int Board, ref int Dev)
    {
      Dev = Board;
      string str = "Exr668Conf_" + Conversions.ToString(Board) + ".xml";
      if (MyProject.Computer.Keyboard.CtrlKeyDown)
      {
        if (File.Exists(Application.UserAppDataPath + "\\" + str))
          FileSystem.Kill(Application.UserAppDataPath + "\\" + str);
      }
      try
      {
        ConfigOpt.Initialize(Application.UserAppDataPath + "\\" + str);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        File.Delete(Application.UserAppDataPath + "\\" + str);
        ConfigOpt.Initialize(Application.UserAppDataPath + "\\" + str);
        ProjectData.ClearProjectError();
      }
      string option = ConfigOpt.GetOption("Main.Device");
      if (option == null || !Versioned.IsNumeric((object) option))
        return;
      int num = int.Parse(option);
      if (num < 0 || num >= 32)
        return;
      Dev = num;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SetDeviceNumber(int Board, int Dev)
    {
      string str = "Exr668Conf_" + Conversions.ToString(Board) + ".xml";
      if (MyProject.Computer.Keyboard.CtrlKeyDown)
      {
        if (File.Exists(Application.UserAppDataPath + "\\" + str))
          FileSystem.Kill(Application.UserAppDataPath + "\\" + str);
      }
      try
      {
        ConfigOpt.Initialize(Application.UserAppDataPath + "\\" + str);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        File.Delete(Application.UserAppDataPath + "\\" + str);
        ConfigOpt.Initialize(Application.UserAppDataPath + "\\" + str);
        ProjectData.ClearProjectError();
      }
      ConfigOpt.SetOption("Main.Device", Dev.ToString());
      ConfigOpt.Store();
    }

    private void WriteConfigValues()
    {
      ConfigOpt.SetOption("Main.Device", this.DevNum.ToString());
      if (this.WindowState == FormWindowState.Normal)
      {
        Point location = this.Location;
        ConfigOpt.SetOption("Main.Location.X", location.X.ToString());
        location = this.Location;
        ConfigOpt.SetOption("Main.Location.Y", location.Y.ToString());
      }
      else
      {
        ConfigOpt.SetOption("Main.Location.X", this.CurLoc.X.ToString());
        ConfigOpt.SetOption("Main.Location.Y", this.CurLoc.Y.ToString());
      }
      int num1 = (int) this.CurState;
      ConfigOpt.SetOption("Main.WindowState", num1.ToString());
      ConfigOpt.SetOption("Main.Configure", this.ShowCfg.ToString());
      ConfigOpt.SetOption("Main.Results", this.ShowResults.ToString());
      ConfigOpt.SetOption("Main.Graph", this.ShowGraph.ToString());
      ConfigOpt.SetOption("Main.Stable", this.ShowStable.ToString());
      num1 = Convert.ToInt32(this.MeasCntUD.Value);
      ConfigOpt.SetOption("Main.MeasCnt", num1.ToString());
      num1 = Convert.ToInt32(this.Gate0UD.Value);
      ConfigOpt.SetOption("Main.Gate0Cnt", num1.ToString());
      num1 = Convert.ToInt32(this.Gate1UD.Value);
      ConfigOpt.SetOption("Main.Gate1Cnt", num1.ToString());
      ConfigOpt.SetOption("Main.AutoSave", this.AutoSaveChk.Checked.ToString());
      bool flag = this.WrapChk.Checked;
      ConfigOpt.SetOption("Main.Wrap", flag.ToString());
      if (this.FreqOpt.Checked)
        ConfigOpt.SetOption("Main.Function", "Frequency");
      else if (this.PeriodOpt.Checked)
        ConfigOpt.SetOption("Main.Function", "Period");
      else if (this.ContOpt.Checked)
        ConfigOpt.SetOption("Main.Function", "Cont");
      else if (this.TIEOpt.Checked)
        ConfigOpt.SetOption("Main.Function", "TIE");
      else if (this.TimeOpt.Checked)
        ConfigOpt.SetOption("Main.Function", "Time");
      if (this.TIEAutoOpt.Checked)
        ConfigOpt.SetOption("Main.TIE", "Auto");
      else
        ConfigOpt.SetOption("Main.TIE", "Man");
      ConfigOpt.SetOption("Main.TIEFreq", this.TIEFreqTxt.Text);
      flag = this.RepeatChk.Checked;
      ConfigOpt.SetOption("Main.RptEnb", flag.ToString());
      Decimal num2 = this.RepeatUD.Value;
      ConfigOpt.SetOption("Main.RptTime", num2.ToString());
      num2 = this.TimeoutUD.Value;
      ConfigOpt.SetOption("Main.Timeout", num2.ToString());
    }

    private void CfgBtn_Click(object sender, EventArgs e)
    {
      this.ShowCfg = true;
      MyProject.Forms.ConfigFrm.Show();
      MyProject.Forms.ConfigFrm.Select();
    }

    private void InitBtn_Click(object sender, EventArgs e)
    {
      if (this.Initialized)
        GT668Def.GT668Close();
      if (this.BrdNum < 0)
        this.BrdNum = GT668Def.GT668EnumerateBoards(true);
      if (this.BrdNum < 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "No GT668 card found", MsgBoxStyle.Critical, (object) "Error");
      }
      else
      {
        GT668Def.GT668BoardNumber(this.DevNum, this.BrdNum);
        GT668Def.GT668Initialize(this.DevNum);
        int ErrNum = GT668Def.GT668GetError();
        if (this.IgnoreCalErr && (ErrNum == 3 || ErrNum == 2))
          ErrNum = 0;
        string boardModel = GT668Def.GT668GetBoardModel();
        if (this.NumBoards > 1)
          this.Text = "GT668 Exerciser (Device #" + Conversions.ToString(this.DevNum) + "): " + boardModel;
        else
          this.Text = "GT668 Exerciser: " + boardModel;
        this.IsUSB = Operators.CompareString(Microsoft.VisualBasic.Strings.Left(boardModel, 8), "GT668USB", false) == 0;
        if (this.IsUSB)
          this.WrapChk.Checked = true;
        GT668Def.GT668GetBoardRevision(ref this.BrdRev);
        this.MasterLbl.Visible = GT668Def.GT668IsMaster();
        this.RealTimeTmr.Enabled = false;
        this.UTCLbl.Visible = false;
        this.RealTimeLbl.Visible = false;
        if (ErrNum != 0)
        {
          string ErrMsg = "";
          GT668Def.GT668GetErrorMessage(ErrNum, ref ErrMsg);
          int num2 = (int) Interaction.MsgBox((object) ("Error: " + ErrMsg), MsgBoxStyle.Exclamation, (object) "Error");
          GT668Def.GT668ClearError();
        }
        else
        {
          if (this.Recover)
          {
            this.running = true;
            this.MeasTmr.Enabled = false;
            this.MeasTmr_Tick((object) this.MeasTmr, e);
            this.Recover = false;
          }
          this.DefBtn.Enabled = true;
          this.MeasCntUD.Enabled = true;
          if (this.FreqOpt.Checked || this.PeriodOpt.Checked || this.TIEOpt.Checked)
          {
            this.GateLbl.Enabled = true;
            this.Gate0UD.Enabled = true;
            this.Gate1UD.Enabled = true;
          }
          else
          {
            this.GateLbl.Enabled = false;
            this.Gate0UD.Enabled = false;
            this.Gate1UD.Enabled = false;
          }
          this.FreqOpt.Enabled = true;
          this.PeriodOpt.Enabled = true;
          this.ContOpt.Enabled = true;
          this.TIEOpt.Enabled = true;
          this.TIEPnl.Enabled = true;
          this.TimeOpt.Enabled = true;
          this.CfgBtn.Enabled = true;
          this.CalBtn.Enabled = true;
          this.InfoBtn.Enabled = true;
          this.RunBtn.Enabled = true;
          this.ViewBtn.Enabled = true;
          this.GraphBtn.Enabled = true;
          this.RepeatChk.Enabled = true;
          this.RepeatUD.Enabled = true;
          this.TimeoutUD.Enabled = true;
          this.AutoSaveChk.Enabled = true;
          this.WrapChk.Enabled = !this.IsUSB;
          this.WrapChk.Visible = !this.IsUSB;
          this.SaveRawBtn.Enabled = !this.WrapChk.Checked;
          if (this.TIEOpt.Checked)
            this.StableBtn.Enabled = true;
          this.Initialized = true;
          if (this.ShowCfg)
            this.CfgBtn_Click((object) this.CfgBtn, e);
          if (this.ShowResults)
            this.ViewBtn_Click((object) this.ViewBtn, e);
          if (this.ShowGraph)
            this.GraphBtn_Click((object) this.GraphBtn, e);
          if (this.ShowStable && this.TIEOpt.Checked)
            this.StableBtn_Click((object) this.StableBtn, e);
        }
        this.Select();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void ExrFrm_Load(object sender, EventArgs e)
    {
      this.ConfigFileName = "";
      try
      {
        foreach (string commandLineArg in MyProject.Application.CommandLineArgs)
        {
          if (commandLineArg.Length > 7 && Operators.CompareString(commandLineArg.Substring(0, 7).ToLower(), "/setup=", false) == 0)
          {
            this.ConfigFileName = commandLineArg.Substring(7);
            this.UserFile = true;
          }
          else if (commandLineArg.Length > 5 && Operators.CompareString(commandLineArg.Substring(0, 5).ToLower(), "/dev=", false) == 0 && Versioned.IsNumeric((object) commandLineArg.Substring(5)))
          {
            this.BrdNum = Conversions.ToInteger(commandLineArg.Substring(5));
            this.UserFile = true;
          }
          else if (commandLineArg.Length == 7 && Operators.CompareString(commandLineArg.ToLower(), "/ignore", false) == 0)
          {
            this.IgnoreCalErr = true;
          }
          else
          {
            int num = (int) Interaction.MsgBox((object) ("Invalid option ignored: '" + commandLineArg + "'"), MsgBoxStyle.Exclamation, (object) "Error");
          }
        }
      }
      finally
      {
        IEnumerator<string> enumerator;
        enumerator?.Dispose();
      }
      this.FormHeight = this.Height;
      this.RecoveredFileName[0] = Application.UserAppDataPath + "\\Timetags0.csv";
      this.RecoveredFileName[1] = Application.UserAppDataPath + "\\Timetags1.csv";
      this.DefBtn.Enabled = false;
      this.MeasCntUD.Enabled = false;
      this.GateLbl.Enabled = false;
      this.Gate0UD.Enabled = false;
      this.Gate1UD.Enabled = false;
      this.FreqOpt.Enabled = false;
      this.PeriodOpt.Enabled = false;
      this.ContOpt.Enabled = false;
      this.TIEOpt.Enabled = false;
      this.TIEPnl.Enabled = false;
      this.TimeOpt.Enabled = false;
      this.CfgBtn.Enabled = false;
      this.CalBtn.Enabled = false;
      this.InfoBtn.Enabled = false;
      this.RunBtn.Enabled = false;
      this.ViewBtn.Enabled = false;
      this.GraphBtn.Enabled = false;
      this.StableBtn.Enabled = false;
      this.FreqOpt.Checked = true;
      this.MeasName = "Frequency";
      this.Units = "Hz";
      int index1 = 0;
      int num1 = Information.UBound((Array) this.Boards);
      int index2 = 0;
      while (index2 <= num1)
      {
        this.Boards[index2] = -1;
        this.Devices[index2] = -1;
        checked { ++index2; }
      }
      if (this.BrdNum < 0)
      {
        int num2;
        do
        {
          num2 = GT668Def.GT668EnumerateBoards(index1 == 0);
          if (this.BrdNum < 0)
            this.BrdNum = num2;
          if (num2 >= 0)
          {
            this.Boards[index1] = num2;
            checked { ++index1; }
          }
        }
        while (num2 >= 0);
      }
      else
      {
        index1 = 1;
        this.Boards[0] = this.BrdNum;
      }
      if (this.BrdNum < 0)
      {
        string ErrMsg = "No board found";
        int error = GT668Def.GT668GetError();
        if ((uint) error > 0U)
          GT668Def.GT668GetErrorMessage(error, ref ErrMsg);
        int num2 = (int) Interaction.MsgBox((object) ErrMsg, MsgBoxStyle.Critical);
        ProjectData.EndApp();
      }
      if (this.UserFile && Operators.CompareString(this.ConfigFileName, "", false) == 0)
        this.ConfigFileName = "Exr668Conf_" + Conversions.ToString(this.BrdNum) + ".xml";
      this.NumBoards = index1;
      if (!this.UserFile)
      {
        this.ConfigFileName = "Exr668Conf_" + Conversions.ToString(this.BrdNum) + ".xml";
        if (MyProject.Computer.Keyboard.CtrlKeyDown && File.Exists(Application.UserAppDataPath + "\\" + this.ConfigFileName))
          FileSystem.Kill(Application.UserAppDataPath + "\\" + this.ConfigFileName);
        if (!File.Exists(Application.UserAppDataPath + "\\" + this.ConfigFileName))
        {
          string str1 = "";
          if (Operators.CompareString(Microsoft.VisualBasic.Strings.Right(Application.UserAppDataPath, Microsoft.VisualBasic.Strings.Len(Application.ProductVersion)), Application.ProductVersion, false) == 0)
          {
            string[] array = Directory.EnumerateDirectories(Microsoft.VisualBasic.Strings.Left(Application.UserAppDataPath, checked (Microsoft.VisualBasic.Strings.Len(Application.UserAppDataPath) - Microsoft.VisualBasic.Strings.Len(Application.ProductVersion)))).ToArray<string>();
            int index3 = Information.UBound((Array) array);
            while (index3 >= 0)
            {
              string str2 = array[index3];
              if (File.Exists(str2 + "\\" + this.ConfigFileName))
              {
                str1 = str2 + "\\" + this.ConfigFileName;
                break;
              }
              if (File.Exists(str2 + "\\Exr668Conf.xml"))
              {
                str1 = str2 + "\\Exr668Conf.xml";
                break;
              }
              checked { index3 += -1; }
            }
          }
          if (Operators.CompareString(str1, "", false) != 0)
            File.Move(str1, Application.UserAppDataPath + "\\" + this.ConfigFileName);
          else if (File.Exists(Application.UserAppDataPath + "\\Exr668Conf.xml"))
            File.Move(Application.UserAppDataPath + "\\Exr668Conf.xml", Application.UserAppDataPath + "\\" + this.ConfigFileName);
        }
      }
      this.ReadDeviceNumber(this.BrdNum, ref this.DevNum);
      if (this.NumBoards >= 1)
      {
        this.DevCbo.Items.Clear();
        if (this.UserFile)
        {
          this.DevCbo.Items.Add((object) Conversions.ToString(this.DevNum));
          this.DevCbo.SelectedIndex = 0;
          this.DevCbo.Enabled = false;
          this.Devices[0] = this.DevNum;
          this.BrdNumLbl.Text = Conversions.ToString(this.BrdNum);
        }
        else
        {
          int num2 = checked (this.NumBoards - 1);
          int index3 = 0;
          while (index3 <= num2)
          {
            int devNum;
            if (this.Boards[index3] == this.BrdNum)
              devNum = this.DevNum;
            else
              this.ReadDeviceNumber(this.Boards[index3], ref devNum);
            this.DevCbo.Items.Add((object) Conversions.ToString(devNum));
            this.Devices[index3] = devNum;
            checked { ++index3; }
          }
          int num3 = checked (this.NumBoards - 1);
          int index4 = 0;
          while (index4 <= num3)
          {
            if (this.Devices[index4] == this.DevNum)
            {
              this.DevCbo.SelectedIndex = index4;
              this.BrdNumLbl.Text = Conversions.ToString(this.Boards[index4]);
              break;
            }
            checked { ++index4; }
          }
        }
        this.DevCbo.Visible = true;
        this.DevLbl.Visible = true;
        this.MapBtn.Visible = true;
      }
      this.DevCbo.Enabled = this.NumBoards > 1;
      this.BrdLbl.Visible = this.DevLbl.Visible;
      this.BrdNumLbl.Visible = this.DevLbl.Visible;
      try
      {
        ConfigOpt.Initialize(Application.UserAppDataPath + "\\" + this.ConfigFileName);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        File.Delete(Application.UserAppDataPath + "\\" + this.ConfigFileName);
        ConfigOpt.Initialize(Application.UserAppDataPath + "\\" + this.ConfigFileName);
        ProjectData.ClearProjectError();
      }
      this.ReadConfigValues();
      this.RawData = (uint[]) null;
      this.RawConverted = 0U;
      this.RawRead = 0U;
      this.RawCount = 0U;
      uint num4 = 0;
      int num5 = Information.UBound((Array) this.Boards);
      int index5 = 0;
      while (index5 <= num5)
      {
        int board = this.Boards[index5];
        if (board >= 0)
          num4 = checked ((uint) ((long) num4 | (long) (1 << board)));
        checked { ++index5; }
      }
      this.Recover = false;
      if (this.AutoSaveChk.Checked)
        this.Recover = this.RecoverResults();
      this.WindowState = this.CurState;
      if (this.WindowState == FormWindowState.Normal && this.CurLoc.X != -32000 && this.CurLoc.Y != -32000)
        this.Location = this.CurLoc;
      if (this.WindowState == FormWindowState.Minimized)
        this.WindowState = FormWindowState.Normal;
      this.Visible = true;
      int num6 = checked (this.NumBoards - 2);
      int index6 = 0;
      while (index6 <= num6)
      {
        if (this.Boards[index6] >= 0 && this.Devices[index6] >= 0)
        {
          int num2 = checked (index6 + 1);
          int num3 = checked (this.NumBoards - 1);
          int index3 = num2;
          while (index3 <= num3)
          {
            if (this.Boards[index3] >= 0 && this.Devices[index3] >= 0 && this.Devices[index3] == this.Devices[index6])
            {
              int num7 = (int) Interaction.MsgBox((object) ("Duplicate mapping. Board #" + Conversions.ToString(this.Boards[index6]) + " and Board #" + Conversions.ToString(this.Boards[index3]) + " both use device #" + Conversions.ToString(this.Devices[index6]) + "\r\nPlease change the mapping"), MsgBoxStyle.Exclamation, (object) "Error");
              this.MapBtn.PerformClick();
              Application.DoEvents();
              return;
            }
            checked { ++index3; }
          }
        }
        checked { ++index6; }
      }
      this.Select();
    }

    private void ExrFrm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.ShowCfg)
        MyProject.Forms.ConfigFrm.Close();
      if (this.ShowResults)
        MyProject.Forms.ResultsFrm.Close();
      if (this.ShowGraph)
        MyProject.Forms.GraphFrm.Close();
      if (this.ShowStable)
        MyProject.Forms.StableFrm.Close();
      this.WriteConfigValues();
      if (this.Initialized)
      {
        GT668Def.GT668Close();
        this.Initialized = false;
      }
      ConfigOpt.Store();
    }

    public string FormatResult(double res, double interval)
    {
      string str = "";
      if (this.FreqOpt.Checked)
      {
        int digits;
        if (interval == this.last_interval)
        {
          digits = this.last_digits;
        }
        else
        {
          digits = interval <= 0.0 ? 15 : checked ((int) Math.Round(Math.Log10(unchecked (interval / 1E-15))));
          this.last_digits = digits;
          this.last_interval = interval;
        }
        GtiUtilDef.GtiFormatBySignificance(257U, digits, res, ref str);
      }
      else if (res == 0.0)
      {
        str = "0.00";
      }
      else
      {
        int least_dig = -15;
        if (Math.Abs(res) < 1E-10)
          least_dig = checked ((int) Math.Round(unchecked (Math.Log10(Math.Abs(res)) - 3.0)));
        GtiUtilDef.GtiFormatByResolution(257U, least_dig, res, ref str);
      }
      return str;
    }

    public string FormatVoltage(double v) => Microsoft.VisualBasic.Strings.FormatNumber((object) v, 3) + "V";

    private void RunBtn_Click(object sender, EventArgs e)
    {
      if (this.running)
      {
        this.RunBtn.Text = "Run";
        this.running = false;
      }
      else
      {
        this.InitBtn.Enabled = false;
        this.DefBtn.Enabled = false;
        this.CfgBtn.Enabled = false;
        this.CalBtn.Enabled = false;
        this.InfoBtn.Enabled = false;
        this.GateLbl.Enabled = false;
        this.Gate0UD.Enabled = false;
        this.Gate1UD.Enabled = false;
        this.FreqOpt.Enabled = false;
        this.PeriodOpt.Enabled = false;
        this.ContOpt.Enabled = false;
        this.TIEOpt.Enabled = false;
        this.TIEPnl.Enabled = false;
        this.TimeOpt.Enabled = false;
        this.MeasCntUD.Enabled = false;
        this.RepeatChk.Enabled = false;
        this.RepeatUD.Enabled = false;
        this.TimeoutUD.Enabled = false;
        this.AutoSaveChk.Enabled = false;
        this.WrapChk.Enabled = false;
        this.SaveRawBtn.Enabled = false;
        if (this.ShowCfg)
          MyProject.Forms.ConfigFrm.EnableControls = false;
        if (this.ShowGraph)
          MyProject.Forms.GraphFrm.Clear();
        if (this.ShowResults)
          MyProject.Forms.ResultsFrm.Clear();
        this.running = true;
        this.RunBtn.Text = "Abort";
        this.Refresh();
        Application.DoEvents();
        this.MeasTmr.Enabled = this.RepeatChk.Checked;
        this.MeasTmr_Tick((object) this.MeasTmr, new EventArgs());
        this.Recover = false;
        while (this.MeasTmr.Enabled)
        {
          Application.DoEvents();
          Application.DoEvents();
          Application.DoEvents();
        }
        this.running = false;
        this.RunBtn.Text = "Run";
        this.InitBtn.Enabled = true;
        this.DefBtn.Enabled = true;
        if (this.FreqOpt.Checked || this.PeriodOpt.Checked || this.TIEOpt.Checked)
        {
          this.GateLbl.Enabled = true;
          this.Gate0UD.Enabled = true;
          this.Gate1UD.Enabled = true;
        }
        else
        {
          this.GateLbl.Enabled = false;
          this.Gate0UD.Enabled = false;
          this.Gate1UD.Enabled = false;
        }
        this.CfgBtn.Enabled = true;
        this.CalBtn.Enabled = true;
        this.InfoBtn.Enabled = true;
        this.FreqOpt.Enabled = true;
        this.PeriodOpt.Enabled = true;
        this.ContOpt.Enabled = true;
        this.TIEOpt.Enabled = true;
        this.TIEPnl.Enabled = true;
        this.TimeOpt.Enabled = true;
        this.MeasCntUD.Enabled = true;
        this.RepeatChk.Enabled = true;
        this.RepeatUD.Enabled = true;
        this.TimeoutUD.Enabled = true;
        this.AutoSaveChk.Enabled = true;
        this.WrapChk.Enabled = !this.IsUSB;
        this.WrapChk.Visible = !this.IsUSB;
        this.SaveRawBtn.Enabled = !this.WrapChk.Checked;
        if (!this.ShowCfg)
          return;
        MyProject.Forms.ConfigFrm.EnableControls = true;
      }
    }

    private void Opt_CheckedChanged(object sender, EventArgs e)
    {
      bool flag = false;
      if (sender == this.FreqOpt)
      {
        this.MeasName = "Frequency";
        this.Units = "Hz";
        this.StableBtn.Enabled = false;
        flag = true;
      }
      else if (sender == this.PeriodOpt)
      {
        this.MeasName = "Period";
        this.Units = "s";
        this.StableBtn.Enabled = false;
        flag = true;
      }
      else if (sender == this.ContOpt)
      {
        this.MeasName = "Continuous Time";
        this.Units = "s";
        this.StableBtn.Enabled = false;
      }
      else if (sender == this.TIEOpt)
      {
        this.MeasName = "TIE";
        this.Units = "s";
        this.StableBtn.Enabled = this.TIEOpt.Enabled;
        flag = true;
      }
      else
      {
        this.MeasName = "Time Interval";
        this.Units = "s";
        this.StableBtn.Enabled = false;
      }
      if (!this.StableBtn.Enabled && this.ShowStable)
        MyProject.Forms.StableFrm.Close();
      this.GateLbl.Enabled = flag;
      this.Gate0UD.Enabled = flag;
      this.Gate1UD.Enabled = flag;
      this.Clear();
    }


    GT900USBClass GT668 = new GT900USBClass();

    private void MeasTmr_Tick(object sender, EventArgs e)
    {
      int num1 = Convert.ToInt32(this.MeasCntUD.Value);
     GT668Class.GtiRealTime[] gtiRealTimeArray1 = (GT668Class.GtiRealTime[]) null;
     GT668Class.GtiRealTime[] gtiRealTimeArray2 = (GT668Class.GtiRealTime[]) null;
      int num2 = 0;
      int num3 = 0;
      uint presc1 = 1;
      uint presc2 = 1;
      double v1 = 0.0;
      double v2 = 0.0;
      double posv1 = 0.0;
      double negv1 = 0.0;
      double posv2 = 0.0;
      double negv2 = 0.0;
      string str1 = "";
            GT668Class.GtiInputSel sel1 = GT668Class.GtiInputSel.GT_CHA_POS;
            GT668Class.GtiInputSel sel2 = GT668Class.GtiInputSel.GT_CHB_POS;
      Stopwatch stopwatch = new Stopwatch();
      if (!this.running)
      {
        this.MeasTmr.Enabled = false;
      }
      else
      {
        this.Clear();
        GT668.ClearError();
        GT668Class.GtiRefClkSrc src = (GT668Def.GtiRefClkSrc) MyProject.Forms.ConfigFrm.ClkSrcCbo.SelectedIndex;
        if (this.LastRef != src)
        {
          if (src == GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL)
          {
            posv2 = 0.0;
            negv2 = 0.0;
            GT668.MeasureAmplitude(GT668Class.GtiSignal.GT_SIG_CLK, ref posv2, ref negv2, 1000000.0);
            if (posv2 - negv2 < 0.25)
            {
              int num4 = (int) Interaction.MsgBox((object) "No signal detected on CLK input for Externa Reference usage.\r\nInternal reference will be used instead", MsgBoxStyle.Exclamation, (object) "Error");
              src = GT668Def.GtiRefClkSrc.GT_REF_INTERNAL;
              MyProject.Forms.ConfigFrm.ClkSrcCbo.SelectedIndex = (int) src;
              GT668Def.GT668SetReferenceClock(src, false, false);
            }
          }
          this.LastRef = src;
        }
        MyProject.Forms.ConfigFrm.LoadSetup();
        if (this.Recover)
        {
          if (Operators.CompareString(this.RecoveredMeas, "Frequency", false) == 0)
            this.FreqOpt.Checked = true;
          else if (Operators.CompareString(this.RecoveredMeas, "Period", false) == 0)
            this.PeriodOpt.Checked = true;
          else if (Operators.CompareString(this.RecoveredMeas, "Continuous Time", false) == 0)
            this.ContOpt.Checked = true;
          else if (Operators.CompareString(this.RecoveredMeas, "TIE", false) == 0)
            this.TIEOpt.Checked = true;
          else if (Operators.CompareString(this.RecoveredMeas, "Time Interval", false) == 0)
            this.TimeOpt.Checked = true;
          else
            this.Recover = false;
        }
        int val1;
        int val2;
        bool enb1;
        bool enb2;
        if (this.Recover)
        {
          this.MeasName = this.RecoveredMeas;
          this.TIEFreqTxt.Text = this.RecoveredTIEFreq;
          gtiRealTimeArray1 = this.RecoveredTimetags0Ex;
          gtiRealTimeArray2 = this.RecoveredTimetags1Ex;
          num2 = checked ((int) this.RecoveredNumTags[0]);
          num3 = checked ((int) this.RecoveredNumTags[1]);
          val1 = checked ((int) this.RecoveredCount[0]);
          val2 = checked ((int) this.RecoveredCount[1]);
          enb1 = num2 > 0;
          enb2 = num3 > 0;
          presc1 = this.RecoveredPrescale[0];
          presc2 = this.RecoveredPrescale[1];
          num1 = num2;
          if (!this.TimeOpt.Checked & !this.TIEOpt.Checked)
            checked { --num1; }
          this.MeasCntUD.Value = new Decimal(num1);
        }
        else
        {
          val1 = 0;
          val2 = 0;
        }
        if (!this.Recover)
        {
          GT668Def.GT668SetMemoryWrapMode(this.WrapChk.Checked);
          GT668Def.GT668GetMeasEnable(0, ref enb1);
          GT668Def.GT668GetMeasEnable(1, ref enb2);
        }
        if (!enb1 && !enb2 || this.TimeOpt.Checked && (!enb1 || !enb2))
          return;
        bool flag1 = false;
        bool flag2 = false;
        GT668Def.GT668GetMeasInput(0, ref sel1);
        GT668Def.GT668GetMeasInput(1, ref sel2);
        if (enb1 && (sel1 == GT668Def.GtiInputSel.GT_CHA_NEG || sel1 == GT668Def.GtiInputSel.GT_CHA_POS))
          flag1 = true;
        if (enb2 && (sel2 == GT668Def.GtiInputSel.GT_CHA_NEG || sel2 == GT668Def.GtiInputSel.GT_CHA_POS))
          flag1 = true;
        if (enb1 && (sel1 == GT668Def.GtiInputSel.GT_CHB_NEG || sel1 == GT668Def.GtiInputSel.GT_CHB_POS))
          flag2 = true;
        if (enb2 && (sel2 == GT668Def.GtiInputSel.GT_CHB_NEG || sel2 == GT668Def.GtiInputSel.GT_CHB_POS))
          flag2 = true;
        if (!this.TimeOpt.Checked & !this.TIEOpt.Checked)
          checked { ++num1; }
        if (!this.Recover)
        {
          posv1 = 0.0;
          negv1 = 0.0;
          v1 = 0.0;
          GT668Def.GtiThrMode thr_mode;
          if (flag1)
          {
            GT668Def.GT668MeasureAmplitude(GT668Def.GtiSignal.GT_SIG_A, ref posv1, ref negv1, 1000.0);
            if (Math.Abs(posv1 - negv1) < 0.1)
            {
              posv1 = (posv1 + negv1) / 2.0;
              negv1 = posv1;
              GT668Def.GT668GetInputThreshold(GT668Def.GtiSignal.GT_SIG_A, ref thr_mode, ref v1);
              if (thr_mode == GT668Def.GtiThrMode.GT_THR_PERCENTS)
                GT668Def.GT668SetInputThreshold(GT668Def.GtiSignal.GT_SIG_A, GT668Def.GtiThrMode.GT_THR_VOLTS, posv1 + 0.5);
            }
            GT668Def.GT668GetActualInputThreshold(GT668Def.GtiSignal.GT_SIG_A, ref v1);
          }
          posv2 = 0.0;
          negv2 = 0.0;
          v2 = 0.0;
          if (flag2)
          {
            GT668Def.GT668MeasureAmplitude(GT668Def.GtiSignal.GT_SIG_B, ref posv2, ref negv2, 1000.0);
            if (Math.Abs(posv2 - negv2) < 0.1)
            {
              posv2 = (posv2 + negv2) / 2.0;
              negv2 = posv2;
              GT668Def.GT668GetInputThreshold(GT668Def.GtiSignal.GT_SIG_B, ref thr_mode, ref v2);
              if (thr_mode == GT668Def.GtiThrMode.GT_THR_PERCENTS)
                GT668Def.GT668SetInputThreshold(GT668Def.GtiSignal.GT_SIG_B, GT668Def.GtiThrMode.GT_THR_VOLTS, posv2 + 0.5);
            }
            GT668Def.GT668GetActualInputThreshold(GT668Def.GtiSignal.GT_SIG_B, ref v2);
          }
        }
        try
        {
          if (!this.Recover)
          {
            val1 = 0;
            gtiRealTimeArray1 = new GT668Def.GtiRealTime[checked (num1 - 1 + 1)];
            val2 = 0;
            gtiRealTimeArray2 = new GT668Def.GtiRealTime[checked (num1 - 1 + 1)];
            num2 = !enb1 ? 0 : num1;
            num3 = !enb2 ? 0 : num1;
          }
          this.RawData = (uint[]) null;
          this.RawConverted = 0U;
          this.RawRead = 0U;
          if (this.WrapChk.Checked)
          {
            this.RawCount = 0U;
          }
          else
          {
            this.RawCount = checked ((uint) (num2 + num3 + 1));
            if (this.RawCount > 0U)
              this.RawData = new uint[checked ((int) ((long) this.RawCount - 1L) + 1)];
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          if (exception is OutOfMemoryException)
          {
            int num4 = (int) Interaction.MsgBox((object) "Out of memory, try to reduce the number of measurements.", MsgBoxStyle.Exclamation, (object) "Error");
          }
          else
          {
            int num5 = (int) Interaction.MsgBox((object) ("Exception: " + exception.Message));
          }
          ProjectData.ClearProjectError();
          return;
        }
        if (!this.Recover)
        {
          uint cnt1 = 1;
          uint cnt2 = 1;
          if (this.FreqOpt.Checked || this.PeriodOpt.Checked || this.TIEOpt.Checked)
          {
            cnt1 = Convert.ToUInt32(this.Gate0UD.Value);
            cnt2 = Convert.ToUInt32(this.Gate1UD.Value);
          }
          GT668Def.GT668SetMeasGate(0, cnt1);
          GT668Def.GT668SetMeasGate(1, cnt2);
        }
        try
        {
          this.Results0 = (double[]) null;
          this.Results1 = (double[]) null;
          this.Time0 = (double[]) null;
          this.Time1 = (double[]) null;
          this.Res0Cnt = 0;
          this.Res1Cnt = 0;
          if (this.FreqOpt.Checked)
          {
            if (enb1)
            {
              this.Results0 = new double[checked (num1 - 2 + 1)];
              this.Time0 = new double[checked (num1 - 2 + 1)];
            }
            if (enb2)
            {
              this.Results1 = new double[checked (num1 - 2 + 1)];
              this.Time1 = new double[checked (num1 - 2 + 1)];
            }
            str1 = "Hz";
          }
          else if (this.PeriodOpt.Checked)
          {
            if (enb1)
            {
              this.Results0 = new double[checked (num1 - 2 + 1)];
              this.Time0 = new double[checked (num1 - 2 + 1)];
            }
            if (enb2)
            {
              this.Results1 = new double[checked (num1 - 2 + 1)];
              this.Time1 = new double[checked (num1 - 2 + 1)];
            }
            str1 = "s";
          }
          else if (this.ContOpt.Checked)
          {
            if (enb1)
            {
              this.Results0 = new double[checked (num1 - 2 + 1)];
              this.Time0 = new double[checked (num1 - 2 + 1)];
            }
            if (enb2)
            {
              this.Results1 = new double[checked (num1 - 2 + 1)];
              this.Time1 = new double[checked (num1 - 2 + 1)];
            }
            str1 = "s";
          }
          else if (this.TIEOpt.Checked)
          {
            if (enb1)
            {
              this.Results0 = new double[checked (num1 - 1 + 1)];
              this.Time0 = new double[checked (num1 - 1 + 1)];
            }
            if (enb2)
            {
              this.Results1 = new double[checked (num1 - 1 + 1)];
              this.Time1 = new double[checked (num1 - 1 + 1)];
            }
            str1 = "s";
          }
          else if (this.TimeOpt.Checked)
          {
            if (enb1 && enb2)
            {
              this.Results0 = new double[checked (num1 - 1 + 1)];
              this.Time0 = new double[checked (num1 - 1 + 1)];
            }
            str1 = "s";
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.Results0 = (double[]) null;
          this.Results1 = (double[]) null;
          this.Time0 = (double[]) null;
          this.Time1 = (double[]) null;
          this.Res0Cnt = 0;
          this.Res1Cnt = 0;
          if (exception is OutOfMemoryException)
          {
            int num4 = (int) Interaction.MsgBox((object) "Out of memory, try to reduce the number of measurements.", MsgBoxStyle.Exclamation, (object) "Error");
          }
          else
          {
            int num5 = (int) Interaction.MsgBox((object) ("Exception: " + exception.Message));
          }
          ProjectData.ClearProjectError();
          return;
        }
        if (this.AutoSaveChk.Checked && !this.Recover)
        {
          int length;
          if (enb1)
          {
            this.SaveFile[0] = new FileStream(this.RecoveredFileName[0], FileMode.Create, FileAccess.Write, FileShare.ReadWrite, 16384, FileOptions.WriteThrough);
            this.SaveWr[0] = new StreamWriter((Stream) this.SaveFile[0]);
            this.SaveWr[0].Write(this.MeasName);
            this.SaveWr[0].WriteLine();
            this.SaveWr[0].Write(presc1.ToString());
            this.SaveWr[0].WriteLine();
            if (Operators.CompareString(this.MeasName, "TIE", false) == 0)
            {
              this.SaveWr[0].Write(this.TIEFreqTxt.Text);
              this.SaveWr[0].WriteLine();
            }
            StreamWriter streamWriter = this.SaveWr[0];
            length = gtiRealTimeArray1.Length;
            string str2 = length.ToString();
            streamWriter.Write(str2);
            this.SaveWr[0].WriteLine();
          }
          if (enb2)
          {
            this.SaveFile[1] = new FileStream(this.RecoveredFileName[1], FileMode.Create, FileAccess.Write, FileShare.ReadWrite, 16384, FileOptions.WriteThrough);
            this.SaveWr[1] = new StreamWriter((Stream) this.SaveFile[1]);
            this.SaveWr[1].Write(this.MeasName);
            this.SaveWr[1].WriteLine();
            this.SaveWr[1].Write(presc2.ToString());
            this.SaveWr[1].WriteLine();
            if (Operators.CompareString(this.MeasName, "TIE", false) == 0)
            {
              this.SaveWr[1].Write(this.TIEFreqTxt.Text);
              this.SaveWr[1].WriteLine();
            }
            StreamWriter streamWriter = this.SaveWr[1];
            length = gtiRealTimeArray2.Length;
            string str2 = length.ToString();
            streamWriter.Write(str2);
            this.SaveWr[1].WriteLine();
          }
        }
        bool enabled = this.MeasTmr.Enabled;
        this.MeasTmr.Enabled = false;
        if (!this.Recover)
        {
          GT668Def.GT668StartMeasurements();
          GT668Def.GT668GetTotalPrescale(0, ref presc1);
          GT668Def.GT668GetTotalPrescale(1, ref presc2);
        }
        stopwatch.Start();
        bool flag3 = false;
        double a1 = 0.0;
        double num6 = 0.0;
        double num7 = 0.0;
        double a2 = 0.0;
        double num8 = 0.0;
        double num9 = 0.0;
        int num10 = 0;
        int num11 = 0;
        int ErrNum = 0;
        while (this.Recover || (enb1 && val1 < num2 || enb2 && val2 < num3) && (!flag3 && this.running && ErrNum == 0))
        {
          uint ActNumTags0 = 0;
          uint ActNumTags1 = 0;
          int num4 = checked (num2 - val1);
          int num5 = checked (num3 - val2);
          if (num4 > 131072)
            num4 = 131072;
          if (num5 > 131072)
            num5 = 131072;
          if (this.Recover)
          {
            ActNumTags0 = checked ((uint) val1);
            ActNumTags1 = checked ((uint) val2);
          }
          else
          {
            int num12 = val1;
            int num13 = val2;
            GT668Def.GtiRealTime gtiRealTime1;
            GT668Def.GtiRealTime gtiRealTime2;
            uint num14;
            if (!this.WrapChk.Checked)
            {
              if (enb1 && val1 < num2 || enb2 && val2 < num3)
              {
                if ((int) this.RawConverted == (int) this.RawCount)
                {
                  this.RawCount = checked ((uint) ((long) this.RawCount + 10000L));
                  this.RawData = (uint[]) Utils.CopyArray((Array) this.RawData, (Array) new uint[checked ((int) ((long) this.RawCount - 1L) + 1)]);
                }
                if (this.RawRead < this.RawCount)
                {
                  uint ActRead = 0;
                  GT668Def.GT668ReadRaw(ref this.RawData[checked ((int) this.RawRead)], this.RawRead, checked (this.RawCount - this.RawRead), ref ActRead);
                  checked { this.RawRead += ActRead; }
                }
              }
              if (this.RawRead > this.RawConverted)
              {
                uint tags_used = 0;
                if (enb1 && val1 < num2 && (enb2 && val2 < num3))
                {
                  GT668Def.GT668ConvertRawToTimetagsEx(ref this.RawData[checked ((int) this.RawConverted)], checked (this.RawRead - this.RawConverted), ref tags_used, ref gtiRealTimeArray1[val1], checked ((uint) num4), ref ActNumTags0, ref gtiRealTimeArray2[val2], checked ((uint) num5), ref ActNumTags1);
                  val1 = checked ((int) ((long) val1 + (long) ActNumTags0));
                  val2 = checked ((int) ((long) val2 + (long) ActNumTags1));
                }
                else if (enb1 && val1 < num2)
                {
                  ref uint local1 = ref this.RawData[checked ((int) this.RawConverted)];
                  int num15 = (int) checked (this.RawRead - this.RawConverted);
                  ref uint local2 = ref tags_used;
                  ref GT668Def.GtiRealTime local3 = ref gtiRealTimeArray1[val1];
                  int num16 = (int) checked ((uint) num4);
                  ref uint local4 = ref ActNumTags0;
                  gtiRealTime2 = gtiRealTime1;
                  ref GT668Def.GtiRealTime local5 = ref gtiRealTime2;
                  num14 = 0U;
                  ref uint local6 = ref num14;
                  GT668Def.GT668ConvertRawToTimetagsEx(ref local1, (uint) num15, ref local2, ref local3, (uint) num16, ref local4, ref local5, 0U, ref local6);
                  val1 = checked ((int) ((long) val1 + (long) ActNumTags0));
                }
                else if (enb2 && val2 < num3)
                {
                  ref uint local1 = ref this.RawData[checked ((int) this.RawConverted)];
                  int num15 = (int) checked (this.RawRead - this.RawConverted);
                  ref uint local2 = ref tags_used;
                  gtiRealTime2 = gtiRealTime1;
                  ref GT668Def.GtiRealTime local3 = ref gtiRealTime2;
                  num14 = 0U;
                  ref uint local4 = ref num14;
                  ref GT668Def.GtiRealTime local5 = ref gtiRealTimeArray2[val2];
                  int num16 = (int) checked ((uint) num5);
                  ref uint local6 = ref ActNumTags1;
                  GT668Def.GT668ConvertRawToTimetagsEx(ref local1, (uint) num15, ref local2, ref local3, 0U, ref local4, ref local5, (uint) num16, ref local6);
                  val2 = checked ((int) ((long) val2 + (long) ActNumTags1));
                }
                checked { this.RawConverted += tags_used; }
              }
            }
            else if (enb1 && val1 < num2 && (enb2 && val2 < num3))
            {
              GT668Def.GT668ReadTimetagsEx(ref gtiRealTimeArray1[val1], checked ((uint) num4), ref ActNumTags0, ref gtiRealTimeArray2[val2], checked ((uint) num5), ref ActNumTags1);
              val1 = checked ((int) ((long) val1 + (long) ActNumTags0));
              val2 = checked ((int) ((long) val2 + (long) ActNumTags1));
            }
            else if (enb1 && val1 < num2)
            {
              ref GT668Def.GtiRealTime local1 = ref gtiRealTimeArray1[val1];
              int num15 = (int) checked ((uint) num4);
              ref uint local2 = ref ActNumTags0;
              gtiRealTime2 = gtiRealTime1;
              ref GT668Def.GtiRealTime local3 = ref gtiRealTime2;
              num14 = 0U;
              ref uint local4 = ref num14;
              GT668Def.GT668ReadTimetagsEx(ref local1, (uint) num15, ref local2, ref local3, 0U, ref local4);
              val1 = checked ((int) ((long) val1 + (long) ActNumTags0));
            }
            else if (enb2 && val2 < num3)
            {
              gtiRealTime2 = gtiRealTime1;
              ref GT668Def.GtiRealTime local1 = ref gtiRealTime2;
              num14 = 0U;
              ref uint local2 = ref num14;
              ref GT668Def.GtiRealTime local3 = ref gtiRealTimeArray2[val2];
              int num15 = (int) checked ((uint) num5);
              ref uint local4 = ref ActNumTags1;
              GT668Def.GT668ReadTimetagsEx(ref local1, 0U, ref local2, ref local3, (uint) num15, ref local4);
              val2 = checked ((int) ((long) val2 + (long) ActNumTags1));
            }
            if (this.AutoSaveChk.Checked)
            {
              int num15 = checked ((int) ((long) ActNumTags0 - 1L));
              int num16 = 0;
              while (num16 <= num15)
              {
                this.SaveWr[0].Write(gtiRealTimeArray1[checked (num12 + num16)].Seconds.ToString());
                this.SaveWr[0].Write(gtiRealTimeArray1[checked (num12 + num16)].Fraction.ToString("0.###############").Substring(1));
                this.SaveWr[0].WriteLine();
                checked { ++num16; }
              }
              if (ActNumTags0 > 0U)
                this.SaveWr[0].Flush();
              int num17 = checked ((int) ((long) ActNumTags1 - 1L));
              int num18 = 0;
              while (num18 <= num17)
              {
                this.SaveWr[1].Write(gtiRealTimeArray2[checked (num13 + num18)].Seconds.ToString());
                this.SaveWr[1].Write(gtiRealTimeArray2[checked (num13 + num18)].Fraction.ToString("0.###############").Substring(1));
                this.SaveWr[1].WriteLine();
                checked { ++num18; }
              }
              if (ActNumTags1 > 0U)
                this.SaveWr[1].Flush();
            }
            ErrNum = GT668Def.GT668GetError();
            switch (ErrNum)
            {
              case 0:
label_149:
                if (checked (ActNumTags0 + ActNumTags1) > 0U)
                {
                  stopwatch.Restart();
                  goto label_153;
                }
                else if (Decimal.Compare(new Decimal(stopwatch.ElapsedMilliseconds), this.TimeoutUD.Value) >= 0)
                {
                  flag3 = true;
                  goto label_153;
                }
                else
                  goto label_153;
              case 10:
                int num19 = (int) Interaction.MsgBox((object) "Error: Measurement rate too high", MsgBoxStyle.Exclamation, (object) "Error");
                this.running = false;
                break;
              case 11:
                int num20 = (int) Interaction.MsgBox((object) "Error: Too many measurements for memory. Try to use Wrap mode.", MsgBoxStyle.Exclamation, (object) "Error");
                this.running = false;
                break;
              default:
                string ErrMsg = "";
                GT668Def.GT668GetErrorMessage(ErrNum, ref ErrMsg);
                int num21 = (int) Interaction.MsgBox((object) ("Error: " + ErrMsg), MsgBoxStyle.Exclamation, (object) "Error");
                break;
            }
            GT668Def.GT668ClearError();
            goto label_149;
          }
label_153:
          Application.DoEvents();
          Application.DoEvents();
          Application.DoEvents();
          if (this.IsDisposed)
          {
            stopwatch.Stop();
            if (!this.Recover)
              GT668Def.GT668StopMeasurements();
            if (!this.AutoSaveChk.Checked)
              return;
            if (enb1)
              this.SaveFile[0].Close();
            if (!enb2)
              return;
            this.SaveFile[1].Close();
            return;
          }
          if (!this.running)
          {
            stopwatch.Stop();
            this.MeasTmr.Enabled = false;
            if (this.Recover)
              return;
            GT668Def.GT668StopMeasurements();
            return;
          }
          double res1;
          double res2;
          if (this.FreqOpt.Checked)
          {
            if (enb1 && checked (val1 - num10) > 0)
            {
              int num12 = val1;
              int num13 = checked (num10 + 1);
              int num14 = checked (num12 - 1);
              int index = num13;
              while (index <= num14)
              {
                double num15 = (double) checked (gtiRealTimeArray1[index].Seconds - gtiRealTimeArray1[index - 1].Seconds) + (gtiRealTimeArray1[index].Fraction - gtiRealTimeArray1[checked (index - 1)].Fraction);
                this.Results0[checked (index - 1)] = (double) presc1 / num15;
                this.Time0[checked (index - 1)] = (double) gtiRealTimeArray1[checked (index - 1)].Seconds + gtiRealTimeArray1[checked (index - 1)].Fraction;
                num10 = index;
                checked { ++index; }
              }
              this.Res0Cnt = checked (val1 - 1);
            }
            if (enb2 && checked (val2 - num11) > 0)
            {
              int num12 = val2;
              int num13 = checked (num11 + 1);
              int num14 = checked (num12 - 1);
              int index = num13;
              while (index <= num14)
              {
                double num15 = (double) checked (gtiRealTimeArray2[index].Seconds - gtiRealTimeArray2[index - 1].Seconds) + (gtiRealTimeArray2[index].Fraction - gtiRealTimeArray2[checked (index - 1)].Fraction);
                this.Results1[checked (index - 1)] = (double) presc2 / num15;
                this.Time1[checked (index - 1)] = (double) gtiRealTimeArray2[checked (index - 1)].Seconds + gtiRealTimeArray2[checked (index - 1)].Fraction;
                num11 = index;
                checked { ++index; }
              }
              this.Res1Cnt = checked (val2 - 1);
            }
          }
          else if (this.PeriodOpt.Checked)
          {
            if (enb1 && checked (val1 - num10) > 0)
            {
              int num12 = val1;
              int num13 = checked (num10 + 1);
              int num14 = checked (num12 - 1);
              int index = num13;
              while (index <= num14)
              {
                double num15 = (double) checked (gtiRealTimeArray1[index].Seconds - gtiRealTimeArray1[index - 1].Seconds) + (gtiRealTimeArray1[index].Fraction - gtiRealTimeArray1[checked (index - 1)].Fraction);
                this.Results0[checked (index - 1)] = num15 / (double) presc1;
                this.Time0[checked (index - 1)] = (double) gtiRealTimeArray1[checked (index - 1)].Seconds + gtiRealTimeArray1[checked (index - 1)].Fraction;
                num10 = index;
                checked { ++index; }
              }
              this.Res0Cnt = checked (val1 - 1);
            }
            if (enb2 && checked (val2 - num11) > 0)
            {
              int num12 = val2;
              int num13 = checked (num11 + 1);
              int num14 = checked (num12 - 1);
              int index = num13;
              while (index <= num14)
              {
                double num15 = (double) checked (gtiRealTimeArray2[index].Seconds - gtiRealTimeArray2[index - 1].Seconds) + (gtiRealTimeArray2[index].Fraction - gtiRealTimeArray2[checked (index - 1)].Fraction);
                this.Results1[checked (index - 1)] = num15 / (double) presc2;
                this.Time1[checked (index - 1)] = (double) gtiRealTimeArray2[checked (index - 1)].Seconds + gtiRealTimeArray2[checked (index - 1)].Fraction;
                num11 = index;
                checked { ++index; }
              }
              this.Res1Cnt = checked (val2 - 1);
            }
          }
          else if (this.ContOpt.Checked)
          {
            bool lockTaken = false;
            try
            {
                            /*
              Monitor.Enter((object) this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError\u0024Init, ref lockTaken);
              if (this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError\u0024Init.State == (short) 0)
              {
                this.\u0024State\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError\u0024Init.State = (short) 2;
                this.\u0024Status\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError = false;
              }
              else if (this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError\u0024Init.State == (short) 2)
                throw new IncompleteInitialization();
                            */
            }
            finally
            {
                            /*
              this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError\u0024Init.State = (short) 1;
              if (lockTaken)
                Monitor.Exit((object) this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024FirstError\u0024Init);
                            */
            }
            if (enb1 && checked (val1 - num10) > 0)
            {
              int num12 = val1;
              int num13 = checked (num10 + 1);
              int num14 = checked (num12 - 1);
              int index = num13;
              while (index <= num14)
              {
                double num15 = (double) checked (gtiRealTimeArray1[index].Seconds - gtiRealTimeArray1[index - 1].Seconds) + (gtiRealTimeArray1[index].Fraction - gtiRealTimeArray1[checked (index - 1)].Fraction);
                this.Results0[checked (index - 1)] = num15;
                this.Time0[checked (index - 1)] = (double) gtiRealTimeArray1[checked (index - 1)].Seconds + gtiRealTimeArray1[checked (index - 1)].Fraction;
                num10 = index;
                checked { ++index; }
              }
              this.Res0Cnt = checked (val1 - 1);
            }
            if (enb2 && checked (val2 - num11) > 0)
            {
              int num12 = val2;
              int num13 = checked (num11 + 1);
              int num14 = checked (num12 - 1);
              int index = num13;
              while (index <= num14)
              {
                double num15 = (double) checked (gtiRealTimeArray2[index].Seconds - gtiRealTimeArray2[index - 1].Seconds) + (gtiRealTimeArray2[index].Fraction - gtiRealTimeArray2[checked (index - 1)].Fraction);
                this.Results1[checked (index - 1)] = num15;
                this.Time1[checked (index - 1)] = (double) gtiRealTimeArray2[checked (index - 1)].Seconds + gtiRealTimeArray2[checked (index - 1)].Fraction;
                num11 = index;
                checked { ++index; }
              }
              this.Res1Cnt = checked (val2 - 1);
            }
          }
          else if (this.TIEOpt.Checked)
          {
            if (enb1 && (checked (val1 - num10) > 1 || num10 > 0))
            {
              int num12 = val1;
              if (this.TIEAutoOpt.Checked)
              {
                double num13 = ((double) checked (gtiRealTimeArray1[num12 - 1].Seconds - gtiRealTimeArray1[0].Seconds) + (gtiRealTimeArray1[checked (num12 - 1)].Fraction - gtiRealTimeArray1[0].Fraction)) / (double) checked (num12 - 1);
                int num14 = checked (num12 - 1);
                val1 = 0;
                while (val1 <= num14)
                {
                  if (val1 == 0)
                  {
                    this.Results0[val1] = 0.0;
                  }
                  else
                  {
                    double num15 = (double) checked (gtiRealTimeArray1[val1].Seconds - gtiRealTimeArray1[val1 - 1].Seconds) + (gtiRealTimeArray1[val1].Fraction - gtiRealTimeArray1[checked (val1 - 1)].Fraction);
                    this.Results0[val1] = this.Results0[checked (val1 - 1)] + num15 - num13;
                  }
                  this.Time0[val1] = (double) gtiRealTimeArray1[val1].Seconds + gtiRealTimeArray1[val1].Fraction;
                  checked { ++val1; }
                }
                this.Res0Cnt = val1;
                num10 = val1;
                a1 = 0.0;
                num6 = 0.0;
                num7 = 0.0;
              }
              else
              {
                double num13 = (double) presc1 / this.TIEFreq;
                int num14 = num10;
                int num15 = checked (num12 - 1);
                int index = num14;
                while (index <= num15)
                {
                  if (index == 0)
                  {
                    this.Results0[0] = 0.0;
                  }
                  else
                  {
                    double num16 = (double) checked (gtiRealTimeArray1[index].Seconds - gtiRealTimeArray1[index - 1].Seconds) + (gtiRealTimeArray1[index].Fraction - gtiRealTimeArray1[checked (index - 1)].Fraction);
                    this.Results0[index] = this.Results0[checked (index - 1)] + num16 - num13;
                  }
                  this.Time0[index] = (double) gtiRealTimeArray1[index].Seconds + gtiRealTimeArray1[index].Fraction;
                  num10 = index;
                  checked { ++index; }
                }
                this.Res0Cnt = val1;
              }
            }
            if (enb2 && (checked (val2 - num11) > 1 || num11 > 0))
            {
              int num12 = val2;
              if (this.TIEAutoOpt.Checked)
              {
                double num13 = ((double) checked (gtiRealTimeArray2[num12 - 1].Seconds - gtiRealTimeArray2[0].Seconds) + (gtiRealTimeArray2[checked (num12 - 1)].Fraction - gtiRealTimeArray2[0].Fraction)) / (double) checked (num12 - 1);
                int num14 = checked (num12 - 1);
                val2 = 0;
                while (val2 <= num14)
                {
                  if (val2 == 0)
                  {
                    this.Results1[val2] = 0.0;
                  }
                  else
                  {
                    double num15 = (double) checked (gtiRealTimeArray2[val2].Seconds - gtiRealTimeArray2[val2 - 1].Seconds) + (gtiRealTimeArray2[val2].Fraction - gtiRealTimeArray2[checked (val2 - 1)].Fraction);
                    this.Results1[val2] = this.Results1[checked (val2 - 1)] + num15 - num13;
                  }
                  this.Time1[val2] = (double) gtiRealTimeArray2[val2].Seconds + gtiRealTimeArray2[val2].Fraction;
                  checked { ++val2; }
                }
                this.Res1Cnt = val2;
                num11 = val2;
                a2 = 0.0;
                num8 = 0.0;
                num9 = 0.0;
              }
              else
              {
                double num13 = (double) presc2 / this.TIEFreq;
                int num14 = num11;
                int num15 = checked (num12 - 1);
                int index = num14;
                while (index <= num15)
                {
                  if (index == 0)
                  {
                    this.Results1[0] = 0.0;
                  }
                  else
                  {
                    double num16 = (double) checked (gtiRealTimeArray2[index].Seconds - gtiRealTimeArray2[index - 1].Seconds) + (gtiRealTimeArray2[index].Fraction - gtiRealTimeArray2[checked (index - 1)].Fraction);
                    this.Results1[index] = this.Results1[checked (index - 1)] + num16 - num13;
                  }
                  this.Time1[index] = (double) gtiRealTimeArray2[index].Seconds + gtiRealTimeArray2[index].Fraction;
                  num11 = index;
                  checked { ++index; }
                }
                this.Res1Cnt = val2;
              }
            }
            if (this.ShowStable)
            {
              this.StableFile = new FileStream(MyProject.Forms.StableFrm.StableResFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite, 1024, FileOptions.WriteThrough);
              this.StableSaved = 0;
              StreamWriter streamWriter = new StreamWriter((Stream) this.StableFile);
              int num12 = Math.Min(this.Res0Cnt, this.Res1Cnt);
              while (this.StableSaved < num12)
              {
                if (this.Res0Cnt > 0)
                {
                  streamWriter.Write(this.Results0[this.StableSaved]);
                  if (this.Res1Cnt > 0)
                    streamWriter.Write(",");
                }
                if (this.Res1Cnt > 0)
                  streamWriter.Write(this.Results1[this.StableSaved]);
                streamWriter.WriteLine();
                checked { ++this.StableSaved; }
              }
              streamWriter.Flush();
              this.StableFile.Close();
              this.StableFile = (FileStream) null;
            }
          }
          else if (this.TimeOpt.Checked && enb1 && (enb2 && checked (val1 - num10) > 0) && checked (val2 - num11) > 0)
          {
            bool lockTaken = false;
            try
            {
                            /*
              Monitor.Enter((object) this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr\u0024Init, ref lockTaken);
              if (this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr\u0024Init.State == (short) 0)
              {
                this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr\u0024Init.State = (short) 2;
                this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr = 0.0;
              }
              else if (this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr\u0024Init.State == (short) 2)
                throw new IncompleteInitialization();
                            */
            }
            finally
            {
                            /*
              this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr\u0024Init.State = (short) 1;
              if (lockTaken)
                Monitor.Exit((object) this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr\u0024Init);
                            */
            }
            if (num10 == 0 && num11 == 0)
            {
                            /*
              this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corrected = false;
              this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr = 0.0;
                            */
            }
            int num12 = checked ((int) Math.Min((long) val1 - (long) ActNumTags0, (long) val2 - (long) ActNumTags1));
            int num13 = Math.Min(val1, val2);
                        /*
            if (!this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corrected && num13 > 1 && num12 > 0)
            {
              double num14 = ((double) checked (gtiRealTimeArray1[num13 - 1].Seconds - gtiRealTimeArray1[0].Seconds) + gtiRealTimeArray1[checked (num13 - 1)].Fraction - gtiRealTimeArray1[0].Fraction) / (double) checked (num13 - 1) / (double) presc1;
              this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr = (double) checked ((int) Math.Round(unchecked ((double) checked (gtiRealTimeArray1[0].Seconds - gtiRealTimeArray2[0].Seconds) + gtiRealTimeArray1[0].Fraction - gtiRealTimeArray2[0].Fraction / num14))) * num14;
              res1 = this.Results0[0] - this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr;
              res2 = this.Results0[0] - this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr;
              num6 = 0.0;
              num7 = 0.0;
              int num15 = checked (num12 - 1);
              int index = 0;
              while (index <= num15)
              {
                this.Results0[index] = this.Results0[index] - this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr;
                if (res1 > this.Results0[index])
                  res1 = this.Results0[index];
                if (res2 < this.Results0[index])
                  res2 = this.Results0[index];
                checked { ++index; }
              }
              this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corrected = true;
            }
            if (!this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corrected && num13 > 1)
            {
              double num14 = ((double) checked (gtiRealTimeArray1[num13 - 1].Seconds - gtiRealTimeArray1[0].Seconds) + gtiRealTimeArray1[checked (num13 - 1)].Fraction - gtiRealTimeArray1[0].Fraction) / (double) checked (num13 - 1) / (double) presc1;
              this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr = (double) checked ((int) Math.Round(unchecked ((double) checked (gtiRealTimeArray1[0].Seconds - gtiRealTimeArray2[0].Seconds) + gtiRealTimeArray1[0].Fraction - gtiRealTimeArray2[0].Fraction / num14))) * num14;
              this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corrected = true;
            }
                        */
            int num16 = num12;
            int num17 = checked (num13 - 1);
            int index1 = num16;
            while (index1 <= num17)
            {
                            /*
              this.Results0[index1] = (double) checked ((int) gtiRealTimeArray1[index1].Seconds - (int) gtiRealTimeArray2[index1].Seconds) + gtiRealTimeArray1[index1].Fraction - gtiRealTimeArray2[index1].Fraction - this.\u0024STATIC\u0024MeasTmr_Tick\u002420211C1249\u0024Corr;
                            */
              this.Time0[index1] = (double) gtiRealTimeArray1[index1].Seconds + gtiRealTimeArray1[index1].Fraction;
              checked { ++index1; }
            }
            this.Res0Cnt = index1;
            num10 = index1;
            num11 = index1;
          }
          Application.DoEvents();
          Application.DoEvents();
          Application.DoEvents();
          if (this.IsDisposed)
          {
            stopwatch.Stop();
            GT668.StopMeasurements();
            if (!this.AutoSaveChk.Checked)
              return;
            if (enb1)
              this.SaveFile[0].Close();
            if (!enb2)
              return;
            this.SaveFile[1].Close();
            return;
          }
          if (ActNumTags0 > 0U && val1 > 1)
            this.Res0Interval = (double) checked (gtiRealTimeArray1[val1 - 1].Seconds - gtiRealTimeArray1[0].Seconds) + gtiRealTimeArray1[checked (val1 - 1)].Fraction - gtiRealTimeArray1[0].Fraction;
          if (ActNumTags1 > 0U && val2 > 1)
            this.Res1Interval = (double) checked (gtiRealTimeArray2[val2 - 1].Seconds - gtiRealTimeArray2[0].Seconds) + gtiRealTimeArray2[checked (val2 - 1)].Fraction - gtiRealTimeArray2[0].Fraction;
          if ((this.TimeOpt.Checked || enb1) && (double) this.Res0Cnt - a1 > 0.0)
          {
            int res0Cnt = this.Res0Cnt;
            int num12 = checked ((int) Math.Round(a1));
            int num13 = checked (res0Cnt - 1);
            int index = num12;
            while (index <= num13)
            {
              double num14 = this.Results0[index] - this.Results0[0];
              num6 += num14;
              num7 += num14 * num14;
              if (index == 0)
              {
                res1 = this.Results0[0];
                res2 = this.Results0[0];
              }
              else
              {
                if (res1 > this.Results0[index])
                  res1 = this.Results0[index];
                if (res2 < this.Results0[index])
                  res2 = this.Results0[index];
              }
              checked { ++index; }
            }
            a1 = (double) this.Res0Cnt;
            double num15 = num6 / (double) this.Res0Cnt;
            double res3 = 0.0;
            if (this.Res0Cnt > 1)
            {
              double d = (num7 - num15 * num6) / (double) checked (this.Res0Cnt - 1);
              res3 = d <= 0.0 ? 0.0 : Math.Sqrt(d);
            }
            this.Mean0Txt.Text = this.FormatResult(num15 + this.Results0[0], this.Res0Interval) + str1;
            this.StdDev0Txt.Text = this.FormatResult(res3, this.Res0Interval) + str1;
            this.Min0Txt.Text = this.FormatResult(res1, this.Res0Interval / (double) ((IEnumerable<double>) this.Results0).Count<double>()) + str1;
            this.Max0Txt.Text = this.FormatResult(res2, this.Res0Interval / (double) ((IEnumerable<double>) this.Results0).Count<double>()) + str1;
            this.Pk0Txt.Text = this.FormatResult(res2 - res1, this.Res0Interval / (double) ((IEnumerable<double>) this.Results0).Count<double>()) + str1;
            this.Cnt0Txt.Text = Conversions.ToString(this.Res0Cnt);
            this.PreSc0Txt.Text = Conversions.ToString(presc1);
          }
          if (flag1 && !this.Recover)
          {
            this.Thr0Txt.Text = this.FormatVoltage(v1);
            if (posv1 != 0.0 || negv1 != 0.0)
            {
              this.MaxPk0Txt.Text = this.FormatVoltage(posv1);
              this.MinPk0Txt.Text = this.FormatVoltage(negv1);
            }
            else
            {
              this.MaxPk0Txt.Text = "-----";
              this.MinPk0Txt.Text = "-----";
            }
          }
          else
          {
            this.Thr0Txt.Text = "-----";
            this.MaxPk0Txt.Text = "-----";
            this.MinPk0Txt.Text = "-----";
          }
          if (enb2 && !this.TimeOpt.Checked && (double) this.Res1Cnt - a2 > 0.0)
          {
            int res1Cnt = this.Res1Cnt;
            int num12 = checked ((int) Math.Round(a2));
            int num13 = checked (res1Cnt - 1);
            int index = num12;
            double res3;
            double res4;
            while (index <= num13)
            {
              double num14 = this.Results1[index] - this.Results1[0];
              num8 += num14;
              num9 += num14 * num14;
              if (index == 0)
              {
                res3 = this.Results1[0];
                res4 = this.Results1[0];
              }
              else
              {
                if (res3 > this.Results1[index])
                  res3 = this.Results1[index];
                if (res4 < this.Results1[index])
                  res4 = this.Results1[index];
              }
              checked { ++index; }
            }
            a2 = (double) this.Res1Cnt;
            double num15 = num8 / (double) this.Res1Cnt;
            double res5 = 0.0;
            if (this.Res1Cnt > 1)
            {
              double d = (num9 - num15 * num8) / (double) checked (this.Res1Cnt - 1);
              res5 = d <= 0.0 ? 0.0 : Math.Sqrt(d);
            }
            this.Mean1Txt.Text = this.FormatResult(num15 + this.Results1[0], this.Res1Interval) + str1;
            this.StdDev1Txt.Text = this.FormatResult(res5, this.Res1Interval) + str1;
            this.Min1Txt.Text = this.FormatResult(res3, this.Res1Interval / (double) ((IEnumerable<double>) this.Results1).Count<double>()) + str1;
            this.Max1Txt.Text = this.FormatResult(res4, this.Res1Interval / (double) ((IEnumerable<double>) this.Results1).Count<double>()) + str1;
            this.Pk1Txt.Text = this.FormatResult(res4 - res3, this.Res1Interval / (double) ((IEnumerable<double>) this.Results1).Count<double>()) + str1;
            this.Cnt1Txt.Text = Conversions.ToString(this.Res1Cnt);
            this.PreSc1Txt.Text = Conversions.ToString(presc2);
          }
          if (flag2 && !this.Recover)
          {
            this.Thr1Txt.Text = this.FormatVoltage(v2);
            if (posv2 != 0.0 || negv2 != 0.0)
            {
              this.MaxPk1Txt.Text = this.FormatVoltage(posv2);
              this.MinPk1Txt.Text = this.FormatVoltage(negv2);
            }
            else
            {
              this.MaxPk1Txt.Text = "-----";
              this.MinPk1Txt.Text = "-----";
            }
          }
          else
          {
            this.Thr1Txt.Text = "-----";
            this.MaxPk1Txt.Text = "-----";
            this.MinPk1Txt.Text = "-----";
          }
          Application.DoEvents();
          Application.DoEvents();
          Application.DoEvents();
          if (this.IsDisposed)
          {
            stopwatch.Stop();
            GT668Def.GT668StopMeasurements();
            if (!this.AutoSaveChk.Checked)
              return;
            if (enb1)
              this.SaveFile[0].Close();
            if (!enb2)
              return;
            this.SaveFile[1].Close();
            return;
          }
          if (this.ShowResults && !MyProject.Forms.ResultsFrm.Busy)
            MyProject.Forms.ResultsFrm.Show(this.MeasName, str1);
          if (this.ShowGraph)
            MyProject.Forms.GraphFrm.Show(this.MeasName, str1);
          Application.DoEvents();
          if (this.Recover)
            this.running = false;
        }
        stopwatch.Stop();
        GT668Def.GT668StopMeasurements();
        if (this.AutoSaveChk.Checked && !this.Recover)
        {
          if (enb1)
            this.SaveFile[0].Close();
          if (enb2)
            this.SaveFile[1].Close();
        }
        this.MeasTmr.Enabled = ErrNum == 0 && enabled;
        if (this.ShowResults)
        {
          while (MyProject.Forms.ResultsFrm.Busy)
            Application.DoEvents();
          MyProject.Forms.ResultsFrm.Clear();
          MyProject.Forms.ResultsFrm.Show(this.MeasName, str1);
        }
        if (!this.ShowGraph)
          return;
        MyProject.Forms.GraphFrm.Show(this.MeasName, str1);
      }
    }

    private void ViewBtn_Click(object sender, EventArgs e)
    {
      this.ViewBtn.Enabled = false;
      this.ShowResults = true;
      MyProject.Forms.ResultsFrm.Show(this.MeasName, this.Units);
    }

    private void GraphBtn_Click(object sender, EventArgs e)
    {
      this.GraphBtn.Enabled = false;
      this.ShowGraph = true;
      MyProject.Forms.GraphFrm.Show(this.MeasName, this.Units);
    }

    private void RepeatUD_ValueChanged(object sender, EventArgs e) => this.MeasTmr.Interval = Convert.ToInt32(((NumericUpDown) sender).Value);

    private void RepeatChk_CheckedChanged(object sender, EventArgs e)
    {
      if (((CheckBox) sender).Checked)
        return;
      this.MeasTmr.Enabled = false;
    }

    private void ExrFrm_Resize(object sender, EventArgs e)
    {
      if (this.CurState != this.WindowState)
      {
        if (this.WindowState == FormWindowState.Normal)
        {
          try
          {
            foreach (object openForm in (ReadOnlyCollectionBase) Application.OpenForms)
            {
              object objectValue = RuntimeHelpers.GetObjectValue(openForm);
              if (objectValue != this)
              {
                ((Form) objectValue).WindowState = FormWindowState.Normal;
                ((Control) objectValue).Visible = true;
              }
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        else
        {
          bool flag = this.WindowState == FormWindowState.Minimized;
          try
          {
            foreach (object openForm in (ReadOnlyCollectionBase) Application.OpenForms)
            {
              object objectValue = RuntimeHelpers.GetObjectValue(openForm);
              if (objectValue != this)
                ((Control) objectValue).Visible = !flag;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
      }
      this.CurState = this.WindowState;
    }

    private void StableBtn_Click(object sender, EventArgs e)
    {
      this.StableBtn.Enabled = false;
      this.ShowStable = true;
      MyProject.Forms.StableFrm.Show();
    }

    private void ExrFrm_LocationChanged(object sender, EventArgs e)
    {
      if (this.WindowState != FormWindowState.Normal)
        return;
      this.CurLoc = this.Location;
    }

    private void CalBtn_Click(object sender, EventArgs e)
    {
      Cursor cursor = this.Cursor;
      this.Cursor = Cursors.WaitCursor;
      this.InitBtn.Enabled = false;
      this.DefBtn.Enabled = false;
      this.RunBtn.Enabled = false;
      this.CfgBtn.Enabled = false;
      this.CalBtn.Enabled = false;
      this.InfoBtn.Enabled = false;
      this.GateLbl.Enabled = false;
      this.Gate0UD.Enabled = false;
      this.Gate1UD.Enabled = false;
      this.FreqOpt.Enabled = false;
      this.PeriodOpt.Enabled = false;
      this.ContOpt.Enabled = false;
      this.TIEOpt.Enabled = false;
      this.TIEPnl.Enabled = false;
      this.TimeOpt.Enabled = false;
      this.MeasCntUD.Enabled = false;
      this.RepeatChk.Enabled = false;
      this.RepeatUD.Enabled = false;
      this.TimeoutUD.Enabled = false;
      this.AutoSaveChk.Enabled = false;
      this.WrapChk.Enabled = false;
      this.SaveRawBtn.Enabled = false;
      GT668Def.GT668SelfCal();
      int error = GT668Def.GT668GetError();
      if (error != 0)
      {
        string ErrMsg = "";
        GT668Def.GT668GetErrorMessage(error, ref ErrMsg);
        int num = (int) Interaction.MsgBox((object) ("Error: " + ErrMsg), MsgBoxStyle.Exclamation, (object) "Error");
        GT668Def.GT668ClearError();
      }
      this.InitBtn.Enabled = true;
      this.DefBtn.Enabled = true;
      this.RunBtn.Enabled = true;
      this.CfgBtn.Enabled = true;
      this.CalBtn.Enabled = true;
      this.InfoBtn.Enabled = true;
      if (this.FreqOpt.Checked || this.PeriodOpt.Checked || this.TIEOpt.Checked)
      {
        this.GateLbl.Enabled = true;
        this.Gate0UD.Enabled = true;
        this.Gate1UD.Enabled = true;
      }
      else
      {
        this.GateLbl.Enabled = false;
        this.Gate0UD.Enabled = false;
        this.Gate1UD.Enabled = false;
      }
      this.FreqOpt.Enabled = true;
      this.PeriodOpt.Enabled = true;
      this.ContOpt.Enabled = true;
      this.TIEOpt.Enabled = true;
      this.TIEPnl.Enabled = true;
      this.TimeOpt.Enabled = true;
      this.MeasCntUD.Enabled = true;
      this.RepeatChk.Enabled = true;
      this.RepeatUD.Enabled = true;
      this.TimeoutUD.Enabled = true;
      this.AutoSaveChk.Enabled = true;
      this.WrapChk.Enabled = !this.IsUSB;
      this.WrapChk.Visible = !this.IsUSB;
      this.SaveRawBtn.Enabled = !this.WrapChk.Checked;
      this.Cursor = cursor;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void DevCbo_SelectedIndexChanged(object sender, EventArgs e)
    {
      int num1 = checked ((int) Math.Round(Conversion.Val(((ComboBox) sender).SelectedItem.ToString())));
      if (this.DevNum == num1)
        return;
      this.ClearAll();
      this.DevNum = num1;
      int num2 = Information.UBound((Array) this.Devices);
      int index = 0;
      while (index <= num2)
      {
        if (num1 == this.Devices[index])
        {
          this.BrdNum = this.Boards[index];
          break;
        }
        checked { ++index; }
      }
      if (!this.UserFile)
      {
        this.ConfigFileName = "Exr668Conf_" + Conversions.ToString(this.BrdNum) + ".xml";
        if (MyProject.Computer.Keyboard.CtrlKeyDown && File.Exists(Application.UserAppDataPath + "\\" + this.ConfigFileName))
          FileSystem.Kill(Application.UserAppDataPath + "\\" + this.ConfigFileName);
      }
      ConfigOpt.Initialize(Application.UserAppDataPath + "\\" + this.ConfigFileName);
      if (this.Initialized)
        this.ReadConfigValues();
      this.BrdNumLbl.Text = Conversions.ToString(this.BrdNum);
      this.WindowState = this.CurState;
      if (this.WindowState == FormWindowState.Normal && this.CurLoc.X != -32000 && this.CurLoc.Y != -32000)
        this.Location = this.CurLoc;
      if (this.WindowState == FormWindowState.Minimized)
        this.WindowState = FormWindowState.Normal;
      if (!this.Initialized)
        return;
      if (this.BrdRev >= 8U)
        this.Height = this.FormHeight;
      GT668Def.GT668Close();
      this.BrdRev = 0U;
      this.Initialized = false;
    }

    private void WrapChk_CheckedChanged(object sender, EventArgs e) => this.SaveRawBtn.Enabled = !((CheckBox) sender).Checked;

    private void SaveRawBtn_Click(object sender, EventArgs e)
    {
      int num1 = checked ((int) Math.Round(Conversion.Val(this.ColTxt.Text)));
      if (this.RawCount == 0U)
        return;
      int num2 = 2;
      this.SaveFileDialog1.OverwritePrompt = true;
      this.SaveFileDialog1.Title = "Save Raw Data";
      this.SaveFileDialog1.Filter = "CSV file (*.csv)|*.csv";
      this.SaveFileDialog1.FilterIndex = 1;
      this.SaveFileDialog1.RestoreDirectory = true;
      if (this.SaveFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      FileStream fileStream = (FileStream) this.SaveFileDialog1.OpenFile();
      if (fileStream == null)
        return;
      int num3 = num2;
      int num4 = 1;
      while (num4 <= num3)
      {
        if (this.Res0Cnt != 0 || num4 != 1)
        {
          string s1 = Conversions.ToString(Operators.AddObject(Operators.AddObject((object) "Channel", Interaction.IIf(num4 == 1, (object) "A", (object) "B")), (object) "\r\n"));
          fileStream.Write(Encoding.ASCII.GetBytes(s1), 0, Encoding.ASCII.GetByteCount(s1));
          string s2 = "";
          int num5 = checked (num1 - 1);
          int num6 = 0;
          while (num6 <= num5)
          {
            string str = s2 + Conversions.ToString(num6);
            s2 = num6 >= checked (num1 - 1) ? str + "\r\n" : str + ",";
            checked { ++num6; }
          }
          fileStream.Write(Encoding.ASCII.GetBytes(s2), 0, Encoding.ASCII.GetByteCount(s2));
          int num7 = 0;
          uint num8 = checked ((uint) ((long) this.RawConverted - 1L));
          uint num9 = 0;
          while (num9 <= num8)
          {
            string str1 = "";
            if (((long) this.RawData[checked ((int) num9)] & 3758096384L) == 2147483648L)
            {
              if (num4 != 1)
                goto label_21;
            }
            else if (((long) this.RawData[checked ((int) num9)] & 3758096384L) == 1073741824L)
            {
              if (num4 != 2)
                goto label_21;
            }
            else if (((long) this.RawData[checked ((int) num9)] & 3758096384L) != 536870912L)
              goto label_21;
            else
              goto label_21;
            string str2 = str1 + ((long) this.RawData[checked ((int) num9)] & 16383L).ToString();
            checked { ++num7; }
            string s3;
            if (num7 < num1)
            {
              s3 = str2 + ",";
            }
            else
            {
              s3 = str2 + "\r\n";
              num7 = 0;
            }
            fileStream.Write(Encoding.ASCII.GetBytes(s3), 0, Encoding.ASCII.GetByteCount(s3));
label_21:
            checked { ++num9; }
          }
          string s4 = "\r\n\r\n";
          fileStream.Write(Encoding.ASCII.GetBytes(s4), 0, Encoding.ASCII.GetByteCount(s4));
        }
        checked { ++num4; }
      }
      fileStream.Close();
    }

    private void ColTxt_Validating(object sender, CancelEventArgs e)
    {
      TextBox textBox = (TextBox) sender;
      if (Versioned.IsNumeric((object) textBox.Text) && Conversion.Val(textBox.Text) >= 1.0)
        return;
      e.Cancel = true;
    }

    private void ExrFrm_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F11)
      {
        int num = (int) MyProject.Forms.ShowPtrs.ShowDialog((IWin32Window) this);
        e.Handled = true;
      }
      else
      {
        if (e.KeyCode != Keys.F10 || this.back_door_in_progress || (!this.Initialized || this.DebugShow))
          return;
        this.InfoBtn.Select();
        this.Refresh();
        Thread.Sleep(100);
        this.CalBtn.Select();
        this.Refresh();
        Thread.Sleep(100);
        this.CfgBtn.Select();
        this.Refresh();
        Thread.Sleep(100);
        this.InitBtn.Select();
        this.Refresh();
        this.back_door_in_progress = true;
        this.back_door = "";
        this.Timer1.Enabled = true;
        e.Handled = true;
      }
    }

    private void ExrFrm_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!this.back_door_in_progress)
        return;
      this.Timer1.Enabled = false;
      this.back_door += Conversions.ToString(e.KeyChar);
      if (Operators.CompareString(this.back_door, Microsoft.VisualBasic.Strings.Left("Debug!1", Microsoft.VisualBasic.Strings.Len(this.back_door)), false) != 0)
      {
        this.back_door_in_progress = false;
        this.back_door = "";
      }
      else
      {
        if (Microsoft.VisualBasic.Strings.Len(this.back_door) == Microsoft.VisualBasic.Strings.Len("Debug!1"))
        {
          this.DebugShow = true;
          MyProject.Forms.DebugFrm.Show();
        }
        this.Timer1.Enabled = true;
      }
      e.Handled = true;
    }

    private void InfoBtn_Click(object sender, EventArgs e)
    {
      string DrvRev = "";
      uint rev = 0;
      uint serialNumber = GT668Def.GT668GetSerialNumber();
      string boardModel = GT668Def.GT668GetBoardModel();
      GT668Def.GT668GetBoardRevision(ref rev);
      GT668Def.GT668GetDriverVersion(ref DrvRev);
      uint memorySize = GT668Def.GT668GetMemorySize();
      uint fpgaCode = GT668Def.GT668GetFpgaCode();
      uint calTime = GT668Def.GT668GetCalTime();
      long fileTime1 = checked (10000000L * (long) Convert.ToInt32(Conversion.Hex(fpgaCode), 16) + 116444736000000000L);
      long fileTime2 = checked (10000000L * (long) Convert.ToInt32(Conversion.Hex(calTime), 16) + 116444736000000000L);
      string str = "Device #" + Conversions.ToString(this.BrdNum) + "\r\n\r\n" + "Board Model: " + boardModel + "\r\n" + "Serial Number: " + Conversions.ToString(serialNumber) + "\r\n" + "H/W Revision: " + Conversions.ToString(rev) + "\r\n" + "Driver Revision: " + DrvRev + "\r\n" + "FPGA Date (UTC): " + Conversions.ToString(DateTime.FromFileTimeUtc(fileTime1)) + "\r\n" + "Factory Cal (UTC): " + Conversions.ToString(DateTime.FromFileTimeUtc(fileTime2)) + "\r\n";
      if (!this.IsUSB)
        str = str + "Memory Size: " + Conversions.ToString((long) memorySize / 1024L / 1024L) + "MB\r\n";
      int num = (int) Interaction.MsgBox((object) str, Title: ((object) "Info"));
    }

    private void TIEFreqTxt_Validating(object sender, CancelEventArgs e)
    {
      if (this.ParseFrequency(((TextBox) sender).Text) >= 0.0)
        return;
      e.Cancel = true;
    }

    private void TIEFreqTxt_Validated(object sender, EventArgs e)
    {
      TextBox textBox = (TextBox) sender;
      string str1 = textBox.Text.Trim();
      string Left = "";
      if (Operators.CompareString(Microsoft.VisualBasic.Strings.Right(str1, 2).ToLower(), "hz", false) == 0)
        str1 = Microsoft.VisualBasic.Strings.Left(str1, checked (str1.Length - 2));
      if (!Versioned.IsNumeric((object) Microsoft.VisualBasic.Strings.Right(str1, 1)))
      {
        Left = Microsoft.VisualBasic.Strings.Right(str1, 1);
        str1 = Microsoft.VisualBasic.Strings.Left(str1, checked (str1.Length - 1)).Trim();
        if (Operators.CompareString(Left, "K", false) == 0)
          Left = "k";
      }
      double num = Conversion.Val(str1);
      if (Operators.CompareString(Left, "k", false) == 0)
        num *= 1000.0;
      else if (Operators.CompareString(Left, "M", false) == 0)
        num *= 1000000.0;
      else if (Operators.CompareString(Left, "G", false) == 0)
        num *= 1000000000.0;
      else if (Operators.CompareString(Left, "m", false) == 0)
        num *= 0.001;
      string str2 = "";
      if (this.TIEFreq != num)
        this.Clear();
      this.TIEFreq = num;
      if (num >= 1000000000.0)
      {
        str2 = "G";
        num /= 1000000000.0;
      }
      else if (num >= 1000000.0)
      {
        str2 = "M";
        num /= 1000000.0;
      }
      else if (num >= 1000.0)
      {
        str2 = "k";
        num /= 1000.0;
      }
      else if (num < 1.0)
      {
        str2 = "m";
        num *= 1000.0;
      }
      textBox.Text = Conversions.ToString(num) + " " + str2 + "Hz";
    }

    private void TIEAutoOpt_CheckedChanged(object sender, EventArgs e) => this.Clear();

    private void RealTimeTmr_Tick(object sender, EventArgs e)
    {
      if (this.MeasTmr.Enabled || this.running)
        return;
      if (!GT668Def.GT668IsRealTimeSet())
      {
        ((System.Windows.Forms.Timer) sender).Enabled = false;
      }
      else
      {
        bool lockTaken1 = false;
        try
        {
                    /*
          Monitor.Enter((object) this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec\u0024Init, ref lockTaken1);
          if (this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec\u0024Init.State == (short) 0)
          {
            this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec\u0024Init.State = (short) 2;
            this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec = 0U;
          }
          else if (this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec\u0024Init.State == (short) 2)
            throw new IncompleteInitialization();
                    */
        }
        finally
        {
                    /*
          this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec\u0024Init.State = (short) 1;
          if (lockTaken1)
            Monitor.Exit((object) this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec\u0024Init);
                    */
        }
        uint sec = 0;
        bool lockTaken2 = false;
                /*
        try
        {
          Monitor.Enter((object) this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0\u0024Init, ref lockTaken2);
          if (this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0\u0024Init.State == (short) 0)
          {
            this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0\u0024Init.State = (short) 2;
            this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0 = new DateTime(1970, 1, 1, 0, 0, 0);
          }
          else if (this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0\u0024Init.State == (short) 2)
            throw new IncompleteInitialization();
        }
        finally
        {
          this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0\u0024Init.State = (short) 1;
          if (lockTaken2)
            Monitor.Exit((object) this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0\u0024Init);
        }
                */
                /*
        if (!GT668Def.GT668GetRealTime(ref sec) || (int) sec == (int) this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec)
          return;
                *
        DateTime dateTime = this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024epoch0.AddSeconds((double) sec);
        this.RealTimeLbl.Text = dateTime.ToShortDateString() + " " + dateTime.ToLongTimeString();
        this.\u0024STATIC\u0024RealTimeTmr_Tick\u002420211C1249\u0024last_sec = sec;
                */
      }
    }

    private void SyncBtn_Click(object sender, EventArgs e)
    {
      if (this.BrdRev < 8U)
        return;
      Cursor current = Cursor.Current;
      Cursor.Current = Cursors.WaitCursor;
      this.RealTimeTmr.Enabled = false;
      GT668Def.GT668SetRealTime(checked ((uint) Math.Round((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds)), false);
      Thread.Sleep(250);
      this.RealTimeTmr.Enabled = true;
      Cursor.Current = current;
    }

    private void ShowUTCChk_CheckedChanged(object sender, EventArgs e)
    {
      this.RealTimeTmr.Enabled = ((CheckBox) sender).Checked;
      if (this.RealTimeTmr.Enabled)
        return;
      this.RealTimeLbl.Text = "";
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void DefBtn_Click(object sender, EventArgs e)
    {
      if (File.Exists(Application.UserAppDataPath + "\\" + this.ConfigFileName))
        FileSystem.Kill(Application.UserAppDataPath + "\\" + this.ConfigFileName);
      bool showCfg = this.ShowCfg;
      ConfigOpt.Initialize(Application.UserAppDataPath + "\\" + this.ConfigFileName);
      this.ReadConfigValues();
      GT668Def.GT668InitDefault(false);
      this.ShowCfg = showCfg;
      if (!this.ShowCfg)
        return;
      MyProject.Forms.ConfigFrm.RefreshSetup();
    }

    private void MapBtn_Click(object sender, EventArgs e)
    {
      this.ClearAll();
      GT668Def.GT668Close();
      this.Initialized = false;
      MyProject.Forms.DevMapFrm.InitializeTable(this.Boards, this.Devices);
      if (MyProject.Forms.DevMapFrm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        MyProject.Forms.DevMapFrm.GetTable(ref this.Boards, ref this.Devices);
        int index1 = -1;
        int num1 = Information.UBound((Array) this.Boards);
        int index2 = 0;
        while (index2 <= num1)
        {
          if (this.Boards[index2] == this.BrdNum)
          {
            this.DevNum = this.Devices[index2];
            index1 = index2;
            break;
          }
          checked { ++index2; }
        }
        if (this.DevNum < 0)
        {
          this.DevNum = this.BrdNum;
          if (index1 >= 0)
            this.Devices[index1] = this.DevNum;
        }
        int num2 = 0;
        int num3 = Information.UBound((Array) this.Boards);
        int index3 = 0;
        while (index3 <= num3)
        {
          if (this.Boards[index3] >= 0 && this.Devices[index3] >= 0)
            checked { ++num2; }
          checked { ++index3; }
        }
        this.NumBoards = num2;
        this.DevCbo.Items.Clear();
        int num4 = checked (this.NumBoards - 1);
        int index4 = 0;
        while (index4 <= num4)
        {
          this.DevCbo.Items.Add((object) Conversions.ToString(this.Devices[index4]));
          if (this.Devices[index4] == this.DevNum)
          {
            this.DevCbo.SelectedIndex = index4;
            this.BrdNumLbl.Text = Conversions.ToString(this.Boards[index4]);
          }
          checked { ++index4; }
        }
        int num5 = checked (this.NumBoards - 1);
        int index5 = 0;
        while (index5 <= num5)
        {
          if (this.Boards[index5] >= 0 && this.Devices[index5] >= 0)
            this.SetDeviceNumber(this.Boards[index5], this.Devices[index5]);
          checked { ++index5; }
        }
        this.ReadDeviceNumber(this.BrdNum, ref this.DevNum);
      }
      GT668Def.GT668BoardNumber(this.DevNum, this.BrdNum);
      this.Refresh();
      Application.DoEvents();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      this.back_door_in_progress = false;
      this.Timer1.Enabled = false;
    }
  }
}

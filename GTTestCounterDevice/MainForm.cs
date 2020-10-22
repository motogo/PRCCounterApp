using BasicClassLibrary;
using Enums;
using GT668Library;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GTTestCounterDevice
{
    public partial class MainForm : Form
    {
        readonly NotifiesClass nf = new NotifiesClass();
        string InfoLine = "LOG";
        string DataLine = "DATA";

        void ErrorRaised(object sender, MessageEventArgs k)
        {

        }

        void InfoRaised(object sender, MessageEventArgs k)
        {
            if (k.Key.ToString() == InfoLine)
            {
                string mld = (k.Meldung.Length > 2) ? $@"{DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss")}: {k.Meldung}" : k.Meldung;
                Console.WriteLine(mld);
                rtResults.AppendText($@"{mld}");
                rtResults.ScrollToCaret();
                Application.DoEvents();
            }
            else if (k.Key.ToString() == DataLine)
            {
                
            
            }
        }

        public MainForm()
        {
            InitializeComponent();
            nf.Register4Info(InfoRaised);
            nf.Register4Error(ErrorRaised);
        }

        public TestOptionsClass EditToData()
        {
            TestOptionsClass to = new TestOptionsClass();
            to.manualTreshold = ckFixTreshold.Checked;
            double mt = StaticFunctionsClass.ToDoubleDef(txtManualTreshold.Text, -1);
            if (mt <= 0)
            {
                ckFixTreshold.Checked = false;
                txtManualTreshold.Text = "1.0";
                to.treshold = 1.0;
            }
            else
            {
                txtManualTreshold.Text = mt.ToString();
                to.treshold = mt;
            }
            to.minBoardNr = (int)nmMinBoard.Value;
            to.maxBoardNr = (int)nmMaxBoard.Value;
            to.signalA = ckSignalA.Checked;
            to.signalB = ckSignalB.Checked;

            return to;
        }

        private bool doTest(int board, GT668Class.GtiSignal signal, GT900USBClass GT668, TestOptionsClass testOpt)
        {
            double posv = 0.0;
            double negv = 0.0;
            Console.WriteLine("");
            GT668.ClearError();
            nf.AddToINFO($@"", InfoLine);
            nf.AddToINFO($@"Testing board {board} for signal {signal}", InfoLine);
            GT668.Select(board);
            GT668.MeasureAmplitude(signal, ref posv, ref negv, 1000.0);
            if (posv - negv >= 0.5)
            {
                double thr_val = (posv + negv) / 2.0;

                nf.AddToINFO($@"Signal found on board {board} for signal {EnumHelper.GetDescription(signal)} setting threshold {Math.Round(thr_val,3)} V", InfoLine);
                GT668.SetReferenceClock(GT668Class.GtiRefClkSrc.GT_REF_INTERNAL, false, false);
                GT668.SetBlockArm(GT668Class.GtiBlkArmSrc.GT_BA_IMM, GT668Class.GtiPolarity.GT_POL_POS, false);
                GT668.SetArmAuxOut(GT668Class.GtiArmAuxOut.GT_AUX_OUT_OFF);
                GT668.SetMemoryWrapMode(true);
                GT668.SetT0Mode(false, true);
                GT668.SetInputImpendance(signal, GT668Class.GtiImpedance.GT_IMP_LO);
                GT668.SetInputCoupling(signal, GT668Class.GtiCoupling.GT_CPL_DC);
                if (testOpt.manualTreshold)
                {
                    GT668.SetInputThreshold(signal, GT668Class.GtiThrMode.GT_THR_VOLTS, testOpt.treshold);
                }
                else
                {
                    GT668.SetInputThreshold(signal, GT668Class.GtiThrMode.GT_THR_VOLTS, thr_val);
                }
                GT668.SetInputPrescale(signal, GT668Class.GtiPrescale.GT_DIV_16);
                GT668.SetMeasSkip(0, 624U);
                switch(signal)
                {
                    case GT668Class.GtiSignal.GT_SIG_A : GT668.SetMeasInput(0, GT668Class.GtiInputSel.GT_CHA_POS); break;
                    case GT668Class.GtiSignal.GT_SIG_B : GT668.SetMeasInput(0, GT668Class.GtiInputSel.GT_CHB_POS); break;
                }

                
                GT668.SetMeasEnable(0, true);
                GT668.SetMeasEnable(1, false);

            
                
                GT668.StartMeasurements();
                Thread.Sleep(100);

                uint num2 = 0;
                ref uint local2 = ref num2;
                double num3 = 0.0;
                ref double local3 = ref num3;
                uint num4 = 0;
                ref uint local4 = ref num4;
                double[] data = new double[2];
                while (local2 != 2U)
                {
                    GT668.ReadTimetags(ref data[0], 2U, ref local2, ref local3, 0U, ref local4);
                    Thread.Sleep(100);
                }

                double result = Math.Abs(10000.0 / (data[1] - data[0]));

                //Console.WriteLine($@"value1:{data[0]} value1:{data[1]}->{result}={result / 1000000.0} Mhz read:{local2}");

                nf.AddToINFO($@"Signal board {0}, {EnumHelper.GetDescription(signal)} is {result / 1000000.0} Mhz", InfoLine);
                return true;
            }
            else
            {
                //No amplitude

                nf.AddToINFO($@"No signal found on board {board} for signal {EnumHelper.GetDescription(signal)}", InfoLine);
                return false;
            }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            GT900USBClass GT668 = new GT900USBClass();
            int device = 0;
            var testOpt = EditToData();
            nf.AddToINFO($@"Start testing ", InfoLine);
            

            bool init = GT668.Initialize(device);
            if (init)
            {
                string bm = GT668.GetBoardModel();
                nf.AddToINFO($@"Device {device} {bm} initialized", InfoLine);
                for (int i = testOpt.minBoardNr; i <= testOpt.maxBoardNr; i++)
                {
                    if(ckSignalA.Checked)                    
                        doTest(i, GT668Class.GtiSignal.GT_SIG_A, GT668, testOpt);
                    if (ckSignalB.Checked)
                        doTest(i, GT668Class.GtiSignal.GT_SIG_B, GT668, testOpt);
                }
            }
            else
            {
                nf.AddToINFO($@"Unable to initialize Device {device}", InfoLine);
            }
            nf.AddToINFO($@"", InfoLine);
            nf.AddToINFO($@"Testing ended -:)", InfoLine);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GT900USBClass GT668 = new GT900USBClass();
            GT668.ClearError();
            string str = GT668.GetDriverVersion();
            txtDriverVersion.Text = str;
                       
            int err = GT668.GetError();
            if(err > 0)
            {
                nf.AddToINFO($@"ERROR by loading app:{GT668.GetErrorMessage(err)}", InfoLine);
            }
            btnTest.Select();
        }
    }
}

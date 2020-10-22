using GT668Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuideTech
{
    public partial class DebugForm : Form
    {
        
            private IContainer components;
           
            private uint ActRaw;
            private uint[] RawData;
            private uint RawRead;
            private uint RawCount;
            private uint ReadCount;

            public DebugForm()
            {
                this.Load += new EventHandler(this.DebugFrm_Load);
                this.FormClosed += new FormClosedEventHandler(this.DebugFrm_FormClosed);
                this.FormClosing += new FormClosingEventHandler(this.DebugFrm_FormClosing);
                this.ActRaw = 0U;
                this.RawRead = 0U;
                this.RawCount = 1000U;
                this.ReadCount = 1000U;
                
                this.InitializeComponent();
            }

           
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
        /*
        public bool LoadSetup()
        {
            bool flag1 = GT668Def.GT668SetMemoryWrapMode(false) && GT668Def.GT668SetT0Mode(false, true) && GT668Def.GT668SetInputImpedance(GT668Def.GtiSignal.GT_SIG_A, (GT668Def.GtiImpedance)this.ImpACbo.SelectedIndex) && GT668Def.GT668SetInputImpedance(GT668Def.GtiSignal.GT_SIG_B, (GT668Def.GtiImpedance)this.ImpBCbo.SelectedIndex) && GT668Def.GT668SetInputCoupling(GT668Def.GtiSignal.GT_SIG_A, (GT668Def.GtiCoupling)this.CplACbo.SelectedIndex) && GT668Def.GT668SetInputCoupling(GT668Def.GtiSignal.GT_SIG_B, (GT668Def.GtiCoupling)this.CplBCbo.SelectedIndex) && GT668Def.GT668SetInputThreshold(GT668Def.GtiSignal.GT_SIG_A, (GT668Def.GtiThrMode)this.ThrModeACbo.SelectedIndex, Conversion.Val(this.ThrATxt.Text)) && GT668Def.GT668SetInputThreshold(GT668Def.GtiSignal.GT_SIG_B, (GT668Def.GtiThrMode)this.ThrModeBCbo.SelectedIndex, Conversion.Val(this.ThrBTxt.Text)) && GT668Def.GT668SetInputThreshold(GT668Def.GtiSignal.GT_SIG_ARM, (GT668Def.GtiThrMode)this.ThrArmModeCbo.SelectedIndex, Conversion.Val(this.ThrArmTxt.Text)) && GT668Def.GT668SetInputThreshold(GT668Def.GtiSignal.GT_SIG_CLK, (GT668Def.GtiThrMode)this.ThrClkModeCbo.SelectedIndex, Conversion.Val(this.ThrClkTxt.Text)) && GT668Def.GT668SetInputPrescale(GT668Def.GtiSignal.GT_SIG_A, (GT668Def.GtiPrescale)this.Ch0PrescCbo.SelectedIndex) && GT668Def.GT668SetInputPrescale(GT668Def.GtiSignal.GT_SIG_B, (GT668Def.GtiPrescale)this.Ch1PrescCbo.SelectedIndex) && GT668Def.GT668SetMeasEnable(0, this.Ch0Chk.Checked) && GT668Def.GT668SetMeasEnable(1, this.Ch1Chk.Checked);
            bool flag2;
            if (MyProject.Forms.ExrFrm.BrdRev >= 8U)
            {
                bool flag3 = !this.DelayChk.Visible ? flag1 && ConfigFrm.GT668SetDelay(false) : flag1 && ConfigFrm.GT668SetDelay(this.DelayChk.Checked);
                bool flag4 = this.Ch0SrcCbo.SelectedIndex != 4 ? (this.Ch0SrcCbo.SelectedIndex != 5 ? flag3 && GT668Def.GT668SetMeasInput(0, (GT668Def.GtiInputSel)this.Ch0SrcCbo.SelectedIndex) : flag3 && GT668Def.GT668SetMeasInput(0, GT668Def.GtiInputSel.GT_ARM_NEG)) : flag3 && GT668Def.GT668SetMeasInput(0, GT668Def.GtiInputSel.GT_ARM_POS);
                flag2 = this.Ch1SrcCbo.SelectedIndex != 4 ? (this.Ch1SrcCbo.SelectedIndex != 5 ? flag4 && GT668Def.GT668SetMeasInput(1, (GT668Def.GtiInputSel)this.Ch1SrcCbo.SelectedIndex) : flag4 && GT668Def.GT668SetMeasInput(1, GT668Def.GtiInputSel.GT_ARM_NEG)) : flag4 && GT668Def.GT668SetMeasInput(1, GT668Def.GtiInputSel.GT_ARM_POS);
            }
            else
                flag2 = flag1 && GT668Def.GT668SetMeasInput(0, (GT668Def.GtiInputSel)this.Ch0SrcCbo.SelectedIndex) && GT668Def.GT668SetMeasInput(1, (GT668Def.GtiInputSel)this.Ch1SrcCbo.SelectedIndex);
            bool flag5 = flag2 && GT668Def.GT668SetMeasSkip(0, Convert.ToUInt32(this.Ch0SkipUD.Value)) && GT668Def.GT668SetMeasSkip(1, Convert.ToUInt32(this.Ch1SkipUD.Value)) && GT668Def.GT668SetMeasTagArm(0, this.IndexToTagArm(this.TA0SrcCbo.SelectedIndex), (GT668Def.GtiPolarity)this.TA0PolCbo.SelectedIndex) && GT668Def.GT668SetMeasTagArm(1, this.IndexToTagArm(this.TA1SrcCbo.SelectedIndex), (GT668Def.GtiPolarity)this.TA1PolCbo.SelectedIndex) && GT668Def.GT668SetBlockArm(this.IndexToBlockArm(this.BASrcCbo.SelectedIndex), (GT668Def.GtiPolarity)this.BAPolCbo.SelectedIndex, this.BAModeCbo.SelectedIndex != 0) && GT668Def.GT668SetArmAuxOut((GT668Def.GtiArmAuxOut)this.AuxOutArmCbo.SelectedIndex);
            return this.ClkSrcCbo.SelectedIndex >= 2 ? (this.ClkSrcCbo.SelectedIndex != 2 ? (GT668Def.GT668IsPXI() ? flag5 && GT668Def.GT668SetReferenceClock((GT668Def.GtiRefClkSrc)checked(this.ClkSrcCbo.SelectedIndex - 1), false, this.ClkAuxChk.Checked) : flag5 && GT668Def.GT668SetReferenceClock((GT668Def.GtiRefClkSrc)this.ClkSrcCbo.SelectedIndex, false, this.ClkAuxChk.Checked)) : flag5 && GT668Def.GT668SetReferenceClock(GT668Def.GtiRefClkSrc.GT_REF_EXTERNAL, true, this.ClkAuxChk.Checked)) : flag5 && GT668Def.GT668SetReferenceClock((GT668Def.GtiRefClkSrc)this.ClkSrcCbo.SelectedIndex, false, this.ClkAuxChk.Checked);
        }

    */
        public void LoadSetup()
        {
            GT668Class.GT668SetMeasInput(0, GT668Class.GtiInputSel.GT_CHA_POS);
            GT668Class.GT668SetMeasInput(1, GT668Class.GtiInputSel.GT_CHB_POS);
            GT668Class.GT668SetMeasSkip(0, 0);
            GT668Class.GT668SetMeasSkip(1, 0);
            GT668Class.GT668SetReferenceClock(GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL,false,false);
            GT668Class.GT668SetMemoryWrapMode(false);
        }

            private void ConfBtn_Click(object sender, EventArgs e)
            {
                this._StatusLbl.Text = "Loading...";
                LoadSetup();
                this._StatusLbl.Text = "Loading - done.";
                int error = GT668Class.GT668GetError();
                if (error == 0)
                    return;
                string ErrMsg = "";
                GT668Class.GT668GetErrorMessage(error, ref ErrMsg);
                int num = (int)Interaction.MsgBox((object)("Error: " + ErrMsg), MsgBoxStyle.Exclamation, (object)"Error");
                GT668Class.GT668ClearError();
            }

            private void StartBtn_Click(object sender, EventArgs e)
            {
                this._StatusLbl.Text = "Starting...";
                GT668Class.GT668StartMeasurements();
                this._StopBtn.Enabled = true;
                this._StartBtn.Enabled = false;
                this._ConfBtn.Enabled = false;
                this._StatusLbl.Text = "Starting - done.";
                int error = GT668Class.GT668GetError();
                if (error != 0)
                {
                    string ErrMsg = "";
                    GT668Class.GT668GetErrorMessage(error, ref ErrMsg);
                    int num = (int)Interaction.MsgBox((object)("Error: " + ErrMsg), MsgBoxStyle.Exclamation, (object)"Error");
                    GT668Class.GT668ClearError();
                }
                this.RawRead = 0U;
            }

            private void StopBtn_Click(object sender, EventArgs e)
            {
                GT668Class.GT668StopMeasurements();
                this._StatusLbl.Text = "Stoping - done.";
                this._StopBtn.Enabled = false;
                this._ConfBtn.Enabled = true;
                this._StartBtn.Enabled = true;
            }

            private void ReadBtn_Click(object sender, EventArgs e)
            {
                string str = "";
                this._StatusLbl.Text = "Reading...";
                this.ActRaw = 0U;
                if (checked(this.RawRead + this.ReadCount) > this.RawCount)
                {
                    checked { this.RawCount += this.ReadCount; }
                    this.RawData = (uint[])Utils.CopyArray((Array)this.RawData, (Array)new uint[checked((int)((long)this.RawCount - 1L) + 1)]);
                }
            GT668Class.GT668ReadRaw(ref this.RawData[checked((int)this.RawRead)], this.RawRead, this.ReadCount, ref this.ActRaw);
            
            
            checked { this.RawRead += this.ActRaw; }
                this._TotalLbl.Text = this.RawRead.ToString();
                if (this.RawRead > 0U)
                {
                    uint num1 = checked((uint)((long)this.RawRead - 1L));
                    uint num2 = 0;
                    while (num2 <= num1)
                    {
                        str = str + (this.RawData[checked((int)num2)] >> 29).ToString() + " " + Strings.Right("00" + Conversion.Hex((long)(this.RawData[checked((int)num2)] >> 16) & 8191L), 3) + " " + Strings.Right("000" + Conversion.Hex((long)this.RawData[checked((int)num2)] & 16383L), 4);
                        if (checked((long)num2 + 1L) < (long)this.RawRead)
                            str += "\r\n";
                        checked { ++num2; }
                    }
                }
                this._RawDataTxt.Text = str;
                this._StatusLbl.Text = "Reading - done.";
            }

            private void TextBox2_TextChanged(object sender, EventArgs e)
            {
                TextBox textBox = (TextBox)sender;
                if (Versioned.IsNumeric((object)textBox.Text))
                    this.ReadCount = checked((uint)Math.Round(Conversion.Val(textBox.Text)));
                else
                    textBox.Text = this.ReadCount.ToString();
            }

            private void DebugFrm_Load(object sender, EventArgs e)
            {
                this.RawData = new uint[checked((int)((long)this.ReadCount - 1L) + 1)];
            }

            private void DebugFrm_FormClosed(object sender, FormClosedEventArgs e)
            {
                
            }

            private void DebugFrm_FormClosing(object sender, FormClosingEventArgs e)
            {    
                GT668Class.GT668StopMeasurements();
            }

            private void RawDataTxt_KeyDown(object sender, KeyEventArgs e)
            {
                if (!e.Control || e.KeyCode != Keys.A)
                    return;
                this._RawDataTxt.SelectAll();
            }
        }
}

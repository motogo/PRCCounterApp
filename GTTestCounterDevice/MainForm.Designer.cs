namespace GTTestCounterDevice
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTestDevice = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGT668Driver = new System.Windows.Forms.Label();
            this.txtDriverVersion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVolt = new System.Windows.Forms.Label();
            this.txtManualTreshold = new System.Windows.Forms.TextBox();
            this.ckFixTreshold = new System.Windows.Forms.CheckBox();
            this.gbBoards = new System.Windows.Forms.GroupBox();
            this.lblToBoard = new System.Windows.Forms.Label();
            this.lblFromBoard = new System.Windows.Forms.Label();
            this.nmMinBoard = new System.Windows.Forms.NumericUpDown();
            this.nmMaxBoard = new System.Windows.Forms.NumericUpDown();
            this.ckSignalB = new System.Windows.Forms.CheckBox();
            this.ckSignalA = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.rtResults = new System.Windows.Forms.RichTextBox();
            this.pnlLogUpper = new System.Windows.Forms.Panel();
            this.pnlTestDevice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbBoards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxBoard)).BeginInit();
            this.gbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTestDevice
            // 
            this.pnlTestDevice.Controls.Add(this.groupBox2);
            this.pnlTestDevice.Controls.Add(this.groupBox1);
            this.pnlTestDevice.Controls.Add(this.btnTest);
            this.pnlTestDevice.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTestDevice.Location = new System.Drawing.Point(0, 0);
            this.pnlTestDevice.Name = "pnlTestDevice";
            this.pnlTestDevice.Size = new System.Drawing.Size(261, 517);
            this.pnlTestDevice.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGT668Driver);
            this.groupBox2.Controls.Add(this.txtDriverVersion);
            this.groupBox2.Location = new System.Drawing.Point(18, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Systeminfo";
            // 
            // lblGT668Driver
            // 
            this.lblGT668Driver.AutoSize = true;
            this.lblGT668Driver.Location = new System.Drawing.Point(9, 26);
            this.lblGT668Driver.Name = "lblGT668Driver";
            this.lblGT668Driver.Size = new System.Drawing.Size(98, 13);
            this.lblGT668Driver.TabIndex = 17;
            this.lblGT668Driver.Text = "GT668 API Version";
            // 
            // txtDriverVersion
            // 
            this.txtDriverVersion.Location = new System.Drawing.Point(113, 23);
            this.txtDriverVersion.Name = "txtDriverVersion";
            this.txtDriverVersion.ReadOnly = true;
            this.txtDriverVersion.Size = new System.Drawing.Size(81, 20);
            this.txtDriverVersion.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVolt);
            this.groupBox1.Controls.Add(this.txtManualTreshold);
            this.groupBox1.Controls.Add(this.ckFixTreshold);
            this.groupBox1.Controls.Add(this.gbBoards);
            this.groupBox1.Controls.Add(this.ckSignalB);
            this.groupBox1.Controls.Add(this.ckSignalA);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 203);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test options";
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Location = new System.Drawing.Point(166, 157);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(14, 13);
            this.lblVolt.TabIndex = 17;
            this.lblVolt.Text = "V";
            // 
            // txtManualTreshold
            // 
            this.txtManualTreshold.Location = new System.Drawing.Point(116, 154);
            this.txtManualTreshold.Name = "txtManualTreshold";
            this.txtManualTreshold.Size = new System.Drawing.Size(44, 20);
            this.txtManualTreshold.TabIndex = 0;
            this.txtManualTreshold.Text = "1,0";
            // 
            // ckFixTreshold
            // 
            this.ckFixTreshold.AutoSize = true;
            this.ckFixTreshold.Location = new System.Drawing.Point(9, 157);
            this.ckFixTreshold.Name = "ckFixTreshold";
            this.ckFixTreshold.Size = new System.Drawing.Size(101, 17);
            this.ckFixTreshold.TabIndex = 0;
            this.ckFixTreshold.Text = "Manual treshold";
            this.ckFixTreshold.UseVisualStyleBackColor = true;
            // 
            // gbBoards
            // 
            this.gbBoards.Controls.Add(this.lblToBoard);
            this.gbBoards.Controls.Add(this.lblFromBoard);
            this.gbBoards.Controls.Add(this.nmMinBoard);
            this.gbBoards.Controls.Add(this.nmMaxBoard);
            this.gbBoards.Location = new System.Drawing.Point(6, 92);
            this.gbBoards.Name = "gbBoards";
            this.gbBoards.Size = new System.Drawing.Size(174, 46);
            this.gbBoards.TabIndex = 17;
            this.gbBoards.TabStop = false;
            this.gbBoards.Text = "Boards";
            // 
            // lblToBoard
            // 
            this.lblToBoard.AutoSize = true;
            this.lblToBoard.Location = new System.Drawing.Point(84, 21);
            this.lblToBoard.Name = "lblToBoard";
            this.lblToBoard.Size = new System.Drawing.Size(20, 13);
            this.lblToBoard.TabIndex = 20;
            this.lblToBoard.Text = "To";
            // 
            // lblFromBoard
            // 
            this.lblFromBoard.AutoSize = true;
            this.lblFromBoard.Location = new System.Drawing.Point(6, 21);
            this.lblFromBoard.Name = "lblFromBoard";
            this.lblFromBoard.Size = new System.Drawing.Size(30, 13);
            this.lblFromBoard.TabIndex = 17;
            this.lblFromBoard.Text = "From";
            // 
            // nmMinBoard
            // 
            this.nmMinBoard.Location = new System.Drawing.Point(43, 19);
            this.nmMinBoard.Name = "nmMinBoard";
            this.nmMinBoard.Size = new System.Drawing.Size(35, 20);
            this.nmMinBoard.TabIndex = 17;
            // 
            // nmMaxBoard
            // 
            this.nmMaxBoard.Location = new System.Drawing.Point(133, 19);
            this.nmMaxBoard.Name = "nmMaxBoard";
            this.nmMaxBoard.Size = new System.Drawing.Size(35, 20);
            this.nmMaxBoard.TabIndex = 19;
            // 
            // ckSignalB
            // 
            this.ckSignalB.AutoSize = true;
            this.ckSignalB.Checked = true;
            this.ckSignalB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSignalB.Location = new System.Drawing.Point(18, 56);
            this.ckSignalB.Name = "ckSignalB";
            this.ckSignalB.Size = new System.Drawing.Size(65, 17);
            this.ckSignalB.TabIndex = 18;
            this.ckSignalB.Text = "Signal B";
            this.ckSignalB.UseVisualStyleBackColor = true;
            // 
            // ckSignalA
            // 
            this.ckSignalA.AutoSize = true;
            this.ckSignalA.Checked = true;
            this.ckSignalA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSignalA.Location = new System.Drawing.Point(18, 33);
            this.ckSignalA.Name = "ckSignalA";
            this.ckSignalA.Size = new System.Drawing.Size(65, 17);
            this.ckSignalA.TabIndex = 17;
            this.ckSignalA.Text = "Signal A";
            this.ckSignalA.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 35);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Run test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.rtResults);
            this.gbResults.Controls.Add(this.pnlLogUpper);
            this.gbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResults.Location = new System.Drawing.Point(261, 0);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(806, 517);
            this.gbResults.TabIndex = 2;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // rtResults
            // 
            this.rtResults.BackColor = System.Drawing.SystemColors.Info;
            this.rtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResults.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtResults.Location = new System.Drawing.Point(3, 58);
            this.rtResults.Name = "rtResults";
            this.rtResults.ReadOnly = true;
            this.rtResults.Size = new System.Drawing.Size(800, 456);
            this.rtResults.TabIndex = 15;
            this.rtResults.Text = "";
            // 
            // pnlLogUpper
            // 
            this.pnlLogUpper.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLogUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogUpper.Location = new System.Drawing.Point(3, 16);
            this.pnlLogUpper.Name = "pnlLogUpper";
            this.pnlLogUpper.Size = new System.Drawing.Size(800, 42);
            this.pnlLogUpper.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 517);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.pnlTestDevice);
            this.Name = "MainForm";
            this.Text = "GT Test Device";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTestDevice.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBoards.ResumeLayout(false);
            this.gbBoards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxBoard)).EndInit();
            this.gbResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTestDevice;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.RichTextBox rtResults;
        private System.Windows.Forms.Panel pnlLogUpper;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbBoards;
        private System.Windows.Forms.Label lblToBoard;
        private System.Windows.Forms.Label lblFromBoard;
        private System.Windows.Forms.NumericUpDown nmMinBoard;
        private System.Windows.Forms.NumericUpDown nmMaxBoard;
        private System.Windows.Forms.CheckBox ckSignalB;
        private System.Windows.Forms.CheckBox ckSignalA;
        private System.Windows.Forms.TextBox txtManualTreshold;
        private System.Windows.Forms.CheckBox ckFixTreshold;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDriverVersion;
        private System.Windows.Forms.Label lblGT668Driver;
    }
}


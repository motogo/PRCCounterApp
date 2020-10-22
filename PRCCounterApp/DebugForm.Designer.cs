namespace GuideTech
{
    partial class DebugForm
    {
        
       
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._ConfBtn = new System.Windows.Forms.Button();
            this._StartBtn = new System.Windows.Forms.Button();
            this._StopBtn = new System.Windows.Forms.Button();
            this._ReadBtn = new System.Windows.Forms.Button();
            this._RawDataTxt = new System.Windows.Forms.TextBox();
            this._TextBox2 = new System.Windows.Forms.TextBox();
            this._Label1 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this._StatusLbl = new System.Windows.Forms.Label();
            this._TotalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _ConfBtn
            // 
            this._ConfBtn.Location = new System.Drawing.Point(44, 35);
            this._ConfBtn.Name = "_ConfBtn";
            this._ConfBtn.Size = new System.Drawing.Size(120, 47);
            this._ConfBtn.TabIndex = 0;
            this._ConfBtn.Text = "ConfBtn";
            this._ConfBtn.UseVisualStyleBackColor = true;
            this._ConfBtn.Click += new System.EventHandler(this.ConfBtn_Click);
            // 
            // _StartBtn
            // 
            this._StartBtn.Location = new System.Drawing.Point(325, 35);
            this._StartBtn.Name = "_StartBtn";
            this._StartBtn.Size = new System.Drawing.Size(169, 47);
            this._StartBtn.TabIndex = 1;
            this._StartBtn.Text = "StartBtn";
            this._StartBtn.UseVisualStyleBackColor = true;
            this._StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // _StopBtn
            // 
            this._StopBtn.Location = new System.Drawing.Point(186, 35);
            this._StopBtn.Name = "_StopBtn";
            this._StopBtn.Size = new System.Drawing.Size(122, 47);
            this._StopBtn.TabIndex = 2;
            this._StopBtn.Text = "StopBtn";
            this._StopBtn.UseVisualStyleBackColor = true;
            this._StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // _ReadBtn
            // 
            this._ReadBtn.Location = new System.Drawing.Point(329, 138);
            this._ReadBtn.Name = "_ReadBtn";
            this._ReadBtn.Size = new System.Drawing.Size(169, 47);
            this._ReadBtn.TabIndex = 3;
            this._ReadBtn.Text = "ReadBtn";
            this._ReadBtn.UseVisualStyleBackColor = true;
            this._ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // _RawDataTxt
            // 
            this._RawDataTxt.Location = new System.Drawing.Point(325, 226);
            this._RawDataTxt.Name = "_RawDataTxt";
            this._RawDataTxt.Size = new System.Drawing.Size(173, 26);
            this._RawDataTxt.TabIndex = 4;
            this._RawDataTxt.Text = "RawDataTxt";
            // 
            // _TextBox2
            // 
            this._TextBox2.Location = new System.Drawing.Point(514, 226);
            this._TextBox2.Name = "_TextBox2";
            this._TextBox2.Size = new System.Drawing.Size(181, 26);
            this._TextBox2.TabIndex = 5;
            this._TextBox2.Text = "TextBox2";
            this._TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Location = new System.Drawing.Point(551, 65);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(57, 20);
            this._Label1.TabIndex = 6;
            this._Label1.Text = "Label1";
            // 
            // _Label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.Location = new System.Drawing.Point(551, 138);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(57, 20);
            this._Label2.TabIndex = 7;
            this._Label2.Text = "Label2";
            // 
            // _StatusLbl
            // 
            this._StatusLbl.AutoSize = true;
            this._StatusLbl.Location = new System.Drawing.Point(325, 296);
            this._StatusLbl.Name = "_StatusLbl";
            this._StatusLbl.Size = new System.Drawing.Size(77, 20);
            this._StatusLbl.TabIndex = 8;
            this._StatusLbl.Text = "StatusLbl";
            // 
            // _TotalLbl
            // 
            this._TotalLbl.AutoSize = true;
            this._TotalLbl.Location = new System.Drawing.Point(510, 296);
            this._TotalLbl.Name = "_TotalLbl";
            this._TotalLbl.Size = new System.Drawing.Size(65, 20);
            this._TotalLbl.TabIndex = 9;
            this._TotalLbl.Text = "TotalLbl";
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._TotalLbl);
            this.Controls.Add(this._StatusLbl);
            this.Controls.Add(this._Label2);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._TextBox2);
            this.Controls.Add(this._RawDataTxt);
            this.Controls.Add(this._ReadBtn);
            this.Controls.Add(this._StopBtn);
            this.Controls.Add(this._StartBtn);
            this.Controls.Add(this._ConfBtn);
            this.Name = "DebugForm";
            this.Text = "DebugForm";
            this.Load += new System.EventHandler(this.DebugFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _ConfBtn;
        private System.Windows.Forms.Button _StartBtn;
        private System.Windows.Forms.Button _StopBtn;
        private System.Windows.Forms.Button _ReadBtn;
        private System.Windows.Forms.TextBox _RawDataTxt;
        private System.Windows.Forms.TextBox _TextBox2;
        private System.Windows.Forms.Label _Label1;
        private System.Windows.Forms.Label _Label2;
        private System.Windows.Forms.Label _StatusLbl;
        private System.Windows.Forms.Label _TotalLbl;
    }
}
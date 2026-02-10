namespace SmartFireControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trbElevation = new System.Windows.Forms.TrackBar();
            this.trbAzimuth = new System.Windows.Forms.TrackBar();
            this.btnFire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTargetX = new System.Windows.Forms.TextBox();
            this.lblAngleResult = new System.Windows.Forms.Label();
            this.txtAngleResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTargetY = new System.Windows.Forms.TextBox();
            this.txtDistanceResult = new System.Windows.Forms.TextBox();
            this.lblDistanceResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblElevationValue = new System.Windows.Forms.Label();
            this.lblAzimuthValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbElevation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAzimuth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trbElevation
            // 
            this.trbElevation.Location = new System.Drawing.Point(11, 147);
            this.trbElevation.Maximum = 90;
            this.trbElevation.Name = "trbElevation";
            this.trbElevation.Size = new System.Drawing.Size(492, 56);
            this.trbElevation.TabIndex = 0;
            this.trbElevation.Scroll += new System.EventHandler(this.trbElevation_Scroll);
            // 
            // trbAzimuth
            // 
            this.trbAzimuth.Location = new System.Drawing.Point(6, 56);
            this.trbAzimuth.Maximum = 180;
            this.trbAzimuth.Name = "trbAzimuth";
            this.trbAzimuth.Size = new System.Drawing.Size(497, 56);
            this.trbAzimuth.TabIndex = 1;
            this.trbAzimuth.Scroll += new System.EventHandler(this.trbAzimuth_Scroll);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Red;
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.Color.White;
            this.btnFire.Location = new System.Drawing.Point(54, 682);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(574, 54);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hədəfin koordinatlarını daxil edin:";
            // 
            // txtTargetX
            // 
            this.txtTargetX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetX.Location = new System.Drawing.Point(209, 170);
            this.txtTargetX.Name = "txtTargetX";
            this.txtTargetX.Size = new System.Drawing.Size(115, 30);
            this.txtTargetX.TabIndex = 4;
            // 
            // lblAngleResult
            // 
            this.lblAngleResult.AutoSize = true;
            this.lblAngleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngleResult.ForeColor = System.Drawing.Color.White;
            this.lblAngleResult.Location = new System.Drawing.Point(49, 367);
            this.lblAngleResult.Name = "lblAngleResult";
            this.lblAngleResult.Size = new System.Drawing.Size(425, 29);
            this.lblAngleResult.TabIndex = 6;
            this.lblAngleResult.Text = "Məsafəyə görə lazım olan bucağ :";
            this.lblAngleResult.Visible = false;
            // 
            // txtAngleResult
            // 
            this.txtAngleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngleResult.Location = new System.Drawing.Point(488, 368);
            this.txtAngleResult.Name = "txtAngleResult";
            this.txtAngleResult.ReadOnly = true;
            this.txtAngleResult.Size = new System.Drawing.Size(140, 30);
            this.txtAngleResult.TabIndex = 7;
            this.txtAngleResult.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Green;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(54, 217);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(574, 46);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Məsafəni və Bucağı Hesabla";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Minaatanın sağa-sola döndərin (0 - 180)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lülənin yuxarı-aşağı qalxması (0 - 90)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1381, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1381, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(345, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(625, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "TACTICAL FIRE CONTROL SYSTEM";
            // 
            // lstLog
            // 
            this.lstLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 25;
            this.lstLog.Items.AddRange(new object[] {
            " "});
            this.lstLog.Location = new System.Drawing.Point(712, 217);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(581, 504);
            this.lstLog.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(938, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Log Paneli";
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbLoading.Location = new System.Drawing.Point(54, 276);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(574, 27);
            this.pbLoading.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(156, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "X :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(347, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Y :";
            // 
            // txtTargetY
            // 
            this.txtTargetY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetY.Location = new System.Drawing.Point(400, 170);
            this.txtTargetY.Name = "txtTargetY";
            this.txtTargetY.Size = new System.Drawing.Size(120, 30);
            this.txtTargetY.TabIndex = 18;
            // 
            // txtDistanceResult
            // 
            this.txtDistanceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceResult.Location = new System.Drawing.Point(488, 324);
            this.txtDistanceResult.Name = "txtDistanceResult";
            this.txtDistanceResult.ReadOnly = true;
            this.txtDistanceResult.Size = new System.Drawing.Size(140, 30);
            this.txtDistanceResult.TabIndex = 21;
            this.txtDistanceResult.Visible = false;
            // 
            // lblDistanceResult
            // 
            this.lblDistanceResult.AutoSize = true;
            this.lblDistanceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceResult.ForeColor = System.Drawing.Color.White;
            this.lblDistanceResult.Location = new System.Drawing.Point(49, 323);
            this.lblDistanceResult.Name = "lblDistanceResult";
            this.lblDistanceResult.Size = new System.Drawing.Size(351, 29);
            this.lblDistanceResult.TabIndex = 20;
            this.lblDistanceResult.Text = "Hədəfə qədər olan məsafə :";
            this.lblDistanceResult.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblElevationValue);
            this.groupBox1.Controls.Add(this.lblAzimuthValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trbAzimuth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trbElevation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(54, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 223);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual İdarə";
            // 
            // lblElevationValue
            // 
            this.lblElevationValue.AutoSize = true;
            this.lblElevationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevationValue.ForeColor = System.Drawing.Color.White;
            this.lblElevationValue.Location = new System.Drawing.Point(520, 147);
            this.lblElevationValue.Name = "lblElevationValue";
            this.lblElevationValue.Size = new System.Drawing.Size(28, 29);
            this.lblElevationValue.TabIndex = 24;
            this.lblElevationValue.Text = "0";
            // 
            // lblAzimuthValue
            // 
            this.lblAzimuthValue.AutoSize = true;
            this.lblAzimuthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzimuthValue.ForeColor = System.Drawing.Color.White;
            this.lblAzimuthValue.Location = new System.Drawing.Point(520, 56);
            this.lblAzimuthValue.Name = "lblAzimuthValue";
            this.lblAzimuthValue.Size = new System.Drawing.Size(28, 29);
            this.lblAzimuthValue.TabIndex = 23;
            this.lblAzimuthValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1328, 748);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDistanceResult);
            this.Controls.Add(this.lblDistanceResult);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTargetY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAngleResult);
            this.Controls.Add(this.lblAngleResult);
            this.Controls.Add(this.txtTargetX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFire);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbElevation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAzimuth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbElevation;
        private System.Windows.Forms.TrackBar trbAzimuth;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTargetX;
        private System.Windows.Forms.Label lblAngleResult;
        private System.Windows.Forms.TextBox txtAngleResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTargetY;
        private System.Windows.Forms.TextBox txtDistanceResult;
        private System.Windows.Forms.Label lblDistanceResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblElevationValue;
        private System.Windows.Forms.Label lblAzimuthValue;
    }
}


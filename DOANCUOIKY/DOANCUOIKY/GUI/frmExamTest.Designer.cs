namespace DOANCUOIKY.GUI
{
    partial class frmExamTest
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblExamTime = new System.Windows.Forms.Label();
            this.btnEndExam = new System.Windows.Forms.Button();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMade = new System.Windows.Forms.Label();
            this.lblDethi = new System.Windows.Forms.Label();
            this.lblCauhoi = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCauThu = new System.Windows.Forms.Label();
            this.lblCauA = new System.Windows.Forms.Label();
            this.lblCauB = new System.Windows.Forms.Label();
            this.lblCauC = new System.Windows.Forms.Label();
            this.lblCauD = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(203, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(107, 26);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(75, 23);
            this.btnExam.TabIndex = 1;
            this.btnExam.Text = "Bắt đầu thi";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblExamTime
            // 
            this.lblExamTime.AutoSize = true;
            this.lblExamTime.BackColor = System.Drawing.Color.Red;
            this.lblExamTime.Location = new System.Drawing.Point(30, 33);
            this.lblExamTime.Name = "lblExamTime";
            this.lblExamTime.Size = new System.Drawing.Size(61, 13);
            this.lblExamTime.TabIndex = 2;
            this.lblExamTime.Text = "thoi gian thi";
            // 
            // btnEndExam
            // 
            this.btnEndExam.Location = new System.Drawing.Point(301, 26);
            this.btnEndExam.Name = "btnEndExam";
            this.btnEndExam.Size = new System.Drawing.Size(75, 23);
            this.btnEndExam.TabIndex = 3;
            this.btnEndExam.Text = "nop bai";
            this.btnEndExam.UseVisualStyleBackColor = true;
            this.btnEndExam.Click += new System.EventHandler(this.btnEndExam_Click);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(29, 136);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(32, 17);
            this.rbA.TabIndex = 4;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(29, 157);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(32, 17);
            this.rbB.TabIndex = 5;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(29, 180);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(32, 17);
            this.rbC.TabIndex = 6;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(28, 203);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(33, 17);
            this.rbD.TabIndex = 7;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(301, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 156);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 10;
            // 
            // lblMade
            // 
            this.lblMade.AutoSize = true;
            this.lblMade.Location = new System.Drawing.Point(87, 77);
            this.lblMade.Name = "lblMade";
            this.lblMade.Size = new System.Drawing.Size(36, 13);
            this.lblMade.TabIndex = 11;
            this.lblMade.Text = "ma de";
            // 
            // lblDethi
            // 
            this.lblDethi.AutoSize = true;
            this.lblDethi.Location = new System.Drawing.Point(166, 77);
            this.lblDethi.Name = "lblDethi";
            this.lblDethi.Size = new System.Drawing.Size(19, 13);
            this.lblDethi.TabIndex = 12;
            this.lblDethi.Text = "de";
            // 
            // lblCauhoi
            // 
            this.lblCauhoi.AutoSize = true;
            this.lblCauhoi.Location = new System.Drawing.Point(81, 107);
            this.lblCauhoi.Name = "lblCauhoi";
            this.lblCauhoi.Size = new System.Drawing.Size(42, 13);
            this.lblCauhoi.TabIndex = 13;
            this.lblCauhoi.Text = "cau hoi";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(464, 272);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(378, 274);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCauThu
            // 
            this.lblCauThu.AutoSize = true;
            this.lblCauThu.Location = new System.Drawing.Point(30, 107);
            this.lblCauThu.Name = "lblCauThu";
            this.lblCauThu.Size = new System.Drawing.Size(31, 13);
            this.lblCauThu.TabIndex = 16;
            this.lblCauThu.Text = "cau :";
            // 
            // lblCauA
            // 
            this.lblCauA.AutoSize = true;
            this.lblCauA.Location = new System.Drawing.Point(67, 138);
            this.lblCauA.Name = "lblCauA";
            this.lblCauA.Size = new System.Drawing.Size(34, 13);
            this.lblCauA.TabIndex = 17;
            this.lblCauA.Text = "cau a";
            // 
            // lblCauB
            // 
            this.lblCauB.AutoSize = true;
            this.lblCauB.Location = new System.Drawing.Point(67, 159);
            this.lblCauB.Name = "lblCauB";
            this.lblCauB.Size = new System.Drawing.Size(34, 13);
            this.lblCauB.TabIndex = 18;
            this.lblCauB.Text = "cau b";
            // 
            // lblCauC
            // 
            this.lblCauC.AutoSize = true;
            this.lblCauC.Location = new System.Drawing.Point(67, 182);
            this.lblCauC.Name = "lblCauC";
            this.lblCauC.Size = new System.Drawing.Size(34, 13);
            this.lblCauC.TabIndex = 19;
            this.lblCauC.Text = "cau c";
            // 
            // lblCauD
            // 
            this.lblCauD.AutoSize = true;
            this.lblCauD.Location = new System.Drawing.Point(67, 205);
            this.lblCauD.Name = "lblCauD";
            this.lblCauD.Size = new System.Drawing.Size(34, 13);
            this.lblCauD.TabIndex = 20;
            this.lblCauD.Text = "cau d";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(588, 26);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(198, 253);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // frmExamTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 321);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.lblCauD);
            this.Controls.Add(this.lblCauC);
            this.Controls.Add(this.lblCauB);
            this.Controls.Add(this.lblCauA);
            this.Controls.Add(this.lblCauThu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblCauhoi);
            this.Controls.Add(this.lblDethi);
            this.Controls.Add(this.lblMade);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.btnEndExam);
            this.Controls.Add(this.lblExamTime);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnExit);
            this.Name = "frmExamTest";
            this.Text = "ExamTest";
            this.Load += new System.EventHandler(this.frmExamTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblExamTime;
        private System.Windows.Forms.Button btnEndExam;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMade;
        private System.Windows.Forms.Label lblDethi;
        private System.Windows.Forms.Label lblCauhoi;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCauThu;
        private System.Windows.Forms.Label lblCauA;
        private System.Windows.Forms.Label lblCauB;
        private System.Windows.Forms.Label lblCauC;
        private System.Windows.Forms.Label lblCauD;
        private System.Windows.Forms.ListView listView2;
    }
}
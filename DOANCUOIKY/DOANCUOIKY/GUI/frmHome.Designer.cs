namespace DOANCUOIKY.GUI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.menuTEACHER = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTITLE_QUESTION = new System.Windows.Forms.ToolStripMenuItem();
            this.NEW_QUESTION = new System.Windows.Forms.ToolStripMenuItem();
            this.FIND_QUESTION = new System.Windows.Forms.ToolStripMenuItem();
            this.HICTORY_EXAM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSTUDENT = new System.Windows.Forms.ToolStripMenuItem();
            this.EXAM_TEST = new System.Windows.Forms.ToolStripMenuItem();
            this.EXAM = new System.Windows.Forms.ToolStripMenuItem();
            this.HISTORY_STUDENT_EXAM = new System.Windows.Forms.ToolStripMenuItem();
            this.ABOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLOGOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbMSSV1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNAME = new System.Windows.Forms.Label();
            this.lbNAME1 = new System.Windows.Forms.Label();
            this.lbPOSITION = new System.Windows.Forms.Label();
            this.lbPOSITION1 = new System.Windows.Forms.Label();
            this.menuHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuHome
            // 
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTEACHER,
            this.menuSTUDENT,
            this.ABOUT,
            this.menuLOGOUT});
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(532, 24);
            this.menuHome.TabIndex = 0;
            this.menuHome.Text = "menuStrip1";
            // 
            // menuTEACHER
            // 
            this.menuTEACHER.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTITLE_QUESTION,
            this.NEW_QUESTION,
            this.FIND_QUESTION,
            this.HICTORY_EXAM});
            this.menuTEACHER.Name = "menuTEACHER";
            this.menuTEACHER.Size = new System.Drawing.Size(58, 20);
            this.menuTEACHER.Text = "Teacher";
            // 
            // menuTITLE_QUESTION
            // 
            this.menuTITLE_QUESTION.Name = "menuTITLE_QUESTION";
            this.menuTITLE_QUESTION.Size = new System.Drawing.Size(156, 22);
            this.menuTITLE_QUESTION.Text = "Tạo Mã đề";
            this.menuTITLE_QUESTION.Click += new System.EventHandler(this.menuTITLE_QUESTION_Click);
            // 
            // NEW_QUESTION
            // 
            this.NEW_QUESTION.Name = "NEW_QUESTION";
            this.NEW_QUESTION.Size = new System.Drawing.Size(156, 22);
            this.NEW_QUESTION.Text = "Thêm mới câu hỏi";
            this.NEW_QUESTION.Click += new System.EventHandler(this.NEW_QUESTION_Click);
            // 
            // FIND_QUESTION
            // 
            this.FIND_QUESTION.Name = "FIND_QUESTION";
            this.FIND_QUESTION.Size = new System.Drawing.Size(156, 22);
            this.FIND_QUESTION.Text = "Tìm kiếm câu hỏi";
            this.FIND_QUESTION.Click += new System.EventHandler(this.FIND_QUESTION_Click);
            // 
            // HICTORY_EXAM
            // 
            this.HICTORY_EXAM.Name = "HICTORY_EXAM";
            this.HICTORY_EXAM.Size = new System.Drawing.Size(156, 22);
            this.HICTORY_EXAM.Text = "Lịch sử thi";
            this.HICTORY_EXAM.Click += new System.EventHandler(this.HICTORY_EXAM_Click);
            // 
            // menuSTUDENT
            // 
            this.menuSTUDENT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EXAM_TEST,
            this.EXAM,
            this.HISTORY_STUDENT_EXAM});
            this.menuSTUDENT.Name = "menuSTUDENT";
            this.menuSTUDENT.Size = new System.Drawing.Size(57, 20);
            this.menuSTUDENT.Text = "Student";
            // 
            // EXAM_TEST
            // 
            this.EXAM_TEST.Name = "EXAM_TEST";
            this.EXAM_TEST.Size = new System.Drawing.Size(122, 22);
            this.EXAM_TEST.Text = "Thi thử";
            // 
            // EXAM
            // 
            this.EXAM.Name = "EXAM";
            this.EXAM.Size = new System.Drawing.Size(122, 22);
            this.EXAM.Text = "Thi chính";
            // 
            // HISTORY_STUDENT_EXAM
            // 
            this.HISTORY_STUDENT_EXAM.Name = "HISTORY_STUDENT_EXAM";
            this.HISTORY_STUDENT_EXAM.Size = new System.Drawing.Size(122, 22);
            this.HISTORY_STUDENT_EXAM.Text = "Lịch sử thi";
            // 
            // ABOUT
            // 
            this.ABOUT.Name = "ABOUT";
            this.ABOUT.Size = new System.Drawing.Size(48, 20);
            this.ABOUT.Text = "About";
            // 
            // menuLOGOUT
            // 
            this.menuLOGOUT.Name = "menuLOGOUT";
            this.menuLOGOUT.Size = new System.Drawing.Size(52, 20);
            this.menuLOGOUT.Text = "Logout";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMSSV.Location = new System.Drawing.Point(178, 244);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(83, 15);
            this.lbMSSV.TabIndex = 1;
            this.lbMSSV.Text = "Mã số sinh viên";
            // 
            // lbMSSV1
            // 
            this.lbMSSV1.AutoSize = true;
            this.lbMSSV1.Location = new System.Drawing.Point(285, 244);
            this.lbMSSV1.Name = "lbMSSV1";
            this.lbMSSV1.Size = new System.Drawing.Size(37, 13);
            this.lbMSSV1.TabIndex = 2;
            this.lbMSSV1.Text = "MSSV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 188);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbNAME
            // 
            this.lbNAME.AutoSize = true;
            this.lbNAME.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNAME.Location = new System.Drawing.Point(184, 282);
            this.lbNAME.Name = "lbNAME";
            this.lbNAME.Size = new System.Drawing.Size(76, 15);
            this.lbNAME.TabIndex = 4;
            this.lbNAME.Text = "Tên sinh viên ";
            this.lbNAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNAME1
            // 
            this.lbNAME1.AutoSize = true;
            this.lbNAME1.Location = new System.Drawing.Point(285, 284);
            this.lbNAME1.Name = "lbNAME1";
            this.lbNAME1.Size = new System.Drawing.Size(80, 13);
            this.lbNAME1.TabIndex = 5;
            this.lbNAME1.Text = "Tên sinh viên   ";
            this.lbNAME1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPOSITION
            // 
            this.lbPOSITION.AutoSize = true;
            this.lbPOSITION.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbPOSITION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPOSITION.Location = new System.Drawing.Point(212, 323);
            this.lbPOSITION.Name = "lbPOSITION";
            this.lbPOSITION.Size = new System.Drawing.Size(49, 15);
            this.lbPOSITION.TabIndex = 6;
            this.lbPOSITION.Text = "Chức vụ";
            this.lbPOSITION.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPOSITION1
            // 
            this.lbPOSITION1.AutoSize = true;
            this.lbPOSITION1.Location = new System.Drawing.Point(285, 325);
            this.lbPOSITION1.Name = "lbPOSITION1";
            this.lbPOSITION1.Size = new System.Drawing.Size(53, 13);
            this.lbPOSITION1.TabIndex = 7;
            this.lbPOSITION1.Text = "Chức vụ  ";
            this.lbPOSITION1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 400);
            this.Controls.Add(this.lbPOSITION1);
            this.Controls.Add(this.lbPOSITION);
            this.Controls.Add(this.lbNAME1);
            this.Controls.Add(this.lbNAME);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMSSV1);
            this.Controls.Add(this.lbMSSV);
            this.Controls.Add(this.menuHome);
            this.MainMenuStrip = this.menuHome;
            this.Name = "frmHome";
            this.Text = "Home";
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuTEACHER;
        private System.Windows.Forms.ToolStripMenuItem menuSTUDENT;
        private System.Windows.Forms.ToolStripMenuItem ABOUT;
        private System.Windows.Forms.ToolStripMenuItem NEW_QUESTION;
        private System.Windows.Forms.ToolStripMenuItem FIND_QUESTION;
        private System.Windows.Forms.ToolStripMenuItem HICTORY_EXAM;
        private System.Windows.Forms.ToolStripMenuItem EXAM_TEST;
        private System.Windows.Forms.ToolStripMenuItem EXAM;
        private System.Windows.Forms.ToolStripMenuItem HISTORY_STUDENT_EXAM;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbMSSV1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNAME;
        private System.Windows.Forms.Label lbNAME1;
        private System.Windows.Forms.Label lbPOSITION;
        private System.Windows.Forms.Label lbPOSITION1;
        private System.Windows.Forms.ToolStripMenuItem menuLOGOUT;
        private System.Windows.Forms.ToolStripMenuItem menuTITLE_QUESTION;
    }
}
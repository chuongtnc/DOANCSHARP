namespace DOANCUOIKY.GUI
{
    partial class frmHistoryExam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.tbStudentNo = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvListStudent = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvListExam = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gvListQuestion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStudent)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListExam)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbStudentName);
            this.groupBox1.Controls.Add(this.tbStudentNo);
            this.groupBox1.Controls.Add(this.btFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã số sinh viên";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(322, 19);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(100, 20);
            this.tbStudentName.TabIndex = 2;
            // 
            // tbStudentNo
            // 
            this.tbStudentNo.Location = new System.Drawing.Point(102, 19);
            this.tbStudentNo.Name = "tbStudentNo";
            this.tbStudentNo.Size = new System.Drawing.Size(100, 20);
            this.tbStudentNo.TabIndex = 1;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(440, 17);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 0;
            this.btFind.Text = "Tìm kiếm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvListStudent);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 465);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // gvListStudent
            // 
            this.gvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListStudent.Location = new System.Drawing.Point(6, 19);
            this.gvListStudent.Name = "gvListStudent";
            this.gvListStudent.Size = new System.Drawing.Size(264, 440);
            this.gvListStudent.TabIndex = 0;
            this.gvListStudent.Click += new System.EventHandler(this.gvListStudent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gvListExam);
            this.groupBox3.Location = new System.Drawing.Point(334, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 465);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Thi";
            // 
            // gvListExam
            // 
            this.gvListExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListExam.Location = new System.Drawing.Point(6, 19);
            this.gvListExam.Name = "gvListExam";
            this.gvListExam.Size = new System.Drawing.Size(276, 440);
            this.gvListExam.TabIndex = 1;
            this.gvListExam.Click += new System.EventHandler(this.gvListExam_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gvListQuestion);
            this.groupBox4.Location = new System.Drawing.Point(668, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 465);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách câu hỏi";
            // 
            // gvListQuestion
            // 
            this.gvListQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListQuestion.Location = new System.Drawing.Point(6, 19);
            this.gvListQuestion.Name = "gvListQuestion";
            this.gvListQuestion.Size = new System.Drawing.Size(264, 440);
            this.gvListQuestion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "----------->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "----------->";
            // 
            // frmHistoryExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHistoryExam";
            this.Text = "HictoryExam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListStudent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListExam)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.TextBox tbStudentNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvListStudent;
        private System.Windows.Forms.DataGridView gvListExam;
        private System.Windows.Forms.DataGridView gvListQuestion;
    }
}
namespace DOANCUOIKY.GUI
{
    partial class frmNewQuestion
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatusSearch = new System.Windows.Forms.ComboBox();
            this.edtQuestionSearch = new System.Windows.Forms.TextBox();
            this.edtNoSearch = new System.Windows.Forms.TextBox();
            this.cbTitleSearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.gvQuestion = new System.Windows.Forms.DataGridView();
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.cbAnswer = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.edtD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edtC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.edtB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edtA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtQuestion = new System.Windows.Forms.TextBox();
            this.edtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuestion)).BeginInit();
            this.gbTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridView1);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.cbStatusSearch);
            this.groupBox.Controls.Add(this.edtQuestionSearch);
            this.groupBox.Controls.Add(this.edtNoSearch);
            this.groupBox.Controls.Add(this.cbTitleSearch);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.btFind);
            this.groupBox.Controls.Add(this.gvQuestion);
            this.groupBox.Location = new System.Drawing.Point(31, 190);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(829, 341);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status";
            // 
            // cbStatusSearch
            // 
            this.cbStatusSearch.FormattingEnabled = true;
            this.cbStatusSearch.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.cbStatusSearch.Location = new System.Drawing.Point(555, 31);
            this.cbStatusSearch.Name = "cbStatusSearch";
            this.cbStatusSearch.Size = new System.Drawing.Size(154, 21);
            this.cbStatusSearch.TabIndex = 16;
            this.cbStatusSearch.Text = "Enable";
            // 
            // edtQuestionSearch
            // 
            this.edtQuestionSearch.Location = new System.Drawing.Point(359, 31);
            this.edtQuestionSearch.Name = "edtQuestionSearch";
            this.edtQuestionSearch.Size = new System.Drawing.Size(147, 20);
            this.edtQuestionSearch.TabIndex = 15;
            // 
            // edtNoSearch
            // 
            this.edtNoSearch.Location = new System.Drawing.Point(232, 31);
            this.edtNoSearch.Name = "edtNoSearch";
            this.edtNoSearch.Size = new System.Drawing.Size(66, 20);
            this.edtNoSearch.TabIndex = 14;
            // 
            // cbTitleSearch
            // 
            this.cbTitleSearch.FormattingEnabled = true;
            this.cbTitleSearch.Location = new System.Drawing.Point(56, 30);
            this.cbTitleSearch.Name = "cbTitleSearch";
            this.cbTitleSearch.Size = new System.Drawing.Size(131, 21);
            this.cbTitleSearch.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã đề";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Câu hỏi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "No";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(748, 28);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 3;
            this.btFind.Text = "Tìm kiếm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // gvQuestion
            // 
            this.gvQuestion.AllowUserToAddRows = false;
            this.gvQuestion.AllowUserToDeleteRows = false;
            this.gvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQuestion.Location = new System.Drawing.Point(6, 61);
            this.gvQuestion.Name = "gvQuestion";
            this.gvQuestion.ReadOnly = true;
            this.gvQuestion.Size = new System.Drawing.Size(817, 274);
            this.gvQuestion.TabIndex = 0;
            this.gvQuestion.Click += new System.EventHandler(this.gvQuestion_Click);
            // 
            // gbTitle
            // 
            this.gbTitle.Controls.Add(this.cbAnswer);
            this.gbTitle.Controls.Add(this.cbStatus);
            this.gbTitle.Controls.Add(this.label13);
            this.gbTitle.Controls.Add(this.label12);
            this.gbTitle.Controls.Add(this.edtD);
            this.gbTitle.Controls.Add(this.label11);
            this.gbTitle.Controls.Add(this.edtC);
            this.gbTitle.Controls.Add(this.label10);
            this.gbTitle.Controls.Add(this.edtB);
            this.gbTitle.Controls.Add(this.label9);
            this.gbTitle.Controls.Add(this.edtA);
            this.gbTitle.Controls.Add(this.label8);
            this.gbTitle.Controls.Add(this.edtQuestion);
            this.gbTitle.Controls.Add(this.edtNo);
            this.gbTitle.Controls.Add(this.label5);
            this.gbTitle.Controls.Add(this.cbTitle);
            this.gbTitle.Controls.Add(this.btSave);
            this.gbTitle.Controls.Add(this.btRemove);
            this.gbTitle.Controls.Add(this.btEdit);
            this.gbTitle.Controls.Add(this.btAdd);
            this.gbTitle.Controls.Add(this.label2);
            this.gbTitle.Controls.Add(this.label1);
            this.gbTitle.Location = new System.Drawing.Point(31, 22);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(829, 162);
            this.gbTitle.TabIndex = 2;
            this.gbTitle.TabStop = false;
            this.gbTitle.Text = "Thông tin mã đề";
            // 
            // cbAnswer
            // 
            this.cbAnswer.FormattingEnabled = true;
            this.cbAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbAnswer.Location = new System.Drawing.Point(352, 88);
            this.cbAnswer.Name = "cbAnswer";
            this.cbAnswer.Size = new System.Drawing.Size(74, 21);
            this.cbAnswer.TabIndex = 27;
            this.cbAnswer.Text = "A";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.cbStatus.Location = new System.Drawing.Point(530, 85);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(212, 21);
            this.cbStatus.TabIndex = 26;
            this.cbStatus.Text = "Enable";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(310, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Trả lời";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(480, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Status";
            // 
            // edtD
            // 
            this.edtD.Location = new System.Drawing.Point(86, 136);
            this.edtD.Name = "edtD";
            this.edtD.Size = new System.Drawing.Size(212, 20);
            this.edtD.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "D";
            // 
            // edtC
            // 
            this.edtC.Location = new System.Drawing.Point(86, 111);
            this.edtC.Name = "edtC";
            this.edtC.Size = new System.Drawing.Size(212, 20);
            this.edtC.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "C";
            // 
            // edtB
            // 
            this.edtB.Location = new System.Drawing.Point(86, 85);
            this.edtB.Name = "edtB";
            this.edtB.Size = new System.Drawing.Size(212, 20);
            this.edtB.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "B";
            // 
            // edtA
            // 
            this.edtA.Location = new System.Drawing.Point(86, 59);
            this.edtA.Name = "edtA";
            this.edtA.Size = new System.Drawing.Size(212, 20);
            this.edtA.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "A";
            // 
            // edtQuestion
            // 
            this.edtQuestion.Location = new System.Drawing.Point(86, 22);
            this.edtQuestion.Name = "edtQuestion";
            this.edtQuestion.Size = new System.Drawing.Size(212, 20);
            this.edtQuestion.TabIndex = 13;
            // 
            // edtNo
            // 
            this.edtNo.Location = new System.Drawing.Point(530, 56);
            this.edtNo.Name = "edtNo";
            this.edtNo.Size = new System.Drawing.Size(212, 20);
            this.edtNo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã đề";
            // 
            // cbTitle
            // 
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(530, 19);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(212, 21);
            this.cbTitle.TabIndex = 10;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(505, 123);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(748, 123);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Xóa";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(667, 123);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(586, 123);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Câu hỏi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // frmNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 553);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.gbTitle);
            this.Name = "frmNewQuestion";
            this.Text = "NewQuestion";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuestion)).EndInit();
            this.gbTitle.ResumeLayout(false);
            this.gbTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox edtQuestionSearch;
        private System.Windows.Forms.TextBox edtNoSearch;
        private System.Windows.Forms.ComboBox cbTitleSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.DataGridView gvQuestion;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.TextBox edtQuestion;
        private System.Windows.Forms.TextBox edtNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStatusSearch;
        private System.Windows.Forms.TextBox edtD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edtC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbAnswer;
        private System.Windows.Forms.DataGridView dataGridView1;


    }
}
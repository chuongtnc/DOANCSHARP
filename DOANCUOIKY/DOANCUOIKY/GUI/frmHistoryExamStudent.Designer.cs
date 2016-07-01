namespace DOANCUOIKY.GUI
{
    partial class frmHistoryExamStudent
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
            this.gvListExam = new System.Windows.Forms.DataGridView();
            this.gvListQuestion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvListExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListExam
            // 
            this.gvListExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListExam.Location = new System.Drawing.Point(12, 12);
            this.gvListExam.Name = "gvListExam";
            this.gvListExam.Size = new System.Drawing.Size(240, 431);
            this.gvListExam.TabIndex = 0;
            this.gvListExam.Click += new System.EventHandler(this.gvListExam_Click);
            // 
            // gvListQuestion
            // 
            this.gvListQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListQuestion.Location = new System.Drawing.Point(361, 12);
            this.gvListQuestion.Name = "gvListQuestion";
            this.gvListQuestion.Size = new System.Drawing.Size(240, 431);
            this.gvListQuestion.TabIndex = 1;
            // 
            // frmHistoryExamStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 455);
            this.Controls.Add(this.gvListQuestion);
            this.Controls.Add(this.gvListExam);
            this.Name = "frmHistoryExamStudent";
            this.Text = "HistoryExamStudent";
            ((System.ComponentModel.ISupportInitialize)(this.gvListExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListExam;
        private System.Windows.Forms.DataGridView gvListQuestion;
    }
}
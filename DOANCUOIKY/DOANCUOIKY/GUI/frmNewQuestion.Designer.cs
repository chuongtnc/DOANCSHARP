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
            this.gbHeaderQuestion = new System.Windows.Forms.GroupBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.gbHeaderQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHeaderQuestion
            // 
            this.gbHeaderQuestion.Controls.Add(this.tbNo);
            this.gbHeaderQuestion.Controls.Add(this.lbNo);
            this.gbHeaderQuestion.Location = new System.Drawing.Point(12, 12);
            this.gbHeaderQuestion.Name = "gbHeaderQuestion";
            this.gbHeaderQuestion.Size = new System.Drawing.Size(801, 160);
            this.gbHeaderQuestion.TabIndex = 0;
            this.gbHeaderQuestion.TabStop = false;
            this.gbHeaderQuestion.Text = "Thông tin Mã đề";
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Location = new System.Drawing.Point(20, 31);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(39, 13);
            this.lbNo.TabIndex = 0;
            this.lbNo.Text = "Mã Đề";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(65, 28);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(100, 20);
            this.tbNo.TabIndex = 1;
            // 
            // frmNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 459);
            this.Controls.Add(this.gbHeaderQuestion);
            this.Name = "frmNewQuestion";
            this.Text = "NewQuestion";
            this.gbHeaderQuestion.ResumeLayout(false);
            this.gbHeaderQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeaderQuestion;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label lbNo;

    }
}
namespace DOANCUOIKY.GUI
{
    partial class frmCategory
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.edtNameSearch = new DevExpress.XtraEditors.TextEdit();
            this.edtNoSearch = new DevExpress.XtraEditors.TextEdit();
            this.gvCategory = new System.Windows.Forms.DataGridView();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtName = new DevExpress.XtraEditors.TextEdit();
            this.edtNo = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtNameSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNoSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btFind);
            this.groupBox1.Controls.Add(this.edtNameSearch);
            this.groupBox1.Controls.Add(this.edtNoSearch);
            this.groupBox1.Controls.Add(this.gvCategory);
            this.groupBox1.Location = new System.Drawing.Point(14, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 341);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm Mã đề";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "No";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(748, 32);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 3;
            this.btFind.Text = "Tìm kiếm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // edtNameSearch
            // 
            this.edtNameSearch.Location = new System.Drawing.Point(327, 34);
            this.edtNameSearch.Name = "edtNameSearch";
            this.edtNameSearch.Size = new System.Drawing.Size(100, 20);
            this.edtNameSearch.TabIndex = 2;
            // 
            // edtNoSearch
            // 
            this.edtNoSearch.Location = new System.Drawing.Point(50, 34);
            this.edtNoSearch.Name = "edtNoSearch";
            this.edtNoSearch.Size = new System.Drawing.Size(212, 20);
            this.edtNoSearch.TabIndex = 1;
            // 
            // gvCategory
            // 
            this.gvCategory.AllowUserToAddRows = false;
            this.gvCategory.AllowUserToDeleteRows = false;
            this.gvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCategory.Location = new System.Drawing.Point(6, 61);
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.ReadOnly = true;
            this.gvCategory.Size = new System.Drawing.Size(817, 274);
            this.gvCategory.TabIndex = 0;
            this.gvCategory.Click += new System.EventHandler(this.gvCategory_Click);
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.btSave);
            this.gbCategory.Controls.Add(this.btRemove);
            this.gbCategory.Controls.Add(this.btEdit);
            this.gbCategory.Controls.Add(this.btAdd);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Controls.Add(this.edtName);
            this.gbCategory.Controls.Add(this.edtNo);
            this.gbCategory.Location = new System.Drawing.Point(14, 25);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(829, 162);
            this.gbCategory.TabIndex = 2;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Thông tin loại";
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
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(97, 67);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(212, 20);
            this.edtName.TabIndex = 1;
            // 
            // edtNo
            // 
            this.edtNo.Location = new System.Drawing.Point(97, 32);
            this.edtNo.Name = "edtNo";
            this.edtNo.Size = new System.Drawing.Size(212, 20);
            this.edtNo.TabIndex = 0;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCategory);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtNameSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNoSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btFind;
        private DevExpress.XtraEditors.TextEdit edtNameSearch;
        private DevExpress.XtraEditors.TextEdit edtNoSearch;
        private System.Windows.Forms.DataGridView gvCategory;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit edtName;
        private DevExpress.XtraEditors.TextEdit edtNo;

    }
}
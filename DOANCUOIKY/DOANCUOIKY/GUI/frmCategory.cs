using DOANCUOIKY.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DOANCUOIKY.GUI
{
    public partial class frmCategory : Form
    {
        CategoryBLL categoryBLL = null;
        DataGridViewRow gvRow = null;
        public frmCategory()
        {
            InitializeComponent();


            //Khai báo tầng title business
            categoryBLL = new CategoryBLL();


            //Mặc định chức năng tạo mới bật trước
            openFunctionAdd();

            //Load dữ liệu mã đề
            LoadDataCategory();
        }

        //Thêm mới mã đề
        private void btSave_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính hợp lệ
            if (ValidateInput())
            {
                Boolean check = categoryBLL.AddCategory(edtNo.Text, edtName.Text);
                if (check == true)
                {
                    MessageBox.Show("Thêm thành công !!!");
                    LoadDataCategory();
                }
                else
                {
                    MessageBox.Show("Loại mã đề bị trùng !!!");
                }
            }

            else
            {
                MessageBox.Show("Không được để trống !!!");
            }
        }

        //Chuyển sang chức năng thêm mới
        private void btAdd_Click(object sender, EventArgs e)
        {
            openFunctionAdd();
        }

        //Chỉnh sửa mã đề
        private void btEdit_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính hợp lệ
            if (ValidateInput())
            {
                Boolean check = categoryBLL.UpdateCategory(gvRow.Cells[0].Value.ToString(), edtNo.Text, edtName.Text);
                if (check == true)
                {
                    MessageBox.Show("Chỉnh sửa thành công !!!");
                    LoadDataCategory();
                }
                else
                {
                    MessageBox.Show("Mã đề bị trùng !!!");
                }
            }

            else
            {
                MessageBox.Show("Không được để trống !!!");
            }
        }

        //Xóa Mã đề
        private void btRemove_Click(object sender, EventArgs e)
        {
            Boolean check = categoryBLL.DeteleCategory(gvRow.Cells[0].Value.ToString());
            if (check)
            {
                MessageBox.Show("Xóa thành công");
                LoadDataCategory();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }


        //Tìm kiếm mã đề
        private void btFind_Click(object sender, EventArgs e)
        {
            gvCategory.DataSource = categoryBLL.LoadDataCategoryByParameters(edtNoSearch.Text, edtNameSearch.Text);
        }

        //Click row truyền dữ liệu vào thông tin mã đề đề chỉnh sửa xóa
        private void gvCategory_Click(object sender, EventArgs e)
        {
            if (gvCategory.CurrentRow != null)
            {
                //Khi row trong griview được click thì sẽ mở chức năng edit
                openFunctionEdit();

                gvRow = gvCategory.CurrentRow;
                edtNo.Text = gvRow.Cells[1].Value.ToString();
                edtName.Text = gvRow.Cells[2].Value.ToString();

            }
        }


        //2 Hàm này dùng để tắt bật các chức năng
        private void openFunctionAdd()
        {
            edtNo.Text = "";
            edtName.Text = "";
            btSave.Enabled = true;
            btEdit.Enabled = false;
            btRemove.Enabled = false;
            btAdd.Enabled = false;
            edtNo.Enabled = true;
        }

        private void openFunctionEdit()
        {
            btSave.Enabled = false;
            btEdit.Enabled = true;
            btRemove.Enabled = true;
            btAdd.Enabled = true;
            edtNo.Enabled = false;
        }

        //-------------------------------------------------

        //Hàm load dữ liệu
        private void LoadDataCategory()
        {
            gvCategory.DataSource = categoryBLL.LoadDatacategory();
        }


        //Hàm kiểm tra thông tin nhập vào
        private Boolean ValidateInput()
        {
            if (edtNo.Text != "" && edtName.Text != "")
            {
                return true;
            }
            return false;
        }




    }
}

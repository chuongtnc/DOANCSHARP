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
    public partial class frmNewQuestion : Form
    {
        TitleBLL titleBLL = null;
        QuestionBLL questionBLL = null;
        DataGridViewRow gvRow = null;

        public frmNewQuestion()
        {
            InitializeComponent();

            //Khai báo tầng title business
            titleBLL = new TitleBLL();

            //Khai báo tầng quesiton business
            questionBLL = new QuestionBLL();

            //Mặc định chức năng tạo mới bật trước
            openFunctionAdd();

            //Load dữ liệu mã đề
            LoadDataTitle();

            //Load dữ liệu combobox
            LoadDataComboBox();
        }

        //Thêm mới mã đề
        private void btSave_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính hợp lệ
            if (ValidateInput())
            {
                Boolean check = questionBLL.AddQuestion((int)cbTitle.SelectedValue, edtNo.Text, edtQuestion.Text, edtA.Text, edtB.Text, edtC.Text, edtD.Text, cbAnswer.SelectedIndex.ToString(), cbStatus.SelectedIndex.ToString());
                if (check == true)
                {
                    MessageBox.Show("Thêm thành công !!!");
                    openFunctionAdd();
                    LoadDataTitle();
                }
                else
                {
                    MessageBox.Show("Mã Câu hỏi bị trùng !!!");
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
                Boolean check = questionBLL.UpdateQuestion((int)gvRow.Cells[0].Value, (int)cbTitle.SelectedValue, edtQuestion.Text, edtA.Text, edtB.Text, edtC.Text, edtD.Text, cbAnswer.SelectedIndex.ToString(), cbStatus.SelectedIndex.ToString());
                if (check == true)
                {
                    MessageBox.Show("Chỉnh sửa thành công !!!");
                    LoadDataTitle();
                }
                else
                {
                    MessageBox.Show("Mã câu hỏi bị trùng !!!");
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
            Boolean check = questionBLL.DeteleQuestion(gvRow.Cells[0].Value.ToString());
            if (check)
            {
                MessageBox.Show("Xóa thành công");
                LoadDataTitle();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        //Tìm kiếm mã đề
        private void btFind_Click(object sender, EventArgs e)
        {
            gvQuestion.DataSource = questionBLL.LoadDataQuestionByParameters((int)cbTitleSearch.SelectedValue, edtNoSearch.Text, edtQuestionSearch.Text, cbStatusSearch.SelectedIndex.ToString());
        }

        //Click row truyền dữ liệu vào thông tin mã đề đề chỉnh sửa xóa
        private void gvQuestion_Click(object sender, EventArgs e)
        {
            if (gvQuestion.CurrentRow != null)
            {
                //Khi row trong griview được click thì sẽ mở chức năng edit
                openFunctionEdit();

                gvRow = gvQuestion.CurrentRow;
                edtNo.Text = gvRow.Cells[2].Value.ToString();
                edtQuestion.Text = gvRow.Cells[3].Value.ToString();
                edtA.Text = gvRow.Cells[4].Value.ToString();
                edtB.Text = gvRow.Cells[5].Value.ToString();
                edtC.Text = gvRow.Cells[6].Value.ToString();
                edtD.Text = gvRow.Cells[7].Value.ToString();
                cbAnswer.SelectedIndex = Int32.Parse(gvRow.Cells[8].Value.ToString());
                cbStatus.SelectedIndex = Int32.Parse(gvRow.Cells[9].Value.ToString());

            }
        }

        //2 Hàm này dùng để tắt bật các chức năng
        private void openFunctionAdd()
        {
            edtNo.Text = "";
            edtQuestion.Text = "";
            edtA.Text = "";
            edtB.Text = "";
            edtC.Text = "";
            edtD.Text = "";
            cbAnswer.Text = "";
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

        //Hàm load dữ liệu
        private void LoadDataTitle()
        {
            gvQuestion.DataSource = questionBLL.LoadDataQuestion();
        }


        //Hàm kiểm tra thông tin nhập vào
        private Boolean ValidateInput()
        {
            if (edtNo.Text != "" && edtQuestion.Text != "")
            {
                return true;
            }
            return false;
        }

        //Hàm lấy dữ liệu vào combobox category
        private void LoadDataComboBox()
        {

            DataTable dt = titleBLL.LoadDataTitle();
            DataTable dtSearch = titleBLL.LoadDataTitle();


            cbTitle.DataSource = dt;
            cbTitle.ValueMember = "ID";
            cbTitle.DisplayMember = "Name";

            cbTitleSearch.DataSource = dtSearch;
            cbTitleSearch.ValueMember = "ID";
            cbTitleSearch.DisplayMember = "Name";

        }


    }
}

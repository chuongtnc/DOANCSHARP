using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOANCUOIKY.BLL;
using DOANCUOIKY.WCF;
using DOANCUOIKY.DTO;
using System.Collections;

namespace DOANCUOIKY.GUI
{
    public partial class frmExamTest : Form
    {
        //
        DateTime examTime;
        int totalExamTime;
        //---------------

        TitleBLL titleBLL = new TitleBLL();
        QuestionBLL questionBLL = new QuestionBLL();
        Service1Client service = new Service1Client();
        //--------------

        string[,] ar = new string[500, 10];
       

        int vitri = 0;
        int count = 0;
        int diem = 0;
        int socaudung = 0;

        public frmExamTest()
        {
            InitializeComponent();
            RadioButton(false);
            btnEndExam.Enabled = false;
        }

        private int kiemtratraloi()
        {
            if (rbA.Checked == true || rbB.Checked == true || rbC.Checked == true || rbD.Checked == true)
                return 1;
            return 0;
        }

        private void RadioButton(bool rb)
        {
            rbA.Enabled = rb;
            rbB.Enabled = rb;
            rbC.Enabled = rb;
            rbD.Enabled = rb;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "") MessageBox.Show("ban chua chon de thi");
            else
            {
                loaddethi();
                napcauhoi(vitri);
                danhsachcauhoi();
            }
        }

        private void loaddethi()
        {
            listView1.Hide();
            Bocauhoi q = new Bocauhoi();
            q.titleId = Int32.Parse(lblId.Text);
            DataTable dt = service.loadQuestion1(q);
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                ar[i, 0] = dr["ID"].ToString();
                ar[i, 1] = dr["QUESTION"].ToString();
                ar[i, 2] = dr["A"].ToString();
                ar[i, 3] = dr["B"].ToString();
                ar[i, 4] = dr["C"].ToString();
                ar[i, 5] = dr["D"].ToString();
                ar[i, 6] = dr["ANSWER"].ToString();
                ar[i, 7] = "";
                ar[i, 8] = "Cau  " + (i + 1);
                i++;
                count++;
            }
            totalExamTime = 1 * count;
            examTime = new DateTime(2000, 1, 1, 0, totalExamTime / 60, totalExamTime % 60, 0);
            lblExamTime.Text = examTime.Minute.ToString() + " : " + examTime.Second.ToString();
            DialogResult r = MessageBox.Show("Thời gian làm bài bắt đầu đếm ngược.Điểm tối đa là 10 điểm.\n\rĐề thi có " + count + " câu hỏi. thoi gian lam bai " + totalExamTime / 60 + " phut\n\r Chúc bạn thi tốt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                if (r == DialogResult.OK)
                {
                    timer.Start();
                    btnExit.Enabled = false;
                    btnExam.Enabled = false;
                    btnEndExam.Enabled = true;
                    RadioButton(true);
                }
            }
        }

        public void napcauhoi(int vitriDS)
        {
            lblCauThu.Text = "Câu hỏi:" + (vitriDS + 1);
            lblCauhoi.Text = ar[vitriDS, 1].ToString();
            lblCauA.Text = ar[vitriDS, 2].ToString();
            lblCauB.Text = ar[vitriDS, 3].ToString();
            lblCauC.Text = ar[vitriDS, 4].ToString();
            lblCauD.Text = ar[vitriDS, 5].ToString();
        }

        //thoi gian thi
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan dt = new TimeSpan(0, 0, 1);
            examTime = examTime.Subtract(dt);
            lblExamTime.Text = examTime.Minute.ToString() + " : " + examTime.Second.ToString();
            if (examTime.Minute == 0 && examTime.Second == 0)
            {
                timer.Enabled = false;
                DialogResult r = MessageBox.Show("Thời gian làm bài đã hết.Mời bạn xem kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                {
                    if (r == DialogResult.OK)
                    {
                        chamdiem();
                        luudiem();
                        MessageBox.Show(diem.ToString());
                    }
                }
            }
        }

        private void chamdiem()
        {
            for (int i = 0; i < count; i++ )
            {
                if(ar[i,6] == ar[i,7])  socaudung++;
            }
            diem = socaudung*10/count;
        }

        private void luudiem()
        {
            examheader eh = new examheader();
            eh.ehId = Int32.Parse(UserInfoHolder.userInfo[0]);
            eh.ehTquestion = count;
            eh.ehTTanswer = socaudung;
            eh.ehScore = diem;

            string result = service.saveExam(eh);
        }

        private void btnEndExam_Click(object sender, EventArgs e)
        {
            lblId.Text = "";
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                chamdiem();
                luudiem();
                MessageBox.Show(diem.ToString());
                timer.Stop();
                listView1.Show();
                btnExit.Enabled = true;
                btnExam.Enabled = true;
                btnEndExam.Enabled = false;
                RadioButton(false);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                lblId.Text = lvi.SubItems[0].Text;
                lblMade.Text = lvi.SubItems[1].Text;
                lblDethi.Text = lvi.SubItems[2].Text;
            }
        }

        //load du lieu len listview
        private void frmExamTest_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("id");
            listView1.Columns.Add("ma de");
            listView1.Columns.Add("de");
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            var dt = titleBLL.LoadDataTitle();
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                listView1.Items.Add(dr["ID"].ToString());
                listView1.Items[i].SubItems.Add(dr["No"].ToString());
                listView1.Items[i].SubItems.Add(dr["Name"].ToString());
                i++;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Capnhap_Dapan();
            vitri++;
            if (vitri >= count)
            {
                vitri = 0;

            }
            napcauhoi(vitri);
            Danh_DapAn(vitri);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Capnhap_Dapan();
            vitri--;
            if (vitri >= 0)
            {
                Danh_DapAn(vitri);
                napcauhoi(vitri);
            }
            else
            {
                vitri = count - 1;
                Danh_DapAn(vitri);
                napcauhoi(vitri);
            }
        }

        private void Capnhap_Dapan()
        {
            if (rbA.Checked == true) ar[vitri, 7] = "0";
            if (rbB.Checked == true) ar[vitri, 7] = "1";
            if (rbC.Checked == true) ar[vitri, 7] = "2";
            if (rbD.Checked == true) ar[vitri, 7] = "3";
        }

        private void Danh_DapAn(int vitrids)
        {
            if (ar[vitrids, 7] == "")
            {
                rbA.Checked = false;
                rbB.Checked = false;
                rbC.Checked = false;
                rbD.Checked = false;
            }
            else
            {
                if (ar[vitrids, 7] == "0") rbA.Checked = true;
                if (ar[vitrids, 7] == "1") rbB.Checked = true;
                if (ar[vitrids, 7] == "2") rbC.Checked = true;
                if (ar[vitrids, 7] == "3") rbD.Checked = true;
            }
        }

        private void danhsachcauhoi()
        {
            listView2.Items.Clear();
            listView2.View = View.Details;
            listView2.Columns.Add("cau so");
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            for (int i = 0; i <= count; i++)
            {
                listView2.Items.Add(ar[i, 8]);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView2.SelectedItems)
            {
                napcauhoi(lvi.Index);
                Danh_DapAn(lvi.Index);
                vitri = lvi.Index;
            }
        }
    }
}

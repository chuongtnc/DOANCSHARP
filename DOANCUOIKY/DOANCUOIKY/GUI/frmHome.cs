
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOANCUOIKY.GUI;

namespace DOANCUOIKY.GUI
{
    public partial class frmHome : Form
    {

        private string[] userInfo;

        public frmHome(string[] userInfo)
        {
            InitializeComponent();

            //Kiểm tra user đã đăng nhập chưa
            if (userInfo.Count() == 0)
            {
                MessageBox.Show("Chưa đăng nhập");
                Application.Exit();
            }
                

            //Gán biến thông tin user được truyền qua từ bên login
            this.userInfo = userInfo;

            //Hiện thông tin user lên màn hình home
            lbMSSV1.Text = userInfo[2];
            lbNAME1.Text = userInfo[3];
            lbPOSITION1.Text = userInfo[4];

            //Disable những chức năng thuộc không thuộc Admin
            if(userInfo[4] == "ADMIN")
            {
                menuSTUDENT.Enabled = false;
            }
            else
            {
                menuTEACHER.Enabled = false;
            }

        }

        private void NEW_QUESTION_Click(object sender, EventArgs e)
        {
            frmNewQuestion frmNewQuestion = new frmNewQuestion();
            frmNewQuestion.ShowDialog();
        }

        private void FIND_QUESTION_Click(object sender, EventArgs e)
        {
            frmFindQuestion frmfindQuestion = new frmFindQuestion();
            frmfindQuestion.ShowDialog();
        }

        private void HICTORY_EXAM_Click(object sender, EventArgs e)
        {
            frmHictoryExam frmHictoryExam = new frmHictoryExam();
            frmHictoryExam.ShowDialog();
        }

        private void menuTITLEQUESTION_Click(object sender, EventArgs e)
        {

        }


    }
}

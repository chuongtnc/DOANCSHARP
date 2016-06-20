
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOANCUOIKY.GUI;
using DOANCUOIKY.DTO;

namespace DOANCUOIKY.GUI
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();

            //Kiểm tra user đã đăng nhập chưa
            if (UserInfoHolder.userInfo.Count() == 0)
            {
                MessageBox.Show("Chưa đăng nhập");
                Application.Exit();
            }


            //Hiện thông tin user lên màn hình home
            lbMSSV1.Text = UserInfoHolder.userInfo[2];
            lbNAME1.Text = UserInfoHolder.userInfo[3];
            lbPOSITION1.Text = UserInfoHolder.userInfo[4];

            //Disable những chức năng thuộc không thuộc Admin
            if (UserInfoHolder.userInfo[4] == "ADMIN")
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

        private void HICTORY_EXAM_Click(object sender, EventArgs e)
        {
            frmHictoryExam frmHictoryExam = new frmHictoryExam();
            frmHictoryExam.ShowDialog();
        }

        private void menuTITLE_QUESTION_Click(object sender, EventArgs e)
        {
            frmNewTitleQuestion frmNewTitleQuestion = new frmNewTitleQuestion();
            frmNewTitleQuestion.ShowDialog();
        }

        private void menuCATEGORY_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.ShowDialog();
        }


    }
}

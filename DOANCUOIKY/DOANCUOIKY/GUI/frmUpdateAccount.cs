using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOANCUOIKY.WCF;
using DOANCUOIKY.DTO;

namespace DOANCUOIKY.GUI
{
    public partial class frmUpdateAccount : Form
    {
        public frmUpdateAccount()
        {
            InitializeComponent();
            txtUserName.Text = UserInfoHolder.userInfo[1];
            txtPassword.Text = UserInfoHolder.userInfo[2];
            txtMssv.Text = UserInfoHolder.userInfo[3];
            txtHovaTen.Text = UserInfoHolder.userInfo[4];
            txtBox(true);
            txtUserName.ReadOnly = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnEdit.Show();
            txtBox(true);
            Service1Client service = new Service1Client();
            CreateAccount uc = new CreateAccount();
            uc.UserName = txtUserName.Text;
            uc.Password = txtPassword.Text;
            uc.Mssv = Int32.Parse(txtMssv.Text);
            uc.HovaTen = txtHovaTen.Text;
            string result = service.updateAccount(uc);
            MessageBox.Show(result);
        }

        private void txtBox(bool t)
        {
            txtHovaTen.ReadOnly = t;
            txtMssv.ReadOnly = t;
            txtPassword.ReadOnly = t;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Hide();
            txtBox(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}

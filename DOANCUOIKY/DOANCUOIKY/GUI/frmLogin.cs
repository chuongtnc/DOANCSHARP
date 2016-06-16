using DOANCUOIKY.BLL;
using DOANCUOIKY.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DOANCUOIKY
{
    public partial class Login : Form
    {
        LoginBLL loginBLL = null;
        public Login()
        {
            InitializeComponent();

            //Khai báo tầng login business
            loginBLL = new LoginBLL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu user thông qua validate username,password
            string[] userInfo = loginBLL.LoginValidate(edtUsername.Text,edtPassword.Text);

            //Kiểm tra hợp lệ
            if(userInfo.Count() != 0)
            {
                //Khai báo form home
                frmHome home = new frmHome(userInfo);

                //Ẩn form hiện tại (Login)
                this.Hide();

                //Hiện form home
                home.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Không đúng tài khoản hoặc mật khẩu");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Kết thúc chương trinh
            Application.Exit();
        }

    }
}

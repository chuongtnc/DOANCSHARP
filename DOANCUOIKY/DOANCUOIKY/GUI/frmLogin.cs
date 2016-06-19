using DOANCUOIKY.BLL;
using DOANCUOIKY.DTO;
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
    public partial class frmLogin : Form
    {
        LoginBLL loginBLL = null;
        public frmLogin()
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
                //Truyền vào biến static userInfo để có thể sử dụng toàn ứng dụng
                UserInfoHolder.userInfo = userInfo;

                //Khai báo form home
                frmHome home = new frmHome();

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

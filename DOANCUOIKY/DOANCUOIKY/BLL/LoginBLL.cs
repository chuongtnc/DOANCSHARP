using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOANCUOIKY.BLL
{
    public class LoginBLL
    {
        WCF.Service1Client wcf = null;

        public LoginBLL()
        {
            wcf = new WCF.Service1Client();
        }

        public string[] LoginValidate(string username, string password)
        {
            WCF.UserInfoToValidate userInfoToValidate = new WCF.UserInfoToValidate();
            userInfoToValidate.Username = username;
            userInfoToValidate.Password = password;

            return wcf.LoginUserDetails(userInfoToValidate);
        }
    }
}

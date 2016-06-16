using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection con = null;
        public Service1()
        {
            con = new SqlConnection(@"Data Source=DAOBADAT-PC\SQLEXPRESS;Initial Catalog=DOANCUOIKY;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        }

        public List<string> LoginUserDetails(UserInfoToValidate userInfoToValidate)
        {
            List<string> usr = new List<string>();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,USERNAME,NO,NAME,POSITION FROM ACCOUNT WHERE USERNAME=@Username AND PASSWORD=@Password", con);
            cmd.Parameters.AddWithValue("@Username", userInfoToValidate.Username);
            cmd.Parameters.AddWithValue("@Password", userInfoToValidate.Password);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                usr.Add(dr[0].ToString());
                usr.Add(dr[1].ToString());
                usr.Add(dr[2].ToString());
                usr.Add(dr[3].ToString());
                usr.Add(dr[4].ToString());
            }
            con.Close();
            return usr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
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
        SqlDataAdapter da = null;
        SqlCommand cmd;
        public Service1()
        {
            con = new SqlConnection(@"Data Source=daobadat-PC\SQLEXPRESS;Initial Catalog=DOANCUOIKY;Integrated Security=True");
            //comm = con.CreateCommand();
        }


        //Các Hàm giành cho Login
        public List<string> LoginUserDetails(UserInfoToValidate userInfoToValidate)
        {
            List<string> usr = new List<string>();
            con.Open();
            cmd = new SqlCommand("SELECT ID,USERNAME,NO,NAME,POSITION FROM ACCOUNT WHERE USERNAME=@Username AND PASSWORD=@Password", con);
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
        //--------------------


        //Các hàm dành cho mã đề
        public Boolean ValidateIfExistNo(string titleNo)
        {
            con.Open();
            cmd = new SqlCommand("SELECT NO FROM TITLE WHERE NO=@titleNo", con);
            cmd.Parameters.AddWithValue("@titleNo", titleNo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                con.Close();
                return true;
            }

            con.Close();
            return false;
        }

        public Boolean AddTitle(string titleNo, string titleName, int titleCategory)
        {
            if (!ValidateIfExistNo(titleNo))
            {
                con.Open();

                cmd = new SqlCommand("INSERT INTO TITLE (NO,NAME,CATEGORY_ID) VALUES(@titleNo, @titleName, @titleCategory)", con);
                cmd.Parameters.AddWithValue("@titleNo", titleNo);
                cmd.Parameters.AddWithValue("@titleName", titleName);
                cmd.Parameters.AddWithValue("@titleCategory", titleCategory);

                cmd.ExecuteNonQuery();

                con.Close();
                return true;
            }

            con.Close();
            return false;

        }

        public DataTable LoadDataTitle()
        {

            da = new SqlDataAdapter("SELECT * FROM TITLE", con);
            var dt = new DataTable("DataTitle");
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadDataTitleByParemeters(string titleNo, string titleName, int titleCategory)
        {
            con.Open();

            cmd = new SqlCommand("SELECT * FROM TITLE WHERE NO LIKE '%'+ @titleNo +'%' AND NAME LIKE '%'+ @titleName +'%' AND CATEGORY_ID = @titleCategory", con);
            cmd.Parameters.AddWithValue("@titleNo", titleNo);
            cmd.Parameters.AddWithValue("@titleName", titleName);
            cmd.Parameters.AddWithValue("@titleCategory", titleCategory);

            da = new SqlDataAdapter(cmd);
            var dt = new DataTable("DataTitle");
            da.Fill(dt);

            con.Close();
            return dt;
        }

        public Boolean UpdateTitle(string titleID, string titleNo, string titleName, int titleCategory)
        {
                con.Open();

                cmd = new SqlCommand("UPDATE TITLE SET NAME = @titleName, CATEGORY_ID = @titleCategory WHERE ID = @titleID", con);
                cmd.Parameters.AddWithValue("@titleName", titleName);
                cmd.Parameters.AddWithValue("@titleID", titleID);
                cmd.Parameters.AddWithValue("@titleCategory", titleCategory);

                cmd.ExecuteNonQuery();

                con.Close();
                return true;

        }


        public Boolean DeleteTitle(string titleID)
        {
            con.Open();

            cmd = new SqlCommand("DELETE FROM TITLE WHERE ID = @titleID", con);
            cmd.Parameters.AddWithValue("@titleID", titleID);

            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        //----------------------



        //Các hàm dành cho Category
        public Boolean ValidateIfExistCategoryNo(string categoryNo)
        {
            con.Open();
            cmd = new SqlCommand("SELECT NO FROM CATEGORY WHERE NO=@categoryNo", con);
            cmd.Parameters.AddWithValue("@categoryNo", categoryNo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                con.Close();
                return true;
            }

            con.Close();
            return false;
        }

        public Boolean AddCategory(string categoryNo, string categoryName)
        {
            if (!ValidateIfExistCategoryNo(categoryNo))
            {
                con.Open();

                cmd = new SqlCommand("INSERT INTO CATEGORY (NO,NAME) VALUES(@categoryNo, @categoryName)", con);
                cmd.Parameters.AddWithValue("@categoryNo", categoryNo);
                cmd.Parameters.AddWithValue("@categoryName", categoryName);

                cmd.ExecuteNonQuery();

                con.Close();
                return true;
            }

            con.Close();
            return false;

        }

        public DataTable LoadDataCategory()
        {

            da = new SqlDataAdapter("SELECT * FROM CATEGORY", con);
            var dt = new DataTable("DataCategory");
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadDataCategoryByParemeters(string categoryNo, string categoryName)
        {
            con.Open();

            cmd = new SqlCommand("SELECT * FROM category WHERE NO LIKE '%'+ @categoryNo +'%' AND NAME LIKE '%'+ @categoryName +'%'", con);
            cmd.Parameters.AddWithValue("@categoryNo", categoryNo);
            cmd.Parameters.AddWithValue("@categoryName", categoryName);

            da = new SqlDataAdapter(cmd);
            var dt = new DataTable("DataCategory");
            da.Fill(dt);

            con.Close();
            return dt;
        }

        public Boolean UpdateCategory(string categoryID, string categoryNo, string categoryName)
        {

                con.Open();

                cmd = new SqlCommand("UPDATE CATEGORY SET NAME = @categoryName WHERE ID = @categoryID", con);
                cmd.Parameters.AddWithValue("@categoryName", categoryName);
                cmd.Parameters.AddWithValue("@categoryID", categoryID);

                cmd.ExecuteNonQuery();

                con.Close();
                return true;

        }


        public Boolean DeleteCategory(string categoryID)
        {
            con.Open();

            cmd = new SqlCommand("DELETE FROM CATEGORY WHERE ID = @categoryID", con);
            cmd.Parameters.AddWithValue("@categoryID", categoryID);

            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        //----------------------

        public int InsertCreateAccount(CreateAccount c)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO ACCOUNT VALUES(@USERNAME, @PASSWORD @NO, @NAME)", con);
                //comm.CommandText = "INSERT INTO ACCOUNT VALUES(@USERNAME, @PASSWORD @NO, @NAME)";
                cmd.Parameters.AddWithValue("USERNAME", c.UserName);
                cmd.Parameters.AddWithValue("PASSWORD", c.Password);
                cmd.Parameters.AddWithValue("NO", c.Mssv);
                cmd.Parameters.AddWithValue("NAME", c.HovaTen);

                cmd.CommandType = CommandType.Text;
                con.Open();

                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(con !=null)
                {
                    con.Close();
                }
            }
        }


    }
}

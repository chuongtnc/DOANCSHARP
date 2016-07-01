﻿using System;
using System.Collections;
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
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DOANCUOIKY;Integrated Security=True");
            //comm = con.CreateCommand();
        }


        //Các Hàm giành cho Login
        public List<string> LoginUserDetails(UserInfoToValidate userInfoToValidate)
        {
            List<string> usr = new List<string>();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE USERNAME=@Username AND PASSWORD=@Password", con);
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
                usr.Add(dr[5].ToString());
                usr.Add(dr[6].ToString());
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

        public DataTable LoadDataTitleByParameters(string titleNo, string titleName, int titleCategory)
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

        public DataTable LoadDataCategoryByParameters(string categoryNo, string categoryName)
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


        //Các hàm dành cho Question
        public Boolean ValidateIfQuestionExistNo(string questionNo)
        {
            con.Open();
            cmd = new SqlCommand("SELECT NO FROM QUESTION WHERE NO=@questionNo", con);
            cmd.Parameters.AddWithValue("@questionNo", questionNo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                con.Close();
                return true;
            }

            con.Close();
            return false;
        }

        public Boolean AddQuestion(int titleID, string questionNo, string question, string A, string B, string C, string D, string answer, string status)
        {
            if (!ValidateIfQuestionExistNo(questionNo))
                {
                    con.Open();

                    cmd = new SqlCommand(@"INSERT INTO QUESTION (TITLE_ID,NO ,QUESTION,A,B,C,D,ANSWER,STATUS,DATE) 
                                          VALUES(@titleID, @questionNo, @question, @A, @B, @C ,@D, @answer, @status, GETDATE())", con);
                    cmd.Parameters.AddWithValue("@titleID", titleID);
                    cmd.Parameters.AddWithValue("@questionNo", questionNo);
                    cmd.Parameters.AddWithValue("@question", question);
                    cmd.Parameters.AddWithValue("@A", A);
                    cmd.Parameters.AddWithValue("@B", B);
                    cmd.Parameters.AddWithValue("@C", C);
                    cmd.Parameters.AddWithValue("@D", D);
                    cmd.Parameters.AddWithValue("@answer", answer);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    return true;

                }

                con.Close();
                return false;
        }

        public DataTable LoadDataQuestion()
        {

            da = new SqlDataAdapter("SELECT * FROM QUESTION",con);
            var dt = new DataTable("DataQuestion");
            da.Fill(dt);
            return dt;
        }

        public DataTable LoadDataQuestionByParameters(int titleID,string questionNo, string question, string status)
        {
            con.Open();

            cmd = new SqlCommand("SELECT * FROM QUESTION WHERE TITLE_ID LIKE '%'+ @titleID +'%' AND NO LIKE '%'+ @questionNo +'%' AND QUESTION LIKE '%'+ @question +'%'  AND STATUS LIKE '%'+ @status +'%'", con);
            cmd.Parameters.AddWithValue("@titleID", titleID.ToString());
            cmd.Parameters.AddWithValue("@questionNo", questionNo);
            cmd.Parameters.AddWithValue("@question", question);
            cmd.Parameters.AddWithValue("@status", status);

            da = new SqlDataAdapter(cmd);
            var dt = new DataTable("DataQuestion");
            da.Fill(dt);

            con.Close();
            return dt;
        }

        public Boolean UpdateQuestion(int questionID , int titleID, string question, string A, string B, string C, string D, string answer, string status)
        {

            con.Open();

            cmd = new SqlCommand(@"UPDATE QUESTION SET TITLE_ID = @titleID, QUESTION = @question, A = @A, B = @B, C = @C, D = @D, ANSWER = @answer, STATUS = @status WHERE ID = @questionID", con);
            cmd.Parameters.AddWithValue("@questionID", questionID);
            cmd.Parameters.AddWithValue("@titleID", titleID);
            cmd.Parameters.AddWithValue("@question", question);
            cmd.Parameters.AddWithValue("@A", A);
            cmd.Parameters.AddWithValue("@B", B);
            cmd.Parameters.AddWithValue("@C", C);
            cmd.Parameters.AddWithValue("@D", D);
            cmd.Parameters.AddWithValue("@answer", answer);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.ExecuteNonQuery();

            con.Close();
            return true;

        }


        public Boolean DeleteQuestion(string questionID)
        {
            con.Open();

            cmd = new SqlCommand("DELETE FROM QUESTION WHERE ID = @questionID", con);
            cmd.Parameters.AddWithValue("@questionID", questionID);

            cmd.ExecuteNonQuery();

            con.Close();
            return true;
        }
        //----------------------

        //Các hàm danh cho HistoryExam

        public DataTable LoadDataStudentByParameters(string studentNo, string studentName)
        {
            con.Open();

            cmd = new SqlCommand("SELECT ID,NO AS 'Mã số sinh viên',NAME AS 'Tên sinh viên' FROM ACCOUNT WHERE NO LIKE '%'+ @studentNo +'%' AND NAME LIKE '%'+ @studentName +'%' AND POSITION <> 'ADMIN'", con);
            cmd.Parameters.AddWithValue("@studentNo", studentNo);
            cmd.Parameters.AddWithValue("@studentName", studentName);

            da = new SqlDataAdapter(cmd);
            var dt = new DataTable("DataStudent");
            da.Fill(dt);

            con.Close();
            return dt;
        }

        public DataTable LoadDataExamByParameters(string studentID)
        {
            con.Open();

            cmd = new SqlCommand("SELECT ID,DATE AS 'Ngày thi',TOTAL_QUESTION AS 'Tổng số câu hỏi đã thi',TOTAL_TRUE_ANSWER AS 'Tổng số câu trả lời đúng',SCORE AS 'Điểm' FROM EXAM_HEADER WHERE ACCOUNT_ID = @studentID ", con);
            cmd.Parameters.AddWithValue("@studentID", studentID);

            da = new SqlDataAdapter(cmd);
            var dt = new DataTable("DataExam");
            da.Fill(dt);

            con.Close();
            return dt;
        }

        public DataTable LoadDataExamLineByParameters(string examHeaderID)
        {
            con.Open();

            cmd = new SqlCommand(@"SELECT QUESTION.QUESTION AS 'Câu hỏi',QUESTION.A,QUESTION.B,QUESTION.C,QUESTION.D,
                                    CASE QUESTION.ANSWER
                                        WHEN 0 THEN 'A'
                                        WHEN 1 THEN 'B'
                                        WHEN 2 THEN 'C'
                                        ELSE 'D' 
                                    END AS 'Đáp án đúng',
                                        CASE EXAM_LINE.ANSWER
                                        WHEN 0 THEN 'A'
                                        WHEN 1 THEN 'B'
                                        WHEN 2 THEN 'C'
                                        ELSE 'D' 
                                    END AS 'Câu trả lời của sinh viên' 
                                        FROM EXAM_LINE,QUESTION WHERE 
                                            EXAM_HEADER_ID = @examHeaderID AND EXAM_LINE.QUESTION_ID = QUESTION.ID", con);
            cmd.Parameters.AddWithValue("@examHeaderID", examHeaderID);

            da = new SqlDataAdapter(cmd);
            var dt = new DataTable("DataExam");
            da.Fill(dt);

            con.Close();
            return dt;
        }

        //----------------------------


        public string InsertCreateAccount(CreateAccount c)
        {
            string mess;
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO ACCOUNT(USERNAME,PASSWORD,NO,NAME,POSITION,ENABLE_FLAG) 
                                 VALUES(@UserName, @Password, @Mssv, @HovaTen, @Position, @Enable_flag)", con);
            
            cmd.Parameters.AddWithValue("@UserName", c.UserName);
            cmd.Parameters.AddWithValue("@Password", c.Password);
            cmd.Parameters.AddWithValue("@Mssv", c.Mssv);
            cmd.Parameters.AddWithValue("@HovaTen", c.HovaTen);
            cmd.Parameters.AddWithValue("@Position", "STUDEN");
            cmd.Parameters.AddWithValue("@Enable_flag", "S");
          
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                mess = c.UserName + " Details inserted successfully";
            }
            else
            {
                mess = c.UserName + " Details not inserted successfully";
            }
            con.Close();
            return mess;           
        }

        private bool kiemtratontai(string ten)
        {
            bool result = false;
            cmd = new SqlCommand("SELECT * FROM ACCOUNT", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (ten == dr.GetString(1))
                {
                    result = true;
                    break;
                }
            }
            con.Close();
            return result;
        }  


        public string updateAccount(CreateAccount uc)
        {
            string mess;
            con.Open();
            cmd = new SqlCommand(@"UPDATE ACCOUNT SET USERNAME=@UserName, PASSWORD=@Password, NO=@Mssv, NAME=@HovaTen WHERE USERNAME = @UserName ", con);
            cmd.Parameters.AddWithValue("@UserName", uc.UserName);
            cmd.Parameters.AddWithValue("@Password", uc.Password);
            cmd.Parameters.AddWithValue("@Mssv", uc.Mssv);
            cmd.Parameters.AddWithValue("@HovaTen", uc.HovaTen);

            int result = cmd.ExecuteNonQuery();
            if(result == 1)
            {
                mess = "cap nhap thanh cong";
            }
            else
            {
                mess = "cap nhap that bai";
            }
            con.Close();
            return mess;
        }

        public DataTable loadQuestion1(Bocauhoi q)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM QUESTION WHERE TITLE_ID=@titleid", con);
            cmd.Parameters.AddWithValue("@titleid", q.titleId);

            da = new SqlDataAdapter(cmd);
            var dt = new DataTable("DataQuestion");
            da.Fill(dt);

            con.Close();
            return dt;
        }

        public int saveExam(examheader eh)
        {
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO EXAM_HEADER(ACCOUNT_ID, TOTAL_QUESTION, TOTAL_TRUE_ANSWER, SCORE, DATE)
                                OUTPUT Inserted.ID
                                VALUES(@ehId, @ehTquestion, @ehTTanswer, @ehScore, GETDATE())", con);
            cmd.Parameters.AddWithValue("@ehId", eh.ehId);
            cmd.Parameters.AddWithValue("@ehTquestion", eh.ehTquestion);
            cmd.Parameters.AddWithValue("@ehTTanswer", eh.ehTTanswer);
            cmd.Parameters.AddWithValue("@ehScore", eh.ehScore);

            int result = (int)cmd.ExecuteScalar();
            con.Close();
            return result;
        }

        public string insertExamLine(examLine el)
        {
            string a;
            con.Open();
            cmd = new SqlCommand(@"INSERT INTO EXAM_LINE(EXAM_HEADER_ID, QUESTION_ID, ANSWER)
                                   VALUES(@elId, @elQuestionId, @elAnswer)", con);
            cmd.Parameters.AddWithValue("@elId", el.elId);
            cmd.Parameters.AddWithValue("@elQuestionId", el.elQuestionId);
            cmd.Parameters.AddWithValue("@elAnswer", el.elAnswer);

            int result = cmd.ExecuteNonQuery();
            if(result == 1)
            {
                a = "cap nhap thanh cong EXAM_LINE";
            }
            else
            {
                a = "cap nhap that bai EXAM_LINE";
            }
            con.Close();
            return a;
        }
    }
}

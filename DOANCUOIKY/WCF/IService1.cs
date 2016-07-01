﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1 
    {
        [OperationContract]
        List<string> LoginUserDetails(UserInfoToValidate userInfoToValidate);

        //Dành cho mã đề
        [OperationContract]
        Boolean AddTitle(string titleNo, string titleName, int titleCategory);

        [OperationContract]
        DataTable LoadDataTitle();

        [OperationContract]
        DataTable LoadDataTitleByParameters(string titleNo, string titleName, int titleCategory);

        [OperationContract]
        Boolean UpdateTitle(string titleID, string titleNo, string titleName, int titleCategory);

        [OperationContract]
        Boolean DeleteTitle(string titleID);
        //--------------


        //Dành cho loại Category
        [OperationContract]
        Boolean AddCategory(string categoryNo, string categoryName);

        [OperationContract]
        DataTable LoadDataCategory();

        [OperationContract]
        DataTable LoadDataCategoryByParameters(string categoryNo, string categoryName);

        [OperationContract]
        Boolean UpdateCategory(string categoryID, string categoryNo, string categoryName);

        [OperationContract]
        Boolean DeleteCategory(string categoryID);
        //--------------

        //Dành cho câu hỏi
        [OperationContract]
        Boolean AddQuestion(int titleID, string questionNo, string question, string A, string B, string C, string D, string answer, string status);

        [OperationContract]
        DataTable LoadDataQuestion();

        [OperationContract]
        DataTable LoadDataQuestionByParameters(int titleID, string questionNo, string question, string status);

        [OperationContract]
        Boolean UpdateQuestion(int questionID, int titleID, string question, string A, string B, string C, string D, string answer, string status);

        [OperationContract]
        Boolean DeleteQuestion(string questionID);
        //--------------

        //Dành cho Lịch sử thi của các sinh viên(Teacher)
        [OperationContract]
        DataTable LoadDataStudentByParameters(string studentNo, string studentName);

        [OperationContract]
        DataTable LoadDataExamByParameters(string studentID);

        [OperationContract]
        DataTable LoadDataExamLineByParameters(string examHeaderID);

        //-----------------------------------------------

        [OperationContract]
        string InsertCreateAccount(CreateAccount c);

        [OperationContract]
        string updateAccount(CreateAccount uc);

        [OperationContract]
        DataTable loadQuestion1(Bocauhoi q);

        [OperationContract]
        string saveExam(examheader eh);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class UserInfoToValidate
    {
        string username = string.Empty;
        string password = string.Empty;

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
    
    [DataContract]
    public class question
    {
        int titleid = int.MaxValue;
        [DataMember]
        public int titleId
        {
            get { return titleid; }
            set { titleid = value; }
        }
    }

    [DataContract]
    public class examheader
    {
        int ehid = int.MaxValue;
        int ehtotalquestion = int.MaxValue;
        int ehtotaltrueanswer = int.MaxValue;
        int ehscore = int.MaxValue;

        [DataMember]
        public int ehId
        {
            get { return ehid; }
            set { ehid = value; }
        }
        [DataMember]
        public int ehTquestion
        {
            get { return ehtotalquestion; }
            set { ehtotalquestion = value; }
        }
        [DataMember]
        public int ehTTanswer
        {
            get { return ehtotaltrueanswer; }
            set { ehtotaltrueanswer = value; }
        }
        [DataMember]
        public int ehScore
        {
            get { return ehscore; }
            set { ehscore = value; }
        }
    }
}

using System;
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
        DataTable LoadDataTitleByParemeters(string titleNo, string titleName, int titleCategory);

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
        DataTable LoadDataCategoryByParemeters(string categoryNo, string categoryName);

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
        DataTable LoadDataQuestionByParemeters(int titleID, string questionNo, string question, string status);

        [OperationContract]
        Boolean UpdateQuestion(int questionID, int titleID, string question, string A, string B, string C, string D, string answer, string status);

        [OperationContract]
        Boolean DeleteQuestion(string questionID);
        //--------------

        [OperationContract]
        string InsertCreateAccount(CreateAccount c);
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
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DOANCUOIKY.BLL
{
    public class QuestionBLL
    {
        WCF.Service1Client wcf = null;

        public QuestionBLL()
        {
            wcf = new WCF.Service1Client();
        }

        public Boolean AddQuestion(int titleID, string questionNo, string question, string A, string B, string C, string D, string answer, string status)
        {
            return wcf.AddQuestion(titleID, questionNo, question, A, B, C, D, answer, status);
        }

        public DataTable LoadDataQuestion()
        {
            return wcf.LoadDataQuestion();
        }

        public DataTable LoadDataQuestionByParameters(int titleID, string questionNo, string question, string status)
        {
            return wcf.LoadDataQuestionByParemeters(titleID, questionNo, question, status);
        }

        public Boolean UpdateQuestion(int questionID , int titleID, string question, string A, string B, string C, string D, string answer, string status)
        {
            return wcf.UpdateQuestion(questionID, titleID, question, A, B, C, D, answer, status);
        }

        public Boolean DeteleQuestion(string questionID)
        {
            return wcf.DeleteQuestion(questionID);
        }
    }
}

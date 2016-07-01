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
            return wcf.LoadDataQuestionByParameters(titleID, questionNo, question, status);
        }

        public Boolean UpdateQuestion(int questionID , int titleID, string question, string A, string B, string C, string D, string answer, string status)
        {
            return wcf.UpdateQuestion(questionID, titleID, question, A, B, C, D, answer, status);
        }

        public Boolean DeteleQuestion(string questionID)
        {
            return wcf.DeleteQuestion(questionID);
        }

        //public DataTable loadQuestion(int titleId, string question, string cauA, string cauB, string cauC, string cauD, int answer)
        //{
        //    return wcf.loadQuestion(titleId, question, cauA, cauB, cauC, cauD, answer);
        //}
    }
}

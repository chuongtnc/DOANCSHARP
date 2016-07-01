using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DOANCUOIKY.BLL
{
    public class HistoryExamBLL
    {
        WCF.Service1Client wcf = null;

        public HistoryExamBLL()
        {
            wcf = new WCF.Service1Client();
        }

        public DataTable LoadDataStudentByParameters(string studentNo, string studentName)
        {
            return wcf.LoadDataStudentByParameters(studentNo, studentName);
        }

        public DataTable LoadDataExamByParameters(string studentID)
        {
            return wcf.LoadDataExamByParameters(studentID);
        }

        public DataTable LoadDataExamLineByParameters(string examHeaderID)
        {
            return wcf.LoadDataExamLineByParameters(examHeaderID);
        }
    }
}

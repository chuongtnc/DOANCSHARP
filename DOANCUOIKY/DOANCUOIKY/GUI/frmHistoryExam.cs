using DOANCUOIKY.BLL;
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
    public partial class frmHistoryExam : Form
    {
        HistoryExamBLL historyExamBLL = null;
        DataGridViewRow gvRow = null;

        public frmHistoryExam()
        {

            //Khai báo tầng HistoryExam business
            historyExamBLL = new HistoryExamBLL();

            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            gvListStudent.DataSource = historyExamBLL.LoadDataStudentByParameters(tbStudentNo.Text,tbStudentName.Text);
            gvListStudent.Columns[0].Visible = false;
        }


        private void gvListStudent_Click(object sender, EventArgs e)
        {
            if (gvListStudent.CurrentRow != null)
            {
                gvRow = gvListStudent.CurrentRow;
                gvListExam.DataSource = historyExamBLL.LoadDataExamByParameters(gvRow.Cells[0].Value.ToString());
                gvListExam.Columns[0].Visible = false;
            }
        }

        private void gvListExam_Click(object sender, EventArgs e)
        {
            if (gvListExam.CurrentRow != null)
            {
                gvRow = gvListExam.CurrentRow;
                gvListQuestion.DataSource = historyExamBLL.LoadDataExamLineByParameters(gvRow.Cells[0].Value.ToString());
            }
        }
    }
}

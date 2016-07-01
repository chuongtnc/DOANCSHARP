using DOANCUOIKY.BLL;
using DOANCUOIKY.DTO;
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
    public partial class frmHistoryExamStudent : Form
    {
        HistoryExamBLL historyExamBLL = new HistoryExamBLL();
        DataGridViewRow gvRow = null;
        public frmHistoryExamStudent()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            gvListExam.DataSource = historyExamBLL.LoadDataExamByParameters(UserInfoHolder.userInfo[0]);
            gvListExam.Columns[0].Visible = false;
        }

        private void gvListExam_Click(object sender, EventArgs e)
        {
            if (gvListExam.CurrentRow != null)
            {
                gvRow = gvListExam.CurrentRow;
                gvListQuestion.DataSource = historyExamBLL.LoadDataExamLineByParameters(gvRow.Cells[0].Value.ToString());
                gvListQuestion.Columns[0].Visible = false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DOANCUOIKY.BLL
{   
    public class TitleBLL
    {
        WCF.Service1Client wcf = null;

        public TitleBLL()
        {
            wcf = new WCF.Service1Client();
        }

        public Boolean AddTitle(string titleNo,string titleName, int titleCategory)
        {
            return wcf.AddTitle(titleNo, titleName, titleCategory);
        }

        public DataTable LoadDataTitle()
        {
            return wcf.LoadDataTitle();
        }

        public DataTable LoadDataTitleByParameters(string titleNo, string titleName, int titleCategory)
        {
            return wcf.LoadDataTitleByParemeters(titleNo, titleName, titleCategory);
        }

        public Boolean UpdateTitle(string titleID, string titleNo, string titleName, int titleCategory)
        {
            return wcf.UpdateTitle(titleID, titleNo, titleName, titleCategory);
        }

        public Boolean DeteleTitle(string titleID)
        {
            return wcf.DeleteTitle(titleID);
        }
        
    }
}

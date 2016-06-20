using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DOANCUOIKY.BLL
{
    public class CategoryBLL
    {
        WCF.Service1Client wcf = null;

        public CategoryBLL()
        {
            wcf = new WCF.Service1Client();
        }

        public Boolean AddCategory(string categoryNo, string categoryName)
        {
            return wcf.AddCategory(categoryNo, categoryName);
        }

        public DataTable LoadDatacategory()
        {
            return wcf.LoadDataCategory();
        }

        public DataTable LoadDataCategoryByParameters(string categoryNo, string categoryName)
        {
            return wcf.LoadDataCategoryByParemeters(categoryNo, categoryName);
        }

        public Boolean UpdateCategory(string categoryID, string categoryNo, string categoryName)
        {
            return wcf.UpdateCategory(categoryID, categoryNo, categoryName);
        }

        public Boolean DeteleCategory(string categoryID)
        {
            return wcf.DeleteCategory(categoryID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Category
    {
        private string categoryID;
        private string categoryType;

        public string CategoryID
        {
            get
            {
                return categoryID;
            }

            set
            {
                categoryID = value;
            }
        }

        public string CategoryType
        {
            get
            {
                return categoryType;
            }

            set
            {
                categoryType = value;
            }
        }
        public Category()
        {

        }
        public Category(string categoryID, string categoryType)
        {
            this.categoryID = categoryID;
            this.categoryType = categoryType;
        }
        //Method for reading categories accessed from the data access layer
        DataTable categoryDataTable = new DataTable();

        public DataTable GetCategory()
        {
            CategoryDataHandler categoryData = new CategoryDataHandler();
            categoryDataTable = categoryData.GetCatogories("Categories");
            return categoryDataTable;
        }

        //Method for reading categories accessed from the data access layer
        
        public void Insertcategory(string categoryID, string categoryType)
        {
            new CategoryDataHandler().InsertCategory(categoryID, categoryType);
        }
        //Method for reading categories accessed from the data access layer

        public void Updatecategory(string categoryID, string categoryType)
        {
            new CategoryDataHandler().UpdateCategory(categoryID, categoryType);
        }

    }
}

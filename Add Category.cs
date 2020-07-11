using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class Add_Category : Form
    {
        Category categories = new Category();
        DataTable categoryData = new DataTable();
        public Add_Category()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryID = txtCategoryID.Text;
            string categoryType = txtCategoryType.Text;
            categories.Insertcategory(categoryID,categoryType);
        }

        private void Add_Category_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int categoryID = rand.Next(0, 9999);
            txtCategoryID.Text = categoryID.ToString();
        }
    }
}

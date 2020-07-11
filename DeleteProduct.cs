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
    public partial class DeleteProduct : Form
    {
        static Product product = new Product();
        List<Product> productList = product.ReadingProducts();
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string ProductID = cmbPID.Text;
                product.DeleteProduct(ProductID);
                MessageBox.Show("Product Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                txtProductName.Clear();
                throw;
            }
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            cmbPID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPID.DataSource = productList;
            cmbPID.DisplayMember = "ProductID";
        }

        private void cmbPID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in productList)
            {
                if(cmbPID.SelectedIndex == productList.IndexOf(item))
                {
                    txtProductName.Text = item.ProductName;
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            ProductManagementDepartment pmd = new ProductManagementDepartment();
            this.Hide();
            pmd.Show();
        }
    }
}

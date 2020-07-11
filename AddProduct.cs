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
    public partial class AddProduct : Form
    {
        Client clients = new Client();
        Residence residences = new Residence();
        static Product products = new Product();
        BindingSource bindings = new BindingSource();
        DataTable dt = new DataTable();
        List<Product> productList = products.ReadingProducts();
        Category categoriess = new Category();
        DataTable categoryData = new DataTable();
        DataTable filteredProducts = new DataTable();
        private string holder;

        public string Holder
        {
            get
            {
                return holder;
            }

            set
            {
                holder = value;
            }
        }

        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            categoryData = categoriess.GetCategory();
            cmbCategory.DataSource = categoryData;
            cmbCategory.DisplayMember = "CategoryType";
            txtCategoryID.DataBindings.Add("Text", categoryData, "CategoryID");
        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnManipulator_Click(object sender, EventArgs e)
        {
            ProductManipulation PM = new ProductManipulation();
            PM.Show();
            this.Hide();
        }

        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Residence> residenceList = residences.ReadResidence();
            List<Client> ClientList = clients.ReadingClients();

            foreach (var item in ClientList)
            {
                foreach (var res in residenceList)
                {
                    

                }

            }
             if(holder !=null)
            { 
                txtPrice.Text = " ";
            }


        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            try
            {
                string productID = txtProductID.Text;
                string prodName = txtProductName.Text;
                string categoryID = txtCategoryID.Text;
                int quantity = int.Parse(txtQuantity.Text);
                double price = Double.Parse(txtPrice.Text);
                string description = txtDescription.Text;
                string manufacture = txtManufacturer.Text;
                string model = txtModel.Text;
                string serialNumber = txtSerialNumber.Text;
                if (prodName != "" && productID.ToString() !="" && description.ToString() != "" && manufacture.ToString() != "" && model.ToString() != "" && serialNumber.ToString() != "")
                {
                    foreach (var item in productList)
                    {
                        if (productID == item.ProductID)
                        {
                                holder = "ProductID Exist";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All the information is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (holder != "ProductID Exist")
                {
                    products.InsertProducts(productID, categoryID, prodName, quantity, price, description, manufacture, model, serialNumber);
                    MessageBox.Show("Product has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescription.Clear();
                    txtManufacturer.Clear();
                    txtModel.Clear();
                    txtPrice.Clear();
                    txtProductID.Clear();
                    txtProductName.Clear();
                    txtQuantity.Clear();
                    txtSerialNumber.Clear();
                    checks.Checked = false;
                }
                else
                {

                    MessageBox.Show("Retry to add the product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductID.Clear();
                    Random random = new Random();
                    int Number = random.Next(0, 9999);
                    txtProductID.Text = Number.ToString();
                }
                dt.Clear();
                dt = products.GetProducts();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductManagementDepartment pmd = new ProductManagementDepartment();
            pmd.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void checks_CheckedChanged(object sender, EventArgs e)
        {
            string manufacture = txtManufacturer.Text;
            string model = txtModel.Text;
            string serialNumber = txtSerialNumber.Text;
            if (checks.Checked ==true)
            {
                btnAddP.Enabled = true;
                txtProductID.Text = string.Format(manufacture + model + serialNumber);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

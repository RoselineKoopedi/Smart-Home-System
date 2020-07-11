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
    public partial class AddOrder : Form
    {
        static Product products = new Product();
        List<Product> productList = products.ProductsPrices();
        DataTable ProductTable = new DataTable();
        static Order ProductOrders = new Order();
        DataTable Ordertable = new DataTable();
        DataTable filteredProducts = new DataTable();
        static Client clients = new Client();
        DataTable clientTable = new DataTable();
        Category categoriess = new Category();
        DataTable categoryData = new DataTable();
        string holder = "";

        public AddOrder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                
                int orderID = int.Parse(txtOrderID.Text);
                string clientID = cmbClientID.Text;
                string productID = txtProductID.Text;
                string categoty = cmbCategory.Text;
                string name = cmbProductName.Text;
                DateTime date = DateTime.Parse(dtpOrders.Text);
                int quantity = int.Parse(txtQuantity.Text);
                double totalPrice = Double.Parse(txtTotalPrice.Text);
                if (orderID.ToString() != "" && clientID.ToString() != "" && productID.ToString() != "" && name.ToString() != "" && date.ToString() != "" && quantity.ToString() != "" && totalPrice.ToString() != "")
                {
                    foreach (var item in productList)
                    {
                        if (cmbProductName.SelectedIndex == productList.IndexOf(item))
                        {
                            if(item.AvailableQuantity < quantity)
                            {
                                holder = "sold";
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Everything is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(holder != "sold")
                {
                        ProductOrders.InsertOrder(orderID, clientID, productID, categoty, name, date, quantity, totalPrice);
                        products.UpdateQuantity(name, quantity);
                        MessageBox.Show("New Order is successfully made, Congratulations'" + txtClientName.Text + "', enjoy your new Product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The product is sold out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
            

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int OrderID = rand.Next(00000, 99999);
            txtOrderID.Text = OrderID.ToString();
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            rdPrice.Checked = false;
            clientTable = clients.GetClients();
            cmbClientID.DataSource = clientTable;
            cmbClientID.DisplayMember = "ClientID";
            txtClientName.DataBindings.Add(new Binding("Text", clientTable, "ClientName"));
            categoryData = categoriess.GetCategory();
            cmbCategory.DataSource = categoryData;
            cmbCategory.DisplayMember = "CategoryType";

        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            filteredProducts = products.FilteredOrders(cmbCategory.Text);
            cmbProductName.DataSource = filteredProducts;
            cmbProductName.DisplayMember = "ProductName";
        }

        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdPrice_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdPrice.Checked == true)
                {
                    if (cmbProductName.Text != "")
                    {
                        foreach (var item in productList)
                        {
                            if (cmbProductName.SelectedIndex == productList.IndexOf(item))
                            {
                                txtPrice.Text = item.Price.ToString();
                                txtTotalPrice.Text = (int.Parse(txtQuantity.Text) * item.Price).ToString();
                                txtProductID.Text = item.ProductID;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductManagementDepartment pmd = new ProductManagementDepartment();
            this.Hide();
            pmd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

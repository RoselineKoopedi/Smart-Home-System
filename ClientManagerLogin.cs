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
    public partial class ClientManagerLogin : Form
    {
        static Employee employees = new Employee();
        List<Employee> employeeList = new List<Employee>();
        static AccessAccount access = new AccessAccount();
        List<AccessAccount> accessList = access.ReadingAccessAccount();
        public ClientManagerLogin()
        {
            InitializeComponent();
        }
        //field
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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
          if (username != "" && password != "")
            {
                foreach (var item in accessList)
                {

                    if (username ==item.Username  && password == item.Password)
                    {
                        holder = "Allow Access";
                    }
                }
            }
            else
            {
                MessageBox.Show("All credentials are required", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            string name = txtUsername.Text.Substring(0, 1).ToUpper();
            string whole = txtUsername.Text.Substring(1);
            if (holder == "Allow Access")
            {
                ClientManagementDepartment CMD = new ClientManagementDepartment();
                CMD.Show();
                this.Hide();
                MessageBox.Show("Welcome to the Client Management System  " + name+ whole+ "  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Credentials", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }

        }

        private void ClientManagerLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string password = txtPass.Text;
            string confirm = txtConfirm.Text;
            Random rand = new Random();
            int number = rand.Next(0, 9999);
            if (password == confirm)
            {
                access.InsertAccessAccounts(number, name, password);
                MessageBox.Show("You may login", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtConfirm.Clear();
            }
            PanelRegister.Visible = false;
        }

        private void btnNewuser_Click(object sender, EventArgs e)
        {
            PanelRegister.Visible = true;
        }
    }
}

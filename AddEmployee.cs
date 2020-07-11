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
    public partial class AddEmployee : Form
    {
        static Employee employees = new Employee();
        AccessAccount accounts = new AccessAccount();
        List<Employee> employeeList = employees.ReadEmployees();
        static Department departments = new Department();
        List<Department> departmentList = departments.ReadingDepartment();
        private string storage;

        public string Storage
        {
            get
            {
                return storage;
            }

            set
            {
                storage = value;
            }
        }

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int Number = random.Next(0, 9999);
            txtEmployeeID.Text = Number.ToString();
            cmbDepartmentID.DataSource = departmentList;
            cmbDepartmentID.DisplayMember = "DepartmentID";
            cmbDepartmentID.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeID = int.Parse(txtEmployeeID.Text);
                string empName = txtEmployeeName.Text;
                string surname = txtEmployeeSurname.Text;
                string pNumber = txtEmployeePN.Text;
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                string address = txtEmployeeAddress.Text;
                string Etype = txtEmployeeType.Text;
                string DName = txtDepartmentName.Text;
                int departmentID = int.Parse(cmbDepartmentID.Text);
                if (empName != "" && surname != "" && pNumber != "" && address != "" && Etype != "" && departmentID.ToString() != "" && EmployeeID.ToString() != "" && DName != "")
                {
                    foreach (var item in employeeList)
                    {
                        if (EmployeeID == item.EmployeeID)
                        {
                            storage = "Employee ID Exist";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All the information is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (storage != "Employee ID Exist")
                {
                    employees.InsertEmployee(EmployeeID, departmentID, empName, surname, pNumber, Etype, address);
                    if (rbtnCredentials.Checked == true)
                    {
                        accounts.InsertAccessAccounts(EmployeeID, username, password);
                    }
                    MessageBox.Show("Employee added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("EmployeeID Exists, try to add the employee again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Random random = new Random();
                    int Number = random.Next(0, 9999);
                    txtEmployeeID.Text = Number.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnManipulator_Click(object sender, EventArgs e)
        {

        }

        private void rbtnCredentials_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnCredentials.Checked==true)
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmployeeSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmployeePN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmployeeType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDepartmentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmployeeAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbDepartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class DeleteEmployee : Form
    {
        static Employee employees = new Employee();
        List<Employee> employeeList = employees.ReadEmployees();
        public DeleteEmployee()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int employeeID = int.Parse(cmbEmployeeID.Text);
            if(employeeID.ToString() !="")
            {
                employees.DeleteEmployee(employeeID);
                MessageBox.Show("Employee Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
             else
            {
                MessageBox.Show("All the information is required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            cmbEmployeeID.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbEmployeeID.DataSource = employeeList;
            cmbEmployeeID.DisplayMember = "EmployeeID";
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in employeeList)
            {
                if (cmbEmployeeID.SelectedIndex == employeeList.IndexOf(item))
                {
                    txtEmployeeName.Text = item.EmployeeName;
                }
            }
        }
    }
}

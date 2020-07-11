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
    public partial class AddOperation : Form
    {
        static Operation operations = new Operation();
        static Correction corrections = new Correction();
        static Residence residences = new Residence();
        List<Operation> operationList = operations.ReadOperations();
        List<Correction> correctionList = corrections.ReadCorrections();
        List<Residence> residenceList = residences.ReadResidence();
        public AddOperation()
        {
            InitializeComponent();
        }
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddOperation_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int Number = random.Next(0, 9999);
            txtOperationID.Text = Number.ToString();
            cmbRID.DataSource = residenceList;
            cmbRID.DisplayMember = "ResidenceID";
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRID.DropDownStyle = ComboBoxStyle.DropDownList;
            txtStatus.Text = "Waiting";
        }

        private void btnManipulator_Click(object sender, EventArgs e)
        {
            OperationManipulation OM = new OperationManipulation();
            OM.Show();
            this.Hide();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            int OperID = int.Parse(txtOperationID.Text);
            int resid = int.Parse(cmbRID.Text);
            string operType = cmbType.Text;
            string status = txtStatus.Text;
            DateTime Odate = DateTime.Parse(DTOperationDate.Text);
            DateTime Ddate = DateTime.Parse(DTDetectedDate.Text);
            string faultD = txtFault.Text;

            try
            {
                if (status.ToString() != "" && operType != "" && OperID.ToString() != "" && Ddate.ToString() != "" && Odate.ToString() != "")
                {
                    foreach (var item in operationList)
                    {
                       
                            foreach (var cor in correctionList)
                            {
                                if (OperID == item.OperationID)
                                {
                                    storage = "k";
                                }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("All the information is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (storage != "k")
                {
                    operations.InsertOperation(OperID, 0, operType, resid, Odate, status);
                    MessageBox.Show("Operation Inserted, do not forget to assign it an employee", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (cmbType.Text == "Correction")
                    {
                        Random random = new Random();
                        int Number = random.Next(0, 9999);
                        corrections.InsertCorrection(Number, OperID, resid, Odate);
                    }
                    if(MessageBox.Show("Do you want to assign a task to one of available employers now?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        Tasks task = new Tasks();
                        task.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Operation ID Exists, try to add the employee again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Random random = new Random();
                    int Number = random.Next(0, 9999);
                    txtOperationID.Text = Number.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TechnicalOperationsupportDepartment PM = new TechnicalOperationsupportDepartment();
            this.Hide();
            PM.Show();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operationType = cmbType.Text;
            
            if(operationType =="Correction")
            {
                txtFault.Enabled = true;
                DTDetectedDate.Enabled = true;
            }
            else
            {
                txtFault.Enabled = false;
                DTDetectedDate.Enabled = false;
            }
        }

        private void txtFault_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

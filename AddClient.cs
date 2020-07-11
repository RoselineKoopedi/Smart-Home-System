using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class AddClient : Form
    {
        
        Client clients = new Client();
        Account accounts = new Account();
        BindingSource bindings = new BindingSource();
        Residence residences = new Residence();
        ContractType Type = new ContractType();
        DataTable TypeData = new DataTable();
        DataTable dt = new DataTable();
        Contract contracts = new Contract();
        Maintenance maintenances = new Maintenance();
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

        public AddClient()
        {
            InitializeComponent();
        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            List<Client> ClientList = clients.ReadingClients();
            Random rand = new Random();
            int Num = rand.Next(99, 99999999);
            txtAccId.Text = Num.ToString();
            Random contRand = new Random();
            Random MaintRand = new Random();
            int MaintRandNum = rand.Next(99, 99999999);
            txtMaintenanceID.Text = Num.ToString();

            Random randy = new Random();
            int rando = randy.Next(0, 5);
            char ch = (char)('A' + rando);
            Random random = new Random();
            int randm = random.Next(0, 99999);
            string text = Convert.ToString(randm).PadLeft(8, '0');
            txtClientID.Text = ch.ToString() + text;

            Random Ran = new Random();
            int Numberr = Ran.Next(99, 99999999);
            txtResidenceID.Text = Numberr.ToString();
            txtClientStatus.Text = "Active";
            txtMaintenanceStatus.Text = "Waiting";
            txtStatus.Text = "Not Paid";
            TypeData = Type.GetTypes();
            cmbContractType.DataSource = TypeData;
            cmbContractType.DisplayMember = "ContractType";
            txtAmount.DataBindings.Add("Text", TypeData, "PaymentAmmount");
            txtPaymentType.DataBindings.Add("Text", TypeData, "PaymentType");
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {

                List<Client> ClientList = clients.ReadingClients();
                List<Account> AccountsList = accounts.ReadAccounts();
                string clientID = txtClientID.Text;
                string name = txtClientName.Text;
                string surname = txtClientSurname.Text;
                string PhoneN = txtClientPN.Text;
                string email = txtEmail.Text;
                DateTime dob = DateTime.Parse(dtpDOB.Text);
                string IdNumber = txtIDNumber.Text;
                string Clientstatus = txtClientStatus.Text;
                string status = txtStatus.Text;
                int AccountID = int.Parse(txtAccId.Text);
                string accountN = txtAccNumber.Text;
                string accType = txtAccType.Text;
                string billType = txtBillingType.Text;
                string BankName = txtBankName.Text;
                int residenceID = int.Parse(txtResidenceID.Text);
                string address = txtAddress.Text;
                // Checking if all the input boxes are filled with the information
                if (name == "" && surname == "" && PhoneN == "" && email == "" && Clientstatus == "" && txtAccId.Text == "" && txtAccNumber.Text == "" && accType == "" && billType == "" && BankName == "" && status == "")
                {

                    MessageBox.Show("All the information is required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //The Inserting method from the presentation layer which is for two tables named Clients and Accounts tables.

                    foreach (var item in ClientList)
                    {
                        foreach (var acc in AccountsList)
                        {
                            if (clientID == item.ClientID.ToString() && AccountID == acc.AccountID)
                            {
                                storage = "Client or Account Exist";
                            }
                        }

                    }
                }
                try
                {
                    if (storage != "Client or Account Exist ")
                    {
                        clients.InsertClient(clientID, name, surname, dob, IdNumber, PhoneN, email, Clientstatus, status);
                        accounts.InsertAccount(AccountID, clientID, accountN, accType, billType, BankName);
                        residences.InsertResidence(residenceID, clientID, address);
                        MessageBox.Show("Client has been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Random randy = new Random();
                        int rando = randy.Next(0, 5);
                        char ch = (char)('A' + rando);
                        Random random = new Random();
                        int randm = random.Next(0, 999999);

                        txtAccId.Text = randm.ToString();
                        dt.Clear();
                        dt = clients.GetClients();
                        Random rand = new Random();
                        int Num = rand.Next(0, 9999);
                        txtAccId.Text = Num.ToString();
                        txtClientName.Clear();
                        txtClientSurname.Clear();
                        txtClientPN.Clear();
                        txtEmail.Clear();
                        txtStatus.Clear();
                        txtBankName.DataSource = null;
                        txtAccType.DataSource = null;
                        txtAccNumber.Clear();
                        txtBillingType.Clear();
                        txtAddress.Clear();
                        txtResidenceID.Clear();
                        

                    }
                    else
                    {
                        Random randy = new Random();
                        int rando = randy.Next(0, 5);
                        char ch = (char)('A' + rando);
                        Random random = new Random();
                        int randm = random.Next(0, 99999);
                        foreach (var item in ClientList)
                        {
                            if (txtAccId.Text == item.ClientID)
                            {
                                txtAccId.Text = item.ClientID + 1;
                            }
                        }
                        string text = Convert.ToString(randm).PadLeft(8, '0');
                        txtClientID.Text = ch.ToString() + text;
                    }
                }
                catch (Exception r)
                {
                    MessageBox.Show(r.Message);
                }
                dt.Clear();
                dt = clients.GetClients();



            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnManipulator_Click(object sender, EventArgs e)
        {
            ClientManipulation CM = new ClientManipulation();
            this.Hide();
            CM.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Method for restricting the text box to allow only numbers
        private void txtClientID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClientID_KeyPresss(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Method for restricting the text box to allow only numbers
        private void txtAccNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Method for restricting the text box to allow only numbers
        private void txtAccID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Method for restricting the text box to allow only numbers
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Method for restricting the text box to allow both letters and numbers
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
        }
        //Method for restricting the text box to allow only letters
        private void txtOption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Method for restricting the text box to allow only letters
        private void txtName_Keypree(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Method for restricting the text box to allow only letters
        private void txtSurname_Keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Method for restricting the text box to allow only characters
        private void txtStatus_Keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;


            }
        }
        //Method for restricting the text box to allow only letters
        private void txtType_Keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Method for restricting the text box to allow only letters
        private void txtBilling_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Method for restricting the text box to allow only characters
        private void txtBank_Keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientManagementDepartment cmd = new ClientManagementDepartment();
            this.Hide();
            cmd.Show();
        }

        private void txtAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBillingType.Text = txtAccType.Text;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            txtContactStatus.Text = "Active";
            txtMaintenanceStatus.Text = "Waiting";
        }

        private void chkContract_CheckedChanged(object sender, EventArgs e)
        {
            if(chkContract.Checked == true)
            {
                ContractPanel.Visible = true;
            }
        }
        //Method for capturing the contract and maintenace details 
        private void btnDone_Click(object sender, EventArgs e)
        {

            try
            {
                string contractID = txtContractID.Text;
                DateTime maintenaceDate = DateTime.Parse(dtpMaintenanceDate.Text);
                string maintenanceID = txtMaintenanceID.Text;
                string maintenanceType = txtMaintenanceType.Text;
                string contractType = cmbContractType.Text;
                string serviceLevel = cmbServiceLevel.Text;
                string upgradeoption = cmbUpgrade.Text;
                string clientID = txtClientID.Text;
                DateTime issueDate = DateTime.Parse(dtpIssueDate.Text);
                DateTime expDate = DateTime.Parse(dtpExpingDate.Text);
                string contractStatus = txtContactStatus.Text;
                string maintenanceStatus = txtMaintenanceStatus.Text;
                double amount = Double.Parse(txtAmount.Text);
                if (maintenanceType != "" && maintenanceType != "" && maintenanceType != "" && maintenanceType != "" && maintenanceType != "" && maintenanceType != "" && maintenanceType != "")
                {
                    contracts.InsertContracts(contractID, clientID, maintenanceID, contractType, issueDate, expDate, contractStatus, upgradeoption,amount);
                    maintenances.InsertMaintenance(maintenanceID, maintenanceType, maintenaceDate, serviceLevel, maintenanceStatus);
                    ContractPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("All information is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbContractType.Text == "Monthly Contract")
            {
                rdDimmers.Checked = true;
                rdSecurity.Checked = true;
                rdHome.Checked = false;
                rdTemperature.Checked = false;
            }
            else if(cmbContractType.Text == "Quarterly Contract")
            {
                rdHome.Checked = true;
                rdTemperature.Checked = true;
                rdDimmers.Checked = false;
                rdSecurity.Checked = false;
            }
            else
            {
                rdHome.Checked = true;
                rdTemperature.Checked = true;
                rdDimmers.Checked = true;
                rdSecurity.Checked = true;
            }
        }
        //Restriction for allowing numbers only
        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Restriction for allowing letters only
        private void txtClientStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Restriction for allowing letters only
        private void txtMaintenanceType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Restriction for allowing letters only
        private void cmbServiceLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbTerms_CheckedChanged(object sender, EventArgs e)
        {
            // Generating the Client ID
            string serviceLevel = cmbServiceLevel.Text;
            string ContrType = cmbContractType.Text.Substring(0, 1);
            Random random = new Random();
            int randm = random.Next(0, 99999);
            string text = Convert.ToString(randm).PadLeft(6,'0');
            

            if (cbTerms.Checked == true)
            {
                btnDone.Enabled = true;
                txtContractID.Text = string.Format(DateTime.Now.Year.ToString() + ContrType + serviceLevel + text);

            }
        }

        private void txtPaymentType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void txtMaintenanceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbServiceLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpMaintenanceDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void txtMaintenanceStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtMaintenanceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}

               
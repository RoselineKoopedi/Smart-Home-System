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
    public partial class ClientManipulation : Form
    {
        Client clients = new Client();
        static Account account = new Account();
        List<Account> accountList = account.ReadAccounts();
        BindingSource bindings = new BindingSource();
        DataTable dt = new DataTable();
        public ClientManipulation()
        {
            InitializeComponent();
        }

        private void ClientManipulation_Load(object sender, EventArgs e)
        {
            dt = clients.GetClients();
            cmbClientID.DataSource = dt;
            cmbClientID.DisplayMember = "ClientID";
            cmbClientID.DropDownStyle = ComboBoxStyle.DropDownList;

            txtAccNumber.DataBindings.Add(new Binding("Text", dt, "AccountNumber"));
            txtClientName.DataBindings.Add(new Binding("Text", dt, "ClientName"));
            txtClientSurname.DataBindings.Add(new Binding("Text", dt, "ClientSurname"));
            dtpDOB.DataBindings.Add(new Binding("Text", dt, "DOB"));
            txtIDNumber.DataBindings.Add(new Binding("Text", dt, "IDNumber"));
            txtClientPN.DataBindings.Add(new Binding("Text", dt, "PhoneNumber"));
            txtClientStatus.DataBindings.Add(new Binding("Text", dt, "Status"));
            txtEmail.DataBindings.Add(new Binding("Text", dt, "Email"));
            txtStatus.DataBindings.Add(new Binding("Text", dt, "BillingStatus"));
            txtAccType.DataBindings.Add(new Binding("Text", dt, "AccountType"));
            txtBankName.DataBindings.Add(new Binding("Text", dt, "BankName"));
            txtBillingType.DataBindings.Add(new Binding("Text", dt, "BillingType"));
            txtAccId.DataBindings.Add(new Binding("Text", dt, "AccountID"));
        }

        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            string clientID = cmbClientID.Text;
            string name = txtClientName.Text;
            string surname = txtClientSurname.Text;
            string PhoneN = txtClientPN.Text;
            string email = txtEmail.Text;
            DateTime dob = DateTime.Parse(dtpDOB.Text);
            string idNumber = txtIDNumber.Text;
            string clientStatus = txtClientStatus.Text;
            string status = txtStatus.Text;
            if (name != "" && surname != "" && PhoneN != "" && email != "" && idNumber != "" && status != "")
            {
                clients.UpdateClient(clientID, name, surname, dob,idNumber, PhoneN, email, clientStatus, status);
                MessageBox.Show("Client has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
                dt = clients.GetClients();
            }
            else
            {
                MessageBox.Show("All the information is required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dt.Clear();
            dt = clients.GetClients();
        }
        

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            
        }
        //Back from the Adding form to the main form of Client Management Department
        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientManagementDepartment cmd = new ClientManagementDepartment();
            cmd.Show();
            this.Hide();
        }
        //Exit from the system
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
    }
}

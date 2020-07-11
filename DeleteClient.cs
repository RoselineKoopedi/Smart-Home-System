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
    public partial class DeleteClient : Form
    {
        Client clients = new Client();
        static Account account = new Account();
        Contract contracts = new Contract();
        List<Account> accountList = account.ReadAccounts();
        BindingSource bindings = new BindingSource();
        DataTable dt = new DataTable();
        DataTable RemoveClient = new DataTable();
        public DeleteClient()
        {
            InitializeComponent();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            string clientID = cmbClientID.Text;
            int accountID = int.Parse(txtAccId.Text);
            clients.DeleteClient(clientID);
            contracts.UpdateContracts(clientID);
           // account.DeleteAccount(accountID);
            MessageBox.Show("successfully deleted Client");
            dt.Clear();
            dt = clients.GetClients();
            txtAccId.Clear();
            txtClientName.Clear();
            txtClientSurname.Clear();
            txtClientPN.Clear();
            txtEmail.Clear();
            txtStatus.Clear();
            txtAccNumber.Clear();
            txtAccType.Clear();
            txtBankName.Clear();
            txtBillingType.Clear();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientManagementDepartment cmd = new ClientManagementDepartment();
            this.Hide();
            cmd.Show();
        }

        private void DeleteClient_Load(object sender, EventArgs e)
        {
            dt = clients.GetClients();
            cmbClientID.DataSource = dt;
            cmbClientID.DisplayMember = "ClientID";
            cmbClientID.DropDownStyle = ComboBoxStyle.DropDownList;

            txtAccNumber.DataBindings.Add(new Binding("Text", dt, "AccountNumber"));
            txtClientName.DataBindings.Add(new Binding("Text", dt, "ClientName"));
            txtClientSurname.DataBindings.Add(new Binding("Text", dt, "ClientSurname"));
            txtClientPN.DataBindings.Add(new Binding("Text", dt, "PhoneNumber"));
            txtEmail.DataBindings.Add(new Binding("Text", dt, "Email"));
            txtStatus.DataBindings.Add(new Binding("Text", dt, "BillingStatus"));
            txtAccType.DataBindings.Add(new Binding("Text", dt, "AccountType"));
            txtBankName.DataBindings.Add(new Binding("Text", dt, "BankName"));
            txtBillingType.DataBindings.Add(new Binding("Text", dt, "BillingType"));
            txtAccId.DataBindings.Add(new Binding("Text", dt, "AccountID"));
            dtpDOB.DataBindings.Add(new Binding("Text", dt, "DOB"));
            txtIDNumber.DataBindings.Add(new Binding("Text", dt, "IDNumber"));
            txtClientStatus.DataBindings.Add(new Binding("Text", dt, "Status"));
            
        }

        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

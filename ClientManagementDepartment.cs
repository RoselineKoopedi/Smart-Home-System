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
    public partial class ClientManagementDepartment : Form
    {
        
        static Account accounts = new Account();
       
        List<Account> AccountList = accounts.ReadAccounts();
        static Client clients = new Client();
        List<Client> clientList = clients.ReadingClients();
        BindingSource bs = new BindingSource();
        BindingSource bindings = new BindingSource();
        DataTable clientTable = new DataTable();
        DataTable FilterClients = new DataTable();
        Contract contracts = new Contract();
        DataTable ContractData = new DataTable();
        
        public ClientManagementDepartment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManipulator_Click(object sender, EventArgs e)
        {
            AddClient AC = new AddClient();
            AC.Show();
            this.Hide();
        }

        private void ClientManagementDepartment_Load(object sender, EventArgs e)
        {
            clientTable.Clear();
            clientTable = clients.GetClients();
            dgvClientManagement.DataSource = null;
            dgvClientManagement.DataSource = clientTable;
            txtAccNumber.DataBindings.Add(new Binding("Text", clientTable, "AccountNumber"));
            txtBilling.DataBindings.Add(new Binding("Text", clientTable, "BillingType"));
            txtBankType.DataBindings.Add(new Binding("Text", clientTable, "BankName"));
            txtStatus.DataBindings.Add(new Binding("Text", clientTable, "BillingStatus"));

            ContractData = contracts.GetContracts();
            dgvContracts.DataSource = ContractData;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
        int dgvClientIndex = 0;
        private void dgvClientManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             dgvClientIndex = e.RowIndex;
            if (dgvClientIndex == -1) return;
            
        }

        private void FirstClient_Click(object sender, EventArgs e)
        {
            bs.DataSource = null;
            dgvClientManagement.DataSource = null;
            bs.DataSource = clientTable;
            dgvClientManagement.DataSource = bs;
            bs.MoveFirst();
        }

        private void PreviousClient_Click(object sender, EventArgs e)
        {
            bs.DataSource = null;
            dgvClientManagement.DataSource = null;
            bs.DataSource = clientTable;
            dgvClientManagement.DataSource = bs;
            bs.MovePrevious();
        }

        private void NextClient_Click(object sender, EventArgs e)
        {
            /*bs.DataSource = null;
            dgvClientManagement.DataSource = null;
            bs.DataSource = clientTable;
            dgvClientManagement.DataSource = bs;
            bs.MoveNext();*/
        }

        private void LastClient_Click(object sender, EventArgs e)
        {
            bs.DataSource = null;
            dgvClientManagement.DataSource = null;
            bs.DataSource = clientTable;
            dgvClientManagement.DataSource = bs;
            bs.MoveLast();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void addClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient ad = new AddClient();
            this.Hide();
            ad.Show();
        }

        private void updateClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManipulation cm = new ClientManipulation();
            this.Hide();
            cm.Show();
        }

        private void deleteClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteClient dc = new DeleteClient();
            this.Hide();
            dc.Show();
        }

        private void addEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.Show();
        }

        private void deleteEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmployee de = new DeleteEmployee();
            de.Show();
        }

        private void updateEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEmployee ue = new UpdateEmployee();
            ue.Show();
        }

        private void manipulateEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Main_Menu mm = new Main_Menu();
            this.Hide();
            mm.Show();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
        }

        private void tbClients_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ClientManagerLogin cml = new ClientManagerLogin();
            cml.Show();
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string clientID = txtSearch.Text;
            FilterClients = clients.FiltereClients(clientID);
            dgvClientManagement.DataSource = null;
            dgvClientManagement.DataSource = FilterClients;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            clientTable.Clear();
            clientTable = clients.GetClients();
            dgvClientManagement.DataSource = null;
            dgvClientManagement.DataSource = clientTable;
        }

        private void FirstClient_Click_1(object sender, EventArgs e)
        {
            bs.DataSource = null;
           dgvClientManagement.DataSource = null;
           bs.DataSource = clientTable;
           dgvClientManagement.DataSource = bs;
           bs.MoveFirst();
        }

        private void PreviousClient_Click_1(object sender, EventArgs e)
        {
            bs.DataSource = null;
            dgvClientManagement.DataSource = null;
            bs.DataSource = clientTable;
            dgvClientManagement.DataSource = bs;
            bs.MovePrevious();
        }

        private void LastClient_Click_1(object sender, EventArgs e)
        {
            bs.DataSource = null;
            dgvClientManagement.DataSource = null;
            bs.DataSource = clientTable;
            dgvClientManagement.DataSource = bs;
            bs.MoveLast();
        }

        private void NextClient_Click_1(object sender, EventArgs e)
        {
            bs.DataSource = null;
            dgvClientManagement.DataSource = null;
            bs.DataSource = clientTable;
            dgvClientManagement.DataSource = bs;
            bs.MoveNext();
        }

        private void tbContractPage_Click(object sender, EventArgs e)
        {

        }
    }
}

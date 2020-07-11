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
    public partial class OperationManipulation : Form
    {
        static Operation operations = new Operation();
        List<Operation> operationList = operations.ReadOperations();
        static Client clients = new Client();
        static Residence residences = new Residence();
        static Product product = new Product();
        static Correction corrections = new Correction();
        static Reports report = new Reports();
        List<Reports> reportList = report.ReadReports();
        List<Client> ClientList = clients.ReadingClients();
        List<Product> productList = product.ReadingProducts();
        List<Residence> residenceList = residences.ReadResidence();
        List<Correction> correctionList = corrections.ReadCorrections();
        public OperationManipulation()
        {
            InitializeComponent();
        }

        private void OperationManipulation_Load(object sender, EventArgs e)
        {
            cmbOID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOID.DataSource = operationList;
            cmbOID.DisplayMember = "OperationID";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmbOID.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cmbOID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in operationList)
            {
                if (cmbOID.SelectedIndex == operationList.IndexOf(item))
                {
                    txtOperType.Text = item.OperationType;
                    DTOperationDate.Text = item.OperationDate.ToString();

                }
                foreach (var cor in correctionList)
                {
                    foreach (var rep in reportList)
                    {

                        if (cmbOID.SelectedIndex == correctionList.IndexOf(cor))
                        {
                            txtFault.Text = rep.FaultDetected;
                        }
                    }
                }
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {

        }
    }
}

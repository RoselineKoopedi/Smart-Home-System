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
    public partial class DeleteOperation : Form
    {
        static Operation operations = new Operation();
       List<Operation> operationList = operations.ReadOperations();
        public DeleteOperation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDeleteOperation_Click(object sender, EventArgs e)
        {
            
            int operationID = int.Parse(cmbOID.Text);
            operations.DeleteOperation(operationID);
            MessageBox.Show("Operation has been deleted ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteOperation_Load(object sender, EventArgs e)
        {
            cmbOID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOID.DataSource = operationList;
            cmbOID.DisplayMember = "OperationID";
        }

        private void cmbOID_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in operationList)
            {
                if(cmbOID.SelectedIndex ==operationList.IndexOf(item))
                {
                    txtOperType.Text = item.OperationType;
                }
            }
        }
    }
}

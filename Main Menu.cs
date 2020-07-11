using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientManagementDepartment cmd = new ClientManagementDepartment();
            this.Hide();
            cmd.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductManagementDepartment pmd = new ProductManagementDepartment();
            this.Hide();
            pmd.Show();
        }

        private void btnTechnical_Click(object sender, EventArgs e)
        {
            TechnicalOperationsupportDepartment tosd = new TechnicalOperationsupportDepartment();
            this.Hide();
            tosd.Show();
        }
    }
}

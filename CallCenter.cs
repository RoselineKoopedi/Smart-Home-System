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
    public partial class CallCenter : Form
    {

        static Client clients = new Client();
        List<Client> ClientList = clients.ReadingClients();
        Order orders = new Order();
        static Calls newCalls = new Calls();
        DataTable clientData = new DataTable();
        List<Calls> callList = newCalls.ReadingCalls();
        DataTable FilterClients = new DataTable();
        public CallCenter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CallCenter_Load(object sender, EventArgs e)
        {
            clientData = clients.GetClients();
            foreach (var item in callList)
            {
                lsbCallRecords.Items.Add("        Call Records         ");
                lsbCallRecords.Items.Add(" ");
                lsbCallRecords.Items.Add("Call ID                  : " + item.CallID);
                lsbCallRecords.Items.Add("Client ID               :  " + item.ClientID);
                lsbCallRecords.Items.Add("Client Full Name   : " + item.ClientName + "   " + item.ClientSurname);
                lsbCallRecords.Items.Add("Phone Number       :" + item.PhoneNumber);
                lsbCallRecords.Items.Add("Call Date          :" + item.CallDate);
                lsbCallRecords.Items.Add("Call Time          : " + item.CallTime);
                lsbCallRecords.Items.Add("Call Duration      :" + item.CallDuration);
                lsbCallRecords.Items.Add("Call Reason        :" + item.CallReason);
                lsbCallRecords.Items.Add(" ");
                lsbCallRecords.Items.Add(" ");
            }

            DurationTimer = new Thread(ShowTime);
            Random rand = new Random();
            int callId = rand.Next(0000, 999999);
            txtCallID.Text = callId.ToString();
          
        }

        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* foreach (var item in ClientList)
            {
                if (cmbClientName.SelectedIndex == ClientList.IndexOf(item))
                {
                    txtClentID.Text = item.ClientID.ToString();
                    txtSurname.Text = item.ClientSurname;
                    txtPhoneNumber.Text = item.PhoneNumber;
                }
            }*/
        }

        private void dtpCallDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now > DateTime.Parse(dtpCallDate.Text))
            {
                MessageBox.Show("Choose the correct date");
            }

        }

        private delegate void SpecialPersonDelegate();//needed to access form objects
        //Thread for the datetime thread
        Thread DurationTimer;
        //Boolean to check the status of the duration counter
        Boolean Counting = false;
        DateTime displayTime;

        private void btnCall_Click(object sender, EventArgs e)
        {
            if (txtCallReason.Text != "")
            {
                if (Counting)
                {
                    Counting = false;//this will stop the datetime thread
                }
                else
                {
                    try
                    {
                        Counting = true;
                        if (!DurationTimer.IsAlive)
                        {
                            DurationTimer = new Thread(() =>
                            {
                                displayTime = DateTime.Parse(("00:00:00").ToString());
                                DateTime now = DateTime.Now;
                                while (Counting)
                                {
                                    displayTime = (displayTime.AddSeconds(1));
                                    ShowTime();
                                    Thread.Sleep(1000);
                                }
                            });
                            DurationTimer.Start();
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("The reason for calling is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ShowTime()
        {
            try
            {
                if (BtnInitiate.InvokeRequired)
                {
                    SpecialPersonDelegate ac = new SpecialPersonDelegate(ShowTime);
                    BtnInitiate.Invoke(ac);
                }
                else
                {
                    lblDuration.Text = displayTime.TimeOfDay.ToString().Substring(0, 8);
                }
            }
            catch (Exception)
            {

            }
        }

      
        public void Hangup()
        {

            try
            {
                if (btnHang.InvokeRequired)
                {
                    lblDuration.Text = displayTime.TimeOfDay.ToString().Substring(0, 8);

                }
            }
            catch (Exception)
            {

            }

        }

        private void txtCallReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letter are allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        

        private void tbCallRecords_Click(object sender, EventArgs e)
        {

        }

        private void BtnInitiate_Click_1(object sender, EventArgs e)
        {
            if (txtCallReason.Text != "")
            {
                if (Counting)
                {
                    Counting = false;//this will stop the datetime thread
                }
                else
                {
                    try
                    {
                        Counting = true;
                        if (!DurationTimer.IsAlive)
                        {
                            DurationTimer = new Thread(() =>
                            {
                                displayTime = DateTime.Parse(("00:00:00").ToString());
                                DateTime now = DateTime.Now;
                                while (Counting)
                                {
                                    displayTime = (displayTime.AddSeconds(1));
                                    ShowTime();
                                    Thread.Sleep(1000);
                                }
                            });
                            DurationTimer.Start();
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("The reason for calling is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHang_Click_1(object sender, EventArgs e)
        {
            int minute = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;
            int callID = int.Parse(txtCallID.Text);
            string clientID = txtSearch.Text;
            string clientName = txtClientName.Text;
            string surname = txtSurname.Text;
            string phoneNumber = txtPhoneNumber.Text;
            DateTime calldate = DateTime.Parse(dtpCallDate.Text);
            string callduration = lblDuration.Text;
            string callTime = string.Format(hour + ":" + minute);
            string reason = txtCallReason.Text;

            if (Counting)
            {
                Counting = false;//this will stop the datetime thread
            }
            else
            {
                try
                {
                    Counting = true;
                    if (!DurationTimer.IsAlive)
                    {
                        DurationTimer = new Thread(() =>
                        {
                            displayTime = DateTime.Parse(("00:00:00").ToString());
                            DateTime now = DateTime.Now;
                            while (Counting)
                            {
                                displayTime = (displayTime.AddSeconds(1));
                                Hangup();

                                Thread.Sleep(1000);
                            }
                        });
                        DurationTimer.Start();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            newCalls.InsertCalls(callID, clientID, clientName, surname, phoneNumber, calldate, callTime, callduration, reason);
            MessageBox.Show("Call Recorded");
            txtCallID.Clear();
            txtCallReason.Clear();
            txtSearch.Clear();
            txtPhoneNumber.Clear();
            txtSurname.Clear();
            txtClientName.Clear();
            txtCallID.Clear();
            Random rand = new Random();
            int callId = rand.Next(0000, 999999);
            txtCallID.Text = callId.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                string clientID = txtSearch.Text;
                FilterClients = orders.FiltereClientOrders(clientID);
                dgvProducts.DataSource = null;
                dgvProducts.Refresh();
                dgvProducts.DataSource = FilterClients;
                txtClientName.DataBindings.Add("Text", FilterClients, "ClientName");
                txtSurname.DataBindings.Add("Text", FilterClients, "ClientSurname");
                txtPhoneNumber.DataBindings.Add("Text", FilterClients, "PhoneNumber");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Account : Client
    {
        //Fields
        private int accountID;
        private string accountNumber;
        private string accountType;
        private string billingType;
        private string bankName;

        //Properties
        public int AccountID
        {
            get
            {
                return accountID;
            }

            set
            {
                accountID = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }

            set
            {
                accountNumber = value;
            }
        }

        public string AccountType
        {
            get
            {
                return accountType;
            }

            set
            {
                accountType = value;
            }
        }

        public string BillingType
        {
            get
            {
                return billingType;
            }

            set
            {
                billingType = value;
            }
        }

        public string BankName
        {
            get
            {
                return bankName;
            }

            set
            {
                bankName = value;
            }
        }
        //Constructors
        public Account()
        {

        }
        public Account(int AccID, string ClID, string AccNumber, string AccType, string BillType, string BName)
        {
            this.accountID = AccID;
            this.ClientID = ClID;
            this.accountNumber = AccNumber;
            this.accountType = AccType;
            this.billingType = BillType;
            this.bankName = BName;
        }
        public Account(string clientID, string clientName, string clientSurname, string phoneNumber, string email, string configurationOption, string billingStatus, int AccID, string ClID, string AccNumber, string AccType, string BillType, string BName)
            :base(clientID, clientName, clientSurname, phoneNumber, email, configurationOption, billingStatus)
        {
            this.ClientID = clientID;
            this.ClientName = clientName;
            this.ClientSurname = clientSurname;
            this.PhoneNumber = phoneNumber;
            this.BillingStatus = billingStatus;
            this.Email = email;
            this.accountID = AccID;
            this.ClientID = ClID;
            this.accountNumber = AccNumber;
            this.accountType = AccType;
            this.billingType = BillType;
            this.bankName = BName;
        }
       
        public Account(int AccID, string AccNumber, string AccType, string BillType, string BName)
        {
            this.accountID = AccID;
            this.accountNumber = AccNumber;
            this.accountType = AccType;
            this.billingType = BillType;
            this.bankName = BName;
        }
        static DataTable dt = new DataTable();
        public DataTable GetAccounts()
        {
            AccountDataHandler dh = new AccountDataHandler();
            dt = dh.GetAccounts("Account");

            return dt;
        }
        //Method for reading accounts accessed from the data handler
        public List<Account> ReadAccounts()
        {
            List<Account> AccountData = new List<Account>();
            DataSet GetAccounts = new AccountDataHandler().ReadAccounts("Account");

            foreach(DataRow item in GetAccounts.Tables["Account"].Rows)
            {
                AccountData.Add(new Account(int.Parse(item["AccountID"].ToString()), item["ClientID"].ToString(),item["AccountNumber"].ToString(),item["AccountType"].ToString(), item["BillingType"].ToString(), item["BankName"].ToString()));
            }
            return AccountData;
        }
        //Method for inserting an account accessed from the data handler
        public void InsertAccount(int AccID, string ClID, string AccNumber, string AccType, string BillType, string BName)
        {
            new AccountDataHandler().InsertAccount(AccID, ClID, AccNumber, AccType, BillType, BName);
        }
        //Method for updating an account accessed from the data handler
        public void UpdateAccount(int AccID, string ClID, string AccNumber, string AccType, string BillType, string BName)
        {
            new AccountDataHandler().updateAccount(AccID, ClID, AccNumber, AccType, BillType, BName);
        }
        //Method for deleting an account accessed from the data handler
        public void DeleteAccount(int AccID)
        {
           // new AccountDataHandler().DeleteAccount(AccID);
        }
    }
}

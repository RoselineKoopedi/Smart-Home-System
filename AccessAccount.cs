using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class AccessAccount : Employee
    {
        //Fields
        private int accessAccountID;
        private string username;
        private string password;

        //Properties
        public int AccessAccountID
        {
            get
            {
                return accessAccountID;
            }

            set
            {
                accessAccountID = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        //Constructors
        public AccessAccount()
        {

        }
        public AccessAccount(int employeeID, int departID, string employeeName, string employeeSurname, string employeePhoneNumber, string employeeType, string employeeAddress)
            : base(employeeID, departID, employeeName, employeeSurname, employeePhoneNumber, employeeType, employeeAddress)
        {

        }
        public AccessAccount(int accID, int emploID, string usern, string passw)
        {
            this.accessAccountID = accID;
            this.EmployeeID = emploID;
            this.username = usern;
            this.password = passw;
        }
        //Method for reading access account accessed from the data handler
        public List<AccessAccount> ReadingAccessAccount()
        {
            List<AccessAccount> ReadAccessAccounts = new List<AccessAccount>();
            DataSet GetClients = new AccessAccountDataHandler().ReadAccounts("AccessAccount");
            foreach (DataRow item in GetClients.Tables["AccessAccount"].Rows)
            {
                ReadAccessAccounts.Add(new AccessAccount(int.Parse(item["AccessAccountID"].ToString()), int.Parse(item["EmployeeID"].ToString()), item["Username"].ToString(), item["Password"].ToString()));
            }
            return ReadAccessAccounts;
        }
        //Method for inserting an account accessed from the data handler
        public void InsertAccessAccounts( int employeeID, string username, string password)
        {
            new AccessAccountDataHandler().InsertAccessAccount( employeeID, username, password);
        }
        //Method for updating an account accessed from the data handler
        public void UpdateAccessAccounts( int employeeID, string username, string password)
        {
            new AccessAccountDataHandler().UpdateAccessAccount( employeeID, username, password);
        }
        //Method for deleting an account accessed from the data handler
        public void DeleteAccessAccounts(int employeeID)
        {
            new AccessAccountDataHandler().DeleteAccessAccount(employeeID);
        }
    }
}

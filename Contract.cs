using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Contract : Client
    {
        private string contractID;
        private string contractType;
        private DateTime issueDate;
        private DateTime expiringDate;
        private string contractStatus;
        private string upgradeOption;

        public string ContractID
        {
            get
            {
                return contractID;
            }

            set
            {
                contractID = value;
            }
        }

        public string ContractType
        {
            get
            {
                return contractType;
            }

            set
            {
                contractType = value;
            }
        }

        public DateTime IssueDate
        {
            get
            {
                return issueDate;
            }

            set
            {
                issueDate = value;
            }
        }

        public DateTime ExpiringDate
        {
            get
            {
                return expiringDate;
            }

            set
            {
                expiringDate = value;
            }
        }

        public string ContractStatus
        {
            get
            {
                return contractStatus;
            }

            set
            {
                contractStatus = value;
            }
        }

        public string UpgradeOption
        {
            get
            {
                return upgradeOption;
            }

            set
            {
                upgradeOption = value;
            }
        }
        public Contract()
        {

        }
        public Contract(string contractID, string clientID, string maintenanceID, string contractType, DateTime issueDate, DateTime expiringDate, string contractStatus, string upgradeOption)
        {
            this.contractID = contractID;
            this.contractType = contractType;
            this.issueDate = issueDate;
            this.expiringDate = expiringDate;
            this.contractStatus = contractStatus;
            this.upgradeOption = upgradeOption;
        }
        public Contract(string clientID, string clientName, string clientSurname, string phoneNumber, string email, string configurationOption, string billingStatus)
            : base(clientID, clientName, clientSurname, phoneNumber, email, configurationOption, billingStatus)
        {
        }
        DataTable contractData = new DataTable();
        //Method for reading contracts accessed from the datahandler
        public DataTable GetContracts()
        {
            ContractDataHandler contracthandler = new ContractDataHandler();
            contractData = contracthandler.ReadContracts("Contracts");
            return contractData;
        }

        public void InsertContracts(string contractID, string clientID, string maintenanceID, string contractType, DateTime issueDate, DateTime expiringDate, string contractStatus, string upgradeOption, double money)
        {
            try
            {

                new ContractDataHandler().InsertContracts(contractID, clientID, maintenanceID, contractType, issueDate, expiringDate, contractStatus, upgradeOption, money);
                new ContractDataHandler().check = true;
            }
            catch (Exception)
            {

                new ContractDataHandler().check = false;
            }
        }
        public void UpdateContracts(string clientID)
        {
            try
            {

                new ContractDataHandler().UpdateContracts(clientID);
                new ContractDataHandler().check = true;
            }
            catch (Exception)
            {

                new ContractDataHandler().check = false;
            }
        }
    }

}


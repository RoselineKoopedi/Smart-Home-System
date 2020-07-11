using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public interface Iclient
    {
         void DeleteClient(string clientID);
    }
  
    public class Client:Iclient
    {
        //Fields
        private string clientID;
        private string clientName;
        private string clientSurname;
        private string phoneNumber;
        private string email;
        private string status;
        private string billingStatus;
        
        //Properties
        public string ClientID
        {
            get
            {
                return clientID;
            }

            set
            {
                clientID = value;
            }
        }

        public string ClientName
        {
            get
            {
                return clientName;
            }

            set
            {
                clientName = value;
            }
        }

        public string ClientSurname
        {
            get
            {
                return clientSurname;
            }

            set
            {
                clientSurname = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string BillingStatus
        {
            get
            {
                return billingStatus;
            }

            set
            {
                billingStatus = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        //Constructors
        public Client()
        {

        }

        public Client(string clientID, string clientName, string clientSurname, string phoneNumber,string email, string status, string billingStatus)
        {
            this.clientID = clientID;
            this.clientName = clientName;
            this.clientSurname = clientSurname;
            this.phoneNumber = phoneNumber;
            this.status = status;
            this.billingStatus = billingStatus;
            this.email = email;

        }
        //Method for reading client accessed from the data handler
        static DataTable dataClient = new DataTable();
        public DataTable GetClients()
        {
            ClientDataHandler ClientHandler = new ClientDataHandler();
            dataClient = ClientHandler.GetClients("Clients");
            ClientHandler.ErrorChecker = true;

            return dataClient;

        }

        //Method for reading client accessed from the data handler
        public List<Client> ReadingClients()
        {
            ClientDataHandler ClientHandler = new ClientDataHandler();
            List<Client> ReadClients = new List<Client>();
            DataSet GetClients = new ClientDataHandler().ReadClients("Clients");
            foreach (DataRow item in GetClients.Tables["Clients"].Rows)
            {
                ReadClients.Add(new Client(item["ClientID"].ToString(), item["ClientName"].ToString(), item["ClientSurname"].ToString(), item["PhoneNumber"].ToString(), item["Email"].ToString(), item["Status"].ToString(), item["BillingStatus"].ToString()));

            }
            ClientHandler.ErrorChecker = true;
            return ReadClients;

        }
        //Method for searching for a client
        public static DataTable FilteredClients = new DataTable();
        public DataTable FiltereClients(string ClientID)
        {
            ClientDataHandler ClientHandler = new ClientDataHandler();

            try
            {
                ClientDataHandler clientData = new ClientDataHandler();
                FilteredClients = clientData.SearchClient("Clients", ClientID);
                ClientHandler.ErrorChecker = true;
                return FilteredClients;
            }
            catch (Exception)
            {
                ClientHandler.ErrorChecker = false;
                throw;
            }
        }
       
        //Method for inserting a client accessed from the data handler
        public void InsertClient(string clientID, string clientName, string clientSurname, DateTime dob, string idnumber, string phoneNumber, string email, string status, string billingStatus)
        {
            ClientDataHandler ClientHandler = new ClientDataHandler();
            try
            {
                
                new ClientDataHandler().InsertClient(clientID, clientName, clientSurname, dob, idnumber, phoneNumber, email, status, billingStatus);
                ClientHandler.ErrorChecker = true;
            }
            catch (Exception)
            {
                ClientHandler.ErrorChecker = false;
                throw;
            }
        }
        //Method for updating a client accessed from the data handler
        public void UpdateClient(string clientID, string clientName, string clientSurname, DateTime dob, string idnumber, string email, string phoneNumber, string status, string billingStatus)
        {
            try
            {
                ClientDataHandler ClientHandler = new ClientDataHandler();
                new ClientDataHandler().UpdateClient(clientID, clientName, clientSurname, dob, idnumber, email, phoneNumber, status, billingStatus);
                ClientHandler.ErrorChecker = true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Method for deleting a client accessed from the data handler
        public void DeleteClient(string ClientID)
        {
            ClientDataHandler ClientHandler = new ClientDataHandler();
            new ClientDataHandler().DeleteClient(ClientID);
            ClientHandler.ErrorChecker = true;
        }
    }
}

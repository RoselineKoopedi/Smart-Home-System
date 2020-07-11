using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Calls : Client
    {
        //Fields
        private int callID;
        private DateTime callDate;
        private string callTime;
        private string callDuration;
        private string callReason;

        // Properties
        public int CallID
        {
            get
            {
                return callID;
            }

            set
            {
                callID = value;
            }
        }

        public DateTime CallDate
        {
            get
            {
                return callDate;
            }

            set
            {
                callDate = value;
            }
        }

        public string CallTime
        {
            get
            {
                return callTime;
            }

            set
            {
                callTime = value;
            }
        }

        public string CallDuration
        {
            get
            {
                return callDuration;
            }

            set
            {
                callDuration = value;
            }
        }

        public string CallReason
        {
            get
            {
                return callReason;
            }

            set
            {
                callReason = value;
            }
        }
        //Constructors
        public Calls()
        {

        }
        public Calls(string clientID, string clientName, string clientSurname, string phoneNumber, string email, string configurationOption, string billingStatus)
            : base(clientID, clientName, clientSurname, phoneNumber, email, configurationOption, billingStatus)
        {

        }
        public Calls(int callID, string clientID, string clientName, string clientSurname, string phoneNumber, DateTime callDate, string callTime, string callDuration, string callReason)
        {
            this.callID = callID;
            this.ClientID = clientID;
            this.ClientName = clientName;
            this.ClientSurname = clientSurname;
            this.PhoneNumber = phoneNumber;
            this.callDate = callDate;
            this.callDuration = callDuration;
            this.callReason = callReason;
        }
        //Method for reading calls accessed from the data handler
        public List<Calls> ReadingCalls()
        {
            List<Calls> ReadClass = new List<Calls>();
            DataSet GetCalls = new callsHandler().ReadCalls("CallRecords");
            foreach (DataRow item in GetCalls.Tables["CallRecords"].Rows)
            {
                ReadClass.Add(new Calls(int.Parse(item["CallID"].ToString()), item["ClientID"].ToString(), item["ClientName"].ToString(), item["ClientSurname"].ToString(), item["PhoneNumber"].ToString(),DateTime.Parse(item["CallDate"].ToString()), item["CallTime"].ToString(), item["CallDuration"].ToString(), item["CallReason"].ToString()));

            }
            return ReadClass;

        }
        //Method for inserting a call accessed from the data handler
        public void InsertCalls(int callID, string clientID, string clientName, string clientSurname, string phoneNumber, DateTime callDate, string callTime, string callDuration, string callReason)
        {
            new callsHandler().InsertCallReason(callID,clientID, clientName, clientSurname, phoneNumber, callDate, callTime, callDuration, callReason);
        }

    }
}

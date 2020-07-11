using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Residence : Client
    {
        private int residenceID;
        private string address;

        public int ResidenceID
        {
            get
            {
                return residenceID;
            }

            set
            {
                residenceID = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        public Residence()
        {

        }
        public Residence(int residenceID, string address)
        {
            this.ResidenceID = residenceID;
            this.Address = address;
        }
        public Residence(int ResidentId, string address, string clientID, string clientName, string clientSurname, string phoneNumber, string email, string configurationOption, string billingStatus)
        : base(clientID, clientName, clientSurname, phoneNumber, email, configurationOption, billingStatus)
        {
            this.ResidenceID = ResidentId;
            this.Address = address;
        }
        public Residence(int residenceID, string clientID, string address)
        {
            this.ClientID = clientID;
            this.ResidenceID = residenceID;
            this.Address = address;
        }
        public List<Residence> ReadResidence()
        {
            List<Residence> GetResidence = new List<Residence>();
            DataSet GetResidenceData = new ResidenceDataHandler().ReadResidence("Residences");

            foreach (DataRow item in GetResidenceData.Tables["Residences"].Rows)
            {
                GetResidence.Add(new Residence(int.Parse(item["ResidenceID"].ToString()), item["ClientID"].ToString(), item["Address"].ToString()));
            }

            return GetResidence;
        }

        public void InsertResidence(int ResidenceID, string ClientID, string Address)
        {
            new ResidenceDataHandler().InsertResidence(ResidenceID, ClientID, Address);
        }
        public void UpdateResidence(int ResidenceID, string ClientID, string Address)
        {
            new ResidenceDataHandler().UpdateResidence(ResidenceID, ClientID, Address);
        }
        public void DeleteResidence(int ResidenceID)
        {
            new ResidenceDataHandler().DeleteResidence(ResidenceID);

        }
    }
}

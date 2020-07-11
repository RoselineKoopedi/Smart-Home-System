using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ContractType
    {
        private string contractTypeID;
        private string contracttype;
        private string paymentType;
        private string  Categories;
        private double paymentAmount;

        public string ContractTypeID
        {
            get
            {
                return contractTypeID;
            }

            set
            {
                contractTypeID = value;
            }
        }

        public string Contracttype
        {
            get
            {
                return contracttype;
            }

            set
            {
                contracttype = value;
            }
        }

        public string PaymentType
        {
            get
            {
                return paymentType;
            }

            set
            {
                paymentType = value;
            }
        }

        public string Categories1
        {
            get
            {
                return Categories;
            }

            set
            {
                Categories = value;
            }
        }

        public double PaymentAmount
        {
            get
            {
                return paymentAmount;
            }

            set
            {
                paymentAmount = value;
            }
        }
        public ContractType()
        {

        }
        public ContractType(string contractTypeID, string contracttype, string paymentType, string Categories, double paymentAmount)
        {
            this.contractTypeID = contractTypeID;
            this.contracttype = contracttype;
            this.contracttype = contracttype;
            this.Categories = Categories;
            this.paymentAmount = paymentAmount;
        }
        DataTable TypeData = new DataTable();
        public DataTable GetTypes()
        {
            TypeDatahandler typehandler = new TypeDatahandler();
            TypeData = typehandler.GetTypes("ContractType");
            return TypeData;
        }
        
    }
}

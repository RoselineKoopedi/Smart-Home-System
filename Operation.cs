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
   public class Operation : Residence
    {
      
        private int operationID;
        private string operationType;
        private DateTime operationDate;
        private string operationStatus;

        public int OperationID
        {
            get
            {
                return operationID;
            }

            set
            {
                operationID = value;
            }
        }

        public string OperationType
        {
            get
            {
                return operationType;
            }

            set
            {
                operationType = value;
            }
        }

        public DateTime OperationDate
        {
            get
            {
                return operationDate;
            }

            set
            {
                operationDate = value;
            }
        }

        public string OperationStatus
        {
            get
            {
                return operationStatus;
            }

            set
            {
                operationStatus = value;
            }
        }

        public Operation()
        {

        }
        public Operation(int operationID, string operationType, DateTime operationDate, string operationStatus)
        {
            this.OperationID = operationID;
            this.OperationType = operationType;
            this.OperationDate = operationDate;
        }
        public Operation(int operationID, string operationType, DateTime operationDate, int residentID, string Address)
            :base(residentID,Address)
        {
            this.ResidenceID = residentID;
            this.Address = Address;
        }
        //Reading operations that are not assigned to any technician
        public static DataTable datat = new DataTable();

        public DataTable GetOperation()
        {
            OperationDataHandler dh = new OperationDataHandler();
            datat = dh.ReadOperation("Operations");

            return datat;
        }
        //Reading operations that are not assigned to any technician
       public static DataTable allOperation = new DataTable();
        
        public DataTable GetAllOperations()
        {
            OperationDataHandler dh = new OperationDataHandler();
            allOperation = dh.AllOperations("Operations");

            return allOperation;
        }
        //Searching an operation data
        public static DataTable searchOperatios = new DataTable();

        public DataTable GetsearchedOperations(int operationID)
        {
            OperationDataHandler dh = new OperationDataHandler();
            searchOperatios = dh.SearchOperation("Operations", operationID);

            return searchOperatios;
        }
        List<Operation> GetOperations = new List<Operation>();

        public List<Operation> ReadOperations()
        {
            DataSet OperationDate = new OperationDataHandler().ReadOperations("Operations");

            foreach (DataRow item in OperationDate.Tables["Operations"].Rows)
            {
                GetOperations.Add(new Operation(int.Parse(item["OperationID"].ToString()), item["OperationType"].ToString(),DateTime.Parse(item["OperationDate"].ToString()), item["OperationType"].ToString()));
            }

            return GetOperations;
        }
        //Inserting an operation
        public void InsertOperation(int operationID, int EmployeeID, string operationType,int ResidenceID, DateTime operationDate, string operationStatus)
        {
            new OperationDataHandler().InsertOperation(operationID, EmployeeID, operationType, ResidenceID, operationDate, operationStatus);
        }
        //Updating an operation
        public void UpdateOperation(int operationID, string operationType, int ResidenceID, DateTime operationDate, string operationStatus)
        {
            new OperationDataHandler().UpdateOperation(operationID, operationType, ResidenceID, operationDate, operationStatus);
        }
        // assigning an employee to an operation
        public void UpdateEmployeeOperation(int operationID, int employeeID)
        {
            new OperationDataHandler().UpdateEmployeeOperation(operationID, employeeID);
        }
        //Deleting an operation
        public void DeleteOperation(int operationID)
        {
            new OperationDataHandler().DeleteOperation(operationID);
               
        }

    }
}

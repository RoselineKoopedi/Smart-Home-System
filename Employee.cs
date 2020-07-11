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
    public class Employee : Department
    {
        private int employeeID;
        private string employeeName;
        private string employeeSurname;
        private string employeePhoneNumber;
        private string employeeType;
        private string employeeAddress;
        public int EmployeeID
        {
            get
            {
                return employeeID;
            }

            set
            {
                employeeID = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }

        public string EmployeeSurname
        {
            get
            {
                return employeeSurname;
            }

            set
            {
                employeeSurname = value;
            }
        }

        public string EmployeePhoneNumber
        {
            get
            {
                return employeePhoneNumber;
            }

            set
            {
                employeePhoneNumber = value;
            }
        }
        public string EmployeeType
        {
            get
            {
                return employeeType;
            }

            set
            {
                employeeType = value;
            }
        }
        public string EmployeeAddress
        {
            get
            {
                return employeeAddress;
            }
            set
            {
                employeeAddress = value;
            }
        }
        public Employee()
        {

        }
        public Employee(int employeeID, int departID, string employeeName, string employeeSurname, string employeePhoneNumber, string employeeType, string employeeAddress)
        {
            this.EmployeeID = employeeID;
            this.DepartmentID = departID;
            this.EmployeeName = employeeName;
            this.EmployeeSurname = employeeSurname;
            this.EmployeePhoneNumber = employeePhoneNumber;
            this.EmployeeType = employeeType;
            this.EmployeeAddress = employeeAddress;
        }
        public Employee(int departID, String departName)
            : base(departID, departName)
        {
            this.DepartmentID = departID;
            this.DepartmentName = departName;
        }
        //Getting all employees accessed from the data access layer
        static DataTable EmployeeData = new DataTable();
        public DataTable GetEmployyes()
        {
            EmployeeDataHandler EmployeeHandler = new EmployeeDataHandler();
           EmployeeData = EmployeeHandler.GetEmployees("Employees", "Technician");
            return EmployeeData;
        }
        // Getting assigned employees accessed from the data access layer 
         static DataTable AssignedEmployees = new DataTable();
         public DataTable GetAssignedEmployees()
         {
             EmployeeDataHandler EmployeeHandler = new EmployeeDataHandler();
             AssignedEmployees = EmployeeHandler.GetassignedEmployee("Employees");
             return AssignedEmployees;
         }
        
       /* List<Employee> GetassignedEmployees()
        {
            List<Employee> assignedEmployees = new List<Employee>();
            EmployeeDataHandler employeeData = new EmployeeDataHandler();
            DataSet assigned = employeeData.GetassignedEmployee("Employees");

            foreach (DataRow item in assigned.Tables["Employees"].Rows)
            {
                assignedEmployees.Add(new Employee(int.Parse(item["EmployeeID"].ToString()),int.Parse(item["DepartmentID"].ToString()),item["EmployeeName"].ToString(),item["EmployeeSurname"].ToString(),item["EmployeePNumber"].ToString(),item["EmployeeType"].ToString(),item["Address"].ToString()));
            }

            return assignedEmployees;
        }*/

        // Getting unassigned employees accessed from the data access layer 
        static DataTable UnassignedEmployees = new DataTable();
        public DataTable GetUnassignedEmployees()
        {
            EmployeeDataHandler EmployeeHandler = new EmployeeDataHandler();
            UnassignedEmployees = EmployeeHandler.GetunassignedEmployee("Employees");
            return UnassignedEmployees;
        }
        public List<Employee> ReadEmployees()
        {
            List<Employee> ReadEmployees = new List<Employee>();
            DataSet GetClients = new EmployeeDataHandler().ReadEmployees("Employees");
            foreach (DataRow item in GetClients.Tables["Employees"].Rows)
            {
                ReadEmployees.Add(new Employee(int.Parse(item["EmployeeID"].ToString()), int.Parse(item["DepartmentID"].ToString()), item["EmployeeName"].ToString(), item["EmployeeSurname"].ToString(), item["EmployeePNumber"].ToString(), item["EmployeeType"].ToString(), item["Address"].ToString()));

            }
            return ReadEmployees;
        }
       

        public void InsertEmployee(int employeeID,int departmentID, string employeeName,string employeeSurname,string employeePhoneNumber,string employeeType, string employeeAddress)
        {
            new EmployeeDataHandler().InsertEmployee(employeeID, departmentID,  employeeName,  employeeSurname,  employeePhoneNumber,  employeeType,  employeeAddress);
                
        }
        public void UpdateEmployee(int employeeID,int departmentID, string employeeName, string employeeSurname, string employeePhoneNumber, string employeeType, string employeeAddress)
        {
            new EmployeeDataHandler().UpdateEmployee(employeeID, departmentID,  employeeName, employeeSurname, employeePhoneNumber, employeeType, employeeAddress);
        }
        public void DeleteEmployee(int employeeID)
        {
            new EmployeeDataHandler().DeleteEmployee(employeeID);
        }
    }
}

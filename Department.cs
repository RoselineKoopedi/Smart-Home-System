using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Department
    {
        private int departmentID;
        private string departmentName;

        public int DepartmentID
        {
            get
            {
                return departmentID;
            }

            set
            {
                departmentID = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return departmentName;
            }

            set
            {
                departmentName = value;
            }
        }
        public Department()
        {

        }
        public Department(int departID, String departName)
        {
            this.departmentID = departID;
            this.departmentName = departName;
        }
        public List<Department> ReadingDepartment()
        {
            List<Department> ReadDepartments = new List<Department>();
            DataSet GetClients = new DepartmentDataHandler().ReadDepartments("Departments");
            foreach (DataRow item in GetClients.Tables["Departments"].Rows)
            {
                ReadDepartments.Add(new Department(int.Parse(item["DepartmentID"].ToString()), item["DepartmentName"].ToString()));

            }
            return ReadDepartments;
        }
    }
}


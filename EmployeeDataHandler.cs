using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccessLayer
{
    public class EmployeeDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public EmployeeDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
        public DataSet ReadEmployees(string tableName)
        {
            DataSet EmployeeData = new DataSet();
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {

                Query = string.Format("SELECT * FROM {0} WHERE EmployeeType ='"+ "Technician"+ "'", tableName);
                SqlDataAdapter Adapter = new SqlDataAdapter(Query, connect);
                Adapter.FillSchema(EmployeeData, SchemaType.Source, tableName);
                Adapter.Fill(EmployeeData, tableName);
                connect.Close();
            }
            return EmployeeData;

        }
        static DataTable EmployeeTable = new DataTable();
        public DataTable GetEmployees(string tablename, string type)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                Query = string.Format("SELECT * FROM {0} INNER JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID WHERE Employees.EmployeeType ='" + type + "' ", tablename);
                connect.Open();
                SqlCommand command = new SqlCommand(Query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(EmployeeTable);
                connect.Close();
                return EmployeeTable;
            }
        }

        //Reading employees that have tasks assigned to
        static DataTable assignedEmployee = new DataTable();
        public DataTable GetassignedEmployee(string tablename)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                Query = string.Format("SELECT * FROM {0} INNER JOIN Operations ON Employees.EmployeeID = Operations.EmployeeID WHERE Employees.EmployeeID  IN (SELECT EmployeeID FROM Operations) ", tablename);
                connect.Open();
                SqlCommand command = new SqlCommand(Query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(assignedEmployee);
                connect.Close();
                return assignedEmployee;
            }
        }
        static DataTable UnassignedEmployee = new DataTable();
        public DataTable GetunassignedEmployee(string tablename)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                Query = string.Format("SELECT * FROM {0} LEFT JOIN Operations ON Employees.EmployeeID = Operations.EmployeeID WHERE Operations.EmployeeID IS NULL ", tablename);
                connect.Open();
                SqlCommand command = new SqlCommand(Query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(UnassignedEmployee);
                connect.Close();
                return UnassignedEmployee;
            }
        }
        public void InsertEmployee(int employeeID, int departmentID, string employeeName, string employeeSurname, string employeePhoneNumber, string employeeType, string employeeAddress)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());

            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("ProcInsertEmployee", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@DepartmentID", departmentID);
                command.Parameters.AddWithValue("@EmployeeName", employeeName);
                command.Parameters.AddWithValue("@EmployeeSurname", employeeSurname);
                command.Parameters.AddWithValue("@PhoneNumber", employeePhoneNumber);
                command.Parameters.AddWithValue("@EmployeeType", employeeType);
                command.Parameters.AddWithValue("@Address", employeeAddress);
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }


        }
        public void UpdateEmployee(int employeeID, int departmentID, string employeeName, string employeeSurname, string employeePhoneNumber, string employeeType, string employeeAddress)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("UpdateEmployee", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeID", employeeID);
                    command.Parameters.AddWithValue("@departmentID", departmentID);
                    command.Parameters.AddWithValue("@employeeName", employeeName);
                    command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
                    command.Parameters.AddWithValue("@employeePhoneNumber", employeePhoneNumber);
                    command.Parameters.AddWithValue("@employeeType", employeeType);
                    command.Parameters.AddWithValue("@employeeAddress", employeeAddress);
                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {


                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }


            }
        }
        
        public void DeleteEmployee(int employeeID)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());

            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("ProcDeleteEmployee", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@employeeID", employeeID);
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {


            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }


        }
    }
}

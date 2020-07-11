using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
     public class OperationDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public static DataTable datat = new DataTable();
        bool ErrorChecker = true;
        public OperationDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
        //Reading data of all operations from the database
        DataTable allOperations = new DataTable();
        public DataTable AllOperations(string tableName)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT * FROM {0} ", tableName);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(allOperations);
                    connect.Close();
                }
                return allOperations;
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }
        //Access operations that are not assigned to any technician

        DataSet assigned = new DataSet();
        public DataSet GetassignedOperations(string tablename)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                Query = string.Format("SELECT * FROM {0} ", tablename);
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, connect);
                adapter.FillSchema(assigned, SchemaType.Source, tablename);
                adapter.Fill(assigned, tablename);
                connect.Close();
                return assigned;
            }
        }
        public DataTable ReadOperation(string tableName)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT * FROM {0} INNER JOIN Residences ON Operations.ResidenceID = Residences.ResidenceID  WHERE Operations.EmployeeID = '" + 0 + "'", tableName);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(datat);
                    connect.Close();
                }
                return datat;
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }
        public static DataTable datatable = new DataTable();
        public DataTable ReadFilteredOperations(string tableName)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT * FROM {0} INNER JOIN Residences ON Operations.ResidenceID = Residences.ResidenceID  WHERE Operations.EmployeeID = '" + 0 + "'", tableName);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(datatable);
                    connect.Close();
                }
                return datat;
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }
        public static DataTable searchedOperations = new DataTable();
        public DataTable SearchOperation(string tableName,int operationID)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT * FROM {0} WHERE  Operations.OperationID = '" + operationID + "'", tableName);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(searchedOperations);
                    connect.Close();
                }
                return searchedOperations;
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }

        DataSet TechnicalData = new DataSet();

        public DataSet ReadOperations(string tableName)
          {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT * FROM {0}", tableName);
                    connect.Open();
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, connect);
                    Adapter.FillSchema(TechnicalData, SchemaType.Source, tableName);
                    Adapter.Fill(TechnicalData, tableName);
                    connect.Close();
                }

                return TechnicalData;
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
          }
        public void InsertOperation(int OperationlID,int employeeID, string OperationType,int ResidenceID, DateTime OperationDate,string OperationStatus)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());

            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("ProceInsertOperations", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@OperationID", OperationlID);
                command.Parameters.AddWithValue("@employeeID", employeeID);
                command.Parameters.AddWithValue("@OperationType", OperationType);
                command.Parameters.AddWithValue("@ResidenceID", ResidenceID);
                command.Parameters.AddWithValue("@OperationDate", OperationDate);
                command.Parameters.AddWithValue("@OperationStatus", OperationStatus);
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                ErrorChecker = false;
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }


        }
        public void UpdateEmployeeOperation(int operationID, int employeeID)
        {
            {
                SqlConnection connect = new SqlConnection(connection.ToString());

                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("ProcUpdateOperation", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@operationID", operationID);
                    command.Parameters.AddWithValue("@employeeID", employeeID);
                    command.Parameters.AddWithValue("@status", "In Process");
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
        public void UpdateOperation(int OperationlID, string OperationType, int ResidenceID, DateTime OperationDate, string operationStatus)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "UPDATE Technical SET OperationType='" + OperationType + "',ResidenceID='" + ResidenceID + "',OperationDate = '" + OperationDate + "',operationStatus='" + operationStatus + "' WHERE OperationID ='" + OperationlID+"' ";
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                }
                catch (Exception )
                {
                    ErrorChecker = false;
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
        public void DeleteOperation(int operationID)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "DELETE FROM  Technical WHERE OperationID ='" + operationID + "'";
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                }
                catch (Exception )
                {
                    ErrorChecker = false;
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
}

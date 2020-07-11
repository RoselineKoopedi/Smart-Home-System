using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class AccessAccountDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public AccessAccountDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
        bool ErrorChecker = true;

        public DataSet ReadAccounts(string tableName)
        {
            try
            {
                DataSet clientData = new DataSet();
                Query = string.Format("SELECT * FROM {0}", tableName);
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(Query, connect);
                    adapter.FillSchema(clientData, SchemaType.Source, tableName);
                    adapter.Fill(clientData, tableName);
                    connect.Close();

                }
                return clientData;
            }
            catch (Exception)
            {
                 ErrorChecker = false;
                throw;

            }
        }
        public void InsertAccessAccount(int employeeID, string username, string password)
        {

            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("ProcInsertAccess", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@emplyeeID", employeeID);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
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
        public void UpdateAccessAccount(int employeeID, string username, string password)
        {
            Query = "UPDATE AccessAccount SET EmployeeID ='" + employeeID + "', Username = '" + username + "',Password = '" + password + "')";
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
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
        public void DeleteAccessAccount(int EmployeeID)
        {
            Query = "DELETE FROM AccessAccount WHERE EmployeeID = '" + EmployeeID + "')";
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
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

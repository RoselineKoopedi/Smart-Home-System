using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccessLayer
{
    public class ClientDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        SqlConnection connecty = new SqlConnection("Data Source = TAYLORKOOPS, Initial Catalog = SmartHomeSystemDatabase, Integrated Security =SSIP");
        string Query = null;
       public  bool ErrorChecker = true;
        public ClientDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }

        // Read client data from the database
        static DataTable datatable = new DataTable();
        public DataTable GetClients(string tablename)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT * FROM {0}   INNER JOIN Account ON Clients.ClientID = Account.ClientID   WHERE Status = '" + "Active" + "'", tablename);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(datatable);
                    connect.Close();
                    return datatable;
                }
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }
        public DataSet ReadClients(string tableName)
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
        // Search for a client 
        public DataTable SearchClient(string tableName, string clientID)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                DataTable OrderDate = new DataTable();
                try
                {


                    Query = string.Format("SELECT * FROM {0} WHERE ClientID = '" + clientID + "'", tableName);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(OrderDate);

                }


                catch (Exception)
                {
                    ErrorChecker = false;
                    throw;
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
                return OrderDate;

            }
        }
      
        // Insert client data into the database
        public void InsertClient(string clientID, string clientName, string clientSurname, DateTime dob, string idnumber, string phoneNumber, string email, string status, string billingStatus)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());

            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("ProcInsertClient", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@clientID", clientID);
                command.Parameters.AddWithValue("@clientName", clientName);
                command.Parameters.AddWithValue("@ClientSurname", clientSurname);
                command.Parameters.AddWithValue("@dob", dob);
                command.Parameters.AddWithValue("@idNumber", idnumber);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@BillingStatus", billingStatus);
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
        // Update client data from the database
        public void UpdateClient(string clientID, string clientName, string clientSurname, DateTime dob, string idnumber, string phoneNumber, string email, string status, string billingStatus)
        {
            {
                SqlConnection connect = new SqlConnection(connection.ToString());

                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("UpdateClientTable", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@clientID", clientID);
                    command.Parameters.AddWithValue("@clientName", clientName);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.Parameters.AddWithValue("@idNumber", idnumber);
                    command.Parameters.AddWithValue("@ClientSurname", clientSurname);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@BillingStatus", billingStatus);
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
        }
        // Delete client data from the database
        public void DeleteClient(string ClientID)
        {

            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("ProcDeleteClient", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@clientID", ClientID);
                    command.Parameters.AddWithValue("@status", "Terminated");
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
     public class ContractDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public ContractDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
        bool ErrorChecker = true;

        // Read Contracts data from the database
        static DataTable datatable = new DataTable();
        public DataTable ReadContracts(string tablename)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT ContractID,Contracts.ClientID,ClientName,ClientSurname ,MaintenanceID,ContractType,IssueDate,ExpiringDate,ContractStatus,UpgradeOption,ContractAmount FROM {0} INNER JOIN Clients ON Contracts.ClientID = Clients.ClientID", tablename);
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
        public bool check = true;
        // Insert Contracts data into the database
        public void InsertContracts(string contractID, string clientID, string maintenanceID, string contractType, DateTime issueDate, DateTime expiringDate, string contractStatus, string upgradeOption,double amount)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("InsertContracts", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@contractID", contractID);
                command.Parameters.AddWithValue("@clientID", clientID);
                command.Parameters.AddWithValue("@maintenanceID", maintenanceID);
                command.Parameters.AddWithValue("@contractType", contractType);
                command.Parameters.AddWithValue("@issueDate", issueDate);
                command.Parameters.AddWithValue("@expiringDate", expiringDate);
                command.Parameters.AddWithValue("@contractStatus", contractStatus);
                command.Parameters.AddWithValue("@upgradeOption", upgradeOption);
                command.Parameters.AddWithValue("@amount", amount);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                check = false;
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }


        }
        //Update contract status. This is used when the client is being deleted
        public void UpdateContracts( string clientID)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("ProcUpdateContract", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@clientID", clientID);
                command.Parameters.AddWithValue("@status", "Terminated");
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                check = false;
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

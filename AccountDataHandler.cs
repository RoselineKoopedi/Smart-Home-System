using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class AccountDataHandler
    {

        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        String Query = null;
        bool ErrorChecker = true;
        public AccountDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
        static DataTable datatable = new DataTable();
        public DataTable GetAccounts(string tablename)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                Query = string.Format("SELECT * FROM {0} INNER JOIN Clients ON Account.ClientID =Clients.ClientID", tablename);
                connect.Open();
                SqlCommand command = new SqlCommand(Query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(datatable);
                connect.Close();
                return datatable;
            }
        }
        public DataSet ReadAccounts(string tableName)
        {
            DataSet AccountData = new DataSet();

            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    connect.Open();
                    Query = string.Format("SELECT * FROM {0}", tableName);
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, connect);
                    Adapter.FillSchema(AccountData, SchemaType.Source, tableName);
                    Adapter.Fill(AccountData, tableName);

                    connect.Close();

                }


                return AccountData;
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }

        public DataSet ReadEverything()
        {
            DataSet clientData = new DataSet();
            Query = String.Format("SELECT Account.AccountID,Account.ClientID,Account.AccountNumber,Account.AccountType,Account.BillingType,Account.BankName,Clients.ClientID,Clients.ClientName,Clients.ClientSurname,Clients.PhoneNumber,Clients.Email,Clients.ConfigurationOption,Clients.BillingStatus FROM Clients INNER JOIN Account ON Clients.ClientID = Account.ClientID");
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(Query, connect);
                command.ExecuteNonQuery();
                connect.Close();
            }
            return clientData;
        }

       public void InsertAccount(int AccID, string ClID, string AccNumber, string AccType, string BillType, string BName)
        {

            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    Query = "INSERT INTO Account(AccountID,ClientID,AccountNumber,AccountType,BillingType,BankName) VALUES('" + AccID + "','" + ClID + "','" + AccNumber + "','" + AccType + "','" + BillType + "','" + BName + "')";
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                    connect.Close();
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
       public void InsertAcccount(int AccID, string ClID, string AccNumber, string AccType, string BillType, string BName)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());

            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("ProcInsertAccounts", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccID", AccID);
                command.Parameters.AddWithValue("@ClID", ClID);
                command.Parameters.AddWithValue("@AccNumber", AccNumber);
                command.Parameters.AddWithValue("@AccType", AccType);
                command.Parameters.AddWithValue("@BillType", BillType);
                command.Parameters.AddWithValue("@BName", BName);
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
        public void updateAccount(int AccID, string ClID, string AccNumber, string AccType, string BillType, string BName)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    connect.Open();
                    Query = "UPDATE Account SET ClientID ='" + ClID + "' ,AccountNumber='" + AccNumber + "',AccountType='" + AccType + "',BillingType ='" + BillType + "',BankName='" + BName + "' WHERE  AccountID='" + AccID + "'";
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                }
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }

        }
       /* public void DeleteAccount(int AccID)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    connect.Open();
                    Query = "DELETE FROM Account WHERE  AccountID ='" + AccID + "'";
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                }
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }*/



    }
}

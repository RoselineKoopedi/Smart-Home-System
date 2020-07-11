using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class callsHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        bool ErrorChecker = true;
        public callsHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }

        public DataSet ReadCalls(string tableName)
        {
            try
            {
                DataSet CallData = new DataSet();
                Query = string.Format("SELECT * FROM {0}", tableName);
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(Query, connect);
                    adapter.FillSchema(CallData, SchemaType.Source, tableName);
                    adapter.Fill(CallData, tableName);
                    connect.Close();
                }
                return CallData;
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }

        public void InsertCallReason(int callID, string clientID, string clientName, string clientSurname, string phoneNumber, DateTime callDate, string callTime, string callDuration, string callReason)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());

            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("ProcInsertCall", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@callID", callID);
                command.Parameters.AddWithValue("@clientID", clientID);
                command.Parameters.AddWithValue("@clientName", clientName);
                command.Parameters.AddWithValue("@ClientSurname", clientSurname);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@callDate", callDate);
                command.Parameters.AddWithValue("@callTime", callTime);
                command.Parameters.AddWithValue("@callDuration", callDuration);
                command.Parameters.AddWithValue("@callReason", callReason);
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
}

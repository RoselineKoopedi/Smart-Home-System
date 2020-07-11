using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class ResidenceDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public ResidenceDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
        public DataSet ReadResidence(string tableName)
        {
            DataSet ResidenceData = new DataSet();
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                Query = string.Format("SELECT * FROM {0}", tableName);
                connect.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(Query, connect);
                Adapter.FillSchema(ResidenceData, SchemaType.Source, tableName);
                Adapter.Fill(ResidenceData, tableName);
                connect.Close();
            }

            return ResidenceData;
        }
     
        public void InsertResidence(int ResidenceID, string clientID, string Address)
        {
            {
                SqlConnection connect = new SqlConnection(connection.ToString());

                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("ProcInsertResidence", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ResidenceID", ResidenceID);
                    command.Parameters.AddWithValue("@clientID", clientID);
                    command.Parameters.AddWithValue("@Address", Address);
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
        public void UpdateResidence(int ResidenceID, string clientID, string Address)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "UPDATE Products SET ResidenceID ='" + ResidenceID + "'ClientID= '" + clientID + "', Address ='" + Address + "' WHERE ResidenceID = '" + ResidenceID + "'";
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
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
        public void DeleteResidence(int ResidenceID)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "DELETE FROM Residences WHERE ResidenceID ='" + ResidenceID + "'";
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
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
}

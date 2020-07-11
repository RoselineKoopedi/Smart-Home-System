using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class MaintenanceDataHandler
    {


        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        SqlConnection connecty = new SqlConnection("Data Source = TAYLORKOOPS, Initial Catalog = SmartHomeSystemDatabase, Integrated Security =SSIP");
        string Query = null;
        public MaintenanceDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }

        // Read Maintenance data from the database
        static DataTable datatable = new DataTable();
        public DataTable ReadMaintenance(string tablename)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                Query = string.Format("SELECT * FROM {0}", tablename);
                connect.Open();
                SqlCommand command = new SqlCommand(Query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(datatable);
                connect.Close();
                return datatable;
            }
        }

        // Insert Maintenance data into the database
        public void InsertMaintenance(string maintenanceID, string maintenanceType, DateTime maintenanceDate, string serviceLevel, string maintenanceStatus)
        {
            SqlConnection connect = new SqlConnection(connection.ToString());

            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("InsertMaintenance", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maintenanceID", maintenanceID);
                command.Parameters.AddWithValue("@maintenanceType", maintenanceType);
                command.Parameters.AddWithValue("@maintenanceDate", maintenanceDate);
                command.Parameters.AddWithValue("@serviceLevel", serviceLevel);
                command.Parameters.AddWithValue("@maintenanceStatus", maintenanceStatus);
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


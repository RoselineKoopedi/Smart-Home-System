using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CategoryDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public bool ErrorChecker = true;
        public CategoryDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }

        // Read client data from the database
        static DataTable datatable = new DataTable();
        public DataTable GetCatogories(string tablename)
        {
            try
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
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }
        public void InsertCategory(string categoryID, string categoryType)
        {

            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("ProcInsertCategory", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@categoryID", categoryID);
                    command.Parameters.AddWithValue("@categoryType", categoryType);
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
        public void UpdateCategory(string categoryID, string categoryType)
        {

            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("ProcUpdateCategory", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@categoryID", categoryID);
                    command.Parameters.AddWithValue("@categoryType", categoryType);
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

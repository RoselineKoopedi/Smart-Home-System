using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class TypeDatahandler
    {

        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public TypeDatahandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }

        DataTable TypeTable = new DataTable();

        public DataTable GetTypes(string tablename)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                Query = string.Format("SELECT * FROM {0}", tablename);
                SqlCommand command = new SqlCommand(Query,connect);
                SqlDataAdapter Adapter = new SqlDataAdapter(command);
                Adapter.Fill(TypeTable);
                return TypeTable;
            }
        }
    }
}

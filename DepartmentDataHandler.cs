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
    public class DepartmentDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public DepartmentDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }

        public DataSet ReadDepartments(string tableName)
        {
            DataSet DepartmentData = new DataSet();
            Query = string.Format("SELECT * FROM {0}", tableName);
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, connect);
                adapter.FillSchema(DepartmentData, SchemaType.Source, tableName);
                adapter.Fill(DepartmentData, tableName);
                connect.Close();
            }
            return DepartmentData;
        }
    }
}

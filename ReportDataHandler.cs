using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ReportDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public ReportDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
        public DataSet ReadReports(string tableName)
        {
            DataSet ReportData = new DataSet();
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                Query = string.Format("SELECT * FROM {0}", tableName);
                connect.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(Query, connect);
                Adapter.FillSchema(ReportData, SchemaType.Source, tableName);
                Adapter.Fill(ReportData, tableName);
                connect.Close();
            }

            return ReportData;
        }
        public void InsertReport(int ReportID, int CorrectionID, string FaultDetected, DateTime date)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "INSERT INTO Reports(ReportID,CorrectionID,FaultDetected,DetectedDate) Value( '" + ReportID + "','" + CorrectionID + "','" + FaultDetected + "','" + date + ")";
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
        public void UpdateReports(int ReportID, int CorrectionID, string FaultDetected, DateTime date)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "UPDATE Reports SET CorrectionID ='" + CorrectionID + "',FaultDetected= '" + FaultDetected + "', date ='" + date + "' WHERE ReportID = '" + ReportID + "'";
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
        public void DeleteReports(int ReportID)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "DELETE FROM Reports WHERE ReportID ='" + ReportID + "'";
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

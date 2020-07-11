using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
     public class CorrectionDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        bool ErrorChecker = true;
        public CorrectionDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
        public DataSet ReadCorrections(string tableName)
        {
            try
            {
                DataSet CorrectionData = new DataSet();
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT * FROM {0}", tableName);
                    connect.Open();
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, connect);
                    Adapter.FillSchema(CorrectionData, SchemaType.Source, tableName);
                    Adapter.Fill(CorrectionData, tableName);
                    connect.Close();
                }

                return CorrectionData;
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }
        public void InsertCorrection(int CorrectionID, int OperationID, int ResidenceID, DateTime CorrectionDate)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "INSERT INTO Corrections(CorrectionID,OperationID,ResidenceID,CorrectionDate) Value( '" + CorrectionID + "','" + OperationID + "','" + ResidenceID + "','" + CorrectionDate + "')";
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                }
                catch (Exception )
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
        public void UpdateCorrection(int CorrectionID, int OperationID, int ResidenceID, DateTime CorrectionDate)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "UPDATE Corrections SET CorrectionID ='" + CorrectionID + "'OperationID ='" + OperationID + "', ResidenceID ='" + ResidenceID + "',CorrectionDate ='" + CorrectionDate + "' WHILE CorrectionID = '"+CorrectionID+"'";
                    SqlCommand command = new SqlCommand(Query, connect);
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

        public void DeleteCorrection(int CorrectionID)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "DELETE FROM Corrections WHERE CorrectionID ='" + CorrectionID + "'";
                    SqlCommand command = new SqlCommand(Query, connect);
                    command.ExecuteNonQuery();
                }
                catch (Exception )
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

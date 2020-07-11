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
    public class ProductDataHandler
    {
        public static DataTable dataTable = new DataTable();
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public static DataTable datatable = new DataTable();
        bool ErrorChecker = true;
        public ProductDataHandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
       

        public DataTable GetProducts(string tableName)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                DataTable ProductData = new DataTable();
                try
                {


                    Query = string.Format("SELECT * FROM {0}", tableName);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(ProductData);

                }


                catch (Exception)
                {
                    ErrorChecker = false;
                    throw;
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
                return ProductData;

            }
        }
        public DataTable FilterOrders(string tableName, string category)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                DataTable OrderDate = new DataTable();
                try
                {
                    Query = string.Format("SELECT * FROM {0} INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID WHERE CategoryType = '" + category + "'", tableName);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(OrderDate);

                }
                catch (Exception)
                {
                    ErrorChecker = false;
                    throw;
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
                return OrderDate;

            }
        }
        public DataSet ReadProducts(string tableName)
        {
            try
            {
                DataSet ProductData = new DataSet();
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT * FROM {0}", tableName);
                    connect.Open();
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, connect);
                    Adapter.FillSchema(ProductData, SchemaType.Source, tableName);
                    Adapter.Fill(ProductData, tableName);
                    connect.Close();
                }

                return ProductData;
            }
            catch (Exception)
            {
                ErrorChecker = false;
                throw;
            }
        }
       
        public void InsertProduct(string ProductID, string CategoryID, string ProductName, int AvailableQuantity, double Price, string description, string manufacturer, string model, string serialNumber)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("ProcInsertProducts", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@productID", ProductID);
                    command.Parameters.AddWithValue("@categoryID", CategoryID);
                    command.Parameters.AddWithValue("@productName", ProductName);
                    command.Parameters.AddWithValue("@availableQuantity", AvailableQuantity);
                    command.Parameters.AddWithValue("@price", Price);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@model", model);
                    command.Parameters.AddWithValue("@serialNumber", serialNumber);
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
        public void UpdateQuantity(string ProductName, int AvailableQuantity)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("UpdateQuantity", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@productName", ProductName);
                    command.Parameters.AddWithValue("@availableQuantity", AvailableQuantity);
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
        public void UpdateProduct(string ProductID, string ProductCategory, string ProductName, int AvailableQuantity, double Price, string description, string manufacturer, string model, string serialNumber)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("UpdateProducts", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@productID", ProductID);
                    command.Parameters.AddWithValue("@category", ProductCategory);
                    command.Parameters.AddWithValue("@productName", ProductName);
                    command.Parameters.AddWithValue("@availableQuantity", AvailableQuantity);
                    command.Parameters.AddWithValue("@price", Price);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@model", model);
                    command.Parameters.AddWithValue("@serialNumber", serialNumber);
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
        public void DeleteProduct(string ProductID)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                        try
                        {
                            connect.Open();
                            SqlCommand command = new SqlCommand("ProcDeleteProduct", connect);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@productID", ProductID);
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
    }
}

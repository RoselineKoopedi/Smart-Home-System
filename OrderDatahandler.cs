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
    public class OrderDatahandler
    {
        public static DataTable dataTable = new DataTable();
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;
        public static DataTable datatable = new DataTable();
        public OrderDatahandler()
        {
            connection.DataSource = "TAYLORKOOPS";
            connection.InitialCatalog = "SmartHomeSystemDatabase";
            connection.IntegratedSecurity = true;
        }
        public DataSet ReadProducts(string tableName)
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
        public DataTable GetOrders(string tableName)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                DataTable OrderDate = new DataTable();
                try
                {


                    Query = string.Format("SELECT * FROM {0}", tableName);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(OrderDate);

                }


                catch (Exception)
                {
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
        public DataTable SearchOrder(string tableName, int orderID)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                DataTable OrderDate = new DataTable();
                try
                {


                    Query = string.Format("SELECT * FROM {0} WHERE OrderID = '" + orderID + "'", tableName);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter Adapter = new SqlDataAdapter(command);
                    Adapter.Fill(OrderDate);

                }


                catch (Exception)
                {
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
        // Read client data from the database
        static DataTable Orderdatatable = new DataTable();
        public DataTable GetOrderClients(string tablename, string clientID)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection.ToString()))
                {
                    Query = string.Format("SELECT ProductID, ProductCategory, ProductName, OrderDate, Quantity, TotalPrice, ClientName, ClientSurname, PhoneNumber FROM {0} INNER JOIN Orders ON Clients.ClientID = Orders.ClientID   WHERE Orders.ClientID = '" + clientID + "'", tablename);
                    connect.Open();
                    SqlCommand command = new SqlCommand(Query, connect);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(Orderdatatable);
                    connect.Close();
                    return Orderdatatable;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void InsertOrder(int OrderID, string ClientID, string ProductID, string ProductCategory, string ProductName, DateTime OrderDate, int Quantity, double TotalPrice)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("ProcInsertOrder", connect);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@orderID", OrderID);
                    command.Parameters.AddWithValue("@clientID", ClientID);
                    command.Parameters.AddWithValue("@productID", ProductID);
                    command.Parameters.AddWithValue("@productCategoty", ProductCategory);
                    command.Parameters.AddWithValue("@productName", ProductName);
                    command.Parameters.AddWithValue("@orderDate", OrderDate);
                    command.Parameters.AddWithValue("@quantity", Quantity);
                    command.Parameters.AddWithValue("@totalPrice", TotalPrice);
                    command.Parameters.AddWithValue("@totalPaid", 0);
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
        public void UpdateOrder(int OrderID, string ClientID, string ProductID, string ProductCategory, string ProductName, DateTime OrderDate, int Quantity, double TotalPrice)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "UPDATE Orders SET ClientID= '" + ClientID + "',ProductID='" + ProductID + ", ProductCategory ='" + ProductCategory + "',ProductName='" + ProductName + ", OrderDate ='" + OrderDate + "',Quantity='" + Quantity + ", TotalPrice ='" + TotalPrice + "''WHERE OrderID = '" + OrderID + "'";
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
       
        public void DeleteOrder(int OrderID)
        {
            using (SqlConnection connect = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "DELETE FROM Orders WHERE OrderID ='" + OrderID + "'";
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

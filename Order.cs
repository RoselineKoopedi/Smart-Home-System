using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
     public class Order : Client
    {
        private int orderID;
        private int quantity;
        private double totalPrice;
        private DateTime orderDate;
        private double totalPaid;

        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }

            set
            {
                orderDate = value;
            }
        }

        public Order()
        {

        }
        public Order(string clientID, string clientName, string clientSurname, string phoneNumber,string email, string configurationOption, string billingStatus)
            :base(clientID, clientName, clientSurname, phoneNumber, email, configurationOption, billingStatus)
        {

        }
        public Order(int orderID, string ClientID, string productID, string productCategory, string productName,DateTime orderDate, int quantity, double totalPrice)
        {
            this.orderID = orderID;
            this.ClientID = ClientID;
            this.quantity = quantity;
            this.orderDate = orderDate;
        }
        public static DataTable dataT = new DataTable();
        public DataTable GetOrders()
        {
            OrderDatahandler Orderdata = new OrderDatahandler();
            dataT = Orderdata.GetOrders("Orders");
            return dataT;
        }
        //Method for searching for an order
        public static DataTable FilteredOrder = new DataTable();
        public DataTable FiltereOrder(int orderID)
        {
            OrderDatahandler OrderData = new OrderDatahandler();
            FilteredOrder = OrderData.SearchOrder("Orders", orderID);
            return FilteredOrder;
        }
        //Method for searching for a client order
        //Method for searching for a client Orders
        public static DataTable FilteredClientOrder = new DataTable();
        public DataTable FiltereClientOrders(string ClientID)
        {
            ClientDataHandler ClientHandler = new ClientDataHandler();

            try
            {
                OrderDatahandler clientData = new OrderDatahandler();
                FilteredClientOrder = clientData.GetOrderClients("Clients", ClientID);
                ClientHandler.ErrorChecker = true;
                return FilteredClientOrder;
            }
            catch (Exception)
            {
                ClientHandler.ErrorChecker = false;
                throw;
            }
        }


        public void InsertOrder(int OrderID, string ClientID, string ProductID, string ProductCategory, string ProductName, DateTime OrderDate, int Quantity, double TotalPrice)
        {
            new OrderDatahandler().InsertOrder( OrderID,  ClientID,  ProductID,  ProductCategory,  ProductName,  OrderDate,  Quantity,  TotalPrice);
        }
        public void UpdateOrder(int OrderID, string ClientID, string ProductID, string ProductCategory, string ProductName, DateTime OrderDate, int Quantity, double TotalPrice)
        {
            new OrderDatahandler().UpdateOrder(OrderID, ClientID, ProductID, ProductCategory, ProductName, OrderDate, Quantity, TotalPrice);
        }
        public void DeleteOrder(int OrderID)
        {
            new OrderDatahandler().DeleteOrder(OrderID);
        }
    }
}

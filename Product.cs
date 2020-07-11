using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Product : Category
    {

        private string productID;
        private string productName;
        private int availableQuantity;
        private double price;
        private string description;
        private string manufacturer;
        private string model;
        private string serialNumber;

        public string ProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }

        public int AvailableQuantity
        {
            get
            {
                return availableQuantity;
            }

            set
            {
                availableQuantity = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }

            set
            {
                serialNumber = value;
            }
        }

        public Product()
        {

        }
        public Product(string productID, string categoryID, string productName, int quantity, double Price, string description, string manufacturer, string model, string serialNumber)
        {
            this.ProductID = productID;
            this.CategoryID = categoryID;
            this.ProductName = productName;
            this.availableQuantity = quantity;
            this.price = Price;
            this.description = description;
            this.manufacturer = manufacturer;
            this.model = model;
            this.serialNumber = serialNumber;
        }
        public Product(string productID, string clientID, string cat, string productName)
        {
            this.ProductID = productID;
            this.CategoryID = cat;
            this.ProductName = productName;
        }
        public Product(string categoryID, string categoryType)
            : base(categoryID, categoryType)
        {

        }
        public static DataTable dataT = new DataTable();
        //Method of reading products accessed from the data access layer
        public DataTable GetProducts()
        {
            ProductDataHandler productdata = new ProductDataHandler();
            dataT = productdata.GetProducts("Products");
            return dataT;
        }

        public static DataTable FilteredData = new DataTable();
        public DataTable FilteredOrders(string category)
        {
            ProductDataHandler productdate = new ProductDataHandler();
            FilteredData = productdate.FilterOrders("Products", category);
            return FilteredData;
        }
        public List<Product> ProductsPrices()
        {
            List<Product> ReadProducts = new List<Product>();
            DataSet GetClients = new ProductDataHandler().ReadProducts("Products");
            foreach (DataRow item in GetClients.Tables["Products"].Rows)
            {
                ReadProducts.Add(new Product(item["ProductID"].ToString(), item["CategoryID"].ToString(), item["ProductName"].ToString(), int.Parse(item["AvailableQuantity"].ToString()), Double.Parse(item["Price"].ToString()), item["Description"].ToString(), item["Manufacturer"].ToString(), item["Model"].ToString(), item["SerialNumber"].ToString()));
            }
            return ReadProducts;
        }
        public List<Product> ReadingProducts()
        {
            List<Product> ReadProducts = new List<Product>();
            DataSet GetClients = new ProductDataHandler().ReadProducts("Products");
            foreach (DataRow item in GetClients.Tables["Products"].Rows)
            {
                ReadProducts.Add(new Product(item["ProductID"].ToString(), item["CategoryID"].ToString(), item["ProductName"].ToString(), int.Parse(item["AvailableQuantity"].ToString()), Double.Parse(item["Price"].ToString()), item["Description"].ToString(), item["Manufacturer"].ToString(), item["Model"].ToString(), item["SerialNumber"].ToString()));

            }
            return ReadProducts;
        }

        public void InsertProducts(string ProductID, string CategoryID, string ProductName, int AvailableQuantity, double Price, string description, string manufacturer, string model, string serialNumber)
        {
            try
            {

                new ProductDataHandler().InsertProduct(ProductID, CategoryID, ProductName, AvailableQuantity, Price, description, manufacturer, model, serialNumber);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateProducts(string ProductID, string CategoryID, string ProductName, int AvailableQuantity, double Price, string description, string manufacturer, string model, string serialNumber)
        {
            try
            {

                new ProductDataHandler().UpdateProduct(ProductID, CategoryID, ProductName, AvailableQuantity, Price, description, manufacturer, model, serialNumber);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateQuantity(string ProductName, int AvailableQuantity)
        {
            try
            {

                new ProductDataHandler().UpdateQuantity(ProductName, AvailableQuantity);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteProduct(string productID)
        {
            try
            {

                new ProductDataHandler().DeleteProduct(productID);

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthOnlineShop.Class
{
    public class Product
    {
        private string _name;
        private string _description;
        private string _unit;
        private double _price;
        private string _category;
        private string _imagePath;
        private int _quantity;//this will be use for prodcut inventory too

        public Product(string name, string description, string unit, double price, string category, string imagePath, int quantity)
        {
            _name = name;
            _description = description;
            _unit = unit;
            _price = price;
            _category = category;
            _imagePath = imagePath;
            _quantity = quantity;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Unit { get { return _unit; } set { _unit = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public string Category { get { return _category; } set { _category = value; } }
        public string ImagePath { get { return _imagePath; } set { _imagePath = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public override string ToString()
        {
            return $"{_name} ({_price} $/{_unit}): {_description}";
        }
        public Dictionary<string, object> ToDictionary()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();

            data.Add(StringDB.Products.FieldName, _name);
            data.Add(StringDB.Products.FieldDescription, _description);
            data.Add(StringDB.Products.FieldUnit, _unit);
            data.Add(StringDB.Products.FieldPrice, _price);
            data.Add(StringDB.Products.FieldCategory, _category);
            data.Add(StringDB.Products.FieldImagePath, _imagePath);
            data.Add(StringDB.Products.FieldQuantity, _quantity);

            return data;
        }
        
        public static Product createProduct(Dictionary<string, object> data)
        {
            string name = data[StringDB.Products.FieldName].ToString();
            string description = data[StringDB.Products.FieldDescription].ToString();
            string unit = data[StringDB.Products.FieldUnit].ToString();
            double price = Convert.ToDouble(data[StringDB.Products.FieldPrice]);
            string category = data[StringDB.Products.FieldCategory].ToString();
            string imagePath = data[StringDB.Products.FieldImagePath].ToString();
            int quantity = Convert.ToInt32(data[StringDB.Products.FieldQuantity]);

            return new Product(name, description, unit, price, category, imagePath, quantity);
        }
        // Use to update quantity for product db
        public static Dictionary<string, object> updateQuantity(int stockQuantity, int orderQuantity)
        {
            Dictionary<string, object> temp = new Dictionary<string, object>();

            temp[StringDB.Products.FieldQuantity] = stockQuantity - orderQuantity;

            return temp;
        }
    }
}

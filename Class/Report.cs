using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthOnlineShop.Class
{
    class Report
    {
        private List<OrderDocument> _orderDocuments;
        //this is to compile all order entry into one giant dictionary for easier handling
        private Dictionary<Product, int> _order;
        public double TotalSales { get; set; }
        public int TotalOrders { get; set; }
        public double AverageSalesPerOrder { get; set; }
        public int TotalUniqueCustomers { get; set; }
        public Dictionary<string, double> SalesPerCategory { get; set; }
        public List<KeyValuePair<Product, int>> Top3Quantity { get; set; }
        public List<KeyValuePair<Product, int>> Top3Sales { get; set; }
        public Report()
        {
            _orderDocuments = new List<OrderDocument>();
            _order = new Dictionary<Product, int>();
            SalesPerCategory = new Dictionary<string, double>();

            foreach (string productCategory in Enum.GetNames(typeof(ProductCategory)))
            {
                SalesPerCategory[productCategory] = 0;
            }

            Top3Quantity = new List<KeyValuePair<Product, int>>();
            Top3Sales = new List<KeyValuePair<Product, int>>();
        }
        public List<OrderDocument> OrderDocuments { get { return _orderDocuments; } set { _orderDocuments = value; } }
        //this is to compile all order entry into one giant dictionary for easier handling
        public void createOrder()
        {
            foreach (var orderDoc in _orderDocuments)
            {
                foreach (var orderItem in orderDoc.Order)
                {
                    Product product = orderItem.Key;
                    int quantity = orderItem.Value;

                    if (_order.ContainsKey(product))
                    {
                        // If the product already exists in the dictionary, increment the quantity
                        _order[product] += quantity;
                    }
                    else
                    {
                        // If the product doesn't exist in the dictionary, add a new entry
                        _order.Add(product, quantity);
                    }
                }
            }
        }

        public void calculateReport()
        {
            //Summary
            TotalSales = _orderDocuments.Sum(orderDoc => orderDoc.TotalCost);
            TotalOrders = _orderDocuments.Count();
            AverageSalesPerOrder = TotalSales / TotalOrders;
            //Breakdown
            foreach (string productCategory in Enum.GetNames(typeof(ProductCategory)))
            {
                SalesPerCategory[productCategory] += _order
                .Where(entry => entry.Key.Category == productCategory)
                .Sum(entry => entry.Key.Price * entry.Value);
            }

            Top3Quantity = _order.OrderByDescending(kv => kv.Value)
                                         .Take(3)
                                         .ToList();
            Top3Sales = _order.OrderByDescending(kv => kv.Key.Price * kv.Value)
                                      .Take(3)
                                      .ToList();
        }

        public void display()
        {
            Console.WriteLine("Sales Report");
            Console.WriteLine("------------");
            Console.WriteLine("Summary:");
            Console.WriteLine($"Total Sales: {this.TotalSales}");
            Console.WriteLine($"Total Orders: {this.TotalOrders}");
            Console.WriteLine("Breakdown:");
            Console.WriteLine();
            Console.WriteLine("Category Sales:");
            foreach (var category in SalesPerCategory)
            {
                Console.WriteLine($"{category.Key}: {category.Value}$");
            }
            Console.WriteLine();

            Console.WriteLine("Top Products by Revenue:");
            foreach (var kvp in Top3Sales)
            {
                Console.WriteLine($"{kvp.Key.Name}: {kvp.Key.Price* kvp.Value}$");
            }
            Console.WriteLine();

            Console.WriteLine("Top Products by Orders:");
            foreach (var kvp in Top3Quantity)
            {
                Console.WriteLine($"{kvp.Key.Name}: {kvp.Value} ordered");
            }
        }
    }
}

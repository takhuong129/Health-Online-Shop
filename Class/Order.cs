using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthOnlineShop.Class
{
    public class Order
    {
        //Dictionary cart, hold the product information and quantity
        private Dictionary<Product, int> _cart;

        public Order()
        {
            _cart = new Dictionary<Product, int>();
        }
        public Dictionary<Product, int> Cart { get { return _cart; } set { _cart = value; } }
        //add item to cart
        public void addToCart(Product product, int quantity)
        {
            if (_cart.ContainsKey(product))
            {
                if (_cart[product] + quantity <= product.Quantity)
                {
                    _cart[product] += quantity;
                }
                else
                {
                    _cart[product] = product.Quantity;
                }
            }
            else
            {
                _cart[product] = quantity;
            }
        }
        //only allow to reduce product quantiy to one
        public void reduceFromCart(Product product, int quantity)
        {
            if (_cart.ContainsKey(product))
            {
                if (_cart[product] - quantity >= 1)
                {
                    _cart[product] -= quantity;
                }
                else
                {
                    _cart[product] = 1;
                }
            }
        }
        //remove item from cart
        public void removeFromCart(Product product)
        {
            if (_cart.ContainsKey(product))
            {
                _cart.Remove(product);
            }
        }
        public double totalCost()
        {
            if (_cart.Count == 0)
            {
                return 0;
            }
            double total = 0;
            foreach (KeyValuePair<Product, int> item in _cart)
            {
                total += item.Key.Price * item.Value;
            }
            return total;
        }

        // test function
        //display every item from cart
        public void display()
        {
            if (_cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                foreach (KeyValuePair<Product, int> item in _cart)
                {
                    Console.WriteLine($"Product [{item.Key.ToString()}] | Amount: {item.Value}");
                }
                Console.WriteLine($"Total Cost: {this.totalCost()} $");
            }
        }
    }
}

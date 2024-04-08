using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthOnlineShop.Class
{
    public class OrderDocument
    {
        private Dictionary<Product, int> _order;
        private double _totalCost;   
        private Date _transactionDate;
        private string _paymentType;
        public OrderDocument(Dictionary<Product, int> order, double totalCost, Date transactionDate)
        {
            _order = order;
            _totalCost = totalCost;
            _transactionDate = transactionDate;
            _paymentType = null;
        }
        public string PaymentType { get { return _paymentType; } set { _paymentType = value; } }
        public Dictionary<Product, int> Order { get { return _order; } set { _order = value; } }
        public double TotalCost { get { return _totalCost; } }
        public Date TransactionDate { get { return _transactionDate; } }

        public string getCart()
        {
            // Create a string to hold the cart items information
            string cartInfo = $"Cart Items ({_order.Count}):\n";
            var order = _order;
            // Iterate over cartItems dictionary and append item names, quantities, and prices to the cartInfo string
            foreach (var item in order)
            {
                Product product = item.Key;
                cartInfo += $"{product.Name}: {item.Value.ToString()} x ${product.Price}\n";
            }
            cartInfo += $"\nTotal Price: ${_totalCost}";
            return cartInfo;
        }
        // return order as a dict of string and int
        public Dictionary<string, object> orderDict()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            foreach (var item in _order)
            {
                Product product = item.Key;
                data.Add(product.Name, item.Value);
            }
            return data;
        }

        // return order as a dict of string and int
        public Dictionary<string, int> stockDict()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            foreach (var item in _order)
            {
                Product product = item.Key;
                data.Add(product.Name, product.Quantity);
            }
            return data;
        }
        public Dictionary<string, object> dataDict()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();

            data[StringDB.History.FieldTransactionDate] = _transactionDate.ToString();
            data[StringDB.History.FieldPaymentType] = _paymentType;
            data[StringDB.History.FieldTotalCost] = _totalCost;
            data[StringDB.History.FieldOrders] = this.orderDict();

            return data;
        }
        //convert the orders field from only having name and total quantity into a dict with product key and quantity
        private static Dictionary<Product, int> createCart(Dictionary<string, object> orderDB, List<Product> products)
        {
            Dictionary<Product, int> data = new Dictionary<Product, int>();

            foreach (var item in orderDB)
            {
                string productName = item.Key;
                int quantity = Convert.ToInt32(item.Value);
                Product foundProduct = products.FirstOrDefault(product => product.Name == productName);
                data.Add(foundProduct, quantity);
            }

            return data;
        }
        public static OrderDocument createOrderDoc(Dictionary<string, object> dataDB, List<Product> products)
        {
            Date transactionDate = Date.strToDate(dataDB[StringDB.History.FieldTransactionDate].ToString());
            double totalCost = Convert.ToDouble(dataDB[StringDB.History.FieldTotalCost]);
            string paymentType = dataDB[StringDB.History.FieldPaymentType].ToString();
            Dictionary<Product, int> cart = new Dictionary<Product, int> ();
            if (dataDB[StringDB.History.FieldOrders] is Dictionary<string, object> orderDB)
            {
                cart = createCart(orderDB, products);
            }

            OrderDocument orderDocument = new OrderDocument(cart, totalCost, transactionDate);
            orderDocument.PaymentType = paymentType;

            return orderDocument;
        }
    }
}

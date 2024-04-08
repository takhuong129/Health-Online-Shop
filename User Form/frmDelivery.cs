using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using HealthOnlineShop.Class;
using System.Threading.Tasks;
using System.Linq;

namespace HealthOnlineShop
{
    public partial class frmDelivery : Form
    {
        private Firebase _firebase;
        private string _username;
        private List<OrderDocument> _orderDocuments;
        
        public frmDelivery(string username)
        {
            InitializeComponent();
            _username = username;
            _firebase = Firebase.Instance;

            this.LoadData();
            
        }

        private async Task<List<Product>> GetProducts()
        {
            // Get the list from database first
            List<Dictionary<string, object>> temp = await _firebase.GetDataFromCollection(StringDB.Products.CollectionName);
            // Convert it into a list of products
            List<Product> products = temp.Select(dict => Product.createProduct(dict)).ToList();

            return products;
        }
        private async Task<List<OrderDocument>> GetOrderDocuments(List<Product> products)
        {
            List<Dictionary<string, object>> temp = await _firebase.GetSubcollectionDataFromDocument(StringDB.Users.CollectionName,
                StringDB.Users.FieldUsername, _username, StringDB.History.CollectionName);

            List<OrderDocument> orderDocuments = temp.Select(dict => OrderDocument.createOrderDoc(dict, products)).ToList();

            return orderDocuments;
        }

        private async void LoadData()
        {
            List<Product> products = await GetProducts();
            // if success
            if (products.Count > 0)
            {
                List<OrderDocument> orderDocuments = await GetOrderDocuments(products);

                _orderDocuments = orderDocuments;

                OrderUpdate();
            }
        }
        public void ResetDelivery()
        {
            deliveryTable.Controls.Clear();
            deliveryTable.ColumnStyles.Clear();
            deliveryTable.RowStyles.Clear();
            LoadData();
        }
        // Example usage:
        private void OrderUpdate()
        {
            // Clear existing controls in the table
            deliveryTable.Controls.Clear();
            deliveryTable.ColumnStyles.Clear();
            deliveryTable.RowStyles.Clear();



            // Set up table layout
            deliveryTable.ColumnCount = 4; // Purchase Date, Payment Method, Total Price, View Details
            deliveryTable.RowCount = _orderDocuments.Count + 1; // +1 for header row
            deliveryTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            deliveryTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            deliveryTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            deliveryTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            // Add headers
            deliveryTable.Controls.Add(new Label() { Text = "Purcharse Date", Font = new Font("Segoe UI", 12, FontStyle.Bold) }, 0, 0);
            deliveryTable.Controls.Add(new Label() { Text = "Payment Method", Font = new Font("Segoe UI", 12, FontStyle.Bold) }, 1, 0);
            deliveryTable.Controls.Add(new Label() { Text = "Total Price", Font = new Font("Segoe UI", 12, FontStyle.Bold) }, 2, 0);
            deliveryTable.Controls.Add(new Label() { Text = "Details", Font = new Font("Segoe UI", 12, FontStyle.Bold) }, 3, 0);

            // Add data rows
            for (int i = 0; i < _orderDocuments.Count; i++)
            {
                OrderDocument orderDocument = _orderDocuments[i];
                deliveryTable.Controls.Add(new Label() { Text = orderDocument.TransactionDate.ToString() }, 0, i + 1);
                deliveryTable.Controls.Add(new Label() { Text = orderDocument.PaymentType }, 1, i + 1);
                deliveryTable.Controls.Add(new Label() { Text = "$" + orderDocument.TotalCost.ToString() }, 2, i + 1);

                Button btnViewDetails = new Button() { Text = "Order", Tag = orderDocument };
                btnViewDetails.Click += (sender, e) => ViewDetails((OrderDocument)((Button)sender).Tag);
                deliveryTable.Controls.Add(btnViewDetails, 3, i + 1);
            }

            // Set table size
            deliveryTable.AutoScroll = true;
            //deliveryTable.Dock = DockStyle.Fill;
        }
        // fetch details order
        private void ViewDetails(OrderDocument orderDocument)
        {
            string details = "Items:\n";
            foreach (var item in orderDocument.Order)
            {
                Product product = item.Key;
                details += $"{product.Name} - Price: ${product.Price}, Quantity: {item.Value}\n";
            }
            MessageBox.Show($"Date: {orderDocument.TransactionDate.ToString()}\n Payment Method: {orderDocument.PaymentType}\n Total Price: ${orderDocument.TotalCost}\n\n{details}");
        }
    }
}

using HealthOnlineShop.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HealthOnlineShop.Class.StringDB;

namespace HealthOnlineShop
{
    public partial class frmReport : Form
    {
        private Report _report;
        private Firebase _firebase;
        public frmReport()
        {
            InitializeComponent();
            _firebase = Firebase.Instance;
            _report = new Report();
            LoadData();
            //using txbTO.text = value for total order
            //using txbTS.text = value for total sales
        }
        private async Task<List<Product>> GetProducts()
        {
            // Get the list from database first
            List<Dictionary<string, object>> temp = await _firebase.GetDataFromCollection(StringDB.Products.CollectionName);
            // Convert it into a list of products
            List<Product> products = temp.Select(dict => Product.createProduct(dict)).ToList();

            return products;
        }
        private async Task<List<OrderDocument>> GetAllHistory(List<Product> products)
        {
            List<Dictionary<string, object>> temp = await _firebase.GetSubcollectionDocumentFromCollection(
                StringDB.Users.CollectionName, StringDB.History.CollectionName);

            List<OrderDocument> orderDocuments = temp.Select(dict => OrderDocument.createOrderDoc(dict, products)).ToList();

            return orderDocuments;
        }
        private async void LoadData()
        {
            List<Product> products = await GetProducts();
            // if success
            if (products.Count > 0)
            {
                List<OrderDocument> orderDocuments = await GetAllHistory(products);

                _report.OrderDocuments = orderDocuments;
                _report.createOrder();
                _report.calculateReport();

                foreach (OrderDocument orderDocument in _report.OrderDocuments)
                {
                    AddDataToTable(orderDocument);
                }
                txbTO.Text = _report.TotalOrders.ToString();
                txbTS.Text = $"${_report.TotalSales}";
            }
        }
        private void AddDataToTable(OrderDocument orderDocument)
        {
            foreach (var item in orderDocument.Order)
            {
                Product product = item.Key;
                double total = product.Price * Convert.ToDouble(item.Value);
                reportTable.Rows.Add(orderDocument.TransactionDate, product.Name, product.Category, item.Value, $"${total}");
            }
            
        }
        // filter for the report
        private void dpPeriod_ValueChanged_1(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dpPeriod.Value.Date;

            // Filter the rows based on the selected month and year
            foreach (DataGridViewRow row in reportTable.Rows)
            {
                if (!row.IsNewRow) // Exclude the new row if any
                {
                    DateTime rowDate;
                    if (DateTime.TryParseExact(row.Cells[0].Value.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out rowDate))
                    {
                        // Extract month and year from the selected date and the row's date
                        int selectedMonth = selectedDate.Month;
                        int selectedYear = selectedDate.Year;
                        int rowMonth = rowDate.Month;
                        int rowYear = rowDate.Year;

                        // Compare the month and year
                        if (selectedMonth == rowMonth && selectedYear == rowYear)
                        {
                            row.Visible = true; // Show rows that match the selected month and year
                        }
                        else
                        {
                            row.Visible = false; // Hide rows that don't match the selected month and year
                        }
                    }
                    else
                    {
                        // Handle invalid date format
                    }
                }
            }
        }

        private void reportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}

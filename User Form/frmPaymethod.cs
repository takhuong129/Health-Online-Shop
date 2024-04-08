using HealthOnlineShop.Class;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthOnlineShop
{
    public partial class frmPaymethod : Form
    {
        bool selected = false;
        public Order _order;
        private double _totalPrice = 0;
        private OrderDocument _orderDocument;
        // return a dictionary of product string key and the quantity order
        private Dictionary<string, object> _orderDict;
        // return a dictionary of product string key and the stock that product currently have
        private Dictionary<string, int> _stockDict;
        // return as db data
        private Dictionary<string, object> _dataDict;
        private string _username;
        private PaymentType _paymentType;
        private Firebase _firebase;
        public frmPaymethod(OrderDocument orderDocument, string username)
        {
            InitializeComponent();
            _orderDocument = orderDocument;// store totalPrice
            _username = username;
            
            _firebase = Firebase.Instance;

            _orderDict = _orderDocument.orderDict();
            _stockDict = _orderDocument.stockDict();
            _dataDict = _orderDocument.dataDict();
            ControlBox = false;
            foreach (var button in new[] { btnCredit, btnDW, btnCOD, btnPayment })
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
            PrintCartItems();
        }
        private void PrintCartItems()
        {
            // Display cart items information in a MessageBox
            MessageBox.Show(_orderDocument.getCart(), $"Cart Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void btnCredit_Click(object sender, EventArgs e)
        {
            txtChoice.Text = $"You have chosen to pay with a Credit Card.";
            selected = true;
            _paymentType = PaymentType.CreditCard;
        }

        private void btnDW_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "You have chosen to pay with a Digital Wallet.";
            selected = true;
            _paymentType = PaymentType.DigitalWallet;
        }

        private void btnCOD_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "You have chosen to pay with COD.";
            selected = true;
            _paymentType = PaymentType.CashOnDelivery;
        }

        private async Task<bool> UpdateQuantity(string product, int stockQuantity, int orderQuantity)
        {
            bool test = await _firebase.UpdateDataToCollection(StringDB.Products.CollectionName,
                            StringDB.Products.FieldName, product, Product.updateQuantity(stockQuantity, orderQuantity));
            if (test)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void ResetProductForm()
        {
            frmProduct productForm = Application.OpenForms.OfType<frmProduct>().FirstOrDefault();

            // Check if the product form exists
            if (productForm != null)
            {
                // Call the LoadProducts method
                productForm.ResetProducts();
            }
        }
        private void ResetDeliverytForm()
        {
            frmDelivery deliveryForm = Application.OpenForms.OfType<frmDelivery>().FirstOrDefault();

            // Check if the product form exists
            if (deliveryForm != null)
            {
                // Call the LoadProducts method
                deliveryForm.ResetDelivery();
            }
        }

        private async void btnPayment_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                MessageBox.Show("Please select payment method.");
            }
            else
            {
                _dataDict[StringDB.History.FieldPaymentType] = _paymentType.ToString();
                bool addHistory = await _firebase.AddDataToSubcollection(StringDB.Users.CollectionName,
                    StringDB.Users.FieldUsername, _username, StringDB.History.CollectionName, _dataDict);

                if (addHistory)
                {
                    foreach (var item in _orderDict)
                    {
                        string product = item.Key;

                        await UpdateQuantity(product, _stockDict[product], Convert.ToInt32(item.Value));
                    }
                    MessageBox.Show("Payment completed succesfully");

                    // Reset the product forms as well as the history form
                    // not sure why it is not working for history
                    ResetProductForm();
                    ResetDeliverytForm();
                }
                else
                {
                    MessageBox.Show("Payment fail");
                }

                this.Close();
            }
        }
        private void testData()
        {
            _orderDocument.PaymentType = _paymentType.ToString();
            MessageBox.Show(_orderDict.Count.ToString());
            Dictionary<string, object> data = _dataDict;
            string st = "test: \n";
            st += $"Transaction Date: {data[StringDB.History.FieldTransactionDate]}\n";
            st += $"Cost: {data[StringDB.History.FieldTotalCost].ToString()}\n";
            st += $"Payment Type: {data[StringDB.History.FieldPaymentType]}\n";
            st += "Orders: \n\n";
            if (data[StringDB.History.FieldOrders] is Dictionary<string, object> nest)
            {
                foreach (var nes in nest)
                {
                    st += $"{nes.Key}: {nes.Value}\n";
                }
            }
            MessageBox.Show(st);
        }
    }
}

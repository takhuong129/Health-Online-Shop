using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthOnlineShop.Class;

namespace HealthOnlineShop
{
    public partial class frmCart : Form
    {
        private Order _order;
        private string _username;
        public frmCart(string username)
        {
            _order = new Order();
            _username = username;
            InitializeComponent();
            ControlBox = false;
        }
        public void AddItem(Product product)
        {
            _order.addToCart(product, 1);
            UpdateCartUI();
        }
        public void ReduceItem(Product product)
        {
            _order.reduceFromCart(product, 1);
            UpdateCartUI();
        }
        private void UpdateCartUI()
        {
            // Clear existing panels
            cartLayout.Controls.Clear();
            int yPosition = 0; // Initial Y position for panels

            // Add panels for each item in the cart
            foreach (var item in _order.Cart)
            {
                Product product = item.Key;
                // Create panel for item
                Panel itemPanel = new Panel();
                itemPanel.BorderStyle = BorderStyle.FixedSingle; // Optional: Add border for visual separation
                itemPanel.Size = new Size(cartLayout.Width, 60); // Set panel size
                itemPanel.Location = new Point(0, yPosition);
                itemPanel.BackColor = Color.LightGreen;
                cartLayout.Controls.Add(itemPanel);

                // Create label for name
                Label nameLabel = new Label();
                nameLabel.Text = product.Name;
                nameLabel.AutoSize = true;
                nameLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                nameLabel.Location = new Point(28, 10);
                itemPanel.Controls.Add(nameLabel);

                // Create label for quantity
                Label quantityLabel = new Label();
                quantityLabel.Text =  item.Value.ToString();
                quantityLabel.AutoSize = true;
                quantityLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                quantityLabel.Location = new Point(178, 10); // Adjust position
                itemPanel.Controls.Add(quantityLabel);

                // Create label for price
                Label priceLabel = new Label();
                priceLabel.Text = "$" + product.Price.ToString();
                priceLabel.AutoSize = true;
                priceLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                priceLabel.Location = new Point(278, 10); // Adjust position
                itemPanel.Controls.Add(priceLabel);
                // Create label for delete
                Label plusLabel = new Label();
                plusLabel.Text = "+";
                plusLabel.AutoSize = true;
                plusLabel.ForeColor = Color.White; // Optional: Change color to indicate deletion action
                plusLabel.Cursor = Cursors.Hand; // Optional: Change cursor to hand when hovering over label
                plusLabel.Location = new Point(350, 10); // Adjust position
                plusLabel.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Set font to Segoe UI, size 11, bold
                plusLabel.Click += (sender, e) => AddItem(product); // Attach click event handler
                itemPanel.Controls.Add(plusLabel);
                // Create label for delete
                Label minusLabel = new Label();
                minusLabel.Text = "-";
                minusLabel.AutoSize = true;
                minusLabel.ForeColor = Color.White; // Optional: Change color to indicate deletion action
                minusLabel.Cursor = Cursors.Hand; // Optional: Change cursor to hand when hovering over label
                minusLabel.Location = new Point(375, 10); // Adjust position
                minusLabel.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Set font to Segoe UI, size 11, bold
                minusLabel.Click += (sender, e) => ReduceItem(product); // Attach click event handler
                itemPanel.Controls.Add(minusLabel);
                // Create label for delete
                Label deleteLabel = new Label();
                deleteLabel.Text = "Delete";
                deleteLabel.AutoSize = true;
                deleteLabel.ForeColor = Color.Red; // Optional: Change color to indicate deletion action
                deleteLabel.Cursor = Cursors.Hand; // Optional: Change cursor to hand when hovering over label
                deleteLabel.Location = new Point(400, 10); // Adjust position
                deleteLabel.Font = new Font("Segoe UI", 11, FontStyle.Bold); // Set font to Segoe UI, size 11, bold
                deleteLabel.Click += (sender, e) => DeleteItemFromCart(product); // Attach click event handler
                itemPanel.Controls.Add(deleteLabel);

                // Adjust Y position for next panel
                yPosition += 65; // Adjust as needed
            }
            // Display total price
            double totalPrice = CalculateTotalPrice();
            txtTotalPrice.Text = "$"+totalPrice.ToString();

        }

        private void DeleteItemFromCart(Product product)
        {
            _order.removeFromCart(product);
            UpdateCartUI(); // Update the UI after deleting the item
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            _order.Cart.Clear(); // Clear all items from the cart
            UpdateCartUI(); // Update the cart UI
        }

        private double CalculateTotalPrice()
        {
            return _order.totalCost();
        }
        // Navigate to Paymethod form
        private void btnPay_Click(object sender, EventArgs e)
        {
            if(_order.Cart.Count > 0)
            {
                this.Hide();
                // create new form and sending data to payment method
                frmPaymethod paymethod = new frmPaymethod(new OrderDocument(_order.Cart, CalculateTotalPrice(), Date.Today), _username);
                paymethod.Show();
                _order.Cart.Clear(); // Clear all items from the cart
                UpdateCartUI(); // Update the cart UI
            }
            else
            {
                MessageBox.Show("You must add an item to the cart first.");
            }
            
        }

    }
}

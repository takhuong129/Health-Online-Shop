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

namespace HealthOnlineShop
{
    public partial class frmInventory : Form
    {
        Firebase _firebase;
        List<Product> _products;
        public class Item
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public string Description { get; set; }
        }
        private frmEdit editForm;
        public frmInventory()
        {
            InitializeComponent();
            _firebase = Firebase.Instance;
            LoadInventory();
        }
        private async Task<List<Product>> GetProducts()
        {
            // Get the list from database first
            List<Dictionary<string, object>> temp = await _firebase.GetDataFromCollection(StringDB.Products.CollectionName);
            // Convert it into a list of products
            List<Product> products = temp.Select(dict => Product.createProduct(dict)).ToList();

            return products;
        }
        private async void LoadInventory()
        {
            inventoryPanel.Controls.Clear();

            List<Product> products = await GetProducts();

            _products = products;

            DisplayInventory(SearchProducts(""));
        }

        // Display item
        private List<Product> SearchProducts(string searchQuery)
        {
            List<Product> products = _products;
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return products;
            }

            var filteredList = products.Where(product =>
            product.Name.ToLower().Contains(searchQuery) 
            || product.Category.ToLower().Contains(searchQuery)).ToList();

            return filteredList;
        }
        private void DisplayInventory(List<Product> products)
        {
            inventoryPanel.Controls.Clear();
            foreach (Product product in products)
            {
                Panel itemPanel = new Panel();
                itemPanel.BackColor = Color.LightBlue;
                itemPanel.Margin = new Padding(5);
                itemPanel.Size = new Size(200, 120); // Increased height to accommodate the button

                Label nameLabel = new Label();
                nameLabel.Text = product.Name;
                nameLabel.AutoSize = true;
                nameLabel.Location = new Point(10, 10);

                Label categoryLabel = new Label(); // Adding category label
                categoryLabel.Text = "Category: " + product.Category;
                categoryLabel.AutoSize = true;
                categoryLabel.Location = new Point(10, 30);

                Label priceLabel = new Label();
                priceLabel.Text = "$" + product.Price.ToString();
                priceLabel.AutoSize = true;
                priceLabel.Location = new Point(10, 50);

                Label quantityLabel = new Label();
                quantityLabel.Text = "Quantity: " + product.Quantity.ToString();
                quantityLabel.AutoSize = true;
                quantityLabel.Location = new Point(10, 70);

                Label descriptionLabel = new Label();
                descriptionLabel.Text = "Description: " + product.Description;
                descriptionLabel.AutoSize = true;
                descriptionLabel.Location = new Point(10, 90);

                Button editButton = new Button(); // Adding button for editing
                editButton.Text = "Edit";
                editButton.Location = new Point(120, 10);
                editButton.BackColor = Color.LightGreen;
                editButton.FlatStyle = FlatStyle.Flat;
                editButton.FlatAppearance.BorderSize = 0;
                editButton.Tag = product; // Attaching item data to the button
                editButton.Click += EditButtonClick; // Adding event handler

                Button deleteButton = new Button(); // Adding button for deleting
                deleteButton.Text = "Delete";
                deleteButton.Location = new Point(120, 40); // Adjust position
                deleteButton.BackColor = Color.LightSalmon; // Choose color
                deleteButton.FlatStyle = FlatStyle.Flat;
                deleteButton.FlatAppearance.BorderSize = 0;
                deleteButton.Tag = product; // Attaching item data to the button
                deleteButton.Click += DeleteButtonClick; // Adding event handler

                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(categoryLabel);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(quantityLabel);
                itemPanel.Controls.Add(descriptionLabel);
                itemPanel.Controls.Add(editButton); // Adding the button to the panel
                itemPanel.Controls.Add(deleteButton); // Adding the delete button to the panel
                inventoryPanel.Controls.Add(itemPanel);
            }
        }
        // Event handler for the edit button click
        private void EditButtonClick(object sender, EventArgs e)
        {

            // Get the button that triggered the event
            Button editButton = sender as Button;

            // Check if the button and its tag are not null
            if (editButton != null && editButton.Tag is Product)
            {
                // Get the product object from the Tag property
                Product product = editButton.Tag as Product;

                if(editForm ==null || editForm.IsDisposed)
                {
                    editForm = new frmEdit(product);
                    editForm.Show(); // Show the frmEdit form
                    editForm.FormClosed += EditForm_FormClosed; // Subscribe to FormClosed event
                }
                else
                {
                    MessageBox.Show("Please close current edit window");
                }
               
            }
        }
        // Event handler for when frmEdit form is closed
        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (editForm.isUpdated) // Check if the item is updated
            {
                MessageBox.Show("Updated");
                LoadInventory(); // Reload inventory
                editForm = null; // Reset the edit form instance
               
            }
        }
        // Event handler for the delete button click
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            // Get the button that triggered the event
            Button deleteButton = sender as Button;

            // Check if the button and its tag are not null
            if (deleteButton != null && deleteButton.Tag is Item)
            {
                // Get the Item object from the Tag property
                Item item = deleteButton.Tag as Item;
                inventoryPanel.Controls.Remove(deleteButton.Parent); // Remove the panel containing the item
            }
        }
        private void txbSearching_TextChanged(object sender, EventArgs e)
        {
            string query = txbSearching.Text.ToLower();
            DisplayInventory(SearchProducts(query));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open frmEdit form in add mode
            frmEdit addItemForm = new frmEdit(null); // Pass null to indicate add mode
            addItemForm.FormClosed += AddItemForm_FormClosed; // Subscribe to FormClosed event
            addItemForm.Show();
        }
        private void AddItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEdit addItemForm = sender as frmEdit;
            if (addItemForm != null && addItemForm.isUpdated) // Check if a new item is added
            {
                MessageBox.Show("New item added");
                LoadInventory(); // Reload inventory to display the new item
            }
        }
    }
}

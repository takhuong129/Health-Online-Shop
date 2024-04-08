using HealthOnlineShop.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthOnlineShop
{
    public partial class frmProduct : Form
    {
        private Firebase _firebase;
        private frmCart shoppingCart;
        private string _username;

        public frmProduct(string username)
        {
            InitializeComponent();
            _firebase = Firebase.Instance;
            _username = username;

            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.FlatAppearance.BorderSize = 0;

            LoadProducts();

            txbSearching.TextChanged += txbSearching_TextChanged;
            PopulateCategory();
            if (shoppingCart == null || shoppingCart.IsDisposed)
            {
                // Create the shopping cart form
                shoppingCart = new frmCart(_username);

                // Calculate the position to place the shopping cart form
                Point buttonLocation = btnCart.PointToScreen(Point.Empty);
                int x = buttonLocation.X + btnCart.Width;
                int y = buttonLocation.Y;

                // Set the position of the shopping cart form
                shoppingCart.StartPosition = FormStartPosition.Manual;
                shoppingCart.Location = new Point(x + 300, y);

                // Show the shopping cart form
                shoppingCart.Show();
            }
            
        }
        private void DisplayItems()
        {
            int margin = 25;
            const int itemsPerRow = 4;
            itemLayout.FlowDirection = FlowDirection.LeftToRight;
            itemLayout.WrapContents = true;

            foreach (ucItems itemControl in itemLayout.Controls)
            {
                itemControl.Margin = new Padding(margin);
                itemControl.onSelect += ItemControl_onSelect; 
                itemLayout.SetFlowBreak(itemControl, itemLayout.Controls.IndexOf(itemControl) % itemsPerRow == itemsPerRow - 1);
            }
        }
        // Adding item to into layout
        public void AddItems(Product product)
        {
            itemLayout.Controls.Add(new ucItems()
            {
                PName = product.Name,
                PPrice = product.Price,
                Category = product.Category,
                PImage = Image.FromFile("Image/" + product.ImagePath),
                Description = product.Description,
                Product = product
            });
        }
        private async Task<List<Product>> GetProducts()
        {
            // Get the list from database first
            List<Dictionary<string, object>> temp = await _firebase.GetDataFromCollection(StringDB.Products.CollectionName);
            // Convert it into a list of products
            List<Product> products = temp.Select(dict => Product.createProduct(dict)).ToList();

            return products;
        }
        private async void LoadProducts()
        {
            List<Product> products = await GetProducts();

            foreach (Product product in products)
            {
                if (product.Quantity > 0 )
                {
                    AddItems(product);
                }
            }
            DisplayItems();
        }
        // Searching bar
        private void txbSearching_TextChanged(object sender, EventArgs e)
        {
            string searchText = txbSearching.Text.ToLower();

            int visibleItemCount = 0;
            foreach (ucItems itemControl in itemLayout.Controls)
            {
                bool isVisible = itemControl.PName.ToLower().Contains(searchText);
                itemControl.Visible = isVisible;

                if (isVisible)
                    visibleItemCount++;
            }

            // Adjust layout to maintain 4 columns
            AdjustLayout(visibleItemCount);
        }
        public void ResetProducts()
        {
            itemLayout.Controls.Clear();
            this.LoadProducts();
        }

        private void ItemControl_onSelect(object sender, EventArgs e)
        {
            ucItems itemControl = (ucItems)sender;
            MessageBox.Show($"{itemControl.Product.Name} have been add to cart");
            shoppingCart.AddItem(itemControl.Product);
            shoppingCart.Show();
        }

        //Catalog Enum
        private void PopulateCategory()
        {
            listCatalog.Items.Add("All");
            foreach (ProductCategory enumValue in Enum.GetValues(typeof(ProductCategory)))
            {
                listCatalog.Items.Add(enumValue.ToString());
            }
            listCatalog.SelectedIndex = 0;

        }
        //Catalog Filter
        private void listCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = listCatalog.SelectedItem.ToString();

            int visibleItemCount = 0;
            foreach (ucItems itemControl in itemLayout.Controls)
            {
                if (itemControl.Category.ToString() == selectedCategory || selectedCategory == "All")
                {
                    itemControl.Visible = true;
                    visibleItemCount++;
                }
                else
                {
                    itemControl.Visible = false;
                }
            }

            // Adjust layout to maintain 4 columns
            AdjustLayout(visibleItemCount);
        }

        // Adjust layout to maintain 4 columns
        private void AdjustLayout(int visibleItemCount)
        {
            const int itemsPerRow = 4;
            int currentItemCount = 0;

            foreach (Control control in itemLayout.Controls)
            {
                ucItems itemControl = control as ucItems;
                if (itemControl != null && itemControl.Visible)
                {
                    currentItemCount++;
                    if (currentItemCount % itemsPerRow == 0 && currentItemCount < visibleItemCount)
                    {
                        // Break line after every 4th visible item
                        itemLayout.SetFlowBreak(itemControl, true);
                    }
                    else
                    {
                        itemLayout.SetFlowBreak(itemControl, false);
                    }
                }
            }
        }
        // HideShow Cart
        private void btnCart_Click(object sender, EventArgs e)
        {
            if (shoppingCart.Visible)
            {
                shoppingCart.Hide();
            }
            else
            {
                shoppingCart.Show();
            }
        }
        // Closing Shopping Cart
        public void DeleteShoppingCart(bool check)
        {
            if (check)
            {
                shoppingCart.Close();
            }
        }

    }
}

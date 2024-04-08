using Google.Type;
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
    public partial class frmEdit : Form
    {
        private Product _product;
        private Firebase _firebase;
        private bool isEditMode;
        public bool isUpdated = false;
        public frmEdit(Product product)
        {
            InitializeComponent();
            _product = product;
            _firebase = Firebase.Instance;
            PopulateCategory();
            txbPrice.KeyPress += txbPrice_KeyPress;
            txbQuantity.KeyPress += txbQuantity_KeyPress;
            if (_product != null)
            {
                // If itemData is provided, it's in edit mode
                isEditMode = true;
                PopulateFields();
                txbName.ReadOnly = true;
                txbName.Cursor = Cursors.Arrow;
            }
            else
            {
                // If itemData is null, it's in add mode
                isEditMode = false;
                ClearFields(); // Clear fields for adding new data
                txbName.ReadOnly = false;
                txbName.Cursor = Cursors.Default;
            }
        }
        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PopulateCategory()
        {
            foreach (ProductCategory enumValue in Enum.GetValues(typeof(ProductCategory)))
            {
                listCategory.Items.Add(enumValue.ToString());
            }
            listCategory.SelectedIndex = 0;

        }
        private void PopulateFields()
        {
            ProductCategory category = (ProductCategory)Enum.Parse(typeof(ProductCategory), _product.Category);

            txbName.Text = _product.Name;
            listCategory.SelectedIndex = Convert.ToInt32(category);
            txbPrice.Text = _product.Price.ToString();
            txbUnit.Text = _product.Unit;
            txbQuantity.Text = _product.Quantity.ToString();
            txbDesc.Text = _product.Description;
            txbImagePath.Text = _product.ImagePath;
        }
        private void ClearFields()
        {
            txbName.Text = "";
            listCategory.SelectedIndex = 0;
            txbPrice.Text = "";
            txbUnit.Text = "";
            txbQuantity.Text = "";
            txbDesc.Text = "";
            txbImagePath.Text = "";
        }
        // simple validation of white space
        private bool validateNewProduct()
        {
            return !(txbName.Text == ""
                || txbPrice.Text == ""
                || txbUnit.Text == ""
                || txbQuantity.Text == ""
                || txbDesc.Text == ""
                || txbImagePath.Text == "");
        }
        private async Task<bool> updateProduct()
        {
            string name = _product.Name;
            string description = txbDesc.Text;
            double price = Convert.ToDouble(txbPrice.Text);
            string unit = txbUnit.Text;
            string category = listCategory.SelectedItem.ToString();
            string imagePath = txbImagePath.Text;
            int quantity = Convert.ToInt32(txbQuantity.Text);

            Product updateProduct = new Product(name, description, unit, price, category, imagePath, quantity);
            bool update = await _firebase.UpdateDataToCollection(StringDB.Products.CollectionName,
                StringDB.Products.FieldName, _product.Name, updateProduct.ToDictionary());
            return update;
        }
        private async Task<bool> addNewProduct()
        {
            string name = txbName.Text;
            string description = txbDesc.Text;
            double price = Convert.ToDouble(txbPrice.Text);
            string unit = txbUnit.Text;
            string category = listCategory.SelectedItem.ToString();
            string imagePath = txbImagePath.Text;
            int quantity = Convert.ToInt32(txbQuantity.Text);

            Product newProduct = new Product(name, description, unit, price, category, imagePath, quantity);
            await _firebase.AddDataToCollection(StringDB.Products.CollectionName, newProduct.ToDictionary());
            return true;
        }
        private async void btnSaveItem_Click(object sender, EventArgs e)
        {
            //Update to database
            if (isEditMode)
            {
                bool update = await updateProduct();
                if (update)
                {
                    MessageBox.Show("Update product successfully");
                }
            }
            else
            {
                bool validateProduct = validateNewProduct();
                if (!validateProduct)
                {
                    MessageBox.Show("New Product is missing information");
                    return;
                }
                bool add = await addNewProduct();
                if (add)
                {
                    MessageBox.Show("Create new product successfully");
                }
            }
            isUpdated = true;
            this.Close();
        }

    }
}

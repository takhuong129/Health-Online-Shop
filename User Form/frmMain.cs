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
    public partial class frmMain : Form
    {
        private AccountCustomer _customer;
        private Firebase _firebase;
        private frmProduct productForm;
        private frmDelivery deliveryForm;
        private frmAccount accountForm;
        public frmMain(AccountCustomer customer)
        {
            InitializeComponent();
            _customer = customer;
            _firebase = Firebase.Instance;
            foreach (var button in new[] { btnProduct, btnAccount, btnDelivery, btnLogout })
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
            //AddControll(new frmProduct());
            // Create instances of all forms
            productForm = new frmProduct(_customer.Username);
            deliveryForm = new frmDelivery(_customer.Username);
            accountForm = new frmAccount(_customer);

            // Hide all forms initially
            productForm.Hide();
            deliveryForm.Hide();
            accountForm.Hide();

            AddControll(productForm);
        }

        public void AddControll(Form f)
        {
            ControlPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlPanel.Controls.Add(f);
            f.Show();
            
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControll(productForm); // Show the product form
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            AddControll(deliveryForm); // Show the delivery form
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AddControll(accountForm); // Show the account form
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            productForm.DeleteShoppingCart(true);
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.FormClosed += (s, args) => this.Close(); // Close the application when the login form is closed
            loginForm.Show();
        }
    }
}

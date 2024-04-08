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
    public partial class frmMainOwner : Form
    {
        private AccountAdmin _admin;
        private Firebase _firebase;
        private frmAccount accountForm;
        private frmInventory inventoryForm;
        private frmReport reportForm;
        public frmMainOwner(AccountAdmin admin)
        {
            InitializeComponent();
            _admin = admin;
            _firebase = Firebase.Instance;
            foreach (var button in new[] { btnInventory, btnAccount, btnReport, btnLogout })
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }

            accountForm = new frmAccount(_admin);
            inventoryForm = new frmInventory();
            reportForm = new frmReport();

            accountForm.Hide();
            inventoryForm.Hide();
            reportForm.Hide();

            AddControll(inventoryForm);
        }

        public void AddControll(Form f)
        {
            ControlPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlPanel.Controls.Add(f);
            f.Show();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AddControll(reportForm);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            AddControll(inventoryForm);
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            AddControll(accountForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.FormClosed += (s, args) => this.Close(); // Close the application when the login form is closed
            loginForm.Show();

        }
    }
}

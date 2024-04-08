using HealthOnlineShop.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthOnlineShop
{
    public partial class frmLogin : Form
    {
        private frmSignup signupForm;
        bool isLogin = false;
        private Firebase firebase;
        public frmLogin()
        {
            InitializeComponent();
            firebase = Firebase.Instance;
        }

        private void btnSwitchSU_Click(object sender, EventArgs e)
        {
            
            if (signupForm == null || signupForm.IsDisposed) // Check if the form is not yet created or disposed
            {
                signupForm = new frmSignup(); // Create a new instance only if it's not already created
                //signupForm.FormClosed += (s, args) => signupForm = null; // Handle the form's closed event to nullify the reference
            }

            signupForm.Show(); // Show the form
            signupForm.BringToFront(); // Bring the form to the front if it's already opened
            this.Hide();
           
        }
        private void loginUser(Dictionary<string, object> accountDict)
        {
            // Test if the account dict has value
            //string test = "";
            //foreach (KeyValuePair<string, object> pair in accountDict)
            //{
            //    test += $"{pair.Key}: {pair.Value}\n";
            //}
            //MessageBox.Show(test);
            

            // Hide the login form
            this.Hide();
            // Create customer class
            AccountCustomer customer = AccountCustomer.createAccount(accountDict);
            // Show the main form
            frmMain mainForm = new frmMain(customer);
            mainForm.FormClosed += (s, args) => this.Close(); // Close the application when the main form is closed
            mainForm.Show();
        }
        private void loginAdmin(Dictionary<string, object> accountDict)
        {
            // Test if the account dict has value
            //string test = "";
            //foreach (KeyValuePair<string, object> pair in accountDict)
            //{
            //    test += $"{pair.Key}: {pair.Value}\n";
            //}
            //MessageBox.Show(test);
            // Hide the login form
            this.Hide();
            // Create admin class
            AccountAdmin admin = AccountAdmin.createAccount(accountDict);
            // Show the main form
            frmMainOwner mainForm = new frmMainOwner(admin);
            mainForm.FormClosed += (s, args) => this.Close(); // Close the application when the main form is closed
            mainForm.Show();
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text.Trim();
            string password = txbPassword.Text.Trim();

            Tuple<string, Dictionary<string, object>> loginDB = await firebase.login(username, password);

            string loginCheck = loginDB.Item1;
            Dictionary<string, object> accountDict = loginDB.Item2;
            isLogin = ((loginCheck == StringDB.Users.Type) || (loginCheck == StringDB.Admins.Type));
            
            if (isLogin)
            {
                //User login
                if (loginCheck == StringDB.Users.Type)
                {
                    loginUser(accountDict);
                }
                // Admin login
                if (loginCheck == StringDB.Admins.Type)
                {
                    loginAdmin(accountDict);
                }
            }
            else
            {
                // login error
                MessageBox.Show(loginCheck);
            }            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

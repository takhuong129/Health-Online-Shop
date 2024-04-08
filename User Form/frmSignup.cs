using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HealthOnlineShop.Class;
using System.Net;

namespace HealthOnlineShop
{
    public partial class frmSignup : Form
    {
        private bool isSignup;
        private static frmLogin loginForm;
        private Firebase firebase;
        public frmSignup()
        {
            InitializeComponent();
            firebase = Firebase.Instance;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (loginForm == null || loginForm.IsDisposed) // Check if the form is not yet created or disposed
            {
                loginForm = new frmLogin(); // Create a new instance only if it's not already created
                //loginForm.FormClosed += (s, args) => loginForm = null; // Handle the form's closed event to nullify the reference
            }

            loginForm.Show(); // Show the form
            loginForm.BringToFront(); // Bring the form to the front if it's already opened
            this.Hide();
        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            string fullName = txbFullname.Text;
            string email = txbEmail.Text;
            string phoneNumber = txbPhoneNumber.Text;
            string address = txbAddress.Text;

            AccountCustomer customer = new AccountCustomer(username, password, fullName, email, phoneNumber, address);
            List<string> messages = customer.validate();

            bool usernameExist = await firebase.CheckIfExist(StringDB.Users.CollectionName, StringDB.Users.FieldUsername, customer.Username);

            if (usernameExist)
            {
                messages.Add(ErrorMessage.UsernameExist);
            }
            isSignup = messages.Count == 0;
            if (isSignup)
            {            
                await firebase.AddDataToCollection(StringDB.Users.CollectionName, customer.convertToDB(StringDB.Modify.Add));

                MessageBox.Show("You've successfully signed up");
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, messages));
            }
           
            
        }
    }
}

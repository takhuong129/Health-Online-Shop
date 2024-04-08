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
using Color = System.Drawing.Color;
using Date = HealthOnlineShop.Class.Date;

namespace HealthOnlineShop
{
    public partial class frmAccount : Form
    { 
        // Reason I didn't use Liskove subsitution here is because they have substantial diffrence
        // of public function allow. it just that the field and methods of protected are mostly the same
        private AccountCustomer _customer = null;
        private AccountAdmin _admin = null;
        private Firebase _firebase;
        // Fields to store original text for comparison
        private AccountType _accountType;
        private string originalFullname;
        private string originalEmail;
        private string originalPhone;
        private Date originalBirthday;
        private string originalExtraInfo;
        private string originalUsername;
        private string originalPassword;


        public frmAccount(AccountCustomer customer)
        {
            InitializeComponent();
            _customer = customer;
            _firebase = Firebase.Instance;

            originalFullname = customer.FullName;
            originalEmail = customer.Email;
            originalPhone = customer.PhoneNumber;
            originalBirthday = customer.DoB;
            originalExtraInfo = customer.Address;
            originalUsername = customer.Username;
            originalPassword = customer.Password;

            labelExtraInfo.Text = StringDB.Users.FieldAddress;
            _accountType = AccountType.Customer;
        }
        public frmAccount(AccountAdmin admin)
        {
            InitializeComponent();
            _admin = admin;
            _firebase = Firebase.Instance;

            originalFullname = admin.FullName;
            originalEmail = admin.Email;
            originalPhone = admin.PhoneNumber;
            originalBirthday = admin.DoB;
            originalExtraInfo = admin.Role;
            originalUsername = admin.Username;
            originalPassword = admin.Password;

            labelExtraInfo.Text = StringDB.Admins.FieldRole;
            _accountType = AccountType.Admin;
        }

        // LoadData from firebase
        private void LoadInfor()
        {
            // Load data into textboxes
            txbFullname.Text = originalFullname;
            txbEmail.Text = originalEmail;
            txbPhone.Text = originalPhone;
            txbAddress.Text = originalExtraInfo;
            dateTimePickerAccount.Value = originalBirthday.DateTime;
            txbUsername.Text = originalUsername;
            txbPassword.Text = originalPassword;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadInfor(); // Load data when form loads
        }
        
        private void updateStatus(bool update)
        {
            if (update)
            {
                MessageBox.Show(ErrorMessage.UpdateSuccess);
            }
            else
            {
                MessageBox.Show(ErrorMessage.UpdateFail);
            }
        }
        private bool validateAccount(Account account)
        {
            List<string> accountValidate = account.validate();
            if (accountValidate.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, accountValidate));
                return false;
            }
            return true;
        }
        // Save Data to firebase
        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Check if any textbox has been modified
            if (!IsAnyTextBoxModified())
            {
                MessageBox.Show("No changes detected.");
                return;
            }
            // Update only the modified fields in class
            UpdateAccountData();
            //if there are more case in the future then this would be switch
            if (_accountType == AccountType.Customer)
            {
                AccountCustomer tempCustomer = new AccountCustomer(originalUsername, originalPassword, originalFullname, originalEmail, originalPhone, originalExtraInfo);
                tempCustomer.DoB = originalBirthday;
                // If there is any errors
                if (!validateAccount(tempCustomer)) return;
                else
                {
                    _customer = tempCustomer;
                    bool update = await _firebase.UpdateDataToCollection(StringDB.Users.CollectionName, StringDB.Users.FieldUsername,
                    originalUsername, _customer.convertToDB(StringDB.Modify.Update));
                    updateStatus(update);
                }
            }
            //if there are more case in the future then this would be switch
            if (_accountType == AccountType.Admin)
            {
                AccountAdmin tempAdmin = new AccountAdmin(originalUsername, originalPassword, originalFullname, originalEmail, originalPhone, originalExtraInfo);
                tempAdmin.DoB = originalBirthday;
                // If there is any errors
                if (!validateAccount(tempAdmin)) return;
                else
                {
                    _admin = tempAdmin;
                    bool update= await _firebase.UpdateDataToCollection(StringDB.Admins.CollectionName, StringDB.Admins.FieldUsername,
                    originalUsername, _admin.convertToDB(StringDB.Modify.Update));
                    updateStatus(update);
                }
                
            }
        }

        // Method to check if any textbox has been modified
        private bool IsAnyTextBoxModified()
        {
            Date date = Date.dtToDate(dateTimePickerAccount.Value);
            // Compare current text with original text
            return txbFullname.Text != originalFullname ||
                   txbEmail.Text != originalEmail ||
                   txbPhone.Text != originalPhone ||
                   date != originalBirthday ||
                   txbAddress.Text != originalExtraInfo ||
                   txbPassword.Text != originalPassword;
        }

        // Method to update data in Firebase
        private void UpdateAccountData()
        {
            
            // Update original text to current text after saving
            Date date = Date.dtToDate(dateTimePickerAccount.Value);
            originalFullname = txbFullname.Text;
            originalEmail = txbEmail.Text;
            originalPhone = txbPhone.Text;
            originalBirthday = date;
            originalExtraInfo = txbAddress.Text;
            originalUsername = txbUsername.Text;
            originalPassword = txbPassword.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

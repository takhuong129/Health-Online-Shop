using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HealthOnlineShop.Class
{
    public class AccountAdmin : Account
    {
        // simple field to create diffrence to customers
        private string _role;
        public AccountAdmin(string username, string password, string fullname, string email, string phoneNumber, string role) : base(username, password, fullname, email, phoneNumber)
        {
            _role = role;
        }
        public string Role { get { return _role; } set { _role = value; } }

        protected string validateRole()
        {
            // Validate that address cant be empty
            return (!string.IsNullOrWhiteSpace(_role)) ? ErrorMessage.None : ErrorMessage.RoleEmpty;
        }

        public override List<string> validate()
        {
            List<string> errorList = new List<string>();
            Dictionary<string, string> errorDict = new Dictionary<string, string>();
            errorDict[StringDB.Admins.FieldUsername] = validateUsername();
            errorDict[StringDB.Admins.FieldPassword] = validatePassword();
            errorDict[StringDB.Admins.FieldFullName] = validateFullName();
            errorDict[StringDB.Admins.FieldEmail] = validateEmail();
            errorDict[StringDB.Admins.FieldPhoneNumber] = validatePhoneNumber();
            errorDict[StringDB.Admins.FieldRole] = validateRole();

            foreach (KeyValuePair<string, string> kvp in errorDict)
            {
                if (kvp.Value != "")
                {
                    errorList.Add(kvp.Value);
                }
            }
            return errorList;
        }
        public override Dictionary<string, object> convertToDB(string dbChange)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            //right now, add and modify only, add would have username as username is readonly
            if (dbChange == StringDB.Modify.Add)
            {
                data[StringDB.Admins.FieldUsername] = this.Username;
            }
            data[StringDB.Admins.FieldPassword] = this.Password;
            data[StringDB.Admins.FieldFullName] = this.FullName;
            data[StringDB.Admins.FieldEmail] = this.Email;
            data[StringDB.Admins.FieldPhoneNumber] = this.PhoneNumber;
            data[StringDB.Admins.FieldRole] = _role;
            data[StringDB.Admins.FieldDoB] = this.DoB.ToString();

            return data;
        }
        // a method to create an account back from dictionary
        public static AccountAdmin createAccount(Dictionary<string, object> data)
        {
            string username = data[StringDB.Admins.FieldUsername].ToString();
            string password = data[StringDB.Admins.FieldPassword].ToString();
            string fullName = data[StringDB.Admins.FieldFullName].ToString();
            string email = data[StringDB.Admins.FieldEmail].ToString();
            string phoneNumber = data[StringDB.Admins.FieldPhoneNumber].ToString();
            string role = data[StringDB.Admins.FieldRole].ToString();

            string dobStr = data[StringDB.Admins.FieldDoB].ToString();
            Date dob = Date.strToDate(dobStr);

            AccountAdmin admin = new AccountAdmin(username, password, fullName, email, phoneNumber, role);
            admin.DoB = dob;

            return admin;
        }
    }
}

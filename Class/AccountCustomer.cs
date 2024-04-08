using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HealthOnlineShop.Class
{
    public class AccountCustomer : Account
    {
        private string _address;

        public AccountCustomer(string username, string password, string fullname, string email, string phoneNumber, string address) : base(username, password, fullname, email, phoneNumber)
        {
            _address = address;
        }  
        public string Address { get { return _address; } set { _address = value; } }

        protected string validateAddress()
        {
            // Validate that address cant be empty
            return (!string.IsNullOrWhiteSpace(_address)) ? ErrorMessage.None : ErrorMessage.AddressEmpty;
        }
        //will check if there is any error by checking if the list is empty, if none then validation is success, else error
        public override List<string> validate()
        {
            List<string> errorList = new List<string>();
            Dictionary<string, string> errorDict = new Dictionary<string, string>();
            errorDict[StringDB.Users.FieldUsername] = validateUsername();
            errorDict[StringDB.Users.FieldPassword] = validatePassword();
            errorDict[StringDB.Users.FieldFullName] = validateFullName();
            errorDict[StringDB.Users.FieldUsername] = validateEmail();
            errorDict[StringDB.Users.FieldPhoneNumber] = validatePhoneNumber();
            errorDict[StringDB.Users.FieldAddress] = validateAddress();

            foreach(KeyValuePair<string, string> kvp in errorDict)
            {
                if (kvp.Value != "") {
                    errorList.Add(kvp.Value);
                }
            }   
            return errorList;
        }
        // dict for creating account or updating account
        public override Dictionary<string, object> convertToDB(string dbChange)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            //right now, add and modify only, add would have username as username is readonly
            if (dbChange == StringDB.Modify.Add)
            {
                data[StringDB.Users.FieldUsername] = this.Username;
            } 
            data[StringDB.Users.FieldPassword] = this.Password;
            data[StringDB.Users.FieldFullName] = this.FullName;
            data[StringDB.Users.FieldEmail] = this.Email;
            data[StringDB.Users.FieldPhoneNumber] = this.PhoneNumber;
            data[StringDB.Users.FieldAddress] = _address;
            data[StringDB.Users.FieldDoB] = this.DoB.ToString();

            return data;
        }
        // a method to create an account back from dictionary
        public static AccountCustomer createAccount(Dictionary<string, object> data)
        {
            string username = data[StringDB.Users.FieldUsername].ToString();
            string password = data[StringDB.Users.FieldPassword].ToString();
            string fullName = data[StringDB.Users.FieldFullName].ToString();
            string email = data[StringDB.Users.FieldEmail].ToString();
            string phoneNumber = data[StringDB.Users.FieldPhoneNumber].ToString();
            string address = data[StringDB.Users.FieldAddress].ToString();
            
            string dobStr = data[StringDB.Users.FieldDoB].ToString();
            Date dob = Date.strToDate(dobStr);

            AccountCustomer customer = new AccountCustomer(username, password, fullName, email, phoneNumber, address);
            customer.DoB = dob;

            return customer;
        }

    }
}

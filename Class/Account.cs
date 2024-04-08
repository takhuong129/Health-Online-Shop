using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HealthOnlineShop.Class
{
    public abstract class Account
    {
        private string _username;
        private string _password;
        private string _fullName;
        private string _email;
        private string _phoneNumber;
        private Date _dob; 
        public Account(string username, string password, string fullname, string email, string phoneNumber)
        {
            _username = username;
            _password = password;
            _fullName = fullname;
            _email = email;
            _phoneNumber = phoneNumber;
            // when first create an account set it to today
            _dob = Date.Today;
        }

        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string FullName { get { return _fullName; } set { _fullName = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }

        public Date DoB { get { return _dob; } set { _dob = value; } }

        protected string validateUsername()
        {
            if (string.IsNullOrWhiteSpace(_username)) return ErrorMessage.UsernameEmpty;
            _username.Trim();
            return (Regex.IsMatch(_username, Pattern.Username)) ? ErrorMessage.None : ErrorMessage.UsernameInvalid;
        }
        protected string validatePassword()
        {
            if (string.IsNullOrWhiteSpace(_password)) return ErrorMessage.PasswordEmpty;
            _password.Trim();
            return (Regex.IsMatch(_password, Pattern.Password)) ? ErrorMessage.None : ErrorMessage.PasswordInvalid;
        }
        protected string validateFullName()
        {
            if (string.IsNullOrWhiteSpace(_fullName)) return ErrorMessage.FullNameEmpty;
            _fullName.Trim();
            string[] nameParts = _fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (nameParts.Length < 2) return ErrorMessage.FullName2Parts;
            return (Regex.IsMatch(_fullName, Pattern.FullName)) ? ErrorMessage.None : ErrorMessage.FullNameInvalid;
        }
        protected string validateEmail()
        {
            if (string.IsNullOrWhiteSpace(_email)) return ErrorMessage.EmailEmpty;
            _email.Trim();
            return (Regex.IsMatch(_email, Pattern.Email)) ? ErrorMessage.None : ErrorMessage.EmailInvalid;
        }
        protected string validatePhoneNumber()
        {
            if (string.IsNullOrWhiteSpace(_phoneNumber)) return ErrorMessage.PhoneNumberEmpty;
            _phoneNumber.Trim();
            return (Regex.IsMatch(_phoneNumber, Pattern.PhoneNumber)) ? ErrorMessage.None : ErrorMessage.PhoneNumberInvalid;
        }

        public abstract List<string> validate();

        public abstract Dictionary<string, object> convertToDB(string dbChange);
    }
}

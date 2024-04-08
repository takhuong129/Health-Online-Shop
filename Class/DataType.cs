using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthOnlineShop.Class
{
    /// <summary>
    /// The goal of datatype is to keep every thing other than normal class
    /// Struct and enum are light weight and could be bundle to class
    /// The class here are just information getter, not necessary but create ease
    /// </summary>
    public enum AccountType
    {
        Admin,
        Customer
    }
    public enum ProductCategory
    {
        Drink, 
        Bread, 
        Snack, 
        Cereal, 
        Ingredient
    }
    public enum PaymentType
    {
        CreditCard,
        DigitalWallet,
        CashOnDelivery
    }
    //This is just me prefering to bundle all the Error Message into one variable to deal with it
    //Can easily be change by having public const tring or prrivate inside the account
    public static class ErrorMessage
    {
        public static string None { get { return ""; } }
        public static string UsernameEmpty { get { return "Username cannot be empty."; } }
        public static string UsernameInvalid { get { return "Username needs to contain only letters and number."; } }
        public static string UsernameExist { get { return "Username already exist, please choose a new one."; } }
        public static string PasswordEmpty { get { return "Password cannot be empty."; } }
        public static string PasswordInvalid { get { return "Password must be at least 8 characters long and contain at least one letter and one number."; } }
        public static string FullNameEmpty { get { return "Full name cannot be empty."; } }
        public static string FullName2Parts { get { return "Full name must contain at least first and last name."; } }
        public static string FullNameInvalid { get { return "Full name must at least be 5 characters long and contain only letter."; } }
        public static string EmailEmpty { get { return "Email cannot be empty."; } }
        public static string EmailInvalid { get { return "Email is invalid."; } }
        public static string PhoneNumberEmpty { get { return "Phone number cannot be empty."; } }
        public static string PhoneNumberInvalid { get { return "Phone number should be exactly 10 digits."; } }
        public static string AddressEmpty { get { return "Address cannot be empty."; } }
        public static string RoleEmpty { get { return "Role cannot be empty."; } }
        public static string LoginUserNotFound { get { return "User does not exist"; } }
        public static string LoginWrongPassword { get { return "Password is incorrect"; } }
        public static string UpdateSuccess { get { return "Account updated successfully"; } }
        public static string UpdateFail { get { return "Account update fail"; } }
    }
    //This is just me prefering to bundle all the pattern into one variable to deal with it
    //Can easily be change by having public const tring or prrivate inside the account
    public static class Pattern
    {
        // Validate that the username contains at least 3 characters of only letters and numbers
        public static string Username { get { return @"^[a-zA-Z0-9]{3,}$"; } }
        // Password must be at least 8 characters long and contain at least one letter and one number.
        public static string Password { get { return @"^(?=.*[a-zA-Z])(?=.*[0-9]).{8,}$"; } }
        // Full name should have at least 5 characters of only letters and whitespace
        public static string FullName { get { return @"^[A-Za-z\s]{5,}$"; } }
        // Validate the email address using a complex expression pattern I found online
        // Here is the link: https://www.rhyous.com/2010/06/15/csharp-email-regular-expression/
        public static string Email { get { 
                return @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z"; ; 
            } 
        }
        // Validate the phone number only contain number with exactly 10 digits
        public static string PhoneNumber { get { return @"^[0-9]{10}$"; } }
    }
    // Again, could have create const, but I do this to have easier time reading
    public static class StringDB
    {
        public static class Users
        {
            public static string CollectionName { get { return "Users"; } }
            public static string Type { get { return "customer"; } }
            public static string FieldUsername { get { return "Username"; } }
            public static string FieldPassword { get { return "Password"; } }
            public static string FieldFullName { get { return "FullName"; } }
            public static string FieldEmail { get { return "Email"; } }
            public static string FieldPhoneNumber { get { return "PhoneNumber"; } }
            public static string FieldDoB { get { return "DateOfBirth"; } }
            public static string FieldAddress { get { return "Address"; } }
        }
        public static class Admins
        {
            public static string CollectionName { get { return "Admins"; } }
            public static string Type { get { return "admin"; } }
            public static string FieldUsername { get { return "Username"; } }
            public static string FieldPassword { get { return "Password"; } }
            public static string FieldFullName { get { return "FullName"; } }
            public static string FieldEmail { get { return "Email"; } }
            public static string FieldPhoneNumber { get { return "PhoneNumber"; } }
            public static string FieldDoB { get { return "DateOfBirth"; } }
            public static string FieldRole { get { return "Role"; } }
        }
        public static class Products
        {
            public static string CollectionName { get { return "Products"; } }
            public static string FieldName { get { return "Name"; } }
            public static string FieldDescription { get { return "Description"; } }
            public static string FieldUnit { get { return "Unit"; } }
            public static string FieldPrice { get { return "Price"; } }
            public static string FieldCategory{ get { return "Category"; } }
            public static string FieldImagePath { get { return "ImagePath"; } }
            public static string FieldQuantity { get { return "Quantity"; } }

        }

        public static class History
        {
            public static string CollectionName { get { return "History"; } }
            public static string FieldTotalCost { get { return "TotalCost"; } }
            public static string FieldPaymentType { get { return "PaymentType"; } }
            public static string FieldTransactionDate { get { return "TransactionDate"; } }
            public static string FieldOrders { get { return "Orders"; } }
        }
        public static class Modify
        {
            public static string Add { get { return "AddToDB"; } }
            public static string Update { get { return "UpdateDB"; } }
        }
    }
    // Honestly, we can also use google date or datetime, but while testing backend
    // I already have this so i just use this.
    public struct Date
    {
        private int _day;
        private int _month;
        private int _year;

        public int Day { get { return _day; } set { _day = value; } }
        public int Month { get { return _month; } set { _month = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public static bool operator ==(Date date1, Date date2)
        {
            return date1.Day == date2.Day 
                && date1.Month == date2.Month 
                && date1.Year == date2.Year;
        }
        public static bool operator !=(Date date1, Date date2)
        {
            return !(date1 == date2);
        }
        public static Date Today 
        {
            get 
            { 
                DateTime today = DateTime.Today;
                return new Date(today.Day, today.Month, today.Year);
            }
        }
        public void setDate(int day, int month, int year) 
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public static Date dtToDate(DateTime dt)
        {
            return new Date(dt.Day, dt.Month, dt.Year);
        }
        public DateTime DateTime
        {
            get
            {
                return new DateTime(_year, _month, _day);
            }
        }
        //usually setting date need us to change 3 parameter as once
        
        
        public static Date strToDate(string dateStr)
        {
            string[] dateParts = dateStr.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            int day = Int32.Parse(dateParts[0]);
            int month = Int32.Parse(dateParts[1]);
            int year = Int32.Parse(dateParts[2]);

            return new Date(day, month, year);
        }
        //display as string
        public override string ToString() 
        {
            string strDay = (_day < 10) ? $"0{_day}" : $"{_day}";
            string strMonth = (_month < 10) ? $"0{_month}" : $"{_month}";

            return $"{strDay}/{strMonth}/{_year}";
        }
    }
}

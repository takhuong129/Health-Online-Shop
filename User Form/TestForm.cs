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
    public partial class TestForm : Form
    {
        Firebase firebase;
        public TestForm()
        {
            InitializeComponent();
            firebase = Firebase.Instance;
        }

        
        private void btn1_Click(object sender, EventArgs e)
        {
            //AddData();
            PrintCollectionData();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
           
        }

        public async void PrintCollectionData()
        {
            List<Dictionary<string, object>> data = await firebase.GetDataFromCollection("Users");

            // Handle the returned data here
            string message = "Data from Firestore:\n";
            foreach (var document in data)
            {
                foreach (var field in document)
                {
                    message += $"{field.Key}: {field.Value}\n";
                }
                message += "\n";
            }

            // Display the formatted data in a MessageBox
            MessageBox.Show(message);
        }

        public async void AddData()
        {
            Dictionary<string, object> dataToAdd = new Dictionary<string, object>();
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            dataToAdd.Add("username", username);
            dataToAdd.Add("password", password);
            // add data to specific collection
            await firebase.AddDataToCollection("User", dataToAdd);
            MessageBox.Show("Data Inserted");
        }

    }
}

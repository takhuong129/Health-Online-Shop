using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Google.Type;
using HealthOnlineShop.Class;

namespace HealthOnlineShop
{
    public class Firebase
    {
        private readonly FirestoreDb _db;
        private static Firebase _instance;
        private Firebase()
        {
            // Sets the path to the Google Cloud Platform service account key file
            // and creates a Firestore database instance
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "firebase_key.json");
            _db = FirestoreDb.Create("heathshop-4cb1b");
        }
        public static Firebase Instance
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new Firebase();
                }
                return _instance;
            }
        }
        public async Task<List<Dictionary<string, object>>> GetDataFromCollection(string collectionName)
        {
            List<Dictionary<string, object>> dataList = new List<Dictionary<string, object>>();
            // Get a reference to the specified collection
            CollectionReference collectionRef = _db.Collection(collectionName);
            // Retrieve a snapshot of the documents in the collection asynchronously
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();
            // Iterate through each document in the snapshot
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                dataList.Add(document.ToDictionary());
            }

            return dataList;
        }
        public async Task<bool> CheckIfExist(string collectionName, string field, object find)
        {
            CollectionReference collectionRef = _db.Collection(collectionName);
            QuerySnapshot snapshot = await collectionRef
                .WhereEqualTo(field, find)
                .GetSnapshotAsync();
            return snapshot.Documents.Count > 0;
        }
        public async Task<bool> UpdateDataToCollection(string collectionName, string field, object find, Dictionary<string, object> updateData)
        {
            CollectionReference collectionRef = _db.Collection(collectionName);
            QuerySnapshot snapshot = await collectionRef
                .WhereEqualTo(field, find)
                .GetSnapshotAsync();

            if (snapshot.Documents.Count > 0)
            {
                DocumentSnapshot documentSnapshot = snapshot.Documents[0];
                DocumentReference docRef = documentSnapshot.Reference;

                // Update the document fields
                await docRef.UpdateAsync(updateData);
                return true;
            }
            return false;
        }
        public async Task AddDataToCollection(string collectionName, Dictionary<string, object> data)
        {
            CollectionReference collectionRef = _db.Collection(collectionName);

            // Add the data to the collection asynchronously
            await collectionRef.AddAsync(data);

            //If you want to create a new collection, just write a new name in collectionName.
        }
        //Find the document of a collections using its field, then create a subcolletion for them and that document in
        public async Task<bool> AddDataToSubcollection(string collectionName, string field, object find, string subcolletionName, Dictionary<string, object> data)
        {
            CollectionReference collectionRef = _db.Collection(collectionName);
            QuerySnapshot snapshot = await collectionRef
                .WhereEqualTo(field, find)
                .GetSnapshotAsync();

            if (snapshot.Documents.Count > 0)
            {
                DocumentSnapshot documentSnapshot = snapshot.Documents[0];
                DocumentReference mainRef = documentSnapshot.Reference;

                CollectionReference subcollectionRef = mainRef.Collection(subcolletionName);
                // Update the document fields
                await subcollectionRef.AddAsync(data);

                return true;
            }
            return false;
        }
        public async Task<List<Dictionary<string, object>>> GetSubcollectionDataFromDocument(string collectionName, string field, object find, string subcolletionName)
        {
            List<Dictionary<string, object>> dataList = new List<Dictionary<string, object>>();
            
            CollectionReference collectionRef = _db.Collection(collectionName);
            QuerySnapshot snapshot = await collectionRef
                .WhereEqualTo(field, find)
                .GetSnapshotAsync();

            if (snapshot.Documents.Count > 0)
            {
                DocumentSnapshot documentSnapshot = snapshot.Documents[0];
                DocumentReference mainRef = documentSnapshot.Reference;

                CollectionReference subcollectionRef = mainRef.Collection(subcolletionName);
                // Update the document fields
                QuerySnapshot subSnapshot = await subcollectionRef.GetSnapshotAsync();
                // Iterate through each document in the snapshot
                foreach (DocumentSnapshot document in subSnapshot.Documents)
                {
                    dataList.Add(document.ToDictionary());
                }
            }
            return dataList;
        }
        // for example, get all historry document of all users and return a giant list of that
        public async Task<List<Dictionary<string, object>>> GetSubcollectionDocumentFromCollection(string collectionName, string subcolletionName)
        {
            List<Dictionary<string, object>> dataList = new List<Dictionary<string, object>>();

            CollectionReference collectionRef = _db.Collection(collectionName);
            QuerySnapshot mainSnapshot = await collectionRef.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in mainSnapshot.Documents)
            {
                DocumentReference mainRef = documentSnapshot.Reference;

                CollectionReference subcollectionRef = mainRef.Collection(subcolletionName);
                // Update the document fields
                QuerySnapshot subSnapshot = await subcollectionRef.GetSnapshotAsync();
                // Iterate through each document in the snapshot
                foreach (DocumentSnapshot document in subSnapshot.Documents)
                {
                    dataList.Add(document.ToDictionary());
                }
            }
            return dataList;
        }

        public async Task<Tuple<string, Dictionary<string, object>>> login(string username, string password)
        {
            // create query for user and admin a temp query
            Query queryUser = _db.Collection(StringDB.Users.CollectionName)
                              .WhereEqualTo(StringDB.Users.FieldUsername, username)
                              .Limit(1);
            Query queryAdmin = _db.Collection(StringDB.Admins.CollectionName)
                               .WhereEqualTo(StringDB.Admins.FieldUsername, username)
                               .Limit(1);


            // Execute the query and retrieve the matching documents
            QuerySnapshot snapshotUser = await queryUser.GetSnapshotAsync();
            QuerySnapshot snapshotAdmin = await queryAdmin.GetSnapshotAsync();

            Dictionary<string, object> accountDict = new Dictionary<string, object>();

            //error message
            Tuple<string, Dictionary<string, object>> loginUserNotFound = 
                Tuple.Create(ErrorMessage.LoginUserNotFound, accountDict);
            Tuple<string, Dictionary<string, object>> loginWrongPassword = 
                Tuple.Create(ErrorMessage.LoginWrongPassword, accountDict);

            // Check if any documents match the query
            if (snapshotAdmin.Documents.Count > 0)
            {
                DocumentSnapshot documentSnapshot = snapshotAdmin.Documents[0];

                // get the object
                accountDict = documentSnapshot.ToDictionary();
                string dbPassword = accountDict[StringDB.Admins.FieldPassword].ToString();
                Tuple<string, Dictionary<string, object>> result = 
                    Tuple.Create(StringDB.Admins.Type, accountDict);
                // Check if the password matches
                return ( dbPassword == password) ? result : loginWrongPassword;
            }
            if (snapshotUser.Documents.Count > 0)
            {
                DocumentSnapshot documentSnapshot = snapshotUser.Documents[0];

                // get the object
                accountDict = documentSnapshot.ToDictionary();
                string dbPassword = accountDict[StringDB.Users.FieldPassword].ToString();
                Tuple<string, Dictionary<string, object>> result =
                    Tuple.Create(StringDB.Users.Type, accountDict);

                // Check if the password matches
                return (dbPassword == password) ? result : loginWrongPassword;
            }
            return loginUserNotFound;
        }
    }
}

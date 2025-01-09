using mongoDb.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace mongoDb.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var collection = connection.GetCustomersCollection();

            var document = new BsonDocument{
                { "CustomerName",customer.CustomerName},
                { "CustomerSurname",customer.CustomerSurname},
                { "CustomerCity",customer.CustomerCity},
                { "CustomerBalance",customer.CustomerBalance},
                { "CustomerShoppingCount",customer.CustomerShoppingCount}
            };

            collection.InsertOne(document);
        }
        public List<Customer> GetAllCustomers() 
        {
            var connection = new MongoDbConnection();
            var collection = connection.GetCustomersCollection();
            var customerDocuments = collection.Find(new BsonDocument()).ToList();

            var customers = new List<Customer>();
            foreach (var document in customerDocuments) 
            {
                customers.Add(new Customer
                {
                    CustomerID = document.GetValue("_id").ToString(),
                    CustomerName = document.GetValue("CustomerName").AsString,
                    CustomerSurname = document.GetValue("CustomerSurname").AsString,
                    CustomerCity = document.GetValue("CustomerCity").AsString,
                    CustomerBalance = document.GetValue("CustomerBalance").ToDecimal(),
                    CustomerShoppingCount = document.GetValue("CustomerShoppingCount").ToInt32()
                });
            }
            return customers;
        }

        public void RemoveCustomer(string customerId)
        {
            var connection = new MongoDbConnection();
            var collection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));
            collection.DeleteOne(filter);
        }

        public void UpdateCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var collection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerID));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerName",customer.CustomerName)
                .Set("CustomerSurname", customer.CustomerSurname)
                .Set("CustomerCity", customer.CustomerCity)
                .Set("CustomerBalance", customer.CustomerBalance)
                .Set("CustomerShoppingCount", customer.CustomerShoppingCount);

            collection.UpdateOne(filter, updatedValue);
        }

        public Customer GetCustomerById(string userId)
        {
            var connection = new MongoDbConnection();
            var collection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(userId));
            var customerDocument = collection.Find(filter).FirstOrDefault();
            return new Customer
            {
                
                CustomerBalance = customerDocument.GetValue("CustomerBalance").ToDecimal(),
                CustomerCity = customerDocument.GetValue("CustomerCity").AsString,
                CustomerID = customerDocument.GetValue("_id").ToString(),
                CustomerName = customerDocument.GetValue("CustomerName").AsString,
                CustomerShoppingCount = customerDocument.GetValue("CustomerShoppingCount").ToInt32(),
                CustomerSurname = customerDocument.GetValue("CustomerSurname").AsString
            };
        }
    }
}

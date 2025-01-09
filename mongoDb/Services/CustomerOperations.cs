using mongoDb.Entities;
using MongoDB.Bson;

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
        }
    }
}

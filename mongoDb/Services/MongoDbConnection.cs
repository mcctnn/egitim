using MongoDB.Bson;
using MongoDB.Driver;

namespace mongoDb.Services
{
    public class MongoDbConnection
    {
        private IMongoDatabase _database;

        public MongoDbConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database=client.GetDatabase("MongoDbCustomer");
            
        }
        public IMongoCollection<BsonDocument> GetCustomersCollection() 
        {
            return _database.GetCollection<BsonDocument>("Customers");
        }
    }
}

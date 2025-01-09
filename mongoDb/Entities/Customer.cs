using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongoDb.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerCity { get; set; }
        public decimal CustomerBalance { get; set; }
        public int CustomerShoppingCount { get; set; }
    }
}

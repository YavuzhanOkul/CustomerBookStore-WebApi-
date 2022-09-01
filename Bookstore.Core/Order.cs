using MongoDB.Bson.Serialization.Attributes;


namespace Bookstore.Core
{
    [BsonIgnoreExtraElements]
    public class Order
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string Status { get; set; }
        public string OrderDate { get; set; }
        public string OrderAddress { get; set; }

    }
}

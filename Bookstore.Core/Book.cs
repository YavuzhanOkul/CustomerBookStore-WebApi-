using MongoDB.Bson.Serialization.Attributes;


namespace Bookstore.Core
{
  public  class Book
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string BookId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int Stock { get; set; }

    }
}

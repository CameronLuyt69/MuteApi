using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MuteApi.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }

        public decimal CountInStock { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        public string Price { get; set; }
    }
}

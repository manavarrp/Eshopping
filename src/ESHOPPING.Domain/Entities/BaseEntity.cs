using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ESHOPPING.Domain.Entities
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
    }
}

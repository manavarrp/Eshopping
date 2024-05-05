using MongoDB.Bson.Serialization.Attributes;

namespace ESHOPPING.Domain.Entities
{
    public class ProductType : BaseEntity
    {
        [BsonElement("Name")]
        public string? Name { get; set; }
    }
}

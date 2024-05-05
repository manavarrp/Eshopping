using MongoDB.Bson.Serialization.Attributes;

namespace ESHOPPING.Domain.Entities
{
    public class ProductBrand : BaseEntity
    {
        [BsonElement("Name")]
        public string? Name { get; set; }
    }
}

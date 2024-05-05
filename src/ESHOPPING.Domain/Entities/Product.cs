using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ESHOPPING.Domain.Entities
{
    public class Product : BaseEntity
    {
        [BsonElement("Name")]
        public string? Name { get; set; }    
        public string? Sumary { get; set; }
        public string? Description { get; set; }
        public string? ImageFile { get; set; }
        public ProductBrand Brands { get; set; } = null!;
        public ProductType Types { get; set; } = null!;

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
    }
}

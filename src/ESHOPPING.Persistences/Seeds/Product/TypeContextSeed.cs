using ESHOPPING.Domain.Entities;
using MongoDB.Driver;
using System.Text.Json;

namespace ESHOPPING.Persistences.Seeds.Product
{
    public static class TypeContextSeed
    {
        public static void SeedData(IMongoCollection<ProductType> typeCollection)
        {
            bool checksTypes = typeCollection.Find(t => true).Any();
            string path = Path.Combine("Seeds", "Product", "SeedData", "types.json");
            if (!checksTypes)
            {
                var typesData = File.ReadAllText(path);
                var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                if(typesData is not null )
                {
                    foreach( var item in types! ) 
                    {
                        typeCollection.InsertOneAsync(item);
                    }
                }

            }
        }
    }
}

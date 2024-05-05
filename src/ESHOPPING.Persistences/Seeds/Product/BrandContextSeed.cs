using ESHOPPING.Domain.Entities;
using MongoDB.Driver;
using System.Text.Json;

namespace ESHOPPING.Persistences.Seeds.Product
{
    public static class BrandContextSeed
    {
        public static void SeedData(IMongoCollection<ProductBrand> brandCollection)
        {
            bool checksBrands = brandCollection.Find(b=>true).Any();
            string path = Path.Combine("Seeds", "Product", "SeedData", "brands.json");
            if (!checksBrands)
            {
                var brandsData = File.ReadAllText(path);
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                if (brandsData != null)
                {
                    foreach (var item in brands!)
                    {
                        brandCollection.InsertOneAsync(item);
                    }
                }

            }
        }
    }
}

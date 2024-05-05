using MongoDB.Driver;
using System.Text.Json;
using Entity = ESHOPPING.Domain.Entities;

namespace ESHOPPING.Persistences.Seeds.Product
{
    public static class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Entity.Product> productCollection)
        {
            bool checksProducts = productCollection.Find(p => true).Any();
            string path = Path.Combine("Seeds", "Product", "SeedData", "products.json");

            if (checksProducts)
            {
                var productsData = File.ReadAllText(path);
                var products = JsonSerializer.Deserialize<List<Entity.Product>>(productsData);
                if(productsData is not null)
                {
                    foreach(var item in products!)
                    {
                        productCollection.InsertOneAsync(item);
                    }
                }

            }

        }
    }
}

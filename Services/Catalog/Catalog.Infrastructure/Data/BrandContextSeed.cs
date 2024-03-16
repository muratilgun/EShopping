using System.Text.Json;
using Catalog.Core.Entities;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Data;

public static class BrandContextSeed
{
    public static void SeedData(IMongoCollection<Brand> brandCollection)
    {
        bool checkBrands = brandCollection.Find(b => true).Any();
        string path = Path.Combine("Data", "SeedData", "brands.json");
        if (!checkBrands)
        {
            var brandsData = File.ReadAllText(path);
            var brands = JsonSerializer.Deserialize<List<Brand>>(brandsData);
            if (brands != null)
            {
                foreach (var item in brands)
                {
                    brandCollection.InsertOneAsync(item);
                }
            }
        }
    } 
}
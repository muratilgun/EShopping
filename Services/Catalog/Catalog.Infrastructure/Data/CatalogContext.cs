using MongoDB.Driver;
using Catalog.Core.Entities;
using Microsoft.Extensions.Configuration;

using Type = Catalog.Core.Entities.Type;

namespace Catalog.Infrastructure.Data;

public class CatalogContext : ICatalogContext
{
    public IMongoCollection<Product> Products { get; }
    public IMongoCollection<Brand> Brands { get; }
    public IMongoCollection<Type> Types { get; }
    
    public CatalogContext(IConfiguration configuration)
    {
        var connectionString = configuration.GetValue<string>("DatabaseSettings:ConnectionString");
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
        Brands = database.GetCollection<Brand>(
            configuration.GetValue<string>("DatabaseSettings:BrandsCollection"));
        Types = database.GetCollection<Type>(
            configuration.GetValue<string>("DatabaseSettings:TypesCollection"));
        Products = database.GetCollection<Product>(
            configuration.GetValue<string>("DatabaseSettings:CollectionName"));
        
        BrandContextSeed.SeedData(Brands);
        TypeContextSeed.SeedData(Types);
        CatalogContextSeed.SeedData(Products);
    }
}
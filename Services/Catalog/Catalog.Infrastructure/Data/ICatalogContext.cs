using Catalog.Core.Entities;
using MongoDB.Driver;
using Type = Catalog.Core.Entities.Type;


namespace Catalog.Infrastructure.Data;

public interface ICatalogContext
{
    IMongoCollection<Product> Products { get; }
    IMongoCollection<Brand> Brands { get; }
    IMongoCollection<Type> Types { get; }
}
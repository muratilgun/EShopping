using Catalog.Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Type =  Catalog.Core.Entities.Type;

namespace Catalog.Application.Features.Products.Queries.GetProductById;

public class GetProductByIdResponse
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    [BsonElement("Name")]
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public string ImageFile { get; set; }
    public decimal Price { get; set; }
    public Brand Brands { get; set; }
    public Type Types { get; set; }
}
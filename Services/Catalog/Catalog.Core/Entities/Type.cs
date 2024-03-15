using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Core.Entities;

public class Type : BaseEntity
{
    [BsonElement("Name")]
    public string Name { get; set; } = null!;
}
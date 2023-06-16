using DbProvider.Abstract;
using MongoDB.Bson.Serialization.Attributes;

namespace DbProvider.Mongo.Tests.Models;

public class DummyModel : IEntity<string>
{
    [BsonId]
    public string Id { get; set; }
    
    // [INFO] : property for testing purposes
    [BsonIgnore]
    public string DummyId { get => Id; init => Id = value; }

    public string? DummyProperty { get; set; }

    public string Nickname { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}
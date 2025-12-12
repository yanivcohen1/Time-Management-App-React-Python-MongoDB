using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuthApi.Models;

public class TodoUserLink
{
    [BsonElement("$ref")]
    public string Ref { get; set; } = "users";

    [BsonElement("$id")]
    public ObjectId Id { get; set; }
}

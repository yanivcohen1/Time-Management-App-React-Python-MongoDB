using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AuthApi.Models;

public class ApplicationUser
{
    [Key]
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("email")]
    public required string Username { get; set; }

    [BsonElement("role")]
    public required string Role { get; set; }

    [BsonElement("password_hash")]
    public required string PasswordHash { get; set; }

    [BsonElement("full_name")]
    public string? FullName { get; set; }
}

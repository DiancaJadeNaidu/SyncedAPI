using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SyncedAPI.Models
{
    public class Score
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
     public string? Id { get; set; } 

        [BsonElement("userId")]
        public string? UserId { get; set; }

        [BsonElement("friendId")]
        public string? FriendId { get; set; }

        [BsonElement("game")]
        public string? Game { get; set; } 

        [BsonElement("points")]
        public int Points { get; set; }

        [BsonElement("timestamp")]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}

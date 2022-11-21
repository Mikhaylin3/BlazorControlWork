using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace BlazorControlWork.Data
{
    public class User
    {
        ObjectId _id;

        [BsonId]
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Login { get; set; }
        [BsonIgnoreIfNull]
        public string? Password { get; set; }
        [BsonIgnoreIfNull]
        public string? FName { get; set; }
        [BsonIgnoreIfNull]
        public string? LName { get; set; }
        [BsonIgnoreIfNull]
        public string? Email { get; set; }
        [BsonIgnoreIfNull]
        public string? Photo { get; set; }
        
        public User()
        {
            Photo = String.Empty;
        }
    }
}

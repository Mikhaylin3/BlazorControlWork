using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BlazorControlWork.Data
{
    public class Unit
    {


        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        [BsonIgnoreIfNull]
        public string? Name { get; set; }
        [BsonIgnoreIfNull]
        public string? Hero { get; set; }
        [BsonIgnoreIfNull]
        public int lvl { get; set; }
        
    }
}

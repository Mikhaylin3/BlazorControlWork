using MongoDB.Driver;
namespace BlazorControlWork.Data
{
    public class UserService
    {
        public User user = new User();

        private static MongoClient client = new MongoClient();
        private static IMongoDatabase database = client.GetDatabase("Davletka");
        private IMongoCollection<User> userColl = database.GetCollection<User>("User");

        public void AddToDb(User user)
        {
            userColl.InsertOne(user);
        }

        public static List<User> FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Davletka");
            var collection = database.GetCollection<User>("User");
            var list = collection.Find(x => true).ToList();
            var users = new List<User>();
            foreach (var user in list)
            {
                users.Add(user);
            }
            return users;
        }

        public User GetUser()
        {
            return user;
        }

        public void SetUser(User user)
        {
            this.user = user;
        }

    }
}

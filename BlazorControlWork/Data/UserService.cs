using MongoDB.Driver;
namespace BlazorControlWork.Data
{
    public class UserService
    {
        public User user = new User();

        private static MongoClient client = new MongoClient();
        private static IMongoDatabase database = client.GetDatabase("Davletka");
        private IMongoCollection<User> userColl = database.GetCollection<User>("Users");

        public void AddToDb(User user)
        {
            userColl.InsertOne(user);
        }

        public void UserLogin(string Login)
        {
            user = userColl.Find(x => x.Login == Login).FirstOrDefault();
        }
    }
}

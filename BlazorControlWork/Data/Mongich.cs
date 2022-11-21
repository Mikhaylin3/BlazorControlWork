using MongoDB.Driver;

namespace BlazorControlWork.Data
{
    public class Mongich
    {
        public static List<Unit> FindAll()
        {
            List<Unit> units = new List<Unit>();
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<Unit>("True");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                units.Add(item);
            }
            return units;
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Telebovich.Bot.Services 
{
    public class Joke {
        public string _id { get; set; }
        public string Text { get; set; }
        public bool IsApproved { get; set; }    
    }
    public class Repository: IRepository
    {
        public AppSettings AppSettings { get; set; }
        public Repository(IOptions<AppSettings> _appSettings)
        {
            AppSettings = _appSettings.Value;
        }
        public Joke Get() 
        {
            IMongoClient client = new MongoClient(AppSettings.MongoCredentials);
            IMongoDatabase database = client.GetDatabase("joker");
            IMongoCollection<Joke> collection = database.GetCollection<Joke>("jokes");
            Joke joke = collection.Find(new BsonDocument()).First();
            return joke;
        }   
    }
}
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Joke 
{
    public ObjectId Id { get; set; }
    public string text { get; set; }
    public bool is_approved { get; set; }
}
using System;
using MongoDB.Bson;
using MongoDB.Driver;
namespace MongoConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            string mongoDBConnectionString = "mongodb://localhost:27017";
            var mongoClient = new MongoClient(mongoDBConnectionString);
            var database = mongoClient.GetDatabase("startup");

            var collection = database.GetCollection<BsonDocument>("employee");

            var document = new BsonDocument
            {
                { "name","alex"},
                { "age","28"},
            };

            collection.InsertOneAsync(document);
            
            
            Console.Read();
        }
    }
}

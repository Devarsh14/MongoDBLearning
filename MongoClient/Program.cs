using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoClient
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new MongoClient("");
            Console.WriteLine("Hello World!");
        }
    }
}

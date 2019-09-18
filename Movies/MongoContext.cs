using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies
{
    public class MongoContext
    {
        public MongoDatabase GetDatabase(string databaseName)
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json").Build();

            var connectionString = config["MongoConnectionString"];
            var client = new MongoClient(connectionString);
            return (MongoDatabase)client.GetDatabase(databaseName);
        }
    }
}

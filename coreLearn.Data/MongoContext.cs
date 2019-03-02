using System;
using MongoDB.Driver;

namespace coreLearn.Data
{
    public class MongoContext
    {
        public MongoContext()
        {
            MongoClient client = new MongoClient(Constants.MongoConnectionString);
            IMongoDatabase mongoDatabase = client.GetDatabase(Constants.MongoDBName);            
            
        }
    }
}

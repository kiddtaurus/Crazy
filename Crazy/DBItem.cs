using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crazy.DB
{
    public class DBItem
    {
        private const string connectionstring = "mongodb://appharbor_w73btpfd:8k05olecu798coco65dpklovpq@ds119476.mlab.com:19476/appharbor_w73btpfd";

        protected static MongoDatabase GetDb()
        {
            var url = new MongoUrl(connectionstring);
            var client = new MongoClient(url);
            var server = client.GetServer();
            var database = server.GetDatabase(url.DatabaseName);

            return database;
        }
    }
}
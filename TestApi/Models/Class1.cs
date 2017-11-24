using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TestApi.Models
{
    public class Class1
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }

        public void c()
        {
            //mongodb://<dbuser>:<dbpassword>@ds119476.mlab.com:19476/appharbor_w73btpfd
            //mongodb://<dbuser>:<dbpassword>@ds119476.mlab.com:19476/appharbor_w73btpfd
            //{ user: "appharbor_w73btpfd", account: "appharbor_w73btpfd" } 
            //Database: appharbor_w73btpfd
            //mongodb://appharbor_w73btpfd:<dbpassword>@ds119476.mlab.com:19476/appharbor_w73btpfd
            var connectionstring = /*ConfigurationManager.AppSettings.Get(*/"mongodb://appharbor_w73btpfd:8k05olecu798coco65dpklovpq@ds119476.mlab.com:19476/appharbor_w73btpfd"/*)*/;
            /*mongodb://appharbor_w73btpfd:8k05olecu798coco65dpklovpq
                        @ds119476.mlab.com:19476/appharbor_w73btpfd*/
            var url = new MongoUrl(connectionstring);
            var client = new MongoClient(url);
            var server = client.GetServer();
            var database = server.GetDatabase(url.DatabaseName);

            var collection = database.GetCollection<Class1>("Class1");

            // insert object
            collection.Insert(new Class1 { Name = "foo" });

            // fetch all objects
            var thingies = collection.FindAll();
        }
    }
}
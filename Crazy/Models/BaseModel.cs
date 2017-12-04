using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crazy.Models
{
    public class BaseModel
    {
        public ObjectId _id { get; set; }
    }
}
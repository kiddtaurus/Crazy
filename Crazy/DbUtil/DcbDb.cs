using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crazy.DB;
using Crazy.Models.Dcb;
using MongoDB.Driver;

namespace Crazy.DbUtil
{
    public class DcbDb : DbBase
    {
        private static readonly MongoCollection<DcbItemModel> Collection = GetCollection<DcbItemModel>("Item");

        public static List<DcbItemModel> GetAll()
        {
//            var collection = GetCollection<DcbItemModel>("Item");

            var list = Collection.FindAll().ToList();

            return list;
        }

        public static DcbItemModel Insert(DcbItemModel dcbItem)
        {
            var result = Collection.Insert(dcbItem);

            return dcbItem;
        }
    }
}
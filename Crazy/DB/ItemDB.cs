using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crazy.Models.DoubleColorBall;

namespace Crazy.DB
{
    public class ItemDB : BaseDB
    {
        public void InsertList(List<DCBItemModel> list)
        {
            var database = GetDb();
            var collection = database.GetCollection<DCBItemModel>("Item");

            collection.Insert(new DCBItemModel(2017141, "01", "02", "03", "04", "05", "06", "16"));
        }

        public static List<DCBItemModel> GetAll()
        {
            var database = GetDb();
            var collection = database.GetCollection<DCBItemModel>("Item");

            var list = collection.FindAll().ToList();

            return list;
        }
    }
}
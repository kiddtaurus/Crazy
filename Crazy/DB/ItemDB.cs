using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crazy.Models;

namespace Crazy.DB
{
    public class ItemDB : BaseDB
    {
        public void InsertList(List<Item> list)
        {
            var database = GetDb();
            var collection = database.GetCollection<Item>("Item");

            collection.Insert(new Item(2017141, "01", "02", "03", "04", "05", "06", "16"));
        }

        public static List<Item> GetAll()
        {
            var database = GetDb();
            var collection = database.GetCollection<Item>("Item");

            var list = collection.FindAll().ToList();

            return list;
        }
    }
}
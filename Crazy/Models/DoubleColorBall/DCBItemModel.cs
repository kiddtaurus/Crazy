using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crazy.Models.DoubleColorBall
{
    public class DCBItemModel : BaseModel
    {
        //https://stackoverflow.com/questions/5505591/how-to-registerclassmap-for-all-classes-in-a-namespace-for-mongodb
        //[BsonId] // mark property as _id
        //[BsonElement("SomeAnotherName", Order = 1)] //set property name , order
        //[BsonIgnoreExtraElements] // ignore extra elements during deserialization
        //[BsonIgnore] // ignore property on insert
        public int No { get; set; }
        public string R1 { get; set; }
        public string R2 { get; set; }
        public string R3 { get; set; }
        public string R4 { get; set; }
        public string R5 { get; set; }
        public string R6 { get; set; }
        public string B { get; set; }
        public int Money { get; set; }

        public DCBItemModel(int no, string r1, string r2, string r3, string r4, string r5, string r6, string b)
            : base()
        {
            No = no;
            R1 = r1;
            R2 = r2;
            R3 = r3;
            R4 = r4;
            R5 = r5;
            R6 = r6;
            B = b;
        }
    }
}
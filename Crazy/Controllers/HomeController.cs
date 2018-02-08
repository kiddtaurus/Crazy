using Crazy.Models.Dcb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crazy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }


    public class A
    {
        private List<DcbItemModel> _list = new List<DcbItemModel>();

        public void ProcessMiss()
        {
            #region init data

            var itemOld = new DcbItemModel
            {
                No = 1,
                R1 = 2,
                R2 = 4,
                R3 = 6,
                R4 = 8,
                R5 = 10,
                R6 = 12,
                B = 14,
            };

            var itemNew = new DcbItemModel
            {
                No = 1,
                R1 = 2,
                R2 = 6,
                R3 = 10,
                R4 = 14,
                R5 = 16,
                R6 = 18,
                B = 13,
            };

            var missOld = new DcbMissModel
            {
                R1 = 1,
                R2 = 2,
                R3 = 3,
                R4 = 4,
                R5 = 5,
                R6 = 6,
                R7 = 7,
                R8 = 8,
                R9 = 9,
                R10 = 10,
                R11 = 1,
                R12 = 2,
                R13 = 3,
                R14 = 4,
                R15 = 5,
                R16 = 6,
                R17 = 7,
                R18 = 8,
                R19 = 9,
                R20 = 10,
                R21 = 1,
                R22 = 2,
                R23 = 3,
                R24 = 4,
                R25 = 5,
                R26 = 6,
                R27 = 7,
                R28 = 8,
                R29 = 9,
                R30 = 10,
                R31 = 1,
                R32 = 2,
                R33 = 3,
                B1 = 1,
                B2 = 2,
                B3 = 3,
                B4 = 4,
                B5 = 5,
                B6 = 6,
                B7 = 7,
                B8 = 8,
                B9 = 9,
                B10 = 10,
                B11 = 1,
                B12 = 2,
                B13 = 3,
                B14 = 4,
                B15 = 5,
                B16 = 6,
            };

            #endregion

            var missNew = new DcbMissModel()
            {
                No = itemNew.No
            };

            missNew.SetZero(itemNew);
            missNew.UpdateValue(missOld);

            //save missNew

            var a = missNew;
        }
    }
}
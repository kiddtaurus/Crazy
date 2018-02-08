using System.Collections.Generic;
using System.Web.Mvc;
using Crazy.DbUtil;
using Crazy.Models.Dcb;

namespace Crazy.Controllers
{
    public class DcbController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDcb()
        {
            return View();
        }


        public JsonResult Insert(DcbItemModel dcbItem)
        {
            var result = dcbItem;//DcbDb.Insert(dcbItem);
            result.No = 111;
            result.R1 = 1;
            result.R2 = 2;
            result.R3 = 3;
            result.R4 = 4;
            result.R5 = 5;
            result.R6 = 6;
            result.B = 11;

            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SaveList(List<DcbItemModel> list)
        {
//            var lists = ItemDB.GetAll();

            return Json("", JsonRequestBehavior.AllowGet);
        }


    }
}
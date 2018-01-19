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
            var result = DcbDb.Insert(dcbItem);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SaveList(List<DcbItemModel> list)
        {
//            var lists = ItemDB.GetAll();

            return Json("", JsonRequestBehavior.AllowGet);
        }


    }
}
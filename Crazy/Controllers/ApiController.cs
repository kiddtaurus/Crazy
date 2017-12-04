using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crazy.DB;
using Crazy.Models;

namespace Crazy.Controllers
{
    public class ApiController : Controller
    {
        public ActionResult Index()
        {
            return View("Api");
        }

        public ActionResult Test()
        {
            return View();
        }

        public JsonResult SaveList(List<Item> list)
        {


            return Json("", JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAll()
        {
            var list = ItemDB.GetAll();
            
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult GetAllById(string id)
        {
            var list = ItemDB.GetAll();

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}

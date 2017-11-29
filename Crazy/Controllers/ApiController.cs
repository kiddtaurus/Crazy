using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Crazy.DB;
using Crazy.Models;

namespace Crazy.Controllers
{
    public class ApiController : Controller
    {
        //
        // GET: /Api/

        public ActionResult Index()
        {
            return View("Api");
        }

        public JsonResult SaveList([FromBody] List<Item> list)
        {


            return Json("", JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAll()
        {
            var list = ItemDB.GetAll();
            
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Get()
        {
            var list = ItemDB.GetAll();

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}

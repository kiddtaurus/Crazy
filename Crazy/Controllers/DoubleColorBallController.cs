using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crazy.Controllers
{
    public class DoubleColorBallController : Controller
    {
        // GET: DoubleColorBall
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDCBItem()
        {
            return View();
        }
    }
}
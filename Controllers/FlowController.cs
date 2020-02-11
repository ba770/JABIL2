using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class FlowController : Controller
    {
        // GET: Flow
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UsualFlowOut()
        {
            return View();
        }


        public ActionResult UsualFlowIn()
        {
            return View();
        }

        public ActionResult TempFlowOut()
        {
            return View();
        }

        public ActionResult TempFlowIn()
        {
            return View();
        }
    }
}
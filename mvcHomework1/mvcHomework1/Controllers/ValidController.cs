using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcHomework1.Controllers
{
    public class ValidController : Controller
    {
        // GET: Valid
        public ActionResult Index(DateTime postTime)
        {
            bool isvalidat = postTime <= DateTime.Now;
            return Json(isvalidat, JsonRequestBehavior.AllowGet);
        }
    }
}
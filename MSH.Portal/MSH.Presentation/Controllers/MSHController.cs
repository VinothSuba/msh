using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSH.Presentation.Controllers
{
    public class MSHController : Controller
    {
        // GET: MSH
        public ActionResult Index()
        {
            return View();
        }
    }
}
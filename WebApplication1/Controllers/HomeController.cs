using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //Get CheckTemp
        public ActionResult CheckTemp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckTemp(int tmpIn = 0)
        {
            return View();
        }
    }
}
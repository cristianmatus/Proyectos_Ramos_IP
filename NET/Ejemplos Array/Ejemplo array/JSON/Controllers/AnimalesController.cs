using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSON_Example.Controllers
{
    public class AnimalesController : Controller
    {
        // GET: Animales
        public ActionResult Index()
        {
            return View();
        }
    }
}
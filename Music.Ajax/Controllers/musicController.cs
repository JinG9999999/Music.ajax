using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Ajax.Controllers
{
    public class musicController : Controller
    {
        // GET: music
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Show()
        {
            return View();
        }
    }
}
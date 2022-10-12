using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiktokFake.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Main()
        {
            return View();
        }

        public ActionResult QR()
        {
            return View();
        }

        public ActionResult KakaoTalk()
        {
            return View();
        }

        public ActionResult Line()
        {
            return View();
        }
    }
}
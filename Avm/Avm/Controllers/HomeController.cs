using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Avm.Models;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Globalization;

namespace Avm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            ViewBag.Message = "Hakkımızda .";

            return View();
        }
        public ActionResult ChangeCulture(string lang, string returnUrl)
        {
            Session["Culture"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }
        public ActionResult iletisim()
        {
            ViewBag.Message = "İletişim Sayfası.";

            return View();
        }
        dbContext db = new dbContext();
        public ActionResult alinacaklar()
        {
            string userid = User.Identity.GetUserId();
          List<Satislar> liste=db.Satis.Where(m => m.aliciid ==userid).ToList();
            return View(liste);
        }
        public ActionResult delete(int? id)
        {
            var urun = db.Satis.Where(m => m.id == id);
            urun = null;
            db.SaveChanges();
            return View();
        }
    }
}
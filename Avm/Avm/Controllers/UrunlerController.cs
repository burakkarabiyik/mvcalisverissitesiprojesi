using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Avm.Models;
using Microsoft.AspNet.Identity;

namespace Avm.Controllers
{
    public class UrunlerController : Controller
    {
        private dbContext db = new dbContext();
       public int urunid=5;
        // GET: Urunlers
        public ActionResult Satinal(int id)
        {
            return View(db.Urunler.Find(id));
        }

        
        ApplicationDbContext dbb = new ApplicationDbContext();

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Satinal()
        {

            Satislar yeni = new Satislar();
            var kisi = (dbb.Users.Find(User.Identity.GetUserId()));
            yeni.aliciid = kisi.Id;
            yeni.urunid = Convert.ToInt32(Session["urunid"]);
            db.Satis.Add(yeni);
             db.SaveChanges();
           return RedirectToAction("Index","Home");
        }

        
 
        // GET: Urunlers/Delete/5
        public ActionResult erkek()
        {
            var eleman = db.Urunler.Where(m => m.tür.Contains("erkek")).ToList();
            return View(eleman);
        }
        public ActionResult bayan()
        {
            var eleman = db.Urunler.Where(m => m.tür.Contains("bayan")).ToList();
            return View(eleman);
        }
        public ActionResult cocuk()
        {
            var eleman = db.Urunler.Where(m => m.tür.Contains("cocuk")).ToList();
            return View(eleman);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

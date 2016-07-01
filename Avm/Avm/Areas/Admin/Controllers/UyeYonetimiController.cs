using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Avm.Models;
namespace Avm.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UyeYonetimiController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/UyeYonetimi
        public ActionResult Uyeler()
        {
            return View();
        }
        public ActionResult RolEkle(String UserId)
        { 
            Session["UserId"] = UserId;
            return View();
        } 

        public ActionResult Ekle(String Role)
        {
            var user = db.Users.Find(Session["UserId"]);
            Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole rol = new Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole();
            rol.RoleId = int.Parse(Role).ToString();
            rol.UserId = Session["UserId"].ToString();
            user.Roles.Add(rol);
            db.SaveChanges();

            return RedirectToAction("Uyeler", "UyeYonetimi");
        } 
       public ActionResult RolSil(string userId)
        {
            var user = db.Users.Find(userId);
            user.Roles.Remove(user.Roles.First());
            db.SaveChanges();
            return RedirectToAction("Uyeler","UyeYonetimi");
        }

        public ActionResult UyeSil(string userId)
        {
            var user = db.Users.Find(userId);
            db.Users.Remove(user);
            db.SaveChanges();

            return RedirectToAction("Index","UyeYonetimi");
        }
    }
}
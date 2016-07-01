using System.Web.Mvc;

namespace Avm.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "Admin",
                url: "Admin",
                defaults: new { controller = "Urunlers", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
               name: "UyeYonetimi",
               url: "UyeYonetimi",
               defaults: new { controller = "UyeYonetimi", action = "Uyeler", id = UrlParameter.Optional }
           );
            context.MapRoute(
              name: "UuyeYonetimi",
              url: "Admin/UyeYonetimi",
              defaults: new { controller = "UyeYonetimi", action = "Uyeler", id = UrlParameter.Optional }
          );
            context.MapRoute(
                name: "AdminCreate",
                url: "Admin/Create",
                defaults: new { controller = "Urunlers", action = "Create", id = UrlParameter.Optional }
            );
            context.MapRoute(
                name: "AdminEdit",
                url: "Admin/Edit/{id}",
                defaults: new { controller = "Urunlers", action = "Create", id = UrlParameter.Optional }
            );
            context.MapRoute(
               name: "Admindelete",
               url: "Admin/delete/{id}",
               defaults: new { controller = "Urunlers", action = "Delete", id = UrlParameter.Optional }
           );
            context.MapRoute(
               name: "Admindetails",
               url: "Admin/details/{id}",
               defaults: new { controller = "Urunlers", action = "Details", id = UrlParameter.Optional }
           );
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
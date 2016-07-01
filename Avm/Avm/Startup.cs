using Microsoft.Owin;
using Owin;
using Avm.Models;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartupAttribute(typeof(Avm.Startup))]
namespace Avm
{
    public partial class Startup
    { 

        public void Configuration(IAppBuilder app)
        {
            dbContext db;
            using ( db = new dbContext())
            {
                db.Database.CreateIfNotExists();
                
            }
             
           
            ApplicationDbContext database = new ApplicationDbContext();//Admin ekleme işlemini burada yapıyorum.
            ApplicationUser user = new ApplicationUser();
            user.Ad = "Admin";
            user.Email = "admin@admin.com";
            user.EmailConfirmed = true;
            user.Id = "1";
            user.Kullaniciadi = "Admin";
            user.Soyad = "Admin";
            user.Telno = "0000";
            user.PasswordHash = "AL5c2IT+Tiem48wFc1fSmmg4zXIjE97NLB71EhbHYM7i9Ij54qsuL8hMci0ACvZFtQ==";
            user.SecurityStamp = "5370dcc2-5b20-4ceb-b9ea-a1d2a7153fcc";//Şifre 123456 diye atandı .
            user.Tutar = 0;
            user.UserName = "admin@admin.com";


            database.Users.Add(user);

            database.SaveChanges();
            IdentityRole rol = new IdentityRole("Admin"); rol.Id = "1";
            database.Roles.Add(rol);//Admin Rolünü ekledik
             rol = new IdentityRole("Satıcı"); rol.Id = "2";
            database.Roles.Add(rol);//Satıcı Rolünü ekledik
            Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole role = new Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole();
            role.RoleId = "1";
            role.UserId = "1";
            user.Roles.Add(role); //Üyeliğimize Admin Rolümüzü ekledik.
            database.SaveChanges();

            ConfigureAuth(app);
        }
    }
}

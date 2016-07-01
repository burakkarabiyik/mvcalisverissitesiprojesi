using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Avm.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here 

            userIdentity.AddClaim(new Claim("Ad", "Ad"));
            userIdentity.AddClaim(new Claim("Soyad", "Soyad"));
            userIdentity.AddClaim(new Claim("Telno", "Telno"));
            userIdentity.AddClaim(new Claim("Odeme", "Odeme"));
            userIdentity.AddClaim(new Claim("Kullaniciadi", "Kullaniciadi"));
            return userIdentity;
        }
        [Display(Name = "Kullanıcı Adı")]
        public string Kullaniciadi { get; set; }
        [Display(Name = "Ad")]
        public string Ad { get; set; }
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }
        [Display(Name = "Tutar")]
        public int Tutar { get; set; }

        [Phone]
        [Required(ErrorMessage = "Telefon Nuamrası Hatalı")]
        [Display(Name = "Telefon Numarası")]
        public string Telno { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Avm.Models.Urunler> Urunlers { get; set; }
    }
}
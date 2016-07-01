using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Avm.Models
{
    public class dbContext : DbContext
    {
        public virtual DbSet<Satislar> Satis { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
    }
}
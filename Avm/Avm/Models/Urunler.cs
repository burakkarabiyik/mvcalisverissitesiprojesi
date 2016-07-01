using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Avm.Models
{
    public class Urunler
    {  
        public int Id { get; set; }
        public String Urunadi { get; set; }
        public byte[] UrunResim { get; set; } 
        public int Fiyat { get; set; }
        public String Aciklama { get; set; }
        public String Aciklama2 { get; set; }
        public int indirim { get; set; }
        public string tür { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Avm.Models
{
    public class Satislar
    { 
        public int id { get; set; }
        public String aliciid { get; set; }
        public int urunid{ get; set; }
    }
}
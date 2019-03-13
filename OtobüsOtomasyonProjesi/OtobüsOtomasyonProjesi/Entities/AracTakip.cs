using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobüsOtomasyonProjesi.Entities
{
    public class AracTakip
    {
        [Key]
        public int AracTakipID { get; set; }
        public string AracPlaka { get; set; }
        public DateTime AracHareketTarihi { get; set; }
        public int AracToplamTutar { get; set; }
    }
}

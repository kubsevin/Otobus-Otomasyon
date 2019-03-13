using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobüsOtomasyonProjesi.Entities
{
    public class Otobus
    {
        [Key]
        public int OtobusID { get; set; }
        public string Plaka { get; set; }
        public string OtobusModel { get; set; }
        public byte[] OtobusResim { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobüsOtomasyonProjesi.Entities
{
    public class Sehir
    {
        [Key]
        public int SehirID { get; set; }
        public int SehirNo { get; set; }
        public string SehirAdi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobüsOtomasyonProjesi.Entities
{
    public class BiletAl
    {
        [Key]
        public int BiletAlID { get; set; }
        public int OtobusID { get; set; }
        public int KalkisSehriID { get; set; }
        public int VarisSehriID { get; set; }
        public int KoltukNo { get; set; }
        public int BiletUcreti { get; set; }
        public string YolcuAdiSoyadi { get; set; }
        public  Cinsiyet Cinsiyet { get; set; }

        public virtual Otobus Otobus { get; set; }
        public virtual Sehir Sehir { get; set; }
    }
}

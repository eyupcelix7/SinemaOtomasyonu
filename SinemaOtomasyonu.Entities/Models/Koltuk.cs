using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.Entities.Models
{
    public class Koltuk
    {
        public int Id { get; set; }
        public string SalonAdi { get; set; }
        public int SiraNo { get; set; }
        public int KoltukNo { get; set; }
        public bool DoluMu { get; set; }
        public virtual ICollection<Rezervasyon> Rezervasyonlar { get; set; }
    }
}

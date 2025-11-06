using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.Entities.Models
{
    public class Rezervasyon
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int MusteriId { get; set; }
        public int KoltukId { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public virtual Film Film { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Koltuk Koltuk { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.Entities.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Sure { get; set; }
        public DateTime YayinlanmaTarihi { get; set; }
        public virtual ICollection<Rezervasyon> Rezervasyonlar { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.Entities.Models
{
    public class Kasa
    {
        public int Id { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
        public DateTime IslemTarihi { get; set; }
    }
}

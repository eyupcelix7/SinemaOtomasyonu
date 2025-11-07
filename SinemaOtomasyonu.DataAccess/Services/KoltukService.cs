using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Services
{
    public class KoltukService
    {
        private readonly SinemaContext _context;
        public KoltukService(SinemaContext context)
        {
            _context = context;
        }

        public void UpdateKoltuk(Koltuk koltuk)
        {
            var existingKoltuk = _context.Koltuklar.FirstOrDefault(k=> k.Id == koltuk.Id);

            if(existingKoltuk != null)
            {
                existingKoltuk.SalonAdi = koltuk.SalonAdi;
                existingKoltuk.SiraNo = koltuk.SiraNo;
                existingKoltuk.KoltukNo = koltuk.KoltukNo;
                existingKoltuk.DoluMu = koltuk.DoluMu;
                _context.SaveChanges();

            }
        }
    }
}

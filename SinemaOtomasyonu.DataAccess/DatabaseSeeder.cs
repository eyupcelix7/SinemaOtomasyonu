using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess
{
    public class DatabaseSeeder
    {
        private readonly SinemaContext _context;
        public DatabaseSeeder(SinemaContext context)
        {
            _context = context;
        }

        public void SeedKoltuklar()
        {
            if (!_context.Koltuklar.Any())
            {
                for (int i = 0;i <= 50;i++)
                {
                    _context.Koltuklar.Add(new Koltuk
                    {
                        SalonAdi = "Salon 1",
                        SiraNo = (i - 1) / 10 + 1,
                        KoltukNo = i,
                        DoluMu = false
                    });
                }
                _context.SaveChanges();
            }
        }
    }
}

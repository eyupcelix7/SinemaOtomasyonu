using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Services
{
    public class RezervasyonService
    {
        private SinemaContext _context;
        public RezervasyonService(SinemaContext context)
        {
            _context = context;
        }

        public void RezervasyonAdd(Rezervasyon rezervasyon)
        {
            _context.Rezervasyonlar.Add(rezervasyon);
            _context.SaveChanges();
        }
    }
}

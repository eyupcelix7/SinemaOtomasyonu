using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Services
{
    public class KasaService
    {
        private SinemaContext _context;
        public KasaService(SinemaContext context)
        {
            _context = context;
        }
        public void AddKasa(Kasa kasa)
        {
            _context.Kasalar.Add(kasa);
            _context.SaveChanges();
        }
        public void UpdateKasa(Kasa kasa)
        {
            var existingKasa =_context.Kasalar.FirstOrDefault(k=> k.Id == kasa.Id);
            if (existingKasa != null)
            {
                existingKasa.Aciklama = kasa.Aciklama;
                existingKasa.Tutar = kasa.Tutar;
                existingKasa.IslemTarihi = kasa.IslemTarihi;
            }
            _context.SaveChanges();
        }
        public List<Kasa> GetAll()
        {
            return _context.Kasalar.ToList();
        }
    }
}

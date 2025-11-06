using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Services
{
    public class MusteriService
    {
        private readonly SinemaContext _context;
        public MusteriService(SinemaContext context)
        {
            _context = context;
        }

        public void AddCustomer(Musteri musteri)
        {
            _context.Musteriler.Add(musteri);
            _context.SaveChanges();
        }
        public List<Musteri> GetAllCustomers() 
        { 
            return _context.Musteriler.ToList();
        }
        public Musteri GetCustomerById(int id)
        {
            return _context.Musteriler.FirstOrDefault(m => m.Id == id);
        }
        public void UpdateCustomer(Musteri musteri)
        {
            var existingCustomer = _context.Musteriler.FirstOrDefault(m=> m.Id == musteri.Id);
            if(existingCustomer != null)
            {
                existingCustomer.Ad = musteri.Ad;
                existingCustomer.Soyad = musteri.Soyad;
                existingCustomer.Telefon = musteri.Telefon;
                existingCustomer.Email = musteri.Email;
                _context.SaveChanges();
            }
        }
        public void DeleteCustomer(int id)
        {
            var existingCustomer = _context.Musteriler.FirstOrDefault(m => m.Id == id);
            if(existingCustomer != null)
            {
                _context.Musteriler.Remove(existingCustomer);
                _context.SaveChanges();
            }
        }
    }
}

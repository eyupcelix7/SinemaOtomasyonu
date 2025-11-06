using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Services
{
    public class FilmService
    {
        private readonly SinemaContext _context;
        public FilmService(SinemaContext context)
        {
            _context = context;
        }
        public void AddFilm(Film film)
        { 
            _context.Filmler.Add(film);
            _context.SaveChanges();
        }
        public List<Film> GetAllFilm()
        {
            return _context.Filmler.ToList();
        }
        public Film GetFilmById(int id)
        { 
            return _context.Filmler.FirstOrDefault(film=> film.Id == id); 
        }
        public void UpdateFilm(Film film) 
        {
            var updateFilm = _context.Filmler.FirstOrDefault(f => f.Id == film.Id);
            if (updateFilm != null)
            {
                updateFilm.Ad = film.Ad;
                updateFilm.Sure = film.Sure;
                updateFilm.Tur = film.Tur;
                updateFilm.YayinlanmaTarihi = film.YayinlanmaTarihi;
                _context.SaveChanges();
            }
        }
        public void DeleteFilm(int id) 
        { 
            var deleteFilm = _context.Filmler.FirstOrDefault(f=> f.Id == id);
            if(deleteFilm != null)
            {
                _context.Filmler.Remove(deleteFilm);
                _context.SaveChanges();
            }
        }
    }
}

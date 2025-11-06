using SinemaOtomasyonu.DataAccess.Mappings;
using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess
{
    public class SinemaContext: DbContext
    {
        public SinemaContext(): base ("SinemaOtomasyonuEFContext") { }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Koltuk> Koltuklar { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FilmMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new KoltukMap());
            modelBuilder.Configurations.Add(new MusteriMap());
            modelBuilder.Configurations.Add(new RezervasyonMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Mappings
{
    public class FilmMap: EntityTypeConfiguration<Film>
    {
        public FilmMap() 
        {
            ToTable("Filmler");
            HasKey(x=> x.Id);
            Property(x => x.Ad).IsRequired().HasMaxLength(100);
            Property(x=> x.Tur).IsRequired().HasMaxLength(50);
            Property(x => x.Sure).IsRequired();
            Property(x=> x.YayinlanmaTarihi).HasColumnType("datetime");
            HasMany(x=> x.Rezervasyonlar).WithRequired(r=> r.Film).HasForeignKey(r=>r.FilmId).WillCascadeOnDelete(false);
        }
    }
}

using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Mappings
{
    public class RezervasyonMap: EntityTypeConfiguration<Rezervasyon>
    {
        public RezervasyonMap()
        {
            ToTable("Rezervasyonlar");
            HasKey(x=> x.Id);
            Property(x => x.RezervasyonTarihi).HasColumnType("datetime").IsRequired();

            HasRequired(x=> x.Film)
                .WithMany(x=> x.Rezervasyonlar)
                .HasForeignKey(x=> x.FilmId)
                .WillCascadeOnDelete(false);

            HasRequired(x=> x.Musteri).WithMany(x=> x.Rezervasyonlar).HasForeignKey(x=> x.MusteriId).WillCascadeOnDelete(false);

            HasRequired(x => x.Koltuk).WithMany(x => x.Rezervasyonlar).HasForeignKey(x => x.KoltukId).WillCascadeOnDelete(false);

        }
    }
}

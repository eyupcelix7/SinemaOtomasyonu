using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Mappings
{
    public class MusteriMap : EntityTypeConfiguration<Musteri>
    {
        public MusteriMap()
        {
            ToTable("Musteriler");

            HasKey(x=> x.Id);
            Property(x=> x.Ad).IsRequired().HasMaxLength(50);
            Property(x=> x.Soyad).IsRequired().HasMaxLength(50);
            Property(x=> x.Telefon).HasMaxLength(20);
            Property(x=> x.Email).HasMaxLength(100);
            HasMany(x=> x.Rezervasyonlar).WithRequired(r=> r.Musteri).HasForeignKey(r=> r.MusteriId).WillCascadeOnDelete(false);
        }
    }
}

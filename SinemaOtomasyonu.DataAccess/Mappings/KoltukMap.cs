using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Mappings
{
    public class KoltukMap: EntityTypeConfiguration<Koltuk>
    {
        public KoltukMap()
        {
            ToTable("Koltuklar");
            HasKey(x => x.Id);
            Property(x=> x.SalonAdi)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.SiraNo)
                .IsRequired();

            Property(x=> x.KoltukNo)
                .IsRequired();

            Property(x=> x.DoluMu)
                .IsRequired();

            HasMany(x => x.Rezervasyonlar)
                .WithRequired(r => r.Koltuk)
                .HasForeignKey(x => x.KoltukId)
                .WillCascadeOnDelete(false);
        }
    }
}

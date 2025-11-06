using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.DataAccess.Mappings
{
    public class KasaMap: EntityTypeConfiguration<Kasa>
    {
        public KasaMap()
        {
            ToTable("Kasa");
            HasKey(kasa => kasa.Id);
            Property(kasa=> kasa.Tutar).HasColumnType("money").IsRequired();
            Property(kasa=> kasa.Aciklama).HasMaxLength(100);
            Property(kasa => kasa.IslemTarihi).HasColumnType("datetime").IsRequired();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobileStore.Entities.Catalog;

namespace TKMobileStore.Data.Mapping.Catalog
{
    public partial class ManufacturerMap : EntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerMap()
        {
            this.ToTable("Manufacturer");
            this.HasKey(m => m.Id);
            this.Property(m => m.Name).IsRequired().HasMaxLength(400);
            this.Property(m => m.MetaKeywords).HasMaxLength(400);
            this.Property(m => m.MetaTitle).HasMaxLength(400);
            this.Property(m => m.PriceRanges).HasMaxLength(400);
        }
    }
}

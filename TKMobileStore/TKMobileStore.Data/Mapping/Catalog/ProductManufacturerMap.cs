using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobileStore.Entities.Catalog;

namespace TKMobileStore.Data.Mapping.Catalog
{
    public partial class ProductManufacturerMap: EntityTypeConfiguration<ProductManufacturer>
    {
        public ProductManufacturerMap()
        {
            this.ToTable("Product_Manufacturer_Mapping");
            this.HasKey(pm => pm.Id);

            this.HasRequired(pm => pm.Product)
                .WithMany(p => p.ProductManufacturers)
                .HasForeignKey(pm => pm.ProductId);

            this.HasRequired(pm => pm.Manufacturer)
                .WithMany()
                .HasForeignKey(pm => pm.ManufacturerId);
        }
    }
}

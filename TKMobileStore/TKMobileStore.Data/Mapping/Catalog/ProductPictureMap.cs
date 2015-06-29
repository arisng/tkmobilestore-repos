using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobileStore.Entities.Catalog;

namespace TKMobileStore.Data.Mapping.Catalog
{
    public partial class ProductPictureMap : EntityTypeConfiguration<ProductPicture>
    {
        public ProductPictureMap()
        {
            this.ToTable("Product_Picture_Mapping");
            this.HasKey(pp => pp.Id);

            this.HasRequired(pp => pp.Picture)
                .WithMany(p => p.ProductPictures)
                .HasForeignKey(pp => pp.PictureId);

            this.HasRequired(pp => pp.Product)
                .WithMany(p => p.ProductPictures)
                .HasForeignKey(pp => pp.ProductId);
        }
    }
}

using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobileStore.Core.Domain.Catalog;
using TKMobileStore.Core.Domain.Discounts;
using TKMobileStore.Core.Domain.Media;
using TKMobileStore.Core.Domain.Seo;
using TKMobileStore.Core.Domain.User;
using TKMobileStore.Data.Mapping.Catalog;
using TKMobileStore.Data.Mapping.Media;
using TKMobileStore.Data.Mapping.Seo;

namespace TKMobileStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ApplicationDbContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        #region Catalog

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ProductManufacturer> ProductManufacturers { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }

        #endregion

        #region Media

        public DbSet<Picture> Pictures { get; set; }

        #endregion

        #region Discount

        public DbSet<Discount> Discounts { get; set; }

        #endregion

        #region Seo

        public DbSet<UrlRecord> UrlRecords { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ManufacturerMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new ProductManufacturerMap());
            modelBuilder.Configurations.Add(new ProductCommentMap());
            modelBuilder.Configurations.Add(new ProductPictureMap());
            modelBuilder.Configurations.Add(new ProductTagMap());

            modelBuilder.Configurations.Add(new PictureMap());

            modelBuilder.Configurations.Add(new UrlRecordMap());
        }
    }
}

using System.Collections.Generic;

namespace TKMobileStore.Core.Domain.Catalog
{
    public partial class ProductTag : BaseEntity
    {
        private ICollection<Product> products;

        public string Name { get; set; }

        public virtual ICollection<Product> Products
        {
            get { return products ?? (products = new List<Product>()); }
            set { products = value; }
        }
    }
}

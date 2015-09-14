using System.Collections.Generic;

namespace TKMobileStore.Core.Domain.Catalog
{
    public class ProductSpecification : BaseEntity, ISoftDeleteable
    {
        public bool Deleted { get; set; }

        public string ProductName { get; set; }

        public virtual ICollection<ProductSpecificationAttribute> ProductSpecificationAttributes { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

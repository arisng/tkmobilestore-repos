using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKMobileStore.Entities.Catalog
{
    public class ProductSpecification : BaseEntity, ISoftDeleteable
    {
        public bool Deleted { get; set; }

        public string ProductName { get; set; }

        public virtual ICollection<ProductSpecificationAttribute> ProductSpecificationAttributes { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

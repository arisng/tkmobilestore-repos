using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKMobileStore.Entities.Catalog
{
    public partial class Manufacturer : BaseEntity, ISoftDeleteable
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public string MetaTitle { get; set; }

        public int PictureId { get; set; }

        public string PriceRanges { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }
    }
}

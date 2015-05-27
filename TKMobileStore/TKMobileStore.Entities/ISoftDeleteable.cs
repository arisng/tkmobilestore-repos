using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKMobileStore.Entities
{
    public interface ISoftDeleteable
    {
        bool Deleted { get; set; }
    }
}

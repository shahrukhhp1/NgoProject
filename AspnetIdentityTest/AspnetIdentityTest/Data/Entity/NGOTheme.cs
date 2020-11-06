using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class NGOTheme : BaseEntity
    {
        public long? NGOId { get; set; }
        public virtual NGO NGO { get; set; }

        public long? ThemeId { get; set; }
        public virtual Theme Theme { get; set; }
    }
}

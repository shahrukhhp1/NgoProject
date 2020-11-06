using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class NGOCity : BaseEntity
    {
        public long? CityId { get; set; }
        public virtual City City { get; set; }

        public long? NGOId { get; set; }
        public virtual NGO NGO { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class NGOProvince : BaseEntity
    {
        public long? ProvinceId { get; set; }
        public virtual Province Province { get; set; }

        public long? NGOId { get; set; }
        public virtual NGO NGO { get; set; }
    }
}

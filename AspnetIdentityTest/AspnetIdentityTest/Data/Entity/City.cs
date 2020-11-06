using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public long? ProvinceId { get; set; }
        public virtual Province Province { get; set; }
    }
}

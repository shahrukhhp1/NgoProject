using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class Province : BaseEntity
    {
        public Province()
        {
            this.Cities = new HashSet<City>();
        }

        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}

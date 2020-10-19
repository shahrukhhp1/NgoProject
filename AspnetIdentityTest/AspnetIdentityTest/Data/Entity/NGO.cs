using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class NGO : BaseEntity
    {
        public NGO()
        {
            this.Users = new HashSet<ApplicationUser>();
        }
        public string Name { get; set; }
        public string CEOName { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}

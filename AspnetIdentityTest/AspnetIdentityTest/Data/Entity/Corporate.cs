using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class Corporate: BaseEntity
    {
        public Corporate()
        {
            this.Users = new HashSet<ApplicationUser>();
        }
        public string Name { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }
}

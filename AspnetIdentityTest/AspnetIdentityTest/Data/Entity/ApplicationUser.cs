using AspnetIdentityTest.Data.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public int IntId { get; set; }
        public UserType UserType { get; set; }


        public long? CorporateUserId { get; set; }
        public virtual Corporate CorporateUser { get; set;}

        public long? NGOUserId { get; set; }
        public virtual NGO NGOUser { get; set; }
    }
}

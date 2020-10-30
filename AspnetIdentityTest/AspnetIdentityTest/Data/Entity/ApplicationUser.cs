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


        public long? CorporateId { get; set; }
        public virtual Corporate Corporate { get; set;}

        public long? NGOId { get; set; }
        public virtual NGO NGO { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using AspnetIdentityTest.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspnetIdentityTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<NGO> NGOs { get; set; }
        
    }
}

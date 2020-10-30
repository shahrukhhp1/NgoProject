using AspnetIdentityTest.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data
{
    public class SeedData : ISeedData
    {
        private ApplicationDbContext _context;

        public SeedData(ApplicationDbContext context)
        {
            _context = context;
        }

        public async void SeedAdminUser()
        {
            var corp = new Corporate
            {
                Name = "Apple"
            };

            var user = new ApplicationUser
            {
                UserName = "admin@email.com",
                NormalizedUserName = "admin@email.com",
                Email = "admin@email.com",
                NormalizedEmail = "admin@email.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var corpUser = new ApplicationUser
            {
                UserName = "apple@email.com",
                NormalizedUserName = "apple@email.com",
                Email = "apple@email.com",
                NormalizedEmail = "apple@email.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };


            //var roleStore = new RoleStore<IdentityRole>(_context);

            //if (!_context.Roles.Any(r => r.Name == "admin"))
            //{
            //    await roleStore.CreateAsync(new IdentityRole { Name = "admin", NormalizedName = "admin" });
            //    await roleStore.CreateAsync(new IdentityRole { Name = "corporate", NormalizedName = "corporate" });
            //}
            if (!_context.Corporates.Any(x => x.Name == corp.Name))
            {
                await _context.Corporates.AddAsync(corp);
                await _context.SaveChangesAsync();
            }
            else {
                corp = _context.Corporates.FirstOrDefault(x => x.Name == corp.Name);
            }
            if (!_context.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user, "123456");
                user.PasswordHash = hashed;

                await _context.AddAsync(user);
                await _context.UserClaims.AddAsync(new IdentityUserClaim<string>() { UserId = user.Id , ClaimType = "admin", ClaimValue = "admin" });
                //var userStore = new UserStore<ApplicationUser>(_context);
                //await userStore.CreateAsync(user);
                await _context.SaveChangesAsync();
                //await userStore.AddClaimsAsync(user, new List<Claim>() { new Claim(ClaimTypes.Role, "admin") });
                //await userStore.AddToRoleAsync(user, "admin");
                //await userStore.AddClaimsAsync(user
            }
            if (!_context.Users.Any(u => u.UserName == corpUser.UserName))
            {
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(corpUser, "123456");
                corpUser.PasswordHash = hashed;
                corpUser.CorporateId = corp.Id;

                await _context.AddAsync(corpUser);
                await _context.UserClaims.AddAsync(new IdentityUserClaim<string>() { UserId = corpUser.Id, ClaimType = "corporate", ClaimValue = "corporate" });
                //var userStore = new UserStore<ApplicationUser>(_context);
                //await userStore.CreateAsync(user);
                await _context.SaveChangesAsync();
                //await userStore.AddClaimsAsync(corpUser, new List<Claim>() { new Claim(ClaimTypes.Role, "corporate") });
            }

            
        }
    }
}

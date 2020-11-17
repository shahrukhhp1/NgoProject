using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspnetIdentityTest.Models;
using AspnetIdentityTest.Extensions;
using AspnetIdentityTest.Data;
using AspnetIdentityTest.Data.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AspnetIdentityTest.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public HomeController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            if (User.IsCorporate())
            {
                return RedirectToAction("Index", "Home", new { area = "corporate" });
            }
            return View();
        }

        public IActionResult RegisterNGO()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubmitNGO(NgoVM data)
        {
            var ngo = _mapper.Map<NGO>(data);
            await _context.NGOs.AddAsync(ngo);
            await _context.SaveChangesAsync();

            var ngoUser = new ApplicationUser
            {
                UserName = data.User,
                NormalizedUserName = data.User,
                Email = data.Email,
                NormalizedEmail = data.Email,
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                NGOId = ngo.Id
            };

            var password = new PasswordHasher<ApplicationUser>();
            var hashed = password.HashPassword(ngoUser, data.Password);
            ngoUser.PasswordHash = hashed;

            await _context.AddAsync(ngoUser);
            await _context.UserClaims.AddAsync(new IdentityUserClaim<string>() { UserId = ngoUser.Id, ClaimType = "ngo", ClaimValue = "ngo" });
            await _context.SaveChangesAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

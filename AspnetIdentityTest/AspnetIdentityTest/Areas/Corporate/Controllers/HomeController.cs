using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetIdentityTest.Areas.Corporate.Models;
using AspnetIdentityTest.Data;
using AspnetIdentityTest.Data.Entity;
using AspnetIdentityTest.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspnetIdentityTest.Areas.Corporate.Controllers
{
    [Area("Corporate")]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        //protected UserManager<ApplicationUser> UserManager { get; set; }
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateGrantForm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUpdateGrantForm(GrantFormVM data)
        {
            var a = data;
            var userId = User.GetIdentity();
            if (!string.IsNullOrEmpty(userId))
            {
                var user = await _context.ApplicationUser.Where(x => x.Id.Equals(userId)).FirstOrDefaultAsync();
                //.Where(x => x.Id.Equals(userId)).FirstOrDefault();
                if (user != null && user.CorporateId.HasValue)
                {

                }
            }

            return View();
        }
    }
}
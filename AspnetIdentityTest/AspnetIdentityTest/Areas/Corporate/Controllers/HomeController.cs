using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspnetIdentityTest.Areas.Corporate.Controllers
{
    [Area("Corporate")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateGrantForm()
        {
            return View();
        }
    }
}
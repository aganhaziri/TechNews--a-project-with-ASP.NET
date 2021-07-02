using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Testi.Models;

namespace Testi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PC()
        {
            return View();
        }
        public IActionResult Smartphone()
        {
            return View();
        }
        public IActionResult Software()
        {
            return View();
        }
        public IActionResult Gaming()
        {
            return View();
        }
        public IActionResult Laptops()
        {
            return View();
        }
        public IActionResult Security()
        {
            return View();
        }
        public IActionResult Networking()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Details1()
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

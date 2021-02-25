using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadastros.Models;

namespace Cadastros.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }
                public IActionResult Sobre()
        {
            return View();
        }
                public IActionResult Produtos()
        {
            return View();
        }
                public IActionResult Portfolio()
        {
            return View();
        }
                public IActionResult Galeria()
        {
            return View();
        }
                public IActionResult Servicos()
        {
            return View();
        }

    }
}

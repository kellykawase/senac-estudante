using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KellyKawase.Models;

namespace KellyKawase.Controllers
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

        public IActionResult PreAgendamento()
        {
            return View();
        }

        [HttpPost]
                public IActionResult PreAgendamento(Consulta consulta)
        {
            ViewBag.agendamento_nome = consulta.nome;
            ViewBag.agendamento_telefone = consulta.telefone;
            ViewBag.agendamento_data = consulta.data;
            ViewBag.agendamento_animal = consulta.animal;
            ViewBag.agendamento_necessidade = consulta.necessidade;
            return View("Confirmado");

        }

                public IActionResult Servicos()

        {
            return View();
        }
        public IActionResult Confirmado()
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

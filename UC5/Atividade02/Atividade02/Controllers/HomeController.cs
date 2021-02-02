using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade02.Models;

namespace Atividade02.Controllers
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
        
        public IActionResult Formulario(){        
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(ItemPedido item){
           Dados.PedidoAtual.IncluirPedido(item);
           return View("Confirmacao");
            
        }
        public IActionResult Listar()
        {
            List<ItemPedido> l = Dados.PedidoAtual.Listar();
            return View(l);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

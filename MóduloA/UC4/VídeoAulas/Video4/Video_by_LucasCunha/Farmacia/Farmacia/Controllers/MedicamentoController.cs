using System;
using System.Collections.Generic;
using Farmacia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Farmacia.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Lista()
        {
            MedicamentoRepository medicamentoRepo = new MedicamentoRepository();
            List<Medicamento> medicamentos = medicamentoRepo.Lista();
            return View(medicamentos);
        }
        [HttpPost]
        public IActionResult AdicionaASacola(ItemPedido novoItem)
        {
            List<ItemPedido> itensSacola = new List<ItemPedido>();
            string listaEmTexto = HttpContext.Session.GetString("sacola");
            if (!String.IsNullOrEmpty(listaEmTexto))
            {
                itensSacola = JsonConvert.DeserializeObject<List<ItemPedido>>(listaEmTexto);
            }
            itensSacola.Add(novoItem);
            listaEmTexto = JsonConvert.SerializeObject(itensSacola);
            HttpContext.Session.SetString("sacola", listaEmTexto);
            return RedirectToAction("Lista");
        }
    }
}
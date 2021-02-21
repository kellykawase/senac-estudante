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
    public class UsuarioController: Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert(u);
            ViewBag.Mensagem = "Usuario Cadastrado com sucesso";
            return View();
        }

        public IActionResult Listar()
        {
            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> usuarios = ur.Query();
            return View(usuarios);
        }
    }
}
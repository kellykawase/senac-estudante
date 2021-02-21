using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadastros.Models;
using Microsoft.AspNetCore.Http;

namespace Cadastros.Controllers
{
    public class UsuarioController: Controller
    {
        public IActionResult Cadastro()
        {
            if(HttpContext.Session.GetInt32("idUsuario") == null)
            return RedirectToAction("Login");
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
            if(HttpContext.Session.GetInt32("idUsuario") == null)
            return RedirectToAction("Login");
            
            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> usuarios = ur.Query();
            return View(usuarios);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.QueryLogin(u);
            if(usuario != null)
            {
                ViewBag.Mensagem = "Você está logado";
                HttpContext.Session.SetInt32("idUsuario", usuario.Id);
                HttpContext.Session.SetString("nomeUsuario", usuario.Nome);
                return Redirect("Cadastro");
            }
            else{
                ViewBag.Mensagem = "Falha no Login";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();//limpa toda a sessão
            return View("Login");
        }
    }
}
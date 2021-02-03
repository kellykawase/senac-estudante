using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SQLInjection.Models;
namespace SQLInjection.Controllers
{
    public class EntradaController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string usuario, string senha)
        {
            try
            {
                string stringConexao = "Database=usuariosdb;Data Source=localhost;User Id=root;";
                using (var conexao = new MySqlConnection(stringConexao))
                {
                    conexao.Open();
                    var consulta = "SELECT COUNT(*) FROM tabelausuarios WHERE usuario = '" + usuario + "' AND Senha = '" + senha + "'";
                    MySqlCommand myCommand = new MySqlCommand(consulta);
                    myCommand.Connection = conexao;
                    Int64 resultado = (Int64)myCommand.ExecuteScalar();
                    if (resultado > 0)
                        ViewBag.Mensagem = "Login efetuado com sucesso";
                    else
                        ViewBag.Mensagem = "Falha no login";
                    myCommand.Connection.Close();
                }
            }
            catch (Exception e)
            {
                ViewBag.Mensagem = "Erro: " + e.Message;
            }
            return View();
        }
    }
}
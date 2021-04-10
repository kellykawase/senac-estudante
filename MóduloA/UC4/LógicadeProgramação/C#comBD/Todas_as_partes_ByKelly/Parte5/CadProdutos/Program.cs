using System;

namespace CadProdutos
{
    class Program
    {
       static void Main(string[] args)
{
  Console.WriteLine("Cadastrando Produto");
  Console.Write("Digite C para cadastrar ou L para listar:");
  string comando = Console.ReadLine();

  ProdutoRepository pr = new ProdutoRepository();
  string nome, fabricante;

  switch(comando)
  {
    case "C":

  Console.Write("Digite o nome do produto: ");
  nome = Console.ReadLine();

  Console.Write("Digite o fabricante do produto: ");
  fabricante = Console.ReadLine();

  pr.Insert(nome, fabricante);
  break;

  case "L":
  pr.Query();
  break;

  default:
  Console.WriteLine("Comando inválido");
  break;
}
    }
    }
}


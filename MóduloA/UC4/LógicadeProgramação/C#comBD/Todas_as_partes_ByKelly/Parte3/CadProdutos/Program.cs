using System;

namespace CadProdutos
{
    class Program
    {
       static void Main(string[] args)
{
  Console.WriteLine("Cadastrando Produto");

  Console.Write("Digite o nome do produto: ");
  string nome = Console.ReadLine();

  Console.Write("Digite o fabricante do produto: ");
  string fabricante = Console.ReadLine();

  ProdutoRepository pr = new ProdutoRepository();
  pr.Insert(nome, fabricante);
  pr.Query();
}
    }
}

using System;
using System.Collections.Generic;

namespace CadProdutos
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Cadastrando Produto");
      Console.Write("Digite C para cadastrar, L para listar, A para atualizar:");
      string comando = Console.ReadLine();
      ProdutoRepository pr = new ProdutoRepository();
      string nome, fabricante;
      Produto prod;

      switch (comando.ToUpper())
      {
        case "C": //código insert sem completar o desafio proposto
          Console.Write("Digite o nome do produto: ");
          nome = Console.ReadLine();

          Console.Write("Digite o fabricante do produto: ");
          fabricante = Console.ReadLine();

          pr.Insert(nome, fabricante);
          break;

        case "L":
          List<Produto> lista = pr.Query("prod");
          foreach (Produto p in lista)
          {
            Console.WriteLine(p.ToString());
          }
          break;

        case "A":
          prod = new Produto();
          Console.Write("Digite o id do produto que será atulizado: ");

          prod.Id = int.Parse(Console.ReadLine());

          Console.Write("Digite o novo nome do produto: ");
          prod.Nome = Console.ReadLine();

          Console.Write("Digite o novo fabricante do produto: ");
          prod.Fabricante = Console.ReadLine();

          Console.Write("Digite o novo preco do produto: ");
          prod.Preco = Decimal.Parse(Console.ReadLine());

          Console.Write("O produto está disponível [s/n]: ");
          prod.Disponivel = (Console.ReadLine().ToLower() == "s");

          pr.Update(prod);
          break;

        default:
          Console.WriteLine("Comando inválido");
          break;
      }
    }
  }
}

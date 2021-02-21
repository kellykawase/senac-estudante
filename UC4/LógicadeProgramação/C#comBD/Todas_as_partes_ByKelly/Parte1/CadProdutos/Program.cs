using System;

namespace CadProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastrando Produto");
            ProdutoRepository pr = new ProdutoRepository();
            pr.Insert();
        }
    }
}

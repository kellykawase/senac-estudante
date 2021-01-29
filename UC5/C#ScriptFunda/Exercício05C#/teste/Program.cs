using System;
using System.Collections.Generic;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaDeInteiro = new List<int>();
            listaDeInteiro.Add(1);
            listaDeInteiro.Add(5);
            listaDeInteiro.Add(4);

            for(int i = 0; i < listaDeInteiro.Count; i++)
            {
                Console.WriteLine(listaDeInteiro[i]);
            }

            Console.WriteLine(listaDeInteiro.IndexOf(4));//acha o índice 2 que tem o valor 4 armazenado
            Console.WriteLine("--------------------------------");
            listaDeInteiro.Remove(5);//remove o elemento 5 da lista
            for(int i = 0; i < listaDeInteiro.Count; i++)
            {
                Console.WriteLine(listaDeInteiro[i]);
            }
        }
    }
}
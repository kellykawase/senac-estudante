using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, mult, fat, i,cont;
            Console.WriteLine("Informe um número inteiro:");
            num = int.Parse(Console.ReadLine());
            mult = num;
            cont = num;
            Console.WriteLine("Interação: {0}",num);
            for (i=1;i<cont;i++)
            {
               Console.WriteLine("--------------------------");
               Console.WriteLine("Interação: {0}",i);
               num = num - 1;
               Console.WriteLine("Multiplicação = {0} x {1} ",mult,num);
               mult = mult * num;
               Console.WriteLine("Resultado ={0} ",mult);
            }
            fat = mult;
             Console.WriteLine("Fatorial ({0}) = {1} ",cont,fat);   
        }
    }
}

using System;

namespace exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, par=0, impar=0;            

           do{
            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());
            if(num%2==0)
                {
                    par = par + 1;
                }
                   if((num !=9999) && (num%2==1))
                   {                                       
                    impar = impar + 1;
                   }                   
                                       
            }while(num !=9999);
            Console.WriteLine("Quantidade de números pares: {0}",par);
            Console.WriteLine("Quantidade de números ímpares: {0}",impar);
        }
    }
}

using System;

namespace exerc03
{
    class Program
    {
                 static void Main(string[] args)
        {
            

            Console.Write("Digite um número inteiro positivo:");
            int x = int.Parse(Console.ReadLine());
            if (Valor(x) == true)
            {
                Console.WriteLine("É primo!");
            }
            else         
               Console.WriteLine("Não é primo!");
               }
          static bool Valor(int y)
        {

            int cont=0;
            for(int i=0;i<y;i++)
            {
                if((y%(i+1))==0)
                {
                    cont = cont + 1;
                }
            }
            
                if(cont==2)
                {
                   return true; 
                }
                   return false;
        }

        }
    }
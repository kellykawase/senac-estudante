using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,cont=3000;
            for(i=1;i<3000;i++)
            {
            cont = cont - 1;
            Console.WriteLine("{0}º: {1}",i,cont);
            }            
        }
    }
}

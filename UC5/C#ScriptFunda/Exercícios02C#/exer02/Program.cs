using System;

namespace exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = {-9, -5, -3, 1, 1.9, 9, 11, 12, 33, 78};
            Console.Write("Valores antigos do vetor:");
            Console.Write("( ");
            for(int i=0; i<vetor.Length;i++)
            {
                
                Console.Write(" {0} ",vetor[i]);
                if(vetor[i]<0)
                {
                    vetor[i]=0;
                }

            }
            Console.WriteLine(" )");
            Console.Write("Novos valores do vetor:  ");
             Console.Write("(  ");
             for(int i=0; i<vetor.Length;i++)
            {
                
                Console.Write(" {0} ",vetor[i]);
            }

            Console.WriteLine(")");
        }
    }
}

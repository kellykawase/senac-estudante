using System;

namespace exerc02
{
    class Program
    {
        static void MenorValor(int[] pArray)
        {
            int menor=pArray[0];
            for(int i=0;i<pArray.Length;i++)
            {
                if( pArray[i]<menor)
                {
                    menor=pArray[i];
                }
            }
            Console.Write("O menor valor é:"+ menor);
        }
        static void Main(string[] args)
        {
            int[] arr = {99, -1,-30,0,1, 10,13,222,3};                   
            MenorValor(arr);
        }
         
        }
    }


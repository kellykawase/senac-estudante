using System;

namespace exer03
{
    class Program
    {
        static void Main(string[] args)
        {
int[] array1 = { 2, 5, 8, 10, 2, 23, 2, 4, 5, 8, 8 };
int contador=0;
int[] vetor = new int[contador];

for(int i = 0; i < array1.Length; i++)
{
    for(int j = i; j < array1.Length; j++)
    {
        if (i != j && array1[j] == array1[i])
            Console.Write( " {0} ",array1[i]);
    }
}
   
        }
    }
}

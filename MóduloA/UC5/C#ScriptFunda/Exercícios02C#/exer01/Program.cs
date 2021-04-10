using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma1=0,soma2=0;
            double[] valor1 = {3,4.99,10,11};
            double[] valor2 = {13,14,16,21,33.33};
            double[] resultado = new double[1];

            for(int i=0;i<valor1.Length; i++)
            {
                soma1 = soma1 + valor1[i];
            }
             for(int i=0;i<valor2.Length; i++)
            {
                soma2 = soma2 + valor2[i];
            }               
            resultado[0] = soma1 +soma2;
            Console.WriteLine("Soma do 1º vetor: {0}",soma1);
            Console.WriteLine("Soma do 2º vetor: {0}",soma2);
            Console.WriteLine("O resultado é: {0}",resultado[0]);

        }
    }
}

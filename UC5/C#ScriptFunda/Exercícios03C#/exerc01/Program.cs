using System;
namespace exerc01
{
    class Program
    {       
        
       static void Main(string[] args)
        {
            double raio;
            Console.Write("Digite o tamanho do raio: ");
            raio = double.Parse(Console.ReadLine());
            double circulo = CalculaAreaCirculo(raio);
            Console.WriteLine($"Área do círculo: {circulo}");
        }
        static double CalculaAreaCirculo(double r)
        {
            double area = 3.14 * Math.Pow(r,2);
            return area;
        }
    }
}
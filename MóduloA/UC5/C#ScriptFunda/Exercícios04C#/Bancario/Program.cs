using System;
namespace Bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaBancaria = new Conta();
            string comando;
            double valor;
            Console.Write("Digite seu nome");
            contaBancaria.Titular = Console.ReadLine();
            contaBancaria.Numero = 1234;
            contaBancaria.DigitoVerificador = 1;
            do
            {
                Console.Write("Digite a operação [d-depósito; s-saque; x-sair] ");
                comando = Console.ReadLine();
                switch(comando)
                {
                    case "d":
                        Console.Write("Digite o valor a depositar: ");
                        valor = double.Parse(Console.ReadLine());
                        contaBancaria.RealizarDeposito(valor);
                        break;
                    case "s":
                        Console.Write("Digite o valor a sacar: ");
                        valor = double.Parse(Console.ReadLine());
                        if(contaBancaria.RelizarSaque(valor) == false)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        break;
                    case "x":
                        Console.WriteLine("Encerrando a aplicação");
                        break;
                    default:
                        Console.WriteLine("Opcao inválida");
                        break;
                }
            }while(comando != "x");
        }
    }
}
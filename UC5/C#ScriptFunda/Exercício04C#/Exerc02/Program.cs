using System;

namespace Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
           Usuario[] cadastro = new Usuario[3];
           string[] nome = new string[3];
           nome[0] = "Kelly";
           nome[1] = "Harumi";
           nome[2] = "Kawase";


                       
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Digite os dados do Usuário {0}: ",nome[i]);
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                string nomes = nome[i];
                cadastro[i] = new Usuario {Login = login, Senha = senha, Nome = nomes};
                Console.WriteLine("-----------------------------------------");
            }
           for(int i=0;i<3;i++)
            {
                Console.WriteLine("Usuário {0}:     ",cadastro[i].Nome);
                Console.Write("Login: {0}   ",cadastro[i].Login);
                Console.WriteLine("Senha: {0} ",cadastro[i].Senha);
                Console.WriteLine("-----------------------------------------");
            }
            
        }
    }
}

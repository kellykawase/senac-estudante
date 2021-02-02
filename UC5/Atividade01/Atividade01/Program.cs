using System;
using System.Collections.Generic;

namespace Atividade01{
    class Program
    {
       
        static void Main(string[] args)
        {
             Pedido lista = new Pedido();
             string resposta = "s";

             Console.WriteLine("-----------------------------------------");
             Console.WriteLine("-------Informe os dados do Pedido--------");

             do{//O programa possibilita informar vários itens de um pedido, informando a 
             //descrição, valor e quantidade.
                 Console.WriteLine("------------------------------------------"); 
                 ItemPedido item = new ItemPedido();                 
                 Console.Write("Nome do item: ");
                 item.descricao = Console.ReadLine();
                 Console.Write("Digite o valor: ");
                 item.valor_unitario = double.Parse(Console.ReadLine());
                 Console.Write("Digite a quantidade: ");
                 item.quantidade = int.Parse(Console.ReadLine());

                 lista.incluirItem(item);
                 
                
                 //O programa pergunta se deseja inserir novo pedido. Se sim, usuário pode incluir novo pedido. Se não, o programa exibe o total do pedido.
                 Console.WriteLine("------------------------------------------"); 
                 Console.WriteLine("Deseja inserir mais algum item? (s/n)");
                 Console.WriteLine("------------------------------------------"); 
                 resposta = Console.ReadLine();

                 if(resposta == "n")
                 {
                     Console.WriteLine("------------------------------------------"); 
                     Console.WriteLine("O valor total do pedido foi R$ {0}",lista.totalizarPedido()); 
                     Console.WriteLine("Agradecemos a preferência!");                    
                     Console.WriteLine("------------------------------------------");
                 }

             }while (resposta == "s");
           
        }
    }

}
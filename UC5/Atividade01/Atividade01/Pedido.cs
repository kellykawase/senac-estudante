using System;
using System.Collections.Generic;

namespace Atividade01{

    public class Pedido//foi criado uma classe Pedido
    {
        private List<ItemPedido> lista = new List<ItemPedido>();
        //Foi criado acima uma propriedade privada do tipo lista (List<>) de ItemPedido
               
        public Pedido()
        {
            List<ItemPedido> lista = new List<ItemPedido>();
        }
        public void incluirItem(ItemPedido item)//Médodo para incluir item
        {
            lista.Add(item);
        }


        public double totalizarPedido()//Método para totalizar o pedido
        //Este retorna um valor Double com o total de todos os itens da lista
        {
            double totalItens = 0;
            for(int i=0; i < lista.Count; i++)
            {
                totalItens = totalItens + lista[i].valor_unitario *lista[i].quantidade;
            }

            return totalItens;
        }
    }

}
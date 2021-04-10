using System.Collections.Generic;

namespace Atividade02.Models
{
    public class Pedido
    {
        private List<ItemPedido> lista = new List<ItemPedido>();

        public void IncluirPedido(ItemPedido item)
        {
            lista.Add(item);
        }
        public List<ItemPedido> Listar(){
            return lista;
        }
        public double Total(){
            double t = 0;

            foreach (ItemPedido i in lista){
                t = t + (i.Valor_unitario * i.Quantidade);
            }
            return t;
        }
    }
}
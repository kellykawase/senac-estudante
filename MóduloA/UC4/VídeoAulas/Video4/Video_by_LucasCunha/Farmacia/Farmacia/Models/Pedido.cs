using System;
using System.Collections.Generic;

namespace Farmacia.Models
{
    public class Pedido
    {
        public int Id {get;set;}
        public DateTime DataPedido {get;set;}
        public bool Entregue {get;set;}
        public Clinica clinica {get;set;}
        public List<ItemPedido> Itens {get;set;}
    }
}
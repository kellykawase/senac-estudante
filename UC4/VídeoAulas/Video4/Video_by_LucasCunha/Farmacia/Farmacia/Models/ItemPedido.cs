namespace Farmacia.Models
{
    public class ItemPedido
    {
        public int Id {get;set;}
        public int Quantidade {get;set;}
        public Pedido pedido {get;set;}
        public Medicamento medicamento {get;set;}
    }
}
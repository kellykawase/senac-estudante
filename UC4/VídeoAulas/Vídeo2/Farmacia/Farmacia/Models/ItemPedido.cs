namespace Farmacia.Models
{
    public class ItemPedido
    {
        public int Id {get; set;}
        public int Quantidade {get; set;}
        public Pedido Pedido {get; set;}
        public Medicamento Medicamento {get;set;}
    }
}
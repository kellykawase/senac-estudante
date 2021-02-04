namespace Farmacia.Models{
    public class Medicamento
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Descricao {get;set;}
        public decimal Valor {get;set;}
        public string Dosagem {get;set;}
        public int QtdEstoque {get;set;}

    }
}
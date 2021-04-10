using System;

namespace CadProdutos
{
  public class Produto
  {
    public int Id {get; set;}
    public string Nome {get; set;}
    public string Fabricante {get; set;}
    public decimal Preco {get; set;}
    public bool Disponivel {get; set;}
    public DateTime DataCadastro {get; set;}

    public override string ToString()
    {
      return $"Id {Id}; Produto: {Nome}; Fabricante: {Fabricante}; Preco: {Preco}; Disponível: {Disponivel}; Data Cadastro:{DataCadastro}";
    }
  }
}
using System;
using System.Collections.Generic;
using MySqlConnector;

namespace CadProdutos
{
    public class ProdutoRepository
    {
        private const string enderecoConexao = "Database=admprodutos;Data Source=localhost;User Id=root;";
        public void Insert(string nome, string fabricante)
        {
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlInsert = "INSERT INTO produto (nome, fabricante, preco, dataCadastro, disponivel)" + "VALUES ('"+ nome +"', '"+ fabricante +"', 1.99, NOW(), 1)";
            MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();

        }
public List<Produto> Query()
{
  MySqlConnection conexao = new MySqlConnection(enderecoConexao);
  conexao.Open();

  string sqlSelect = "SELECT * FROM produto ORDER BY nome";
  MySqlCommand comandoQuery = new MySqlCommand(sqlSelect, conexao);
  MySqlDataReader resultado = comandoQuery.ExecuteReader();

  List<Produto> listaProdutos = new List<Produto>();

  while(resultado.Read())
{
  Produto item = new Produto();
  item.Id = resultado.GetInt32("Id");
  item.Nome = resultado.GetString("Nome");
  item.Fabricante = resultado.GetString("Fabricante");
  item.Preco = resultado.GetDecimal("preco");
  item.Disponivel = resultado.GetBoolean("disponivel");
  item.DataCadastro = resultado.GetDateTime("dataCadastro");

listaProdutos.Add(item);
}
  resultado.Close();
  conexao.Close();

  return listaProdutos;
}
    }
    
}
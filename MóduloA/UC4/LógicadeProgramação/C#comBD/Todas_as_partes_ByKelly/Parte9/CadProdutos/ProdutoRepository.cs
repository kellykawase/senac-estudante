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

      string sqlInsert =
        "INSERT INTO produto (nome, fabricante, preco, dataCadastro, disponivel)" +
        "VALUES ('" + nome + "', '" + fabricante + "', 1.99, NOW(), 1)";
      MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);
      comando.ExecuteNonQuery();

      conexao.Close();
    }

    public List<Produto> Query(string filtroNome)
    {

      MySqlConnection conexao = new MySqlConnection(enderecoConexao);
      conexao.Open();

      string sqlSelect = "SELECT * FROM produto";

      if (!String.IsNullOrEmpty(filtroNome))
        sqlSelect = sqlSelect + $" WHERE nome like '{filtroNome}%'";

      sqlSelect = sqlSelect + " ORDER BY nome";
      MySqlCommand comandoQuery = new MySqlCommand(sqlSelect, conexao);
      MySqlDataReader resultado = comandoQuery.ExecuteReader();

      List<Produto> listaProdutos = new List<Produto>();

      while (resultado.Read())
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

    public void Update(Produto p)
    {
      MySqlConnection conexao = new MySqlConnection(enderecoConexao);
      conexao.Open();

      string sqlUpdate =
        "UPDATE produto " +
        " SET nome = '" + p.Nome + "', fabricante = '" + p.Fabricante + "', " +
          " preco = " + p.Preco.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + ", " +
          " disponivel = " + (p.Disponivel ? 1 : 0) +
        " WHERE id=" + p.Id;
      MySqlCommand comando = new MySqlCommand(sqlUpdate, conexao);
      comando.ExecuteNonQuery();

      conexao.Close();
    }
  }
}

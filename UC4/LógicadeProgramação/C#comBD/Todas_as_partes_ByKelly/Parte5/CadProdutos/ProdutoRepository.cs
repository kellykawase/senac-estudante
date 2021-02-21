using System;
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
        public void Query()
{
  MySqlConnection conexao = new MySqlConnection(enderecoConexao);
  conexao.Open();

  string sqlSelect = "SELECT * FROM produto";
  MySqlCommand comandoQuery = new MySqlCommand(sqlSelect, conexao);
  MySqlDataReader resultado = comandoQuery.ExecuteReader();

  while(resultado.Read())
{
  int id = resultado.GetInt32("Id");
  string nome = resultado.GetString("Nome");
  string fabricante = resultado.GetString("Fabricante");
  decimal preco = resultado.GetDecimal("preco");
  bool disponivel = resultado.GetBoolean("disponivel");
  DateTime dataCadastro = resultado.GetDateTime("dataCadastro");

  Console.WriteLine($"Produto: {nome}; Fabricante: {fabricante}; "+
  $"Preco: {preco}; Disponível: {disponivel}; Data Cadastro:{dataCadastro}");
}
  resultado.Close();
  conexao.Close();
}
    }
    
}
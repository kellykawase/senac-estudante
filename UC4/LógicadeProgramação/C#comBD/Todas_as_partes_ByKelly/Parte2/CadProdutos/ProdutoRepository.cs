using MySqlConnector;

namespace CadProdutos
{
    public class ProdutoRepository
    {
        public void Insert(string nome, string fabricante)
        {
            string enderecoConexao = "Database=admprodutos;Data Source=localhost;User Id=root;";
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlInsert = "INSERT INTO produto (nome, fabricante, preco, dataCadastro, disponivel)" + "VALUES ('"+ nome +"', '"+ fabricante +"', 1.99, NOW(), 1)";
            MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();

        }
    }
    
}
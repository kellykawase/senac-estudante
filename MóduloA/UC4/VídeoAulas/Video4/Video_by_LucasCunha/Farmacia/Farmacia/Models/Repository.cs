using MySqlConnector;

namespace Farmacia.Models
{
    public class Repository
    {
        protected const string _strConexao = "DATABASE=farmacia;Data Source=localhost;User Id=root;";
        protected MySqlConnection conexao = new MySqlConnection(_strConexao);
    }
}
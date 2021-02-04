using MySqlConnector;

namespace Farmacia.Models
{
    public abstract class Repository
    {
        protected const string _strConexao = "Database=farmacia;Data Source=localhost;User Id=root;";
        protected MySqlConnection conexao = new MySqlConnection(_strConexao);
    }
}

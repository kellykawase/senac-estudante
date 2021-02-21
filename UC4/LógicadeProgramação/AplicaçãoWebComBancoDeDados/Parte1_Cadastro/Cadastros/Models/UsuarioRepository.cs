using MySqlConnector;
namespace Cadastros.Models
{
    public class UsuarioRepository
    {
        private const string _strConexao = "Database=ProjCadastros; Data Source=localhost; User Id=root;";
        public void Insert(Usuario novoUsuario)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql= "INSERT INTO usuario(nome, login, senha) VALUES (@Nome, @Login, @Senha)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
            comando.Parameters.AddWithValue("@Login", novoUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", novoUsuario.Senha);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        
    }
}
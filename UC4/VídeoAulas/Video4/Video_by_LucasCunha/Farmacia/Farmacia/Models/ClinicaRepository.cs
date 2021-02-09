using System.Collections.Generic;
using MySqlConnector;

namespace Farmacia.Models
{
    public class ClinicaRepository : Repository
    {
        public void Cadastra (Clinica c)
        {
            conexao.Open();
            string sql = "INSERT INTO Clinica (nome, detalhes) VALUES (@nome, @detalhes);";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", c.Nome);
            comando.Parameters.AddWithValue("@detalhes", c.Detalhes);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Clinica> Lista(int id)
        {
            conexao.Open();
            string sql = "SELECT * FROM Clinica " + (id > 0 ? "WHERE id = @id" : "") + " ORDER BY nome";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            if(id > 0)
            {
                comando.Parameters.AddWithValue("@id", id);
            }
            MySqlDataReader reader = comando.ExecuteReader();
            List<Clinica> lista = new List<Clinica>();

            while(reader.Read())
            {
                Clinica clinica = new Clinica();
                clinica.Id = reader.GetInt32("id");
                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                {
                    clinica.Nome = reader.GetString("nome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("detalhes")))
                {
                    clinica.Detalhes = reader.GetString("detalhes");
                }
                lista.Add(clinica);
            }
            conexao.Close();
            return lista;
        }
        public List<Clinica> Lista()
        {
            return Lista(0);
        }
    }
}
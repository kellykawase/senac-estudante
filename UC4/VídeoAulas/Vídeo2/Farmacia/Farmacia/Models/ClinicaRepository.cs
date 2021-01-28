using System.Collections.Generic;
using MySqlConnector;

namespace Farmacia.Models
{
public class ClinicaRepository : Repository
{

public void Cadastra(Clinica c)
{
conexao.Open();
string sql = "INSERT INTO Clinica (nome, Detalhes)"+"VALUES (@nome, @detalhes)";

MySqlCommand comando = new MySqlCommand(sql, conexao);
comando.Parameters.AddWithValue("@nome", c.Nome);
comando.Parameters.AddWithValue("@detalhes",c.Detalhes);

comando.ExecuteNonQuery();
conexao.Close();
}

 public List<Clinica> Lista(int id)
        {
        conexao.Open();
        string sql = "INSERT INTO Clinica "+ (id > 0 ? "WHERE id = @id" : "") + " ORDER BY nome";
        MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
        if(id > 0){
        comandoQuery.Parameters.AddWithValue("@id", id);
        }
        MySqlDataReader reader = comandoQuery.ExecuteReader();
        List<Clinica> lista = new List<Clinica>();

        while (reader.Read())
        {
            Clinica clinica = new Clinica();
            clinica.Id = reader.GetInt32("Id");

            if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
            clinica.Nome = reader.GetString("Nome");
            if (!reader.IsDBNull(reader.GetOrdinal("Detalhes")))
            lista.Add(clinica);
        }
                conexao.Close();
        return lista;
    }

public List<Clinica> Lista()
    {
        return Lista(0);
    }
}
}
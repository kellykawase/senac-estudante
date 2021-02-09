using System.Collections.Generic;
using MySqlConnector;

namespace Farmacia.Models
{
    public class MedicamentoRepository : Repository
    {
        public void Cadastra(Medicamento m)
        {
            conexao.Open();
            string sql = "INSERT INTO Medicamento (nome, descricao, valor, dosagem, qtdEstoque) VALUES (@nome, @descricao, @valor, @dosagem, @qtdEstoque);";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", m.Nome);
            comando.Parameters.AddWithValue("@descricao", m.Descricao);
            comando.Parameters.AddWithValue("@valor", m.Valor);
            comando.Parameters.AddWithValue("@dosagem", m.Dosagem);
            comando.Parameters.AddWithValue("@qtdEstoque", m.QtdEstoque);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Medicamento> Lista(int id)
        {
            conexao.Open();
            string sql = "SELECT * FROM Medicamento " + (id > 0 ? "WHERE id = @id" : "") + " ORDER BY nome";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            if(id > 0)
            {
                comando.Parameters.AddWithValue("@id", id);
            }
            MySqlDataReader reader = comando.ExecuteReader();
            List<Medicamento> lista = new List<Medicamento>();

            while(reader.Read())
            {
                Medicamento medicamento = new Medicamento();
                medicamento.Id = reader.GetInt32("id");
                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                {
                    medicamento.Nome = reader.GetString("nome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("descricao")))
                {
                    medicamento.Descricao = reader.GetString("descricao");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("valor")))
                {
                    medicamento.Valor = reader.GetDecimal("valor");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("dosagem")))
                {
                    medicamento.Dosagem = reader.GetString("dosagem");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("qtdEstoque")))
                {
                    medicamento.QtdEstoque = reader.GetInt32("qtdEstoque");
                }
                lista.Add(medicamento);
            }
            conexao.Close();
            return lista;
        }
        public List<Medicamento> Lista()
        {
            return Lista(0);
        }
    }
}
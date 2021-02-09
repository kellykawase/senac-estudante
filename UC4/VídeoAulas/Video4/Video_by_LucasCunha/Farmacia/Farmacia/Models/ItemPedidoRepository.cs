using System.Collections.Generic;
using MySqlConnector;

namespace Farmacia.Models
{
    public class ItemPedidoRepository : Repository
    {
        public void Cadastra(ItemPedido ip)
        {
            conexao.Open();
            string sql = "INSERT INTO ItemPedido (id_pedido, id_medicamento, quantidade) VALUES (@id_pedido, @id_medicamento, @quantidade);";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id_pedido", ip.pedido.Id);
            comando.Parameters.AddWithValue("@id_medicamento", ip.medicamento.Id);
            comando.Parameters.AddWithValue("@quantidade", ip.Quantidade);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<ItemPedido> Lista(int idPedido)
        {
            conexao.Open();
            string sql = "SELECT ip.id as IdItemPedido, ip.id_pedido, ip.quantidade, m.id as IdMedicamento, m.nome, m.valor, FROM itempedido ip JOIN medicamento m ON ip.id_medicamento = m.id WHERE id_pedido = @idPedido;";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@idPedido", idPedido);
            MySqlDataReader reader = comando.ExecuteReader();
            List<ItemPedido> lista = new List<ItemPedido>();

            while(reader.Read())
            {
                ItemPedido item = new ItemPedido();
                item.Id = reader.GetInt32("IdItemPedido");
                item.Quantidade = reader.GetInt32("quantidade");

                item.medicamento = new Medicamento();
                item.medicamento.Id = reader.GetInt32("IdMedicamento");

                if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                {
                    item.medicamento.Nome = reader.GetString("nome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("valor")))
                {
                    item.medicamento.Valor = reader.GetDecimal("valor");
                }
                lista.Add(item);
            }
            conexao.Close();
            return lista;
        }
    }
}
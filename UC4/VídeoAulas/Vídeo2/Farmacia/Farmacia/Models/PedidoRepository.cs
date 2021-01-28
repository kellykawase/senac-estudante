using System.Collections.Generic;
using MySqlConnector;
using System.Data.SqlClient;
using System.Data;
namespace Farmacia.Models
{
    public class PedidoRepository: Repository
    {
    public int Cadastra(Pedido p)
    {
        conexao.Open();
        string sql = "INSERT INTO Pedido (dataPedido, entregue, id_clinica)"+"VALUES (@dataPedido, 0, @idClinica)";

        MySqlCommand comando = new MySqlCommand(sql, conexao);
        comando.Parameters.AddWithValue("@dataPedido", p.DataPedido);
        comando.Parameters.AddWithValue("@idClinica",p.clinica.Id);
        
        comando.ExecuteNonQuery();
        int idNovoPedido = (int)comando.LastInsertedId;

        conexao.Close();
        return idNovoPedido;
    }
    public List<Pedido> Lista(int id)
    {
        conexao.Open();
        string sql = "SELECT * FROM Pedido p" + (id > 0 ? "WHERE id = @id" : "") + "ORDER BY dataPedido DESC";
        MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
        
        if(id > 0)
        comandoQuery.Parameters.AddWithValue("@id", id);
       
        MySqlDataReader reader = comandoQuery.ExecuteReader();
        List<Pedido> lista = new List<Pedido>();

        while (reader.Read())
        {
            Pedido pedido = new Pedido();
            pedido.Id = reader.GetInt32("Id");

            if (!reader.IsDBNull(reader.GetOrdinal("DataPedido")))
            pedido.DataPedido = reader.GetDateTime("DataPedido");

            if (!reader.IsDBNull(reader.GetOrdinal("entregue")))
            pedido.Entregue = reader.GetBoolean("entregue");

            if (!reader.IsDBNull(reader.GetOrdinal("Id_Clinica"))){
            pedido.clinica = new Clinica();
            pedido.clinica.Id = reader.GetInt32("Id_Clinica");
            }
        lista.Add(pedido);
    }
    conexao.Close();
    return lista;
    }
    public List<Pedido> Lista()
    {
        return Lista(0);
    }
    }
    }

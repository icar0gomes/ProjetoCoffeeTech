using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCoffeeTech.Model
{
    public class PedidoRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public PedidoRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DataTable BuscarPedidos(DateTime? dataInicio, DateTime? dataFim, string status)
        {
            // Monta a consulta SQL com base nos filtros fornecidos
            string query = "SELECT p.Id AS NumPedido, p.DataEmissao, c.Nome AS Cliente, p.Total AS TotalBruto, p.TotalLiquido, p.Status " +
                           "FROM Pedidos p " +
                           "INNER JOIN Clientes c ON p.ClienteId = c.Id " +
                           "WHERE 1=1 ";

            // Adiciona filtros de data se fornecidos
            if (dataInicio.HasValue)
                query += "AND p.DataEmissao >= @DataInicio ";
            if (dataFim.HasValue)
                query += "AND p.DataEmissao <= @DataFim ";
            if (!string.IsNullOrEmpty(status))
                query += "AND p.Status = @Status ";

            using (SqlConnection conn = new SqlConnection("Sua_Connection_String"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                // Adiciona parâmetros à consulta SQL
                if (dataInicio.HasValue)
                    adapter.SelectCommand.Parameters.AddWithValue("@DataInicio", dataInicio.Value);
                if (dataFim.HasValue)
                    adapter.SelectCommand.Parameters.AddWithValue("@DataFim", dataFim.Value);
                if (!string.IsNullOrEmpty(status))
                    adapter.SelectCommand.Parameters.AddWithValue("@Status", status);

                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
        }
    }

}



using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCoffeeTech.Model
{
    public class FornecedorService
    {
        private DatabaseConnection db = new DatabaseConnection();

        // Inserir novo fornecedor
        public void InserirFornecedor(Fornecedor fornecedor)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = @"INSERT INTO Fornecedores (NomeFantasia, CNPJ, RazaoSocial, Status, Logradouro, Numero, Bairro, CEP, Municipio, UF, Telefone, Email, NomeResponsavel, Observacoes) 
                                 VALUES (@NomeFantasia, @CNPJ, @RazaoSocial, @Status, @Logradouro, @Numero, @Bairro, @CEP, @Municipio, @UF, @Telefone, @Email, @NomeResponsavel, @Observacoes)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
                    cmd.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
                    cmd.Parameters.AddWithValue("@RazaoSocial", fornecedor.RazaoSocial);
                    cmd.Parameters.AddWithValue("@Status", fornecedor.Status);
                    cmd.Parameters.AddWithValue("@Logradouro", fornecedor.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", fornecedor.Numero);
                    cmd.Parameters.AddWithValue("@Bairro", fornecedor.Bairro);
                    cmd.Parameters.AddWithValue("@CEP", fornecedor.CEP);
                    cmd.Parameters.AddWithValue("@Municipio", fornecedor.Municipio);
                    cmd.Parameters.AddWithValue("@UF", fornecedor.UF);
                    cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
                    cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
                    cmd.Parameters.AddWithValue("@NomeResponsavel", fornecedor.NomeResponsavel);
                    cmd.Parameters.AddWithValue("@Observacoes", fornecedor.Observacoes);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir fornecedor: {ex.Message}");
            }
        }

        // Atualizar dados do fornecedor existente
        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = @"UPDATE Fornecedores 
                                 SET NomeFantasia = @NomeFantasia, 
                                     CNPJ = @CNPJ, 
                                     RazaoSocial = @RazaoSocial, 
                                     Status = @Status, 
                                     Logradouro = @Logradouro, 
                                     Numero = @Numero, 
                                     Bairro = @Bairro, 
                                     CEP = @CEP, 
                                     Municipio = @Municipio, 
                                     UF = @UF, 
                                     Telefone = @Telefone, 
                                     Email = @Email, 
                                     NomeResponsavel = @NomeResponsavel, 
                                     Observacoes = @Observacoes 
                                 WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", fornecedor.ID);
                    cmd.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
                    cmd.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
                    cmd.Parameters.AddWithValue("@RazaoSocial", fornecedor.RazaoSocial);
                    cmd.Parameters.AddWithValue("@Status", fornecedor.Status);
                    cmd.Parameters.AddWithValue("@Logradouro", fornecedor.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", fornecedor.Numero);
                    cmd.Parameters.AddWithValue("@Bairro", fornecedor.Bairro);
                    cmd.Parameters.AddWithValue("@CEP", fornecedor.CEP);
                    cmd.Parameters.AddWithValue("@Municipio", fornecedor.Municipio);
                    cmd.Parameters.AddWithValue("@UF", fornecedor.UF);
                    cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
                    cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
                    cmd.Parameters.AddWithValue("@NomeResponsavel", fornecedor.NomeResponsavel);
                    cmd.Parameters.AddWithValue("@Observacoes", fornecedor.Observacoes);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar fornecedor: {ex.Message}");
            }
        }

        // Excluir fornecedor
        public void ExcluirFornecedor(int id)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = "DELETE FROM Fornecedores WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir fornecedor: {ex.Message}");
            }
        }

        // Obter lista de fornecedores
        public List<Fornecedor> ListarFornecedores()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = "SELECT ID, NomeFantasia, CNPJ, UF, UltimaMovimentacao, DataAlteracao FROM Fornecedores";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Fornecedor fornecedor = new Fornecedor
                        {
                            ID = (int)reader["ID"],
                            NomeFantasia = reader["NomeFantasia"].ToString(),
                            UF = reader["UF"].ToString(),
                            UltimaMovimentacao = reader["UltimaMovimentacao"] != DBNull.Value ? (decimal)reader["UltimaMovimentacao"] : 0,
                            DataAlteracao = reader["DataAlteracao"] != DBNull.Value ? (DateTime)reader["DataAlteracao"] : DateTime.MinValue
                        };
                        fornecedores.Add(fornecedor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar fornecedores: {ex.Message}");
            }

            return fornecedores;
        }

    }
}

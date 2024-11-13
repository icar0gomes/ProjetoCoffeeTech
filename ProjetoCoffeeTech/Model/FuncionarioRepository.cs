using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCoffeeTech.Model
{

    public class FuncionarioRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public FuncionarioRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public bool AdicionarFuncionario(Funcionario funcionario)
        {
            try
            {
                // Usando o DatabaseConnection para obter a conexão
                using (SqlConnection connection = _databaseConnection.GetConnection())
                {
                    string query = "INSERT INTO funcionarios (nome, senha, email, setor, cargo, dataNascimento) " +
                                   "VALUES (@Nome, @Senha, @Email, @Setor, @Cargo, @DataNascimento)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    command.Parameters.AddWithValue("@Senha", funcionario.Senha);
                    command.Parameters.AddWithValue("@Email", funcionario.Email);
                    command.Parameters.AddWithValue("@Setor", funcionario.Setor);
                    command.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    command.Parameters.AddWithValue("@DataNascimento", funcionario.DataNascimento);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;  // Retorna true se o comando for executado com sucesso
                }
            }
            catch (Exception ex)
            {
                // Log de erro, pode ser melhorado com um sistema de logs real
                Console.WriteLine($"Erro ao adicionar funcionário: {ex.Message}");
                return false;
            }
        }

        public Funcionario AutenticarFuncionario(string email, string senha)
        {
            // Usando o DatabaseConnection para obter a conexão
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT * FROM funcionarios WHERE email = @Email AND senha = @Senha";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Funcionario funcionario = new Funcionario
                    {
                        IdFuncionario = (int)reader["idFuncionario"],
                        Nome = reader["nome"].ToString(),
                        Email = reader["email"].ToString(),
                        Setor = reader["setor"].ToString(),
                        Cargo = reader["cargo"].ToString(),
                        DataNascimento = Convert.ToDateTime(reader["dataNascimento"])
                    };
                    return funcionario;
                }
                else
                {
                    return null;
                }
            }

    
        }    
    }
}



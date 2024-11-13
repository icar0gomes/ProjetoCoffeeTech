using ProjetoCoffeeTech.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCoffeeTech.Controller
{
    public class FuncionarioController
    {
        private readonly FuncionarioRepository _funcionarioRepository;

        public FuncionarioController()
        {
            var dbConnection = new DatabaseConnection(); // Cria uma instância do DatabaseConnection
            _funcionarioRepository = new FuncionarioRepository(dbConnection); // Passa a instância do DatabaseConnection
        }

        public bool CadastrarFuncionario(string nome, string senha, string email, string setor, string cargo, DateTime dataNascimento)
        {
            Funcionario funcionario = new Funcionario
            {
                Nome = nome,
                Senha = senha,
                Email = email,
                Setor = setor,
                Cargo = cargo,
                DataNascimento = dataNascimento
            };

            return _funcionarioRepository.AdicionarFuncionario(funcionario);
        }

        public Funcionario Login(string email, string senha)
        {
            return _funcionarioRepository.AutenticarFuncionario(email, senha);
        }
    }
}

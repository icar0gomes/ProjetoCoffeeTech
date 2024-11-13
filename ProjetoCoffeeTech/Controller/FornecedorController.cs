using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCoffeeTech.Model
{
    public class FornecedorController
    {
        private FornecedorService fornecedorService = new FornecedorService();

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                fornecedorService.InserirFornecedor(fornecedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar fornecedor: {ex.Message}");
            }
        }

        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                fornecedorService.AtualizarFornecedor(fornecedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar fornecedor: {ex.Message}");
            }
        }

        public void DeletarFornecedor(int id)
        {
            try
            {
                fornecedorService.ExcluirFornecedor(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir fornecedor: {ex.Message}");
            }
        }

        // Modificando o método para retornar apenas os campos necessários para o DataGridView
        public List<Fornecedor> ObterFornecedores()
        {
            // Obtém a lista completa de fornecedores
            var fornecedores = fornecedorService.ListarFornecedores();

            // Retorna uma nova lista contendo apenas os campos necessários para exibição
            return fornecedores.Select(f => new Fornecedor
            {
                ID = f.ID,
                NomeFantasia = f.NomeFantasia,
                CNPJ = f.CNPJ,
                Logradouro = f.Logradouro,
                Telefone = f.Telefone,
                NomeResponsavel = f.NomeResponsavel
            }).ToList();
        }
    }
}

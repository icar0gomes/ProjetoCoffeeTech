using ProjetoCoffeeTech.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCoffeeTech.View
{
    public partial class ControleFornecedor : Form
    {

        private FornecedorController controller = new FornecedorController();

        public ControleFornecedor()
        {
            InitializeComponent();
            AtualizarDataGrid();

        }

        private void AtualizarDataGrid()
        {
           
                // Chama o método do Controller que busca os dados
                var fornecedores = controller.ObterFornecedores();

                // Preenche o DataGridView com os dados dos fornecedores
                dgvFornecedores.DataSource = fornecedores;
            

        }

        private void linkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaInicial cad = new TelaInicial();
            cad.Show();
            this.Hide();
        }

        private void ControleFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows.Count > 0)
            {
                // Acessa o primeiro item da linha selecionada
                int id = Convert.ToInt32(dgvFornecedores.SelectedRows[0].Cells["ID"].Value);
                Fornecedor fornecedor = controller.ObterFornecedores().Find(f => f.ID == id);

                CadastroFornecedor telaCadastro = new CadastroFornecedor();
                telaCadastro.ShowDialog();
                AtualizarDataGrid(); // Atualiza a lista após o novo cadastro
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para editar.");
            }
        }



            private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            CadastroFornecedor telaCadastro = new CadastroFornecedor();
            telaCadastro.ShowDialog();
            AtualizarDataGrid(); // Atualiza a lista após o novo cadastro
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadastreSe cad = new CadastreSe();
            cad.Show();
            this.Hide();
        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor telaCadastro = new CadastroFornecedor();
            telaCadastro.ShowDialog();
            this.Hide();
        }

        private void gerenciamentoDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciamentoFornecedores cad = new GerenciamentoFornecedores();
            cad.Show();
            this.Hide();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleEstoque cad = new ControleEstoque();
            cad.Show();
            this.Hide();
        }

        private void consultaDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPedido cad = new ConsultaPedido();
            cad.Show();
            this.Hide();
        }

        private void controleDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleProdução cad = new ControleProdução();
            cad.Show();
            this.Hide();

        }

        private void telaDeInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInicial cad = new TelaInicial();
            cad.Show();
            this.Hide();
        }
    }
}

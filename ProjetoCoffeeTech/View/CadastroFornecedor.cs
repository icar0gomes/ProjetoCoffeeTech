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
    public partial class CadastroFornecedor : Form
    {
        private FornecedorController controller = new FornecedorController();
        private Fornecedor fornecedor;

        public CadastroFornecedor(Fornecedor fornecedor = null)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;

            // Preencher o ComboBox com as UFs (Unidades Federativas)
            cBoxUF.Items.AddRange(new string[]
            {
            "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA",
            "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
            });

            // Se o fornecedor for passado, preenche os campos
            if (fornecedor != null)
            {
                txtNomeFantasia.Text = fornecedor.NomeFantasia;
                txtCNPJ.Text = fornecedor.CNPJ;
                txtRazaoSocial.Text = fornecedor.RazaoSocial;
                txtStatus.Text = fornecedor.Status;
                txtLogradouro.Text = fornecedor.Logradouro;
                txtNumLogradouro.Text = fornecedor.Numero;
                txtBairro.Text = fornecedor.Bairro;
                txtCEP.Text = fornecedor.CEP;
                txtMunicipio.Text = fornecedor.Municipio;
                cBoxUF.SelectedItem = fornecedor.UF; // Seleciona o UF corretamente no ComboBox
                txtTelefone.Text = fornecedor.Telefone;
                txtEmailFornec.Text = fornecedor.Email;
                txtNomeEmail.Text = fornecedor.NomeResponsavel;
                txtObservacao.Text = fornecedor.Observacoes;
            }
        }

    
    private void linkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaInicial cad = new TelaInicial();
            cad.Show();
            this.Hide();
        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviarCadastro_Click(object sender, EventArgs e)
        {
            if (fornecedor == null) fornecedor = new Fornecedor();

            // Atualizando os dados do fornecedor com os campos do formulário
            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.Status = txtStatus.Text;
            fornecedor.Logradouro = txtLogradouro.Text;
            fornecedor.Numero = txtNumLogradouro.Text;
            fornecedor.Bairro = txtBairro.Text;
            fornecedor.CEP = txtCEP.Text;
            fornecedor.Municipio = txtMunicipio.Text;
            fornecedor.UF = cBoxUF.SelectedItem?.ToString(); // Pega o estado selecionado no ComboBox
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Email = txtEmailFornec.Text;
            fornecedor.NomeResponsavel = txtNomeEmail.Text;
            fornecedor.Observacoes = txtObservacao.Text;

            // Se o fornecedor tem ID 0, é um novo fornecedor, senão é uma atualização
            if (fornecedor.ID == 0)
                controller.AdicionarFornecedor(fornecedor);
            else
                controller.AtualizarFornecedor(fornecedor);

            MessageBox.Show("Fornecedor salvo com sucesso!");
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (fornecedor != null && fornecedor.ID != 0)
            {
                var confirm = MessageBox.Show("Tem certeza que deseja excluir este fornecedor?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    controller.DeletarFornecedor(fornecedor.ID);
                    MessageBox.Show("Fornecedor excluído com sucesso!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado para exclusão.");
            }
        }

        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {
            if (fornecedor == null || fornecedor.ID == 0)
            {
                MessageBox.Show("Selecione um fornecedor para editar.");
                return;
            }

            // Atualizar o objeto fornecedor com os dados do formulário
            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.Status = txtStatus.Text;
            fornecedor.Logradouro = txtLogradouro.Text;
            fornecedor.Numero = txtNumLogradouro.Text;
            fornecedor.Bairro = txtBairro.Text;
            fornecedor.CEP = txtCEP.Text;
            fornecedor.Municipio = txtMunicipio.Text;
            fornecedor.UF = cBoxUF.SelectedItem?.ToString();
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Email = txtEmailFornec.Text;
            fornecedor.NomeResponsavel = txtNomeEmail.Text;
            fornecedor.Observacoes = txtObservacao.Text;

            // Chama o controlador para atualizar o fornecedor no banco de dados
            controller.AtualizarFornecedor(fornecedor);

            MessageBox.Show("Fornecedor atualizado com sucesso!");
            this.Close();
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

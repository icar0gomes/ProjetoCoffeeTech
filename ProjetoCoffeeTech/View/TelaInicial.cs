using ProjetoCoffeeTech.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCoffeeTech
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

       

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnGerenciaFornecedor_Click_1(object sender, EventArgs e)
        {
            GerenciamentoFornecedores cad = new GerenciamentoFornecedores();
            cad.Show();
            this.Hide();
        }

        private void btnCadastroFornecedor_Click_1(object sender, EventArgs e)
        {
            ControleFornecedor cad = new ControleFornecedor();
            cad.Show();
            this.Hide();
        }

        private void btnConsultaPedido_Click_1(object sender, EventArgs e)
        {
            ConsultaPedido cad = new ConsultaPedido();
            cad.Show();
            this.Hide();
           
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            RelatorioVendas cad =  new  RelatorioVendas();
            cad.Show();
            this.Hide();

        }

        private void btnControleProdução_Click_1(object sender, EventArgs e)
        {
            ControleProdução cad = new ControleProdução();
            cad.Show();
            this.Hide();
        }

        private void btnControleEstoque_Click_1(object sender, EventArgs e)
        {
            ControleEstoque cad = new ControleEstoque();
            cad.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

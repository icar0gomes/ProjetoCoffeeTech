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
    public partial class ConsultaPedido : Form
    {
            private PedidoRepository _pedidoRepository;

        public ConsultaPedido()
        {
            InitializeComponent();
            var dbConnection = new DatabaseConnection();
            _pedidoRepository = new PedidoRepository(dbConnection);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaInicial cad = new TelaInicial();
            cad.Show();
            this.Hide();
        }

        private void ConsultaPedido_Load(object sender, EventArgs e)
        {
            // Configuração do ComboBox de Status
            cbStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cbStatus.Items.AddRange(new string[] { "Processado", "Em Processamento", "Em Aberto" });
            cbStatus.DrawItem += new DrawItemEventHandler(cbStatus_DrawItem);

            // Configuração das colunas do DataGridView
            dgvPedidos.Columns.Add("NumPedido", "Número do Pedido");
            dgvPedidos.Columns.Add("DataEmissao", "Data de Emissão");
            dgvPedidos.Columns.Add("Cliente", "Cliente");
            dgvPedidos.Columns.Add("TotalBruto", "Total Bruto");
            dgvPedidos.Columns.Add("TotalLiquido", "Total Líquido");
            dgvPedidos.Columns.Add("Status", "Status");

            // Formatação das colunas de valores
            dgvPedidos.Columns["TotalBruto"].DefaultCellStyle.Format = "C2";  // Formatação para moeda
            dgvPedidos.Columns["TotalLiquido"].DefaultCellStyle.Format = "C2"; // Formatação para moeda

        }

        private void cbStatus_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string status = cbStatus.Items[e.Index].ToString();
            Color color = Color.Black;
            if (status == "Processado") color = Color.Green;
            else if (status == "Em Processamento") color = Color.Yellow;
            else if (status == "Em Aberto") color = Color.Red;

            e.DrawBackground();

            using (Font font = new Font("Century Gothic", 10, FontStyle.Regular))
            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(status, font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string status = cbStatus.SelectedItem?.ToString();
                DateTime? dataInicio = dtpDataEmissaoInicial.Checked ? dtpDataEmissaoInicial.Value : (DateTime?)null;
                DateTime? dataFim = dtpDataEmissaoFinal.Checked ? dtpDataEmissaoFinal.Value : (DateTime?)null;

                // Valida se as datas foram selecionadas corretamente
                if (!dataInicio.HasValue || !dataFim.HasValue)
                {
                    MessageBox.Show("Por favor, selecione as datas de início e fim.");
                    return;
                }

                // Carrega os dados no DataGridView
                dgvPedidos.DataSource = _pedidoRepository.BuscarPedidos(dataInicio, dataFim, status);
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem caso ocorra algum erro
                MessageBox.Show("Erro ao buscar os pedidos: " + ex.Message);
            }

        }

        private void btnLimparfiltros_Click(object sender, EventArgs e)
        {
            // Limpa os filtros e limpa o DataGridView
            dtpDataEmissaoInicial.Value = DateTime.Now;
            dtpDataEmissaoFinal.Value = DateTime.Now;
            cbStatus.SelectedIndex = -1;
            dgvPedidos.DataSource = null; // Limpa a exibição dos dados
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjetoCoffeeTech.View
{
    public partial class ControleEstoque : Form
    {
        public ControleEstoque()
        {
            InitializeComponent();
            CriarGrafico();
        }

        private void linkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaInicial cad = new TelaInicial();
            cad.Show();
            this.Hide();
        }

        private void CriarGrafico()
        {

            graficoEstoque.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Regular);
            graficoEstoque.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Regular);

            // Configurando as séries do gráfico
            graficoEstoque.Series.Clear();

            // Série do estoque mínimo
            Series estoqueMinimo = new Series("Estoque mínimo");
            estoqueMinimo.ChartType = SeriesChartType.StackedColumn;
            estoqueMinimo.Points.AddXY("Arábica", 3000);
            estoqueMinimo.Points.AddXY("Acaiá", 4000);
            estoqueMinimo.Points.AddXY("Bourbon", 3500);
            estoqueMinimo.Points.AddXY("Catuaí", 5000);
            estoqueMinimo.Points.AddXY("Geisha", 2000);
            estoqueMinimo.Points.AddXY("Kona", 4000);
            estoqueMinimo.Points.AddXY("Robusta", 3500);

            // Série do estoque médio
            Series estoqueMedio = new Series("Estoque médio");
            estoqueMedio.ChartType = SeriesChartType.StackedColumn;
            estoqueMedio.Points.AddXY("Arábica", 7000);
            estoqueMedio.Points.AddXY("Acaiá", 6000);
            estoqueMedio.Points.AddXY("Bourbon", 8000);
            estoqueMedio.Points.AddXY("Catuaí", 7000);
            estoqueMedio.Points.AddXY("Geisha", 6000);
            estoqueMedio.Points.AddXY("Kona", 8000);
            estoqueMedio.Points.AddXY("Robusta", 7000);

            // Série do estoque máximo
            Series estoqueMaximo = new Series("Estoque máximo");
            estoqueMaximo.ChartType = SeriesChartType.StackedColumn;
            estoqueMaximo.Points.AddXY("Arábica", 10000);
            estoqueMaximo.Points.AddXY("Acaiá", 9000);
            estoqueMaximo.Points.AddXY("Bourbon", 12000);
            estoqueMaximo.Points.AddXY("Catuaí", 10000);
            estoqueMaximo.Points.AddXY("Geisha", 9000);
            estoqueMaximo.Points.AddXY("Kona", 11000);
            estoqueMaximo.Points.AddXY("Robusta", 10000);

            // Adicionando as séries ao gráfico
            graficoEstoque.Series.Add(estoqueMinimo);
            graficoEstoque.Series.Add(estoqueMedio);
            graficoEstoque.Series.Add(estoqueMaximo);

            // Definir as cores das barras (opcional)
            estoqueMinimo.Color = System.Drawing.Color.Brown;
            estoqueMedio.Color = System.Drawing.Color.Peru;
            estoqueMaximo.Color = System.Drawing.Color.Tan;




        }
        private void ControleEstoque_Load(object sender, EventArgs e)
        {
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

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
          
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print(); // Imprime o documento selecionado
                }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Exemplo de conteúdo que será impresso
            string texto = "Relatório de Estoque de Café\n\n";
            texto += "Arábica: 7000\n";
            texto += "Acaiá: 6000\n";
            texto += "Bourbon: 8000\n";

            // Desenhando o texto na página de impressão
            e.Graphics.DrawString(texto, new Font("Arial", 12), Brushes.Black, 100, 100);
        }


    }
}


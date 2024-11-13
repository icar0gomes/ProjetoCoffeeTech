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
    public partial class RelatorioVendas : Form
    {

        private readonly RelatorioVendasModel _relatorioModel;

        public RelatorioVendas()
        {
            InitializeComponent();
            _relatorioModel = new RelatorioVendasModel(); // Instancia o model
        }

        private void RelatorioVendas_Load(object sender, EventArgs e)
        {
            // Configura um único gráfico circular para representar as vendas físicas e on-line
            CircularProgressBar progressBarVendas = new CircularProgressBar
            {
                VendasFisicas = 28, // Percentual de vendas físicas
                CorFisicas = Color.SaddleBrown,
                CorOnline = Color.Chocolate,
                Location = new Point(150, 250),
                Name = "progressBarVendas"
            };
            this.Controls.Add(progressBarVendas);

            // Adiciona legendas para as vendas físicas e on-line
            Label lblVendasFisicas = new Label
            {
                Text = $"● Vendas físicas = {_relatorioModel.VendasFisicas}%",
                Location = new Point(150, 482),
                ForeColor = Color.SaddleBrown,
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                AutoSize = true
            };
            this.Controls.Add(lblVendasFisicas);

            Label lblVendasOnline = new Label
            {
                Text = $"● Vendas on-line = {_relatorioModel.VendasOnline}%",
                Location = new Point(150, 458),
                ForeColor = Color.Chocolate,
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                AutoSize = true
            };
            this.Controls.Add(lblVendasOnline);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaInicial cad = new TelaInicial();
            cad.Show();
            this.Hide();
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

    public class CircularProgressBar : Control
    {
        public int VendasFisicas { get; set; }
        public Color CorFisicas { get; set; }
        public Color CorOnline { get; set; }

        public CircularProgressBar()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            DoubleBuffered = true;
            Size = new Size(200, 200);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float startAngle = -90;
            float sweepAngleFisicas = 360f * VendasFisicas / 100;
            float sweepAngleOnline = 360f - sweepAngleFisicas;

            // Desenha o fundo do círculo
            using (Pen penBackground = new Pen(Color.LightGray, 15))
            {
                g.DrawArc(penBackground, 10, 10, Width - 20, Height - 20, 0, 360);
            }

            // Desenha a parte das vendas físicas
            using (Pen penFisicas = new Pen(CorFisicas, 15))
            {
                g.DrawArc(penFisicas, 10, 10, Width - 20, Height - 20, startAngle, sweepAngleFisicas);
            }

            // Desenha a parte das vendas on-line
            using (Pen penOnline = new Pen(CorOnline, 15))
            {
                g.DrawArc(penOnline, 10, 10, Width - 20, Height - 20, startAngle + sweepAngleFisicas, sweepAngleOnline);
            }

            // Desenha o texto central indicando o total
            string texto = $"{VendasFisicas}% físicas\n{100 - VendasFisicas}% on-line";
            Font font = new Font("Century Gothic", 12, FontStyle.Bold);
            SizeF textSize = g.MeasureString(texto, font);
            g.DrawString(texto, font, Brushes.Brown, (Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
        }
    }

}

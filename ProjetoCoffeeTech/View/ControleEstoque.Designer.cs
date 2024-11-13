namespace ProjetoCoffeeTech.View
{
    partial class ControleEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleEstoque));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.graficoEstoque = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeProduçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaDeInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkVoltar = new System.Windows.Forms.LinkLabel();
            this.BtnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEstoque)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(319, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "CONTROLE DE ESTOQUE";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(794, 17);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 52;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "voltar";
            // 
            // graficoEstoque
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoEstoque.ChartAreas.Add(chartArea1);
            this.graficoEstoque.Location = new System.Drawing.Point(140, 141);
            this.graficoEstoque.Name = "graficoEstoque";
            this.graficoEstoque.Size = new System.Drawing.Size(727, 354);
            this.graficoEstoque.TabIndex = 54;
            this.graficoEstoque.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 69);
            this.menuStrip1.TabIndex = 86;
            this.menuStrip1.Text = "MENU";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.BackgroundImage = global::ProjetoCoffeeTech.Properties.Resources.Logo_png;
            this.MenuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFuncionáriosToolStripMenuItem,
            this.cadastroDeFornecedoresToolStripMenuItem,
            this.gerenciamentoDeFornecedoresToolStripMenuItem,
            this.controleDeEstoqueToolStripMenuItem,
            this.consultaDePedidoToolStripMenuItem,
            this.controleDeProduçãoToolStripMenuItem,
            this.telaDeInicioToolStripMenuItem});
            this.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Transparent;
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(112, 65);
            this.MenuToolStripMenuItem.Text = "_________";
            // 
            // cadastroDeFuncionáriosToolStripMenuItem
            // 
            this.cadastroDeFuncionáriosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroDeFuncionáriosToolStripMenuItem.Name = "cadastroDeFuncionáriosToolStripMenuItem";
            this.cadastroDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.cadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de Funcionários";
            this.cadastroDeFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionáriosToolStripMenuItem_Click);
            // 
            // cadastroDeFornecedoresToolStripMenuItem
            // 
            this.cadastroDeFornecedoresToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroDeFornecedoresToolStripMenuItem.Name = "cadastroDeFornecedoresToolStripMenuItem";
            this.cadastroDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.cadastroDeFornecedoresToolStripMenuItem.Text = "Cadastro de Fornecedores";
            this.cadastroDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFornecedoresToolStripMenuItem_Click);
            // 
            // gerenciamentoDeFornecedoresToolStripMenuItem
            // 
            this.gerenciamentoDeFornecedoresToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerenciamentoDeFornecedoresToolStripMenuItem.Name = "gerenciamentoDeFornecedoresToolStripMenuItem";
            this.gerenciamentoDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.gerenciamentoDeFornecedoresToolStripMenuItem.Text = "Gerenciamento de Fornecedores";
            this.gerenciamentoDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoDeFornecedoresToolStripMenuItem_Click);
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de Estoque";
            this.controleDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.controleDeEstoqueToolStripMenuItem_Click);
            // 
            // consultaDePedidoToolStripMenuItem
            // 
            this.consultaDePedidoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaDePedidoToolStripMenuItem.Name = "consultaDePedidoToolStripMenuItem";
            this.consultaDePedidoToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.consultaDePedidoToolStripMenuItem.Text = "Consulta de Pedido";
            this.consultaDePedidoToolStripMenuItem.Click += new System.EventHandler(this.consultaDePedidoToolStripMenuItem_Click);
            // 
            // controleDeProduçãoToolStripMenuItem
            // 
            this.controleDeProduçãoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controleDeProduçãoToolStripMenuItem.Name = "controleDeProduçãoToolStripMenuItem";
            this.controleDeProduçãoToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.controleDeProduçãoToolStripMenuItem.Text = "Controle de Produção";
            this.controleDeProduçãoToolStripMenuItem.Click += new System.EventHandler(this.controleDeProduçãoToolStripMenuItem_Click);
            // 
            // telaDeInicioToolStripMenuItem
            // 
            this.telaDeInicioToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaDeInicioToolStripMenuItem.Name = "telaDeInicioToolStripMenuItem";
            this.telaDeInicioToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.telaDeInicioToolStripMenuItem.Text = "Tela de Inicio";
            this.telaDeInicioToolStripMenuItem.Click += new System.EventHandler(this.telaDeInicioToolStripMenuItem_Click);
            // 
            // linkVoltar
            // 
            this.linkVoltar.AutoSize = true;
            this.linkVoltar.BackColor = System.Drawing.Color.Transparent;
            this.linkVoltar.LinkColor = System.Drawing.Color.White;
            this.linkVoltar.Location = new System.Drawing.Point(815, 29);
            this.linkVoltar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkVoltar.Name = "linkVoltar";
            this.linkVoltar.Size = new System.Drawing.Size(33, 13);
            this.linkVoltar.TabIndex = 88;
            this.linkVoltar.TabStop = true;
            this.linkVoltar.Text = "voltar";
            this.linkVoltar.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVoltar_LinkClicked);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnImprimir.Location = new System.Drawing.Point(891, 172);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(79, 33);
            this.BtnImprimir.TabIndex = 89;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // ControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCoffeeTech.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 532);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.linkVoltar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.graficoEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControleEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COFFEE TECH - Controle de Estoque";
            this.Load += new System.EventHandler(this.ControleEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficoEstoque)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoEstoque;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeProduçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaDeInicioToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkVoltar;
        private System.Windows.Forms.Button BtnImprimir;
    }
}
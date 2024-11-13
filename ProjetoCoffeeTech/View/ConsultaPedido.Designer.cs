namespace ProjetoCoffeeTech.View
{
    partial class ConsultaPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimparfiltros = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.NumPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataEmissaoInicial = new System.Windows.Forms.Label();
            this.dtpDataEmissaoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEmissaoInicial = new System.Windows.Forms.DateTimePicker();
            this.lblDataEmissaoFinal = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(414, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "CONSULTA DE PEDIDO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(865, 237);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 38);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimparfiltros
            // 
            this.btnLimparfiltros.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLimparfiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimparfiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparfiltros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparfiltros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimparfiltros.Location = new System.Drawing.Point(865, 328);
            this.btnLimparfiltros.Name = "btnLimparfiltros";
            this.btnLimparfiltros.Size = new System.Drawing.Size(114, 38);
            this.btnLimparfiltros.TabIndex = 35;
            this.btnLimparfiltros.Text = "Limpar Filtros";
            this.btnLimparfiltros.UseVisualStyleBackColor = false;
            this.btnLimparfiltros.Click += new System.EventHandler(this.btnLimparfiltros_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(628, 156);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(192, 21);
            this.cbStatus.TabIndex = 33;
            // 
            // dgvPedidos
            // 
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPedido,
            this.DataEmissao,
            this.Cliente,
            this.TotalBruto,
            this.TotalLiquido,
            this.Status});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvPedidos.Enabled = false;
            this.dgvPedidos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvPedidos.Location = new System.Drawing.Point(113, 194);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPedidos.RowHeadersVisible = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPedidos.Size = new System.Drawing.Size(666, 278);
            this.dgvPedidos.TabIndex = 34;
            // 
            // NumPedido
            // 
            this.NumPedido.HeaderText = "Número de Pedido";
            this.NumPedido.Name = "NumPedido";
            this.NumPedido.Width = 150;
            // 
            // DataEmissao
            // 
            this.DataEmissao.HeaderText = "Data de Emissão";
            this.DataEmissao.Name = "DataEmissao";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // TotalBruto
            // 
            this.TotalBruto.HeaderText = "Total Bruto";
            this.TotalBruto.Name = "TotalBruto";
            // 
            // TotalLiquido
            // 
            this.TotalLiquido.HeaderText = "Total Liquído";
            this.TotalLiquido.Name = "TotalLiquido";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 115;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(691, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 16);
            this.lblStatus.TabIndex = 32;
            this.lblStatus.Text = "Status :";
            // 
            // lblDataEmissaoInicial
            // 
            this.lblDataEmissaoInicial.AutoSize = true;
            this.lblDataEmissaoInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmissaoInicial.Location = new System.Drawing.Point(125, 132);
            this.lblDataEmissaoInicial.Name = "lblDataEmissaoInicial";
            this.lblDataEmissaoInicial.Size = new System.Drawing.Size(169, 16);
            this.lblDataEmissaoInicial.TabIndex = 28;
            this.lblDataEmissaoInicial.Text = "Data de emissão inicial :";
            // 
            // dtpDataEmissaoFinal
            // 
            this.dtpDataEmissaoFinal.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLight;
            this.dtpDataEmissaoFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEmissaoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissaoFinal.Location = new System.Drawing.Point(390, 152);
            this.dtpDataEmissaoFinal.Name = "dtpDataEmissaoFinal";
            this.dtpDataEmissaoFinal.Size = new System.Drawing.Size(154, 23);
            this.dtpDataEmissaoFinal.TabIndex = 31;
            // 
            // dtpDataEmissaoInicial
            // 
            this.dtpDataEmissaoInicial.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLight;
            this.dtpDataEmissaoInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEmissaoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissaoInicial.Location = new System.Drawing.Point(128, 152);
            this.dtpDataEmissaoInicial.Name = "dtpDataEmissaoInicial";
            this.dtpDataEmissaoInicial.Size = new System.Drawing.Size(154, 23);
            this.dtpDataEmissaoInicial.TabIndex = 29;
            this.dtpDataEmissaoInicial.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // lblDataEmissaoFinal
            // 
            this.lblDataEmissaoFinal.AutoSize = true;
            this.lblDataEmissaoFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmissaoFinal.Location = new System.Drawing.Point(387, 132);
            this.lblDataEmissaoFinal.Name = "lblDataEmissaoFinal";
            this.lblDataEmissaoFinal.Size = new System.Drawing.Size(157, 16);
            this.lblDataEmissaoFinal.TabIndex = 30;
            this.lblDataEmissaoFinal.Text = "Data de emissão final :";
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
            this.menuStrip1.Size = new System.Drawing.Size(1082, 69);
            this.menuStrip1.TabIndex = 94;
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
            this.linkVoltar.TabIndex = 95;
            this.linkVoltar.TabStop = true;
            this.linkVoltar.Text = "voltar";
            this.linkVoltar.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ConsultaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCoffeeTech.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 596);
            this.Controls.Add(this.linkVoltar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimparfiltros);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataEmissaoInicial);
            this.Controls.Add(this.dtpDataEmissaoFinal);
            this.Controls.Add(this.dtpDataEmissaoInicial);
            this.Controls.Add(this.lblDataEmissaoFinal);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaPedido";
            this.Load += new System.EventHandler(this.ConsultaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimparfiltros;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataEmissaoInicial;
        private System.Windows.Forms.DateTimePicker dtpDataEmissaoFinal;
        private System.Windows.Forms.DateTimePicker dtpDataEmissaoInicial;
        private System.Windows.Forms.Label lblDataEmissaoFinal;
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
    }
}
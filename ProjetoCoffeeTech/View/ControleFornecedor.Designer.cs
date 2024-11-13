namespace ProjetoCoffeeTech.View
{
    partial class ControleFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleFornecedor));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeProduçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaDeInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.linkVoltar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Sienna;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(949, 284);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 32);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.BackColor = System.Drawing.Color.Sienna;
            this.btnNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovoCadastro.Location = new System.Drawing.Point(930, 339);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(139, 36);
            this.btnNovoCadastro.TabIndex = 56;
            this.btnNovoCadastro.Text = "Novo Cadastro";
            this.btnNovoCadastro.UseVisualStyleBackColor = false;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // dgvFornecedores
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedores.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFornecedores.EnableHeadersVisualStyles = false;
            this.dgvFornecedores.Location = new System.Drawing.Point(90, 158);
            this.dgvFornecedores.MultiSelect = false;
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvFornecedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(768, 335);
            this.dgvFornecedores.TabIndex = 55;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "NOME FANTASIA";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CNPJ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ENDEREÇO";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TELEFONE";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NOME RESPONSÁVEL";
            this.Column6.Name = "Column6";
            this.Column6.Width = 135;
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
            this.menuStrip1.TabIndex = 85;
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label17.Location = new System.Drawing.Point(369, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(410, 32);
            this.label17.TabIndex = 86;
            this.label17.Text = "CONTROLE DE FORNECEDORES";
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
            // ControleFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCoffeeTech.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 532);
            this.Controls.Add(this.linkVoltar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovoCadastro);
            this.Controls.Add(this.dgvFornecedores);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControleFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleFornecedor";
            this.Load += new System.EventHandler(this.ControleFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeProduçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaDeInicioToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel linkVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
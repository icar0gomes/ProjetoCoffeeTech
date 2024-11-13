namespace ProjetoCoffeeTech.View
{
    partial class CadastreSe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastreSe));
            this.cBoxSetor = new System.Windows.Forms.ComboBox();
            this.cBoxCargo = new System.Windows.Forms.ComboBox();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.btnEnviarCadastro = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.linkVoltar = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBoxSetor
            // 
            this.cBoxSetor.FormattingEnabled = true;
            this.cBoxSetor.Items.AddRange(new object[] {
            "TI",
            "Vendas e Marketing",
            "Logística",
            "Recursos Humanos",
            "Operações",
            "Financeiro",
            "Produção",
            "Colheita",
            "Pós-Colheita",
            "Manutenção",
            "Qualidade",
            "Agrícolas",
            "Adminsitrativo"});
            this.cBoxSetor.Location = new System.Drawing.Point(343, 297);
            this.cBoxSetor.Name = "cBoxSetor";
            this.cBoxSetor.Size = new System.Drawing.Size(183, 21);
            this.cBoxSetor.TabIndex = 35;
            // 
            // cBoxCargo
            // 
            this.cBoxCargo.FormattingEnabled = true;
            this.cBoxCargo.Items.AddRange(new object[] {
            "Auxiliar",
            "Coodernador",
            "Diretor"});
            this.cBoxCargo.Location = new System.Drawing.Point(343, 255);
            this.cBoxCargo.Name = "cBoxCargo";
            this.cBoxCargo.Size = new System.Drawing.Size(183, 21);
            this.cBoxCargo.TabIndex = 34;
            // 
            // btnEditarCadastro
            // 
            this.btnEditarCadastro.BackColor = System.Drawing.Color.Sienna;
            this.btnEditarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCadastro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarCadastro.Location = new System.Drawing.Point(557, 462);
            this.btnEditarCadastro.Name = "btnEditarCadastro";
            this.btnEditarCadastro.Size = new System.Drawing.Size(101, 31);
            this.btnEditarCadastro.TabIndex = 33;
            this.btnEditarCadastro.Text = "Editar";
            this.btnEditarCadastro.UseVisualStyleBackColor = false;
            // 
            // btnEnviarCadastro
            // 
            this.btnEnviarCadastro.BackColor = System.Drawing.Color.Sienna;
            this.btnEnviarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviarCadastro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviarCadastro.Location = new System.Drawing.Point(390, 462);
            this.btnEnviarCadastro.Name = "btnEnviarCadastro";
            this.btnEnviarCadastro.Size = new System.Drawing.Size(101, 31);
            this.btnEnviarCadastro.TabIndex = 32;
            this.btnEnviarCadastro.Text = "Enviar";
            this.btnEnviarCadastro.UseVisualStyleBackColor = false;
            this.btnEnviarCadastro.Click += new System.EventHandler(this.btnEnviarCadastro_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(343, 345);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(315, 27);
            this.txtSenha.TabIndex = 31;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(257, 345);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(67, 23);
            this.lblSenha.TabIndex = 28;
            this.lblSenha.Text = "Senha";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(343, 392);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(315, 27);
            this.txtConfirmaSenha.TabIndex = 30;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaSenha.Location = new System.Drawing.Point(113, 392);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(224, 23);
            this.lblConfirmaSenha.TabIndex = 29;
            this.lblConfirmaSenha.Text = "Confirmação de Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(343, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 27);
            this.txtEmail.TabIndex = 27;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(343, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(315, 27);
            this.txtNome.TabIndex = 26;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(257, 251);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(69, 23);
            this.lblCargo.TabIndex = 25;
            this.lblCargo.Text = "Cargo";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimeNascimento.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimeNascimento.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimeNascimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNascimento.Location = new System.Drawing.Point(343, 158);
            this.dateTimeNascimento.MaxDate = new System.DateTime(2006, 12, 1, 0, 0, 0, 0);
            this.dateTimeNascimento.MinDate = new System.DateTime(1970, 12, 1, 0, 0, 0, 0);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(148, 27);
            this.dateTimeNascimento.TabIndex = 24;
            this.dateTimeNascimento.Value = new System.DateTime(2005, 12, 1, 0, 0, 0, 0);
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.BackColor = System.Drawing.Color.Transparent;
            this.lblSetor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(269, 298);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(56, 23);
            this.lblSetor.TabIndex = 23;
            this.lblSetor.Text = "Setor";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(257, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 23);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-mail";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(133, 159);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(201, 23);
            this.lblDataNascimento.TabIndex = 21;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(162, 109);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(164, 23);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome Completo";
            // 
            // linkVoltar
            // 
            this.linkVoltar.AutoSize = true;
            this.linkVoltar.BackColor = System.Drawing.Color.Transparent;
            this.linkVoltar.LinkColor = System.Drawing.Color.White;
            this.linkVoltar.Location = new System.Drawing.Point(777, 42);
            this.linkVoltar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkVoltar.Name = "linkVoltar";
            this.linkVoltar.Size = new System.Drawing.Size(33, 13);
            this.linkVoltar.TabIndex = 19;
            this.linkVoltar.TabStop = true;
            this.linkVoltar.Text = "voltar";
            this.linkVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkVoltar_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(172, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sua tela de cadastro! ";
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCoffeeTech.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 532);
            this.Controls.Add(this.cBoxSetor);
            this.Controls.Add(this.cBoxCargo);
            this.Controls.Add(this.btnEditarCadastro);
            this.Controls.Add(this.btnEnviarCadastro);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.dateTimeNascimento);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.linkVoltar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastreSe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastreSe";
            this.Load += new System.EventHandler(this.CadastreSe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxSetor;
        private System.Windows.Forms.ComboBox cBoxCargo;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnEnviarCadastro;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.LinkLabel linkVoltar;
        private System.Windows.Forms.Label label1;
    }
}
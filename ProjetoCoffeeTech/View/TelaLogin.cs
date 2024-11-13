using ProjetoCoffeeTech.Controller;
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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FuncionarioController controller = new FuncionarioController();
            Funcionario funcionario = controller.Login(txtLogin.Text, txtSenha.Text);

            if (funcionario != null)
            {
                MessageBox.Show("Login bem-sucedido!");
                // Aqui pode redirecionar para a próxima tela
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.");
            }

            TelaInicial cad = new TelaInicial();
            cad.Show();
            this.Hide();
        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
            this.Hide();
        }
    }
}

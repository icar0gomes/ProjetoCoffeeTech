using ProjetoCoffeeTech.Controller;
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
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void lblLinkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaInicial cad = new TelaInicial();
            cad.Show();
            this.Hide();
        }

        private void btnEnviarCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmaSenha.Text)
            {
                FuncionarioController controller = new FuncionarioController();
                bool sucesso = controller.CadastrarFuncionario(
                    txtNome.Text,
                    txtSenha.Text,
                    txtEmail.Text,
                    cBoxSetor.Text,
                    cBoxCargo.Text,
                    dateTimeNascimento.Value
                );
                MessageBox.Show(sucesso ? "Cadastro realizado com sucesso!" : "Falha ao cadastrar. Verifique os dados.");
            }
            else
            {
                MessageBox.Show("As senhas não coincidem.");
            }
        }

        private void CadastreSe_Load(object sender, EventArgs e)
        {

        }
    }
}

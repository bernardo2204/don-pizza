using System;
using System.Windows.Forms;

namespace DonPizza
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha email e senha.");
                return;
            }

            Usuario objUsuario = new Usuario();
            objUsuario.SetEmail(txtEmail.Text);
            objUsuario.SetSenha(txtSenha.Text);

            if (objUsuario.ValidarLogin())
            {
                this.Hide();
                FrmPrincipal telaPrincipal = new FrmPrincipal();
                telaPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.");
                txtSenha.Clear();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace DonPizza
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        Cliente objCliente = new Cliente();

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            MostrarDadosClientes();
        }

        private void MostrarDadosClientes()
        {
            dtgClientes.DataSource = objCliente.ListarClientes();
        }

        private void LimparDados()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objCliente.SetNome(txtNome.Text);
            objCliente.SetCpf(txtCpf.Text);
            objCliente.SetTelefone(txtTelefone.Text);
            objCliente.SetEmail(txtEmail.Text);
            objCliente.SetSenha(txtSenha.Text);
            objCliente.SetCep(txtCep.Text);
            objCliente.SetEndereco(txtEndereco.Text);

            objCliente.InserirCliente();
            MostrarDadosClientes();
            MessageBox.Show("Dados do cliente INSERIDOS com sucesso.");
            LimparDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Clique num cliente da lista antes de alterar.");
                return;
            }

            objCliente.SetId(int.Parse(txtId.Text));
            objCliente.SetNome(txtNome.Text);
            objCliente.SetCpf(txtCpf.Text);
            objCliente.SetTelefone(txtTelefone.Text);
            objCliente.SetEmail(txtEmail.Text);
            objCliente.SetSenha(txtSenha.Text);
            objCliente.SetCep(txtCep.Text);
            objCliente.SetEndereco(txtEndereco.Text);

            objCliente.AlterarCliente();
            MostrarDadosClientes();
            MessageBox.Show("Dados do cliente ALTERADOS com sucesso.");
            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Clique num cliente da lista antes de excluir.");
                return;
            }

            int idCliente = int.Parse(txtId.Text);
            objCliente.SetId(idCliente);

            try
            {
                objCliente.ExcluirCliente();
                MessageBox.Show("Dados do cliente excluídos com sucesso.");
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("foreign key"))
                {
                    MessageBox.Show("Não foi possível excluir: esse cliente já tem pedido(s) registrado(s) no sistema.");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cliente:\n" + ex.Message);
                }
            }

            LimparDados();
            MostrarDadosClientes();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtId.Text = dtgClientes.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNome.Text = dtgClientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCpf.Text = dtgClientes.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtTelefone.Text = dtgClientes.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtEmail.Text = dtgClientes.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtSenha.Text = dtgClientes.Rows[e.RowIndex].Cells["senha"].Value.ToString();

            var cepValor = dtgClientes.Rows[e.RowIndex].Cells["cep"].Value;
            txtCep.Text = cepValor == DBNull.Value ? "" : cepValor.ToString();

            var enderecoValor = dtgClientes.Rows[e.RowIndex].Cells["endereco"].Value;
            txtEndereco.Text = enderecoValor == DBNull.Value ? "" : enderecoValor.ToString();
        }
    }
}

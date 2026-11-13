using System;
using System.Windows.Forms;

namespace DonPizza
{
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        Fornecedor objFornecedor = new Fornecedor();

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            MostrarDadosFornecedores();
        }

        private void MostrarDadosFornecedores()
        {
            dtgFornecedores.DataSource = objFornecedor.ListarFornecedores();
        }

        private void LimparDados()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCnpj.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtProdutoFornecido.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objFornecedor.SetNome(txtNome.Text);
            objFornecedor.SetCnpj(txtCnpj.Text);
            objFornecedor.SetTelefone(txtTelefone.Text);
            objFornecedor.SetEmail(txtEmail.Text);
            objFornecedor.SetProdutoFornecido(txtProdutoFornecido.Text);

            objFornecedor.InserirFornecedor();
            MostrarDadosFornecedores();
            MessageBox.Show("Dados do fornecedor INSERIDOS com sucesso.");
            LimparDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Clique num fornecedor da lista antes de alterar.");
                return;
            }

            objFornecedor.SetId(int.Parse(txtId.Text));
            objFornecedor.SetNome(txtNome.Text);
            objFornecedor.SetCnpj(txtCnpj.Text);
            objFornecedor.SetTelefone(txtTelefone.Text);
            objFornecedor.SetEmail(txtEmail.Text);
            objFornecedor.SetProdutoFornecido(txtProdutoFornecido.Text);

            objFornecedor.AlterarFornecedor();
            MostrarDadosFornecedores();
            MessageBox.Show("Dados do fornecedor ALTERADOS com sucesso.");
            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Clique num fornecedor da lista antes de excluir.");
                return;
            }

            objFornecedor.SetId(int.Parse(txtId.Text));

            try
            {
                objFornecedor.ExcluirFornecedor();
                MessageBox.Show("Dados do fornecedor excluídos com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir fornecedor:\n" + ex.Message);
            }

            LimparDados();
            MostrarDadosFornecedores();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtId.Text = dtgFornecedores.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNome.Text = dtgFornecedores.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCnpj.Text = dtgFornecedores.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
            txtTelefone.Text = dtgFornecedores.Rows[e.RowIndex].Cells["telefone"].Value.ToString();

            var emailValor = dtgFornecedores.Rows[e.RowIndex].Cells["email"].Value;
            txtEmail.Text = emailValor == DBNull.Value ? "" : emailValor.ToString();

            txtProdutoFornecido.Text = dtgFornecedores.Rows[e.RowIndex].Cells["produto_fornecido"].Value.ToString();
        }
    }
}

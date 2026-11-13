using System;
using System.Windows.Forms;

namespace DonPizza
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        Produto objProduto = new Produto();

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            MostrarDadosProdutos();
        }

        private void MostrarDadosProdutos()
        {
            dtgProdutos.DataSource = objProduto.ListarProdutos();
        }

        private void LimparDados()
        {
            txtId.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtImagem.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Clique num produto da lista antes de alterar.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            objProduto.SetId(int.Parse(txtId.Text));
            objProduto.SetNome(txtNome.Text);
            objProduto.SetDescricao(txtDescricao.Text);
            objProduto.SetCategoria(txtCategoria.Text);
            objProduto.SetPreco(preco);
            objProduto.SetImagem(txtImagem.Text);

            objProduto.AlterarProduto();
            MostrarDadosProdutos();
            MessageBox.Show("Dados do produto ALTERADOS com sucesso.");
            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Clique num produto da lista antes de excluir.");
                return;
            }

            objProduto.SetId(int.Parse(txtId.Text));

            try
            {
                objProduto.ExcluirProduto();
                MessageBox.Show("Dados do produto excluídos com sucesso.");
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("foreign key"))
                {
                    MessageBox.Show("Não foi possível excluir: esse produto já está em pedido(s) registrado(s) no sistema.");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir produto:\n" + ex.Message);
                }
            }

            LimparDados();
            MostrarDadosProdutos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtId.Text = dtgProdutos.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNome.Text = dtgProdutos.Rows[e.RowIndex].Cells["nome"].Value.ToString();

            var descricaoValor = dtgProdutos.Rows[e.RowIndex].Cells["descricao"].Value;
            txtDescricao.Text = descricaoValor == DBNull.Value ? "" : descricaoValor.ToString();

            txtCategoria.Text = dtgProdutos.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
            txtPreco.Text = dtgProdutos.Rows[e.RowIndex].Cells["preco"].Value.ToString();

            var imagemValor = dtgProdutos.Rows[e.RowIndex].Cells["imagem"].Value;
            txtImagem.Text = imagemValor == DBNull.Value ? "" : imagemValor.ToString();
        }
    }
}

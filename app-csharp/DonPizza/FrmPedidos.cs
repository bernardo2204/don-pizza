using System;
using System.Windows.Forms;

namespace DonPizza
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        Pedido objPedido = new Pedido();

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            MostrarDadosPedidos();
        }

        private void MostrarDadosPedidos()
        {
            dtgPedidos.DataSource = objPedido.ListarPedidos();
        }

        private void LimparDados()
        {
            txtId.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Clique num pedido da lista e escolha o status antes de alterar.");
                return;
            }

            objPedido.SetId(int.Parse(txtId.Text));
            objPedido.SetStatus(cmbStatus.Text);

            objPedido.AlterarStatusPedido();
            MostrarDadosPedidos();
            MessageBox.Show("Status do pedido ALTERADO com sucesso.");
            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Clique num pedido da lista antes de excluir.");
                return;
            }

            objPedido.SetId(int.Parse(txtId.Text));

            try
            {
                objPedido.ExcluirPedido();
                MessageBox.Show("Pedido excluído com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir pedido:\n" + ex.Message);
            }

            LimparDados();
            MostrarDadosPedidos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtId.Text = dtgPedidos.Rows[e.RowIndex].Cells["id"].Value.ToString();
            cmbStatus.Text = dtgPedidos.Rows[e.RowIndex].Cells["status"].Value.ToString();
        }
    }
}

using System;
using System.Windows.Forms;

namespace DonPizza
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes telaClientes = new FrmClientes();
            telaClientes.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedores telaFornecedores = new FrmFornecedores();
            telaFornecedores.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos telaProdutos = new FrmProdutos();
            telaProdutos.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos telaPedidos = new FrmPedidos();
            telaPedidos.ShowDialog();
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            ImportadorPedidos importador = new ImportadorPedidos();

            try
            {
                string resumo = importador.Importar(openFileDialog1.FileName);
                MessageBox.Show(resumo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao importar o arquivo:\n" + ex.Message);
            }
        }
    }
}

namespace DonPizza
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.lblImagem = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTopo
            //
            this.pnlTopo.BackColor = System.Drawing.Color.Black;
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1020, 55);
            this.pnlTopo.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(245, 240, 230);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1020, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Produtos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlCampos
            //
            this.pnlCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCampos.Controls.Add(this.txtImagem);
            this.pnlCampos.Controls.Add(this.lblImagem);
            this.pnlCampos.Controls.Add(this.txtPreco);
            this.pnlCampos.Controls.Add(this.lblPreco);
            this.pnlCampos.Controls.Add(this.txtCategoria);
            this.pnlCampos.Controls.Add(this.lblCategoria);
            this.pnlCampos.Controls.Add(this.txtDescricao);
            this.pnlCampos.Controls.Add(this.lblDescricao);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtId);
            this.pnlCampos.Controls.Add(this.lblId);
            this.pnlCampos.Location = new System.Drawing.Point(12, 65);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(300, 480);
            this.pnlCampos.TabIndex = 1;
            //
            // txtImagem
            //
            this.txtImagem.Location = new System.Drawing.Point(15, 320);
            this.txtImagem.MaxLength = 150;
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(270, 23);
            this.txtImagem.TabIndex = 11;
            //
            // lblImagem
            //
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(15, 300);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(53, 15);
            this.lblImagem.TabIndex = 10;
            this.lblImagem.Text = "Imagem:";
            //
            // txtPreco
            //
            this.txtPreco.Location = new System.Drawing.Point(15, 262);
            this.txtPreco.MaxLength = 10;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(270, 23);
            this.txtPreco.TabIndex = 9;
            //
            // lblPreco
            //
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(15, 242);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(43, 15);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço:";
            //
            // txtCategoria
            //
            this.txtCategoria.Location = new System.Drawing.Point(15, 204);
            this.txtCategoria.MaxLength = 30;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(270, 23);
            this.txtCategoria.TabIndex = 7;
            //
            // lblCategoria
            //
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 184);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(64, 15);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            //
            // txtDescricao
            //
            this.txtDescricao.Location = new System.Drawing.Point(15, 146);
            this.txtDescricao.MaxLength = 255;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(270, 23);
            this.txtDescricao.TabIndex = 5;
            //
            // lblDescricao
            //
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(15, 126);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(70, 15);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            //
            // txtNome
            //
            this.txtNome.Location = new System.Drawing.Point(15, 88);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(270, 23);
            this.txtNome.TabIndex = 3;
            //
            // lblNome
            //
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            //
            // txtId
            //
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(15, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(270, 23);
            this.txtId.TabIndex = 1;
            //
            // lblId
            //
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            //
            // dtgProdutos
            //
            this.dtgProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Location = new System.Drawing.Point(324, 65);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.RowHeadersWidth = 51;
            this.dtgProdutos.RowTemplate.Height = 25;
            this.dtgProdutos.Size = new System.Drawing.Size(684, 480);
            this.dtgProdutos.TabIndex = 2;
            this.dtgProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellClick);
            //
            // btnAlterar
            //
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Location = new System.Drawing.Point(12, 552);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(150, 40);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            //
            // btnExcluir
            //
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(172, 552);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 40);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            //
            // btnLimpar
            //
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(332, 552);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            //
            // btnSair
            //
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(492, 552);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 40);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            //
            // FrmProdutos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 240, 230);
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dtgProdutos);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlTopo);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Don Pizza - Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.TextBox txtImagem;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

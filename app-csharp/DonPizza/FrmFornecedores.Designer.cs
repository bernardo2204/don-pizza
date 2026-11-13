namespace DonPizza
{
    partial class FrmFornecedores
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
            this.txtProdutoFornecido = new System.Windows.Forms.TextBox();
            this.lblProdutoFornecido = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtgFornecedores = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFornecedores)).BeginInit();
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
            this.lblTitulo.Text = "Fornecedores";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlCampos
            //
            this.pnlCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCampos.Controls.Add(this.txtProdutoFornecido);
            this.pnlCampos.Controls.Add(this.lblProdutoFornecido);
            this.pnlCampos.Controls.Add(this.txtEmail);
            this.pnlCampos.Controls.Add(this.lblEmail);
            this.pnlCampos.Controls.Add(this.txtTelefone);
            this.pnlCampos.Controls.Add(this.lblTelefone);
            this.pnlCampos.Controls.Add(this.txtCnpj);
            this.pnlCampos.Controls.Add(this.lblCnpj);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtId);
            this.pnlCampos.Controls.Add(this.lblId);
            this.pnlCampos.Location = new System.Drawing.Point(12, 65);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(300, 480);
            this.pnlCampos.TabIndex = 1;
            //
            // txtProdutoFornecido
            //
            this.txtProdutoFornecido.Location = new System.Drawing.Point(15, 320);
            this.txtProdutoFornecido.MaxLength = 100;
            this.txtProdutoFornecido.Name = "txtProdutoFornecido";
            this.txtProdutoFornecido.Size = new System.Drawing.Size(270, 23);
            this.txtProdutoFornecido.TabIndex = 11;
            //
            // lblProdutoFornecido
            //
            this.lblProdutoFornecido.AutoSize = true;
            this.lblProdutoFornecido.Location = new System.Drawing.Point(15, 300);
            this.lblProdutoFornecido.Name = "lblProdutoFornecido";
            this.lblProdutoFornecido.Size = new System.Drawing.Size(130, 15);
            this.lblProdutoFornecido.TabIndex = 10;
            this.lblProdutoFornecido.Text = "Produto fornecido:";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(15, 262);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 23);
            this.txtEmail.TabIndex = 9;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 242);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            //
            // txtTelefone
            //
            this.txtTelefone.Location = new System.Drawing.Point(15, 204);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(270, 23);
            this.txtTelefone.TabIndex = 7;
            //
            // lblTelefone
            //
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(15, 184);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(60, 15);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            //
            // txtCnpj
            //
            this.txtCnpj.Location = new System.Drawing.Point(15, 146);
            this.txtCnpj.MaxLength = 18;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(270, 23);
            this.txtCnpj.TabIndex = 5;
            //
            // lblCnpj
            //
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(15, 126);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(38, 15);
            this.lblCnpj.TabIndex = 4;
            this.lblCnpj.Text = "CNPJ:";
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
            // dtgFornecedores
            //
            this.dtgFornecedores.BackgroundColor = System.Drawing.Color.White;
            this.dtgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFornecedores.Location = new System.Drawing.Point(324, 65);
            this.dtgFornecedores.Name = "dtgFornecedores";
            this.dtgFornecedores.RowHeadersWidth = 51;
            this.dtgFornecedores.RowTemplate.Height = 25;
            this.dtgFornecedores.Size = new System.Drawing.Size(684, 480);
            this.dtgFornecedores.TabIndex = 2;
            this.dtgFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFornecedores_CellClick);
            //
            // btnCadastrar
            //
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(15, 122, 61);
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 552);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 40);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            //
            // btnAlterar
            //
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Location = new System.Drawing.Point(172, 552);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(150, 40);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            //
            // btnExcluir
            //
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(332, 552);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 40);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            //
            // btnLimpar
            //
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(492, 552);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            //
            // btnSair
            //
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(652, 552);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 40);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            //
            // FrmFornecedores
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 240, 230);
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtgFornecedores);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlTopo);
            this.Name = "FrmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Don Pizza - Fornecedores";
            this.Load += new System.EventHandler(this.FrmFornecedores_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.TextBox txtProdutoFornecido;
        private System.Windows.Forms.Label lblProdutoFornecido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dtgFornecedores;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

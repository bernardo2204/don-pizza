namespace DonPizza
{
    partial class FrmClientes
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
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
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
            this.lblTitulo.Text = "Clientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlCampos
            //
            this.pnlCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCampos.Controls.Add(this.txtEndereco);
            this.pnlCampos.Controls.Add(this.lblEndereco);
            this.pnlCampos.Controls.Add(this.txtCep);
            this.pnlCampos.Controls.Add(this.lblCep);
            this.pnlCampos.Controls.Add(this.txtSenha);
            this.pnlCampos.Controls.Add(this.lblSenha);
            this.pnlCampos.Controls.Add(this.txtEmail);
            this.pnlCampos.Controls.Add(this.lblEmail);
            this.pnlCampos.Controls.Add(this.txtTelefone);
            this.pnlCampos.Controls.Add(this.lblTelefone);
            this.pnlCampos.Controls.Add(this.txtCpf);
            this.pnlCampos.Controls.Add(this.lblCpf);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtId);
            this.pnlCampos.Controls.Add(this.lblId);
            this.pnlCampos.Location = new System.Drawing.Point(12, 65);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(300, 480);
            this.pnlCampos.TabIndex = 1;
            //
            // txtEndereco
            //
            this.txtEndereco.Location = new System.Drawing.Point(15, 436);
            this.txtEndereco.MaxLength = 150;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(270, 23);
            this.txtEndereco.TabIndex = 15;
            //
            // lblEndereco
            //
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(15, 416);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(60, 15);
            this.lblEndereco.TabIndex = 14;
            this.lblEndereco.Text = "Endereço:";
            //
            // txtCep
            //
            this.txtCep.Location = new System.Drawing.Point(15, 378);
            this.txtCep.MaxLength = 9;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(270, 23);
            this.txtCep.TabIndex = 13;
            //
            // lblCep
            //
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(15, 358);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(32, 15);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "CEP:";
            //
            // txtSenha
            //
            this.txtSenha.Location = new System.Drawing.Point(15, 320);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(270, 23);
            this.txtSenha.TabIndex = 11;
            //
            // lblSenha
            //
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(15, 300);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 15);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha:";
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
            // txtCpf
            //
            this.txtCpf.Location = new System.Drawing.Point(15, 146);
            this.txtCpf.MaxLength = 14;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(270, 23);
            this.txtCpf.TabIndex = 5;
            //
            // lblCpf
            //
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(15, 126);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(32, 15);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF:";
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
            // dtgClientes
            //
            this.dtgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(324, 65);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeadersWidth = 51;
            this.dtgClientes.RowTemplate.Height = 25;
            this.dtgClientes.Size = new System.Drawing.Size(684, 480);
            this.dtgClientes.TabIndex = 2;
            this.dtgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellClick);
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
            // FrmClientes
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
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlTopo);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Don Pizza - Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

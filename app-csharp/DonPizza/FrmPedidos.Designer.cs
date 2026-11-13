namespace DonPizza
{
    partial class FrmPedidos
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlTopo.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
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
            this.lblTitulo.Text = "Pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlCampos
            //
            this.pnlCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCampos.Controls.Add(this.cmbStatus);
            this.pnlCampos.Controls.Add(this.lblStatus);
            this.pnlCampos.Controls.Add(this.txtId);
            this.pnlCampos.Controls.Add(this.lblId);
            this.pnlCampos.Location = new System.Drawing.Point(12, 65);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(300, 480);
            this.pnlCampos.TabIndex = 1;
            //
            // cmbStatus
            //
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Recebido",
            "Em preparo",
            "Saiu para entrega",
            "Entregue",
            "Cancelado"});
            this.cmbStatus.Location = new System.Drawing.Point(15, 88);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(270, 23);
            this.cmbStatus.TabIndex = 3;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
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
            // dtgPedidos
            //
            this.dtgPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(324, 65);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.RowHeadersWidth = 51;
            this.dtgPedidos.RowTemplate.Height = 25;
            this.dtgPedidos.Size = new System.Drawing.Size(684, 480);
            this.dtgPedidos.TabIndex = 2;
            this.dtgPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPedidos_CellClick);
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
            // FrmPedidos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 240, 230);
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dtgPedidos);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlTopo);
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Don Pizza - Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

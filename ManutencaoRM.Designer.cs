namespace Jira_Generator_V2
{
    partial class ManutencaoRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManutencaoRM));
            this.btnCopiar = new System.Windows.Forms.Button();
            this.lblReproducao = new System.Windows.Forms.Label();
            this.txtReproducao = new System.Windows.Forms.TextBox();
            this.cmbVersao = new System.Windows.Forms.ComboBox();
            this.lblMensagemErro = new System.Windows.Forms.Label();
            this.txtMensagemErro = new System.Windows.Forms.TextBox();
            this.lblDescrProblema = new System.Windows.Forms.Label();
            this.txtDescrProblema = new System.Windows.Forms.TextBox();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.lblNomeBanco = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.txtBiblioteca = new System.Windows.Forms.TextBox();
            this.txtColigada = new System.Windows.Forms.TextBox();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.lblColigada = new System.Windows.Forms.Label();
            this.lblParametrizacao = new System.Windows.Forms.Label();
            this.txtParametrizacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.White;
            this.btnCopiar.Location = new System.Drawing.Point(304, 625);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(116, 23);
            this.btnCopiar.TabIndex = 14;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lblReproducao
            // 
            this.lblReproducao.AutoSize = true;
            this.lblReproducao.Location = new System.Drawing.Point(121, 500);
            this.lblReproducao.Name = "lblReproducao";
            this.lblReproducao.Size = new System.Drawing.Size(230, 13);
            this.lblReproducao.TabIndex = 80;
            this.lblReproducao.Text = "Passo-a-passo para a reprodução do problema:";
            // 
            // txtReproducao
            // 
            this.txtReproducao.Location = new System.Drawing.Point(124, 516);
            this.txtReproducao.Multiline = true;
            this.txtReproducao.Name = "txtReproducao";
            this.txtReproducao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReproducao.Size = new System.Drawing.Size(513, 91);
            this.txtReproducao.TabIndex = 13;
            // 
            // cmbVersao
            // 
            this.cmbVersao.AutoCompleteCustomSource.AddRange(new string[] {
            "PEP",
            "PEP/RM"});
            this.cmbVersao.BackColor = System.Drawing.Color.White;
            this.cmbVersao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersao.FormattingEnabled = true;
            this.cmbVersao.Items.AddRange(new object[] {
            "12.1.23",
            "12.1.24",
            "12.1.25",
            "12.1.26",
            "12.1.27"});
            this.cmbVersao.Location = new System.Drawing.Point(191, 38);
            this.cmbVersao.Name = "cmbVersao";
            this.cmbVersao.Size = new System.Drawing.Size(134, 21);
            this.cmbVersao.TabIndex = 2;
            // 
            // lblMensagemErro
            // 
            this.lblMensagemErro.AutoSize = true;
            this.lblMensagemErro.Location = new System.Drawing.Point(121, 375);
            this.lblMensagemErro.Name = "lblMensagemErro";
            this.lblMensagemErro.Size = new System.Drawing.Size(98, 13);
            this.lblMensagemErro.TabIndex = 76;
            this.lblMensagemErro.Text = "Mensagem do erro:";
            // 
            // txtMensagemErro
            // 
            this.txtMensagemErro.Location = new System.Drawing.Point(124, 391);
            this.txtMensagemErro.Multiline = true;
            this.txtMensagemErro.Name = "txtMensagemErro";
            this.txtMensagemErro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagemErro.Size = new System.Drawing.Size(513, 91);
            this.txtMensagemErro.TabIndex = 12;
            // 
            // lblDescrProblema
            // 
            this.lblDescrProblema.AutoSize = true;
            this.lblDescrProblema.Location = new System.Drawing.Point(124, 125);
            this.lblDescrProblema.Name = "lblDescrProblema";
            this.lblDescrProblema.Size = new System.Drawing.Size(120, 13);
            this.lblDescrProblema.TabIndex = 75;
            this.lblDescrProblema.Text = "Descrição do Problema:";
            // 
            // txtDescrProblema
            // 
            this.txtDescrProblema.Location = new System.Drawing.Point(127, 144);
            this.txtDescrProblema.Multiline = true;
            this.txtDescrProblema.Name = "txtDescrProblema";
            this.txtDescrProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescrProblema.Size = new System.Drawing.Size(513, 90);
            this.txtDescrProblema.TabIndex = 10;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(505, 65);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(135, 20);
            this.txtNomeBanco.TabIndex = 7;
            // 
            // lblNomeBanco
            // 
            this.lblNomeBanco.AutoSize = true;
            this.lblNomeBanco.Location = new System.Drawing.Point(410, 72);
            this.lblNomeBanco.Name = "lblNomeBanco";
            this.lblNomeBanco.Size = new System.Drawing.Size(87, 13);
            this.lblNomeBanco.TabIndex = 74;
            this.lblNomeBanco.Text = "Nome do Banco:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(505, 118);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(134, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(453, 125);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 71;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(505, 91);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(134, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(448, 98);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 68;
            this.lblUsuario.Text = "Usuário:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(505, 38);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(135, 20);
            this.txtServidor.TabIndex = 6;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(450, 45);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 13);
            this.lblServidor.TabIndex = 64;
            this.lblServidor.Text = "Servidor:";
            // 
            // cmbBanco
            // 
            this.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Items.AddRange(new object[] {
            "SQL",
            "ORACLE"});
            this.cmbBanco.Location = new System.Drawing.Point(505, 11);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(134, 21);
            this.cmbBanco.TabIndex = 5;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(409, 19);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(90, 13);
            this.lblBanco.TabIndex = 61;
            this.lblBanco.Text = "Banco de Dados:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.AutoCompleteCustomSource.AddRange(new string[] {
            "PEP",
            "PEP/RM"});
            this.cmbProduto.BackColor = System.Drawing.Color.White;
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Items.AddRange(new object[] {
            "RM"});
            this.cmbProduto.Location = new System.Drawing.Point(191, 12);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(134, 21);
            this.cmbProduto.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(131, 20);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 59;
            this.lblProduto.Text = "Produto:";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(135, 46);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(43, 13);
            this.lblVersao.TabIndex = 57;
            this.lblVersao.Text = "Versão:";
            // 
            // txtBiblioteca
            // 
            this.txtBiblioteca.Location = new System.Drawing.Point(190, 91);
            this.txtBiblioteca.Name = "txtBiblioteca";
            this.txtBiblioteca.Size = new System.Drawing.Size(135, 20);
            this.txtBiblioteca.TabIndex = 4;
            // 
            // txtColigada
            // 
            this.txtColigada.Location = new System.Drawing.Point(190, 65);
            this.txtColigada.Name = "txtColigada";
            this.txtColigada.Size = new System.Drawing.Size(135, 20);
            this.txtColigada.TabIndex = 3;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Location = new System.Drawing.Point(121, 98);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(56, 13);
            this.lblBiblioteca.TabIndex = 109;
            this.lblBiblioteca.Text = "Biblioteca:";
            // 
            // lblColigada
            // 
            this.lblColigada.AutoSize = true;
            this.lblColigada.Location = new System.Drawing.Point(126, 72);
            this.lblColigada.Name = "lblColigada";
            this.lblColigada.Size = new System.Drawing.Size(51, 13);
            this.lblColigada.TabIndex = 108;
            this.lblColigada.Text = "Coligada:";
            // 
            // lblParametrizacao
            // 
            this.lblParametrizacao.AutoSize = true;
            this.lblParametrizacao.Location = new System.Drawing.Point(121, 252);
            this.lblParametrizacao.Name = "lblParametrizacao";
            this.lblParametrizacao.Size = new System.Drawing.Size(137, 13);
            this.lblParametrizacao.TabIndex = 113;
            this.lblParametrizacao.Text = "Parametrização necessária:";
            // 
            // txtParametrizacao
            // 
            this.txtParametrizacao.Location = new System.Drawing.Point(124, 268);
            this.txtParametrizacao.Multiline = true;
            this.txtParametrizacao.Name = "txtParametrizacao";
            this.txtParametrizacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParametrizacao.Size = new System.Drawing.Size(513, 91);
            this.txtParametrizacao.TabIndex = 11;
            // 
            // ManutencaoRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 659);
            this.Controls.Add(this.lblParametrizacao);
            this.Controls.Add(this.txtParametrizacao);
            this.Controls.Add(this.txtBiblioteca);
            this.Controls.Add(this.txtColigada);
            this.Controls.Add(this.lblBiblioteca);
            this.Controls.Add(this.lblColigada);
            this.Controls.Add(this.lblReproducao);
            this.Controls.Add(this.txtReproducao);
            this.Controls.Add(this.cmbVersao);
            this.Controls.Add(this.lblMensagemErro);
            this.Controls.Add(this.txtMensagemErro);
            this.Controls.Add(this.lblDescrProblema);
            this.Controls.Add(this.txtDescrProblema);
            this.Controls.Add(this.txtNomeBanco);
            this.Controls.Add(this.lblNomeBanco);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnCopiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManutencaoRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relato de Problema (RM)";
            this.Load += new System.EventHandler(this.ManutencaoRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblReproducao;
        private System.Windows.Forms.TextBox txtReproducao;
        private System.Windows.Forms.ComboBox cmbVersao;
        private System.Windows.Forms.Label lblMensagemErro;
        private System.Windows.Forms.TextBox txtMensagemErro;
        private System.Windows.Forms.Label lblDescrProblema;
        private System.Windows.Forms.TextBox txtDescrProblema;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.Label lblNomeBanco;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblServidor;
        public System.Windows.Forms.ComboBox cmbBanco;
        public System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtBiblioteca;
        private System.Windows.Forms.TextBox txtColigada;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblColigada;
        private System.Windows.Forms.Label lblParametrizacao;
        private System.Windows.Forms.TextBox txtParametrizacao;
    }
}
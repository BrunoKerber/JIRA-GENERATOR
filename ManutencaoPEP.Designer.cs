namespace Jira_Generator_V2
{
    partial class ManutencaoPEP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManutencaoPEP));
            this.btnCopiar = new System.Windows.Forms.Button();
            this.lblReproducao = new System.Windows.Forms.Label();
            this.txtReproducao = new System.Windows.Forms.TextBox();
            this.cmbResolucao = new System.Windows.Forms.ComboBox();
            this.cmbSO = new System.Windows.Forms.ComboBox();
            this.cmbVersao = new System.Windows.Forms.ComboBox();
            this.lblMensagemErro = new System.Windows.Forms.Label();
            this.txtMensagemErro = new System.Windows.Forms.TextBox();
            this.lblDescrProblema = new System.Windows.Forms.Label();
            this.txtDescrProblema = new System.Windows.Forms.TextBox();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.lblNomeBanco = new System.Windows.Forms.Label();
            this.lblResolucao = new System.Windows.Forms.Label();
            this.lblSo = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.White;
            this.btnCopiar.Location = new System.Drawing.Point(327, 506);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(116, 23);
            this.btnCopiar.TabIndex = 0;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lblReproducao
            // 
            this.lblReproducao.AutoSize = true;
            this.lblReproducao.Location = new System.Drawing.Point(126, 379);
            this.lblReproducao.Name = "lblReproducao";
            this.lblReproducao.Size = new System.Drawing.Size(230, 13);
            this.lblReproducao.TabIndex = 55;
            this.lblReproducao.Text = "Passo-a-passo para a reprodução do problema:";
            // 
            // txtReproducao
            // 
            this.txtReproducao.Location = new System.Drawing.Point(129, 395);
            this.txtReproducao.Multiline = true;
            this.txtReproducao.Name = "txtReproducao";
            this.txtReproducao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReproducao.Size = new System.Drawing.Size(513, 91);
            this.txtReproducao.TabIndex = 45;
            // 
            // cmbResolucao
            // 
            this.cmbResolucao.AutoCompleteCustomSource.AddRange(new string[] {
            "PEP",
            "PEP/RM"});
            this.cmbResolucao.BackColor = System.Drawing.Color.White;
            this.cmbResolucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolucao.FormattingEnabled = true;
            this.cmbResolucao.Items.AddRange(new object[] {
            "1366 x 768"});
            this.cmbResolucao.Location = new System.Drawing.Point(193, 90);
            this.cmbResolucao.Name = "cmbResolucao";
            this.cmbResolucao.Size = new System.Drawing.Size(134, 21);
            this.cmbResolucao.TabIndex = 54;
            // 
            // cmbSO
            // 
            this.cmbSO.AutoCompleteCustomSource.AddRange(new string[] {
            "PEP",
            "PEP/RM"});
            this.cmbSO.BackColor = System.Drawing.Color.White;
            this.cmbSO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSO.FormattingEnabled = true;
            this.cmbSO.Items.AddRange(new object[] {
            "Windows 10 PRO (x64)",
            "Windows 7 PRO (x64)"});
            this.cmbSO.Location = new System.Drawing.Point(193, 64);
            this.cmbSO.Name = "cmbSO";
            this.cmbSO.Size = new System.Drawing.Size(134, 21);
            this.cmbSO.TabIndex = 53;
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
            "12.1.26"});
            this.cmbVersao.Location = new System.Drawing.Point(193, 38);
            this.cmbVersao.Name = "cmbVersao";
            this.cmbVersao.Size = new System.Drawing.Size(134, 21);
            this.cmbVersao.TabIndex = 52;
            // 
            // lblMensagemErro
            // 
            this.lblMensagemErro.AutoSize = true;
            this.lblMensagemErro.Location = new System.Drawing.Point(126, 254);
            this.lblMensagemErro.Name = "lblMensagemErro";
            this.lblMensagemErro.Size = new System.Drawing.Size(98, 13);
            this.lblMensagemErro.TabIndex = 51;
            this.lblMensagemErro.Text = "Mensagem do erro:";
            // 
            // txtMensagemErro
            // 
            this.txtMensagemErro.Location = new System.Drawing.Point(129, 270);
            this.txtMensagemErro.Multiline = true;
            this.txtMensagemErro.Name = "txtMensagemErro";
            this.txtMensagemErro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagemErro.Size = new System.Drawing.Size(513, 91);
            this.txtMensagemErro.TabIndex = 44;
            // 
            // lblDescrProblema
            // 
            this.lblDescrProblema.AutoSize = true;
            this.lblDescrProblema.Location = new System.Drawing.Point(126, 125);
            this.lblDescrProblema.Name = "lblDescrProblema";
            this.lblDescrProblema.Size = new System.Drawing.Size(120, 13);
            this.lblDescrProblema.TabIndex = 50;
            this.lblDescrProblema.Text = "Descrição do Problema:";
            // 
            // txtDescrProblema
            // 
            this.txtDescrProblema.Location = new System.Drawing.Point(129, 144);
            this.txtDescrProblema.Multiline = true;
            this.txtDescrProblema.Name = "txtDescrProblema";
            this.txtDescrProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescrProblema.Size = new System.Drawing.Size(513, 90);
            this.txtDescrProblema.TabIndex = 42;
            this.txtDescrProblema.TextChanged += new System.EventHandler(this.txtDescrProblema_TextChanged);
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(507, 65);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(135, 20);
            this.txtNomeBanco.TabIndex = 38;
            // 
            // lblNomeBanco
            // 
            this.lblNomeBanco.AutoSize = true;
            this.lblNomeBanco.Location = new System.Drawing.Point(412, 72);
            this.lblNomeBanco.Name = "lblNomeBanco";
            this.lblNomeBanco.Size = new System.Drawing.Size(87, 13);
            this.lblNomeBanco.TabIndex = 49;
            this.lblNomeBanco.Text = "Nome do Banco:";
            // 
            // lblResolucao
            // 
            this.lblResolucao.AutoSize = true;
            this.lblResolucao.Location = new System.Drawing.Point(126, 98);
            this.lblResolucao.Name = "lblResolucao";
            this.lblResolucao.Size = new System.Drawing.Size(61, 13);
            this.lblResolucao.TabIndex = 48;
            this.lblResolucao.Text = "Resolução:";
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(155, 72);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(25, 13);
            this.lblSo.TabIndex = 47;
            this.lblSo.Text = "SO:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(507, 118);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(134, 20);
            this.txtSenha.TabIndex = 41;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(455, 125);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 46;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(507, 91);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(134, 20);
            this.txtUsuario.TabIndex = 40;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(450, 98);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 43;
            this.lblUsuario.Text = "Usuário:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(507, 38);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(135, 20);
            this.txtServidor.TabIndex = 37;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(452, 45);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 13);
            this.lblServidor.TabIndex = 39;
            this.lblServidor.Text = "Servidor:";
            // 
            // cmbBanco
            // 
            this.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Items.AddRange(new object[] {
            "SQL",
            "ORACLE"});
            this.cmbBanco.Location = new System.Drawing.Point(507, 11);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(134, 21);
            this.cmbBanco.TabIndex = 35;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(411, 19);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(90, 13);
            this.lblBanco.TabIndex = 36;
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
            "PEP",
            "PEP/RM"});
            this.cmbProduto.Location = new System.Drawing.Point(193, 12);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(134, 21);
            this.cmbProduto.TabIndex = 33;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(133, 20);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 34;
            this.lblProduto.Text = "Produto:";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(137, 46);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(43, 13);
            this.lblVersao.TabIndex = 32;
            this.lblVersao.Text = "Versão:";
            // 
            // ManutencaoPEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 541);
            this.Controls.Add(this.lblReproducao);
            this.Controls.Add(this.txtReproducao);
            this.Controls.Add(this.cmbResolucao);
            this.Controls.Add(this.cmbSO);
            this.Controls.Add(this.cmbVersao);
            this.Controls.Add(this.lblMensagemErro);
            this.Controls.Add(this.txtMensagemErro);
            this.Controls.Add(this.lblDescrProblema);
            this.Controls.Add(this.txtDescrProblema);
            this.Controls.Add(this.txtNomeBanco);
            this.Controls.Add(this.lblNomeBanco);
            this.Controls.Add(this.lblResolucao);
            this.Controls.Add(this.lblSo);
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
            this.Name = "ManutencaoPEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relato de Problema (PEP)";
            this.Load += new System.EventHandler(this.ManutencaoPEP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblReproducao;
        private System.Windows.Forms.TextBox txtReproducao;
        private System.Windows.Forms.ComboBox cmbResolucao;
        private System.Windows.Forms.ComboBox cmbSO;
        private System.Windows.Forms.ComboBox cmbVersao;
        private System.Windows.Forms.Label lblMensagemErro;
        private System.Windows.Forms.TextBox txtMensagemErro;
        private System.Windows.Forms.Label lblDescrProblema;
        private System.Windows.Forms.TextBox txtDescrProblema;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.Label lblNomeBanco;
        private System.Windows.Forms.Label lblResolucao;
        private System.Windows.Forms.Label lblSo;
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
    }
}
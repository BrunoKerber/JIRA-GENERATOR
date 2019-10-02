namespace Jira_Generator_V2
{
    partial class Melhoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Melhoria));
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
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReproducao
            // 
            this.lblReproducao.AutoSize = true;
            this.lblReproducao.Location = new System.Drawing.Point(124, 379);
            this.lblReproducao.Name = "lblReproducao";
            this.lblReproducao.Size = new System.Drawing.Size(230, 13);
            this.lblReproducao.TabIndex = 80;
            this.lblReproducao.Text = "Passo-a-passo para a reprodução do problema:";
            // 
            // txtReproducao
            // 
            this.txtReproducao.Location = new System.Drawing.Point(127, 395);
            this.txtReproducao.Multiline = true;
            this.txtReproducao.Name = "txtReproducao";
            this.txtReproducao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReproducao.Size = new System.Drawing.Size(513, 91);
            this.txtReproducao.TabIndex = 70;
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
            this.cmbResolucao.Location = new System.Drawing.Point(191, 90);
            this.cmbResolucao.Name = "cmbResolucao";
            this.cmbResolucao.Size = new System.Drawing.Size(134, 21);
            this.cmbResolucao.TabIndex = 79;
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
            this.cmbSO.Location = new System.Drawing.Point(191, 64);
            this.cmbSO.Name = "cmbSO";
            this.cmbSO.Size = new System.Drawing.Size(134, 21);
            this.cmbSO.TabIndex = 78;
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
            this.cmbVersao.Location = new System.Drawing.Point(191, 38);
            this.cmbVersao.Name = "cmbVersao";
            this.cmbVersao.Size = new System.Drawing.Size(134, 21);
            this.cmbVersao.TabIndex = 77;
            // 
            // lblMensagemErro
            // 
            this.lblMensagemErro.AutoSize = true;
            this.lblMensagemErro.Location = new System.Drawing.Point(124, 254);
            this.lblMensagemErro.Name = "lblMensagemErro";
            this.lblMensagemErro.Size = new System.Drawing.Size(98, 13);
            this.lblMensagemErro.TabIndex = 76;
            this.lblMensagemErro.Text = "Mensagem do erro:";
            // 
            // txtMensagemErro
            // 
            this.txtMensagemErro.Location = new System.Drawing.Point(127, 270);
            this.txtMensagemErro.Multiline = true;
            this.txtMensagemErro.Name = "txtMensagemErro";
            this.txtMensagemErro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagemErro.Size = new System.Drawing.Size(513, 91);
            this.txtMensagemErro.TabIndex = 69;
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
            this.txtDescrProblema.TabIndex = 67;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(505, 65);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(135, 20);
            this.txtNomeBanco.TabIndex = 63;
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
            // lblResolucao
            // 
            this.lblResolucao.AutoSize = true;
            this.lblResolucao.Location = new System.Drawing.Point(124, 98);
            this.lblResolucao.Name = "lblResolucao";
            this.lblResolucao.Size = new System.Drawing.Size(61, 13);
            this.lblResolucao.TabIndex = 73;
            this.lblResolucao.Text = "Resolução:";
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(153, 72);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(25, 13);
            this.lblSo.TabIndex = 72;
            this.lblSo.Text = "SO:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(505, 118);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(134, 20);
            this.txtSenha.TabIndex = 66;
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
            this.txtUsuario.TabIndex = 65;
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
            this.txtServidor.TabIndex = 62;
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
            this.cmbBanco.TabIndex = 60;
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
            "PEP",
            "PEP/RM"});
            this.cmbProduto.Location = new System.Drawing.Point(191, 12);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(134, 21);
            this.cmbProduto.TabIndex = 58;
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
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.White;
            this.btnCopiar.Location = new System.Drawing.Point(304, 506);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(116, 23);
            this.btnCopiar.TabIndex = 56;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // Melhoria
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
            this.Name = "Melhoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura de Melhoria";
            this.Load += new System.EventHandler(this.Melhoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnCopiar;
    }
}
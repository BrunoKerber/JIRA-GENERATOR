namespace Jira_Generator_V2
{
    partial class LiberacaoIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiberacaoIssue));
            this.cmbVersao = new System.Windows.Forms.ComboBox();
            this.lblConclusao = new System.Windows.Forms.Label();
            this.txtConclusao = new System.Windows.Forms.TextBox();
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
            this.btnCopiar = new System.Windows.Forms.Button();
            this.cmbResolucao = new System.Windows.Forms.ComboBox();
            this.cmbSO = new System.Windows.Forms.ComboBox();
            this.lblResolucao = new System.Windows.Forms.Label();
            this.lblSo = new System.Windows.Forms.Label();
            this.lblTesteRealizado = new System.Windows.Forms.Label();
            this.txtTesteRealizado = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // lblConclusao
            // 
            this.lblConclusao.AutoSize = true;
            this.lblConclusao.Location = new System.Drawing.Point(124, 125);
            this.lblConclusao.Name = "lblConclusao";
            this.lblConclusao.Size = new System.Drawing.Size(60, 13);
            this.lblConclusao.TabIndex = 100;
            this.lblConclusao.Text = "Conclusão:";
            // 
            // txtConclusao
            // 
            this.txtConclusao.Location = new System.Drawing.Point(127, 144);
            this.txtConclusao.Multiline = true;
            this.txtConclusao.Name = "txtConclusao";
            this.txtConclusao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConclusao.Size = new System.Drawing.Size(513, 97);
            this.txtConclusao.TabIndex = 10;
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
            this.lblNomeBanco.TabIndex = 99;
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
            this.lblSenha.TabIndex = 96;
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
            this.lblUsuario.TabIndex = 93;
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
            this.lblServidor.TabIndex = 89;
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
            this.lblBanco.TabIndex = 86;
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
            "PEP/RM",
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
            this.lblProduto.TabIndex = 84;
            this.lblProduto.Text = "Produto:";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(135, 46);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(43, 13);
            this.lblVersao.TabIndex = 82;
            this.lblVersao.Text = "Versão:";
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.White;
            this.btnCopiar.Location = new System.Drawing.Point(304, 506);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(116, 23);
            this.btnCopiar.TabIndex = 13;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
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
            "800 x 600",
            "1024 x 768",
            "1280 x 600",
            "1280 x 720",
            "1280 x 768",
            "1280 x 1024",
            "1360 x 768",
            "1366 x 768",
            "1400 x 1050",
            "1440 x 900",
            "1600 x 900",
            "168 x 1050",
            "1440 x 900",
            "1600 x 900",
            "1680 x 1050",
            "1920 x 1080"});
            this.cmbResolucao.Location = new System.Drawing.Point(191, 90);
            this.cmbResolucao.Name = "cmbResolucao";
            this.cmbResolucao.Size = new System.Drawing.Size(134, 21);
            this.cmbResolucao.TabIndex = 4;
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
            "Windows 7",
            "Windows 8",
            "Windows 8.1",
            "Windows 10"});
            this.cmbSO.Location = new System.Drawing.Point(191, 64);
            this.cmbSO.Name = "cmbSO";
            this.cmbSO.Size = new System.Drawing.Size(134, 21);
            this.cmbSO.TabIndex = 3;
            // 
            // lblResolucao
            // 
            this.lblResolucao.AutoSize = true;
            this.lblResolucao.Location = new System.Drawing.Point(124, 98);
            this.lblResolucao.Name = "lblResolucao";
            this.lblResolucao.Size = new System.Drawing.Size(61, 13);
            this.lblResolucao.TabIndex = 107;
            this.lblResolucao.Text = "Resolução:";
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(153, 72);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(25, 13);
            this.lblSo.TabIndex = 106;
            this.lblSo.Text = "SO:";
            // 
            // lblTesteRealizado
            // 
            this.lblTesteRealizado.AutoSize = true;
            this.lblTesteRealizado.Location = new System.Drawing.Point(125, 255);
            this.lblTesteRealizado.Name = "lblTesteRealizado";
            this.lblTesteRealizado.Size = new System.Drawing.Size(87, 13);
            this.lblTesteRealizado.TabIndex = 111;
            this.lblTesteRealizado.Text = "Teste Realizado:";
            // 
            // txtTesteRealizado
            // 
            this.txtTesteRealizado.Location = new System.Drawing.Point(126, 274);
            this.txtTesteRealizado.Multiline = true;
            this.txtTesteRealizado.Name = "txtTesteRealizado";
            this.txtTesteRealizado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTesteRealizado.Size = new System.Drawing.Size(513, 94);
            this.txtTesteRealizado.TabIndex = 11;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(123, 384);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 113;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(124, 403);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacao.Size = new System.Drawing.Size(513, 94);
            this.txtObservacao.TabIndex = 12;
            // 
            // LiberacaoIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 541);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblTesteRealizado);
            this.Controls.Add(this.txtTesteRealizado);
            this.Controls.Add(this.cmbResolucao);
            this.Controls.Add(this.cmbSO);
            this.Controls.Add(this.lblResolucao);
            this.Controls.Add(this.lblSo);
            this.Controls.Add(this.cmbVersao);
            this.Controls.Add(this.lblConclusao);
            this.Controls.Add(this.txtConclusao);
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
            this.Name = "LiberacaoIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberação de Issue";
            this.Load += new System.EventHandler(this.LiberacaoIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVersao;
        private System.Windows.Forms.Label lblConclusao;
        private System.Windows.Forms.TextBox txtConclusao;
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
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.ComboBox cmbResolucao;
        private System.Windows.Forms.ComboBox cmbSO;
        private System.Windows.Forms.Label lblResolucao;
        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.Label lblTesteRealizado;
        private System.Windows.Forms.TextBox txtTesteRealizado;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
    }
}
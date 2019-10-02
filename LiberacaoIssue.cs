using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Jira_Generator_V2
{
    public partial class LiberacaoIssue : Form
    {
        private readonly string baseText;
        public LiberacaoIssue()
        {
            InitializeComponent();
            cmbProduto.SelectedIndex = 0;
            cmbVersao.SelectedIndex = 0;
            cmbBanco.SelectedIndex = 0;
            cmbResolucao.SelectedIndex = 5;
            cmbSO.SelectedIndex = 3;
            txtUsuario.Text = "mestre";
            txtSenha.Text = "totvs";

            try
            {
                baseText = File.ReadAllText(@"C:\Modelos Jira Generator\3 - Modelo Liberação de Issue.txt", Encoding.UTF8);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("O arquivo modelo não está em um diretório válido!",
                "ERRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
            }

        private void LiberacaoIssue_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string usuario, senha, nm_banco, nm_server, versao, produto, banco, descr_problema, mensagem_erro, so, resolucao, reproducao, hora, data, conclusao, testerealizado, observacao;

            banco = cmbBanco.Text;
            so = cmbSO.Text;
            resolucao = cmbResolucao.Text;
            produto = cmbProduto.Text;
            descr_problema = txtConclusao.Text;
            conclusao = txtConclusao.Text;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            nm_banco = txtNomeBanco.Text;
            nm_server = txtServidor.Text;
            versao = cmbVersao.Text;
            testerealizado = txtTesteRealizado.Text;
            observacao = txtObservacao.Text;
            hora = DateTime.Now.ToShortTimeString();
            data = DateTime.Now.ToShortDateString();

            var text = baseText.Replace("[VERSAO]", versao)
            .Replace("[PRODUTO]", produto)
            .Replace("[BANCO]", banco)
            .Replace("[RESOLUCAO]", resolucao)
            .Replace("[PROBLEMA]", descr_problema)
            .Replace("[CONCLUSAO]", conclusao)
            .Replace("[TESTEREALIZADO]", testerealizado)
            .Replace("[USUARIO]", usuario)
            .Replace("[SENHA]", senha)
            .Replace("[SO]", so)
            .Replace("[NOMEBANCO]", nm_banco)
            .Replace("[DATA]", data)
            .Replace("[HORA]", hora)
            .Replace("[OBSERVACAO]", observacao)
            .Replace("[SERVIDOR]", nm_server);

            Clipboard.SetText(text);
        }
    }
}

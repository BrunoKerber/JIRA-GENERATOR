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
    public partial class ManutencaoRM : Form
    {
        private readonly string baseText;

        public ManutencaoRM()
        {
            InitializeComponent();
            cmbProduto.SelectedIndex = 0;
            cmbVersao.SelectedIndex = 4;
            cmbBanco.SelectedIndex = 0;
            txtUsuario.Text = "mestre";
            txtSenha.Text = "totvs";

            try
            {
                baseText = File.ReadAllText(@"C:\Modelos Jira Generator\2 - Modelo Abertura de TicketRM.txt", Encoding.UTF8);
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

        private void ManutencaoRM_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string usuario, senha, nm_banco, nm_server, versao, produto, banco, descr_problema, mensagem_erro, biblioteca, coligada, reproducao, hora, data, parametrizacao;

            banco = cmbBanco.Text;
            produto = cmbProduto.Text;
            biblioteca = txtBiblioteca.Text;
            coligada = txtColigada.Text;
            descr_problema = txtDescrProblema.Text;
            parametrizacao = txtParametrizacao.Text;
            mensagem_erro = txtMensagemErro.Text;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            nm_banco = txtNomeBanco.Text;
            nm_server = txtServidor.Text;
            versao = cmbVersao.Text;
            reproducao = txtReproducao.Text;
            hora = DateTime.Now.ToShortTimeString();
            data = DateTime.Now.ToShortDateString();

            var textrm = baseText.Replace("[VERSAO]", versao)
            .Replace("[PRODUTO]", produto)
            .Replace("[BANCO]", banco)
            .Replace("[BIBLIOTECA]", biblioteca)
            .Replace("[COLIGADA]", coligada)
            .Replace("[PROBLEMA]", descr_problema)
            .Replace("[PARAMETRIZACAO]", parametrizacao)
            .Replace("[MSGERRO]", mensagem_erro)
            .Replace("[REPRODUCAO]", reproducao)
            .Replace("[USUARIO]", usuario)
            .Replace("[SENHA]", senha)
            .Replace("[NOMEBANCO]", nm_banco)
            .Replace("[DATA]", data)
            .Replace("[HORA]", hora)
            .Replace("[SERVIDOR]", nm_server);

            Clipboard.SetText(textrm);
        }
    }
}

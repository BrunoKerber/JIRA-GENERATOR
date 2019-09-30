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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Versão 2.1 | 27/09/2019 |" + " Desenvolvido por: BRUNO KERBER PINHEIRO",
            "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }

        private void pEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManutencaoPEP PEP = new ManutencaoPEP();
            PEP.ShowDialog();
        }

        private void rMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManutencaoRM RM = new ManutencaoRM();
            RM.ShowDialog();
        }

        private void liberaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiberacaoIssue PEPRM = new LiberacaoIssue();
            PEPRM.ShowDialog();
        }

        private void melhoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Melhoria PEPRM = new Melhoria();
            PEPRM.ShowDialog();
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aluraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cursos.alura.com.br/loginForm?urlAfterLogin=https://cursos.alura.com.br/dashboard");
        }

        private void tDNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tdn.totvs.com/display/F1/Porto+Alegre");
        }

        private void jiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://jiraproducao.totvs.com.br");
        }

        private void ambientesGCADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://10.51.3.41:8080/apex/f?p=104:10:5823557676588::NO:::");
        }

        private void jenkinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://poajenkhml01:8080/jenkins/");
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bh-testflow.bh01.local/testflow/dashboard");
        }

        private void agendamentoAluraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://engenharia.bh01.local/alura/#/login");
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://calendar.google.com");
        }
    }
}

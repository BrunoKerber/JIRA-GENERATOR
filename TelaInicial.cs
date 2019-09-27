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

            MessageBox.Show("Versão 2.0 | 27/09/2019 " + "Desenvolvido por: BRUNO KERBER PINHEIRO",
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
    }
}

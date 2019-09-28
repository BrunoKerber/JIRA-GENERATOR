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
    public partial class ManutencaoPEP : Form
    {
        string text = File.ReadAllText(@"C:\Modelos Jira Generator\1 - Modelo Abertura de TicketPEP.txt", Encoding.UTF8);

        public ManutencaoPEP()
        {
            InitializeComponent();
        }

        private void ManutencaoPEP_Load(object sender, EventArgs e)
        {
         
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(text);
        }
    }
}

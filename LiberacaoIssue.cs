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
        string text = File.ReadAllText(@"C:\Modelos Jira Generator\3 - Modelo Liberação de Issue.txt", Encoding.UTF8);
        public LiberacaoIssue()
        {
            InitializeComponent();
        }

        private void LiberacaoIssue_Load(object sender, EventArgs e)
        {
           // string text = File.ReadAllText(@"C:\Modelos Jira Generator\3 - Modelo Liberação de Issue.txt", Encoding.UTF8);
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(text);
        }
    }
}

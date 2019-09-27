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
        public ManutencaoRM()
        {
            InitializeComponent();
        }

        private void ManutencaoRM_Load(object sender, EventArgs e)
        {
            string text = File.ReadAllText(@"C:\Modelos Jira Generator\2 - Modelo Abertura de TicketRM.txt", Encoding.UTF8);
        }
    }
}

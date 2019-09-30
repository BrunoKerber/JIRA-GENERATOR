using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jira_Generator_V2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Abertura tela Inicial
               Application.Run(new TelaInicial());

            // Abertura tela de Login
           // Application.Run(new LoginJiraTest());
        }
    }
}

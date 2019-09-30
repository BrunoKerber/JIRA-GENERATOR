using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jira_Generator_V2
{
    public partial class LoginJiraTest : Form
    {

        public LoginJiraTest()
        {
            InitializeComponent();
        }

        private void LoginJiraTest_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           txtSenha.PasswordChar = '*';
           txtSenha.MaxLength = 30;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 30;
        }
    }
}

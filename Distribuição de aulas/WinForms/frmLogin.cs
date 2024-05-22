using Distribuição_de_aulas.dbConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuição_de_aulas
{
    public partial class frmLogin : Form
    {
       

        public static bool Cancelar = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;

             if (DbBLL.Login(nome, senha))
            {
                Close();

            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreto!");
            }

            
           

              

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = default;
            }
            else
            {
                txtSenha.PasswordChar = '*';

            }
        }
    }
}

using Distribuicao.DataModels;
using Distribuicao.DataAccess;
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
            try
            {
                string nome = txtNome.Text;
                string senha = txtSenha.Text;

                if (Login(nome, senha))
                {
                    Close();
                }
                else
                {
                    throw new Exception("Usuario ou senha incorreto!");                   
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha.PasswordChar == '*')
                {
                    txtSenha.PasswordChar = default;
                }
                else
                {
                    txtSenha.PasswordChar = '*';
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool Login(string nome, string senha)
        {
            UsuarioModel usuario = new UsuarioModel() { nomeusuario = nome, senha =senha };
            try
            {
                var user = UsuarioQuery.GetUserLogin(usuario);

                if (nome == user.nomeusuario && senha == user.senha)
                {
                    cadastroUsuario.UsuarioLogado = user;
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}

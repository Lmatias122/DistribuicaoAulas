using Distribuicao.DataModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace Distribuição_de_aulas
{
    public class cadastroUsuario
    {

        private static Usuario[] usuarios =
            {
            new Usuario() {nomeusuario="",senha = ""}
            };

        private static Usuario _UserLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _UserLogado; }
            set { _UserLogado = value; }
        }

        public static bool Login(string email, string senha)
        {
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.nomeusuario == email && usuario.senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }               

            }
            return false;
        }
    }
}

﻿using Distribuicao.DataModels;
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

        private static UsuarioModel[] usuarios =
            {
            new UsuarioModel() {nomeusuario="",senha = ""}
            };

        private static UsuarioModel _UserLogado = null;

        public static UsuarioModel UsuarioLogado
        {
            get { return _UserLogado; }
            set { _UserLogado = value; }
        }

    }
}

using System.Collections.Generic;

namespace Distribuicao.DataModels
{
    public class UsuarioModel
    {
        public int idusuario { get; set; }
        public string nomeusuario { get; set; }
        public string senha { get; set; }
        public ECargos cargo { get; set; }
        public EDispDia disp_dia { get; set; }
        public EdispHora disp_hora { get; set; }

    }
}

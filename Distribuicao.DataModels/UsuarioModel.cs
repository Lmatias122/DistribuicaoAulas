using System.Collections.Generic;

namespace Distribuicao.DataModels
{
    public class UsuarioModel
    {
        public int idUsuario { get; set; }
        public string nomeusuario { get; set; }
        public string senha { get; set; }
        public ECargos cargo { get; set; }
    }
}

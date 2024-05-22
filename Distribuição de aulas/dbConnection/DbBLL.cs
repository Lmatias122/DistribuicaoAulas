using Dapper;
using Distribuicao.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuição_de_aulas.dbConnection
{
    public class DbBLL
    {
        public bool Add(Usuario usuario)
        {
            var conn = new DbConnection();

            var query = @"INSERT INTO public.usuarios(
	                        nomeusuario, senha)
	                    VALUES (@nomeusuario, @senha);";


            var result = conn.Connection.Execute(sql:query,param:usuario);


            return result == 1;

        }

        public static List<Usuario> Getall()
        {
            var conn = new DbConnection();

            var query = @"SELECT * FROM usuarios";

            var usuarios = conn.Connection.Query<Usuario>(sql:query);

            return usuarios.ToList();
        }

        public static bool Login(string nome,string senha)
        {
            var userList = Getall();

            foreach (Usuario user  in userList)
            {
                if(nome == user.nomeusuario && senha == user.senha)
                {
                    cadastroUsuario.UsuarioLogado = user;
                    return true;
                }
            }

            return false;
        } 



    }
}

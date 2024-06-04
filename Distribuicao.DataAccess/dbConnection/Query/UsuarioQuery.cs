using Dapper;
using Distribuicao.DataModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuição_de_aulas.dbConnection
{
    public class UsuarioQuery
    {
        public static bool Add(UsuarioModel usuario)
        {
            var conn = new DbConnection();
                
            var query = @"INSERT INTO public.usuarios(
	                        nomeusuario, senha,cargo,disp_dia,disp_hora)
	                    VALUES (@nomeusuario, @senha,@cargo,@disp_dia,@disp_hora);";


            var result = conn.Connection.Execute(sql:query,param:usuario);


            return result == 1;

        }


        public static List<UsuarioModel> Getall()
        {
            var conn = new DbConnection();

            var query = @"SELECT * FROM usuarios";

            var usuarios = conn.Connection.Query<UsuarioModel>(sql:query);

            return usuarios.ToList();
        }

        public static UsuarioModel GetUserLogin(UsuarioModel usuario)
        {
            var conn = new DbConnection();

            var query = @"SELECT *
                        FROM usuarios
                        WHERE nomeusuario = @nomeusuario and senha = @senha";

            var user = conn.Connection.Query<UsuarioModel>(sql: query,param:usuario).FirstOrDefault();

            return user;   
        }

        public static List<UsuarioModel> GetCargo(ECargos cargo)
        {
            var conn = new DbConnection();

            var query = String.Format( @"SELECT * FROM usuarios WHERE cargo={0}",(long)cargo);

            var curso = conn.Connection.Query<UsuarioModel>(sql: query);

            return curso.ToList();
        }





    }
}

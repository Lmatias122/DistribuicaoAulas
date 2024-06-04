using Dapper;
using Distribuicao.DataModels;
using Distribuição_de_aulas.dbConnection;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuicao.DataAccess.dbConnection.Query
{
    public class CursoQuery
    {
        public static bool Add(CursoModel cursos)
        {
            var conn = new DbConnection();

            var query = @"INSERT INTO public.curso(
                            nomecurso, periodo, idusuario)
                            VALUES (@nomecurso, @periodo, @idusuario);";

            var result = conn.Connection.Execute(sql: query, param: cursos);

            return result == 1;

        }

        public static List<CursoModel> Getall()
        {
            var conn = new DbConnection();

            var query = @"SELECT * FROM curso";

            var curso = conn.Connection.Query<CursoModel>(sql: query);

            return curso.ToList();
        }

        
    }
}

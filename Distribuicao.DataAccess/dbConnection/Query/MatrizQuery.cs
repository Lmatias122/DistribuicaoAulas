using Dapper;
using Distribuicao.DataModels;
using Distribuição_de_aulas.dbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuicao.DataAccess.dbConnection.Query
{
    public class MatrizQuery
    {

        public static bool Add(MatrizModel matriz)
        {
            var conn = new DbConnection();

            var query = @"INSERT INTO public.matriz_curricular(
                            idcurso,nome)
                            VALUES (@idcurso,@nome);";

            var result = conn.Connection.Execute(sql: query, param: matriz);

            return result == 1;

        }

        public static List<MatrizModel> Getall()
        {
            var conn = new DbConnection();

            var query = @"SELECT * FROM matriz_curricular";

            var matriz = conn.Connection.Query<MatrizModel>(sql: query);

            return matriz.ToList();
        }



    }
}

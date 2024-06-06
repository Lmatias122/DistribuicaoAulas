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
    public class DispProfQuery
    {
            public static bool Add(DispProfModel dispProf)
            {
                var conn = new DbConnection();

                var query = @"INSERT INTO public.disp_prof(
	                        idprofessor, diasemana,dispaula)
	                    VALUES (@idprofessor, @diasemana,@dispaula);";


                var result = conn.Connection.Execute(sql: query, param: dispProf);


                return result == 1;

            }     
    }
}

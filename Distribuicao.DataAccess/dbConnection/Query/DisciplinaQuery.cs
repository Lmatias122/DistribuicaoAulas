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
    public class DisciplinaQuery
    {
        public static bool Add(DisciplinaModel disciplina)
        {
            var conn = new DbConnection();

            var query = @"INSERT INTO public.disciplinas(
                            nomeDisciplina, idusuario,idMatriz_Curricular,diaSemana,dispAula)
                            VALUES (@nomeDisciplina, @idusuario,@idMatriz_Curricular,@diaSemana,@dispAula);";

            var result = conn.Connection.Execute(sql: query, param: disciplina);

            return result == 1;
        }
        public static List<DisciplinaModel>Getall()
        {
            var conn = new DbConnection();

            var query = @"SELECT * FROM disciplinas";

            var curso = conn.Connection.Query<DisciplinaModel>(sql: query);

            return curso.ToList();
        }

        public static List<DisciplinaModel> GetAllUsername()
        {
            var conn = new DbConnection();

            var query = @"SELECT users.nomeusuario,nomedisciplina,disc.diasemana,disc.dispaula, matriz.nome
	                        FROM public.disciplinas disc
	                         INNER JOIN usuarios users
	                         ON disc.idusuario = users.idusuario
	                        INNER JOIN matriz_curricular matriz
	                        ON disc.idmatriz_curricular = matriz.idmatriz_curricular
					";

            var curso = conn.Connection.Query<DisciplinaModel>(sql: query);

            return curso.ToList();
        }


        public static DisciplinaModel GetDisp(DisciplinaModel disciplina)
        {
            var conn = new DbConnection();

            var query = @"SELECT *
                        FROM disciplinas
                        WHERE idusuario = @idusuario AND dispAula = @dispAula and diaSemana = @diaSemana and idmatriz_curricular = @idmatriz_curricular";



            var disp = conn.Connection.Query<DisciplinaModel>(sql: query, param: disciplina).FirstOrDefault();

            return disp;
        }
    }
}

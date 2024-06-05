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
                            nomeDisciplina, idusuario,idMatriz_Curricular,semestre,diaSemana,dispAula)
                            VALUES (@nomeDisciplina, @idusuario,@idMatriz_Curricular,@semestre,@diaSemana,@dispAula);";

            var result = conn.Connection.Execute(sql: query, param: disciplina);

            return result == 2;
        }
        public static List<DisciplinaModel>Getall()
        {
            var conn = new DbConnection();

            var query = @"SELECT * FROM disciplinas";

            var curso = conn.Connection.Query<DisciplinaModel>(sql: query);

            return curso.ToList();
        }
    }
}

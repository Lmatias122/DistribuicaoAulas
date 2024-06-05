namespace Distribuicao.DataModels
{
    public class DisciplinaModel
    {
        public int idDisciplinas {  get; set; }
        public string nomeDisciplina { get; set; }
        public int idusuario { get; set; }
        public int idMatriz_Curricular { get; set;}
        public string semestre { get; set; }

        public EDispDia diaSemana { get; set; }
        public EdispHora dispAula { get; set; }

    }
}

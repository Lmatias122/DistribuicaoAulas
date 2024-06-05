using Distribuicao.DataAccess.dbConnection.Query;
using Distribuicao.DataModels;
using Distribuição_de_aulas.dbConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuição_de_aulas
{
    public partial class frmCadastroDisciplinas : Form
    {
        public frmCadastroDisciplinas()
        {
            InitializeComponent();
            cmbProf.DisplayMember = nameof(Tuple<string, UsuarioModel>.Item1);
            cmbProf.ValueMember = nameof(Tuple<string, UsuarioModel>.Item1);
            cmbCurso.DisplayMember = nameof(Tuple<string, CursoModel>.Item1);
            cmbCurso.ValueMember = nameof(Tuple<string, CursoModel>.Item1);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var nome = txtDisciplina.Text;
            var prof = cmbProf.SelectedItem as Tuple<string, UsuarioModel>;
            var curso = cmbCurso.SelectedItem as Tuple<string, CursoModel>;
            var idusuario = prof.Item2.idusuario;

            DisciplinaModel model = new DisciplinaModel()
            {
                idusuario = idusuario,
                nomeDisciplina = nome,
                idCurso = curso.Item2.idcurso
            };
            var disciplina = DisciplinaQuery.Add(model);
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroDisciplinas_Load(object sender, EventArgs e)
        {
            var teste = UsuarioQuery.GetCargo(ECargos.Professor);

            foreach (var prof in teste) 
            {
                cmbProf.Items.Add(new Tuple<string, UsuarioModel>(prof.nomeusuario, prof));
            }

            var teste2 = CursoQuery.Getall();

            foreach(var curso in teste2)
            {
                cmbCurso.Items.Add(new Tuple<string, CursoModel>(curso.nomecurso, curso));
            }
        }
    }
}

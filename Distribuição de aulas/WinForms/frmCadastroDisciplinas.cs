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
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var nome = txtDisciplina.Text;
            var prof = cmbProf.SelectedItem;
            var curso = cmbCurso.SelectedItem;

            DisciplinaModel model = new DisciplinaModel()
            {
                idusuario = prof,
                nomeDisciplina = nome,
                idcurso = curso
            };
            var disciplina = DisciplinaQuery.Add(model);
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroDisciplinas_Load(object sender, EventArgs e)
        {
            var teste = UsuarioQuery.GetProf();

            foreach (var prof in teste) 
            {
                cmbProf.Items.Add(prof.nomeusuario);
            }
        }
    }
}

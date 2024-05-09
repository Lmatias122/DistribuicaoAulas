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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDisciplinas disciplinas = new CadastroDisciplinas();
            disciplinas.Show();
        }

        private void cadastrarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCursos cursos = new CadastroCursos();
            cursos.Show();
        }

        private void cadastrarGradesCurricularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGrade grade= new CadastroGrade();
            grade.Show();
        }

        private void cadastrarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrousuarios usuarios = new Cadastrousuarios();
            usuarios.Show();
        }

        private void consultaDeDisciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDisciplinas disciplinas = new ConsultaDisciplinas();
            disciplinas.Show();
        }

        private void consultaDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCursos cursos = new ConsultaCursos();
            cursos.Show();
        }

        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios usuarios = new ConsultaUsuarios();
            usuarios.Show();
        }

        private void consultaDeGradescurricularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaGrade grade = new ConsultaGrade();
            grade.Show();
        }

        private void consultaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDistribuicao distribuicao = new ConsultaDistribuicao();
            distribuicao.Show();
        }
    }
}

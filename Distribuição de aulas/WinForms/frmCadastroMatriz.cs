using Distribuicao.DataAccess.dbConnection.Query;
using Distribuicao.DataModels;
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
    public partial class frmCadastroMatriz : Form
    {
        public frmCadastroMatriz()
        {
            InitializeComponent();


            cmbCurso.DisplayMember = nameof(Tuple<string, CursoModel>.Item1);
            cmbCurso.ValueMember = nameof(Tuple<string, CursoModel>.Item1);
        }

        private void CadastroCursos_Load(object sender, EventArgs e)
        {

            var teste2 = CursoQuery.Getall();

            foreach (var curso in teste2)
            {
                cmbCurso.Items.Add(new Tuple<string, CursoModel>(curso.nomecurso, curso));
            }

        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var nome = txtMatriz.Text;
            var curso = cmbCurso.SelectedItem as Tuple<string, CursoModel>;
            
            
            MatrizModel model = new MatrizModel()
            {
                idCurso  = curso.Item2.idcurso,
                nome = nome         

            };

            var Matriz = MatrizQuery.Add(model);

            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

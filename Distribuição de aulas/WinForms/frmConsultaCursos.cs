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
    public partial class frmConsultaCursos : Form
    {
        public frmConsultaCursos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaCursos_Load(object sender, EventArgs e)
        {
            var cursos = CursoQuery.Getall();

            foreach (var curso in cursos)
            {
                dgvCurso.Rows.Add();
                
            }
        }
    }
}

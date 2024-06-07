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
    public partial class frmConsultaUsuarios : Form
    {
        public frmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var teste = UsuarioQuery.Getall();

            var i = 0;
            var teste2 = 0;
            foreach (var item in teste)
            {
                dgvCurso.Rows.Add(item.nomeusuario);

                while (teste2 <= teste.Count)
                {
                    dgvCurso.Rows[i].Cells[1].Value = item.cargo;

                    break;
                }
                teste2++;
                i++;

            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

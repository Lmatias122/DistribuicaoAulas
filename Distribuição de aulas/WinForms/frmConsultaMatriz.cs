using Distribuicao.DataAccess.dbConnection.Query;
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
    public partial class frmConsultaMatriz : Form
    {
        public frmConsultaMatriz()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaGrade_Load(object sender, EventArgs e)
        {            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var teste = DisciplinaQuery.GetAllUsername();

                var i = 0;
                var teste2 = 0;
                foreach (var item in teste)
                {
                    dgvMatriz.Rows.Add(item.nomeDisciplina);

                    while (teste2 <= teste.Count)
                    {
                        dgvMatriz.Rows[i].Cells[1].Value = item.nomeusuario;

                        dgvMatriz.Rows[i].Cells[2].Value = item.diaSemana;

                        dgvMatriz.Rows[i].Cells[3].Value = item.dispAula;

                        break;
                    }
                    teste2++;
                    i++;

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

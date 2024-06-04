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
    public partial class frmCadastroCursos : Form
    {
        public frmCadastroCursos()
        {
            InitializeComponent();
        }

        private void CadastroCursos_Load(object sender, EventArgs e)
        {
            var teste = UsuarioQuery.GetCoord();

            foreach(var coord in teste)
            {
                cmbCoordenador.Items.Add(coord.nomeusuario);                
            }
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txtNome.Text;
                var coordenador = cmbCoordenador.SelectedItem.ToString();
                var idusuario = 0;
                var periodo = "";

                var teste = UsuarioQuery.GetCoord();

                foreach (var coord in teste)
                {
                    if (coord.nomeusuario == coordenador)
                    {
                        idusuario = coord.idusuario;
                    }
                }

                CursoModel model = new CursoModel()
                {
                    idusuario = idusuario,
                    nomecurso = nome,
                    periodo = periodo
                };

                var curso = CursoQuery.Add(model);

                if (curso)
                {
                    MessageBox.Show("Curso cadastrado com sucesso!");
                }
                else
                {
                    throw new Exception("Erro ao cadastrar curso");
                }

                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

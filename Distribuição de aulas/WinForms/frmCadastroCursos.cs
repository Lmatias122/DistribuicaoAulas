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

            cmbCoordenador.DisplayMember = nameof(Tuple<string, UsuarioModel>.Item1);
            cmbCoordenador.ValueMember = nameof(Tuple<string, UsuarioModel>.Item1);

        }

        private void CadastroCursos_Load(object sender, EventArgs e)
        {
            var teste = UsuarioQuery.GetCargo(ECargos.Coordenador);

            foreach (var coord in teste)
            {
                cmbCoordenador.Items.Add(new Tuple<string, UsuarioModel>(coord.nomeusuario, coord));

            }
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txtNome.Text;
                var coordenador = cmbCoordenador.SelectedItem as Tuple<string, UsuarioModel>;               
                var idusuario = coordenador.Item2.idUsuario;
                var duracao = txtDur.Text;

                CursoModel model = new CursoModel()
                {
                    idusuario = idusuario,
                    nomecurso = nome,
                    duracao = int.Parse(duracao)
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
            }
            catch (Exception ex)
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

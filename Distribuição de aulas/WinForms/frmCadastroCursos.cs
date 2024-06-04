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
            //var teste = UsuarioQuery.GetCargo(ECargos.Coordenador);

           var teste = new List<UsuarioModel>()
            {
               new UsuarioModel() {
                nomeusuario = "teste",
                cargo = ECargos.Coordenador,
                senha = "teste",
            },
           new UsuarioModel()
           {
               nomeusuario = "abc",
                cargo = ECargos.Coordenador,
                senha = "123",
           } 
           };


            foreach(var coord in teste)
            {
                cmbCoordenador.Items.Add(new Tuple<string,UsuarioModel>(coord.nomeusuario,coord)); 
                
            }
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {

            
            var nome = txtNome.Text;
            var coordenador = cmbCoordenador.SelectedValue as Tuple<string, UsuarioModel>;
            var idusuario = coordenador.Item2.idusuario;;
            var periodo = "";

           

            // var teste = UsuarioQuery.GetCargo(ECargos.Coordenador);            

            



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

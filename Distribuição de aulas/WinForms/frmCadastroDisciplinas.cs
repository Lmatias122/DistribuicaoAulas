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
            cmbMatriz.DisplayMember = nameof(Tuple<string, CursoModel>.Item1);
            cmbMatriz.ValueMember = nameof(Tuple<string, CursoModel>.Item1);
        }

        private void CadastroDisciplinas_Load(object sender, EventArgs e)
        {
            try
            {
                var teste = UsuarioQuery.GetCargo(ECargos.Professor);

                foreach (var prof in teste)
                {
                    cmbProf.Items.Add(new Tuple<string, UsuarioModel>(prof.nomeusuario, prof));
                }

                /*var teste2 = MatrizQuery.Getall();

                foreach (var matriz in teste2)
                {
                    cmbMatriz.Items.Add(new Tuple<string, MatrizModel>(matriz.nome, matriz));
                }
                */

                checkDisp_dia.Items.AddRange(Enum.GetNames(typeof(EDispDia)));
                checkDisp_Hora.Items.AddRange(Enum.GetNames(typeof(EdispHora)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txtDisciplina.Text;
                var prof = cmbProf.SelectedItem as Tuple<string, UsuarioModel>;
                var idusuario = prof.Item2.idUsuario;
                //var idmatriz = cmbMatriz.Item2.idmatriz;
                var semestre = txtSemestre.Text;
                var diaSemana = checkDisp_dia.CheckedItems;
                var horario = checkDisp_Hora.CheckedItems;

                var dispDia_checked = checkDisp_dia.CheckedItems;
                var dispHora_checked = checkDisp_Hora.CheckedItems;

                var dispHora = "";
                var dispDia = "";

                foreach (var dias in dispDia_checked)
                {
                    if (diaSemana.Count > 1)
                    {
                        dispDia += dias + ", ";
                    }
                    else
                    {
                        dispDia += dias;
                    }

                }

                foreach (var hora in dispHora_checked)
                {
                    if (horario.Count > 1)
                    {
                        dispHora += hora + ", ";
                    }
                    else
                    {
                        dispHora += hora;

                    }
                }

                DisciplinaModel model = new DisciplinaModel()
                {
                    idusuario = idusuario,
                    idMatriz_Curricular = 2,
                    nomeDisciplina = nome,
                    semestre = semestre,
                    diaSemana = dispDia,
                    dispAula = dispHora,

                };
                var disciplina = DisciplinaQuery.Add(model);
                if (disciplina)
                {
                    MessageBox.Show("Disciplina cadastrada com sucesso");
                }
                else
                {
                    throw new Exception("Ocorreu um erro!");
                }

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

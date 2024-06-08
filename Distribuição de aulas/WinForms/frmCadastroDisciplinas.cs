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
                var profList = UsuarioQuery.GetCargo(ECargos.Professor);

                foreach (var prof in profList)
                {
                    cmbProf.Items.Add(new Tuple<string, UsuarioModel>(prof.nomeusuario, prof));
                }

                var matrizList= MatrizQuery.Getall();

                foreach (var matriz in matrizList)
                {
                    cmbMatriz.Items.Add(new Tuple<string, MatrizModel>(matriz.nome, matriz));
                }

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
                var matriz = cmbMatriz.SelectedItem as Tuple<string, MatrizModel>;
                var idmatriz = matriz.Item2.idMatriz_Curricular;
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
                    idMatriz_Curricular = idmatriz,
                    nomeDisciplina = nome,
                    diaSemana = dispDia,
                    dispAula = dispHora,

                };



                if (VerificaDisp(model))
                {
                    if (!VerificaConflito(model))
                    {
                        var disciplina = DisciplinaQuery.Add(model);
                        if (disciplina)
                        {
                            MessageBox.Show("Disciplina cadastrada com sucesso");
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Ocorreu um erro!");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("O professor selecionado não está disponível no periodo solicitado");

                        //Caso exista conflitos no horario cadastrado na disciplina com o horario do professor selecionado, o codigo nao deve permitir o cadastro da disciplina;
                    }
                }
                else 
                {
                    MessageBox.Show("O professor selecionado não está disponível no periodo solicitado");
                    //Caso exista conflitos no horario cadastrado na disciplina com o horario do professor selecionado, o codigo nao deve permitir o cadastro da disciplina;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public bool VerificaDisp(DisciplinaModel disciplina)
        {
            try
            {
                DispProfModel prof = new DispProfModel()
                {
                    diaSemana = disciplina.diaSemana,
                    dispAula = disciplina.dispAula,
                    idProfessor = disciplina.idusuario
                };

                var Prof = DispProfQuery.GetDisp(prof);

                if (Prof == null)
                {
                    return false;
                    // Caso retorne false, significa que nao existe registro desse usuario dentro do banco de disciplinas, ou seja, a disciplina nao pode ser cadastrada.
                }

                //Caso tenha disponibilidade o retorno deve ser TRUE

                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool VerificaConflito(DisciplinaModel disciplina)
        {
            try {
                var disp = DisciplinaQuery.GetDisp(disciplina);

                if (disp == null)
                {
                    return false;
                }

                //Verificar na tabela de disciplina se existe algum professor com o id, dia da semana e dipaula ja cadastrados com os dados informados. 
                // 
                //Caso exista, retornar TRUE e indicar que existe conflito, um erro deve aparecer e impedir o cadastro;

                //Caso tenha conflitos o retorno deve ser TRUE

                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

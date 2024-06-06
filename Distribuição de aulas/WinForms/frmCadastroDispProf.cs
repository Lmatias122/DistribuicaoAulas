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

namespace Distribuição_de_aulas.WinForms
{
    public partial class frmCadastroDispProf : Form
    {
        public frmCadastroDispProf()
        {
            InitializeComponent();
        }

        private void frmCadastroDispProf_Load(object sender, EventArgs e)
        {
            try
            {
                checkDiaDisp.Items.AddRange(Enum.GetNames(typeof(EDispDia)));
                checkHoDisp.Items.AddRange(Enum.GetNames(typeof(EdispHora)));
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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                var dispDia_checked = checkDiaDisp.CheckedItems;
                var dispHora_checked = checkHoDisp.CheckedIndices;
                var idProf = txtIdProf.Text;

                var dispHora = "";
                var dispDia = "";

                foreach (var dias in dispDia_checked)
                {
                    if (dispDia_checked.Count > 1)
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
                    if (dispHora_checked.Count > 1)
                    {
                        dispHora += hora + ", ";
                    }
                    else
                    {
                        dispHora += hora;
                    }
                }

                DispProfModel dispprof = new DispProfModel()
                {
                    idProfessor = int.Parse(idProf),
                    diaSemana = dispDia,
                    dispAula = dispHora
                };

                var prof = DispProfQuery.Add(dispprof);

                if (prof)
                {
                    MessageBox.Show("A disponibilidade do professor foi adicionado com sucesso");
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao Adicionar a disponibilidade do professor");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

}

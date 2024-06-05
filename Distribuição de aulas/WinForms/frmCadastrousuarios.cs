using Distribuicao.DataModels;
using Distribuição_de_aulas.dbConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuição_de_aulas
{
    public partial class frmCadastrousuarios : Form
    {
        public frmCadastrousuarios()
        {
            InitializeComponent();
        }
        private void frmCadastrousuarios_Load(object sender, EventArgs e)
        {
            try
            {

                checkDisp_dia.Items.AddRange(Enum.GetNames(typeof(EDispDia)));
                checkDisp_Hora.Items.AddRange(Enum.GetNames(typeof(EdispHora)));

                cmbCargo.Items.AddRange(Enum.GetNames(typeof(ECargos)));
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
                var nome = textNome.Text;
                var senha = textSenha.Text;
                var cargo = cmbCargo.SelectedIndex;
                var dispDia_checked = checkDisp_dia.CheckedItems;
                var dispHora_checked = checkDisp_Hora.CheckedItems;

                var dispHora = "";
                var dispDia = "";

                foreach (var dias in dispDia_checked) 
                {
                    dispDia += dias+", ";
                }

                foreach(var hora in dispHora_checked)
                {
                    dispHora += hora+", ";
                }

               
                UsuarioModel usuario = new UsuarioModel()
                {
                    nomeusuario = nome,
                    senha = senha,
                    cargo = (ECargos)cargo,
                    disp_dia = dispDia,
                    disp_hora = dispHora,
                };

                var user = UsuarioQuery.Add(usuario);

                if (user)
                {
                    MessageBox.Show("Usuario Adicionado com sucesso");
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao Adicionar o Usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

﻿using Distribuição_de_aulas.WinForms;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();

            while (cadastroUsuario.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();

                if (frmLogin.Cancelar)
                {
                    Application.Exit();
                    return;
                }
            }

            Visible = true;
        }

        private void cadastrarDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDisciplinas disciplinas = new frmCadastroDisciplinas();
            disciplinas.Show();
        }

        private void cadastrarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCursos cursos = new frmCadastroCursos();
            cursos.Show();
        }

        private void cadastrarGradesCurricularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMatriz grade= new frmCadastroMatriz();
            grade.Show();
        }

        private void cadastrarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrousuarios usuarios = new frmCadastrousuarios();
            usuarios.Show();
        }

        private void cadastrarDispProfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDispProf disp = new frmCadastroDispProf();
            disp.Show();
        }
        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarios usuarios = new frmConsultaUsuarios();
            usuarios.Show();
        }

        private void consultaDeGradescurricularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMatriz grade = new frmConsultaMatriz();
            grade.Show();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }
}

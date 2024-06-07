namespace Distribuição_de_aulas
{
    partial class frmCadastroDisciplinas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.cmbMatriz = new System.Windows.Forms.ComboBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblDispAula = new System.Windows.Forms.Label();
            this.checkDisp_dia = new System.Windows.Forms.CheckedListBox();
            this.checkDisp_Hora = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplina.Location = new System.Drawing.Point(4, 17);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(138, 37);
            this.lblDisciplina.TabIndex = 0;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisciplina.Location = new System.Drawing.Point(278, 20);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(594, 27);
            this.txtDisciplina.TabIndex = 5;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastro.Location = new System.Drawing.Point(540, 516);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(120, 47);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Location = new System.Drawing.Point(764, 516);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 47);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(4, 149);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(189, 37);
            this.lblCurso.TabIndex = 14;
            this.lblCurso.Text = "Matriz Curricular";
            // 
            // lblProfessor
            // 
            this.lblProfessor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(4, 78);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(138, 35);
            this.lblProfessor.TabIndex = 15;
            this.lblProfessor.Text = "Professor";
            // 
            // cmbProf
            // 
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.Location = new System.Drawing.Point(278, 84);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(594, 27);
            this.cmbProf.TabIndex = 16;
            // 
            // cmbMatriz
            // 
            this.cmbMatriz.FormattingEnabled = true;
            this.cmbMatriz.Location = new System.Drawing.Point(278, 154);
            this.cmbMatriz.Name = "cmbMatriz";
            this.cmbMatriz.Size = new System.Drawing.Size(594, 27);
            this.cmbMatriz.TabIndex = 19;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.Location = new System.Drawing.Point(273, 228);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(189, 37);
            this.lblDiaSemana.TabIndex = 22;
            this.lblDiaSemana.Text = "Dia da semana";
            // 
            // lblDispAula
            // 
            this.lblDispAula.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispAula.Location = new System.Drawing.Point(668, 228);
            this.lblDispAula.Name = "lblDispAula";
            this.lblDispAula.Size = new System.Drawing.Size(204, 37);
            this.lblDispAula.TabIndex = 24;
            this.lblDispAula.Text = "Horário disponível";
            // 
            // checkDisp_dia
            // 
            this.checkDisp_dia.FormattingEnabled = true;
            this.checkDisp_dia.Location = new System.Drawing.Point(278, 280);
            this.checkDisp_dia.Name = "checkDisp_dia";
            this.checkDisp_dia.Size = new System.Drawing.Size(147, 136);
            this.checkDisp_dia.TabIndex = 29;
            // 
            // checkDisp_Hora
            // 
            this.checkDisp_Hora.FormattingEnabled = true;
            this.checkDisp_Hora.Location = new System.Drawing.Point(673, 280);
            this.checkDisp_Hora.Name = "checkDisp_Hora";
            this.checkDisp_Hora.Size = new System.Drawing.Size(199, 48);
            this.checkDisp_Hora.TabIndex = 30;
            // 
            // frmCadastroDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(922, 587);
            this.Controls.Add(this.checkDisp_Hora);
            this.Controls.Add(this.checkDisp_dia);
            this.Controls.Add(this.lblDispAula);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.cmbMatriz);
            this.Controls.Add(this.cmbProf);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.lblDisciplina);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(916, 574);
            this.Name = "frmCadastroDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroDisciplina";
            this.Load += new System.EventHandler(this.CadastroDisciplinas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.ComboBox cmbProf;
        private System.Windows.Forms.ComboBox cmbMatriz;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblDispAula;
        private System.Windows.Forms.CheckedListBox checkDisp_dia;
        private System.Windows.Forms.CheckedListBox checkDisp_Hora;
    }
}
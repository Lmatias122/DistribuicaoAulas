namespace Distribuição_de_aulas
{
    partial class frmCadastroGrade
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
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblGradeC = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.cmbGradeC = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSemestre
            // 
            this.lblSemestre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(4, 80);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(132, 42);
            this.lblSemestre.TabIndex = 6;
            this.lblSemestre.Text = "Semestre";
            // 
            // lblGradeC
            // 
            this.lblGradeC.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeC.Location = new System.Drawing.Point(4, 151);
            this.lblGradeC.Name = "lblGradeC";
            this.lblGradeC.Size = new System.Drawing.Size(138, 37);
            this.lblGradeC.TabIndex = 8;
            this.lblGradeC.Text = "Disciplina";
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
            // cmbSemestre
            // 
            this.cmbSemestre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Items.AddRange(new object[] {
            "Selecione o Semestre",
            "1 ",
            "2",
            "3",
            "4",
            "5"});
            this.cmbSemestre.Location = new System.Drawing.Point(278, 76);
            this.cmbSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(594, 32);
            this.cmbSemestre.TabIndex = 14;
            // 
            // cmbGradeC
            // 
            this.cmbGradeC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGradeC.FormattingEnabled = true;
            this.cmbGradeC.Items.AddRange(new object[] {
            "disciplina 1",
            "disciplina 2"});
            this.cmbGradeC.Location = new System.Drawing.Point(278, 147);
            this.cmbGradeC.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGradeC.Name = "cmbGradeC";
            this.cmbGradeC.Size = new System.Drawing.Size(594, 32);
            this.cmbGradeC.TabIndex = 15;
            // 
            // lblCurso
            // 
            this.lblCurso.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(4, 17);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(132, 38);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso";
            // 
            // cmbCurso
            // 
            this.cmbCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "Tecnologia Ánalise e Desenvolvimento de Sistemas",
            "Engenharia de Produção"});
            this.cmbCurso.Location = new System.Drawing.Point(278, 13);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(594, 32);
            this.cmbCurso.TabIndex = 16;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(278, 211);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(594, 32);
            this.cmbUsuario.TabIndex = 18;
            // 
            // lblProfessor
            // 
            this.lblProfessor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(4, 215);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(138, 37);
            this.lblProfessor.TabIndex = 17;
            this.lblProfessor.Text = "Professor";
            // 
            // frmCadastroGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(922, 587);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.cmbGradeC);
            this.Controls.Add(this.cmbSemestre);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblGradeC);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.lblCurso);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(916, 574);
            this.Name = "frmCadastroGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroGradeC";
            this.Load += new System.EventHandler(this.CadastroCursos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblGradeC;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.ComboBox cmbGradeC;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblProfessor;
    }
}
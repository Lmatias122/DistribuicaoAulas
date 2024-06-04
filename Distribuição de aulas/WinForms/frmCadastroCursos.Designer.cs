namespace Distribuição_de_aulas
{
    partial class frmCadastroCursos
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCoordenador = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cmbCoordenador = new System.Windows.Forms.ComboBox();
            this.checkNoite = new System.Windows.Forms.CheckBox();
            this.checkTarde = new System.Windows.Forms.CheckBox();
            this.checkManha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(4, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(138, 37);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(4, 227);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(177, 48);
            this.lblPeriodo.TabIndex = 4;
            this.lblPeriodo.Text = "Período";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(278, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(579, 27);
            this.txtNome.TabIndex = 5;
            // 
            // lblCoordenador
            // 
            this.lblCoordenador.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenador.Location = new System.Drawing.Point(4, 78);
            this.lblCoordenador.Name = "lblCoordenador";
            this.lblCoordenador.Size = new System.Drawing.Size(153, 42);
            this.lblCoordenador.TabIndex = 6;
            this.lblCoordenador.Text = "Coordenador";
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
            this.btnVoltar.Size = new System.Drawing.Size(104, 47);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cmbCoordenador
            // 
            this.cmbCoordenador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCoordenador.FormattingEnabled = true;
            this.cmbCoordenador.Location = new System.Drawing.Point(278, 84);
            this.cmbCoordenador.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCoordenador.Name = "cmbCoordenador";
            this.cmbCoordenador.Size = new System.Drawing.Size(579, 27);
            this.cmbCoordenador.TabIndex = 14;
            // 
            // checkNoite
            // 
            this.checkNoite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNoite.AutoSize = true;
            this.checkNoite.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNoite.Location = new System.Drawing.Point(778, 227);
            this.checkNoite.Name = "checkNoite";
            this.checkNoite.Size = new System.Drawing.Size(65, 23);
            this.checkNoite.TabIndex = 38;
            this.checkNoite.Text = "Noite";
            this.checkNoite.UseVisualStyleBackColor = true;
            // 
            // checkTarde
            // 
            this.checkTarde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTarde.AutoSize = true;
            this.checkTarde.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTarde.Location = new System.Drawing.Point(540, 225);
            this.checkTarde.Name = "checkTarde";
            this.checkTarde.Size = new System.Drawing.Size(69, 23);
            this.checkTarde.TabIndex = 36;
            this.checkTarde.Text = "Tarde";
            this.checkTarde.UseVisualStyleBackColor = true;
            // 
            // checkManha
            // 
            this.checkManha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkManha.AutoSize = true;
            this.checkManha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkManha.Location = new System.Drawing.Point(278, 225);
            this.checkManha.Name = "checkManha";
            this.checkManha.Size = new System.Drawing.Size(74, 23);
            this.checkManha.TabIndex = 37;
            this.checkManha.Text = "Manhã";
            this.checkManha.UseVisualStyleBackColor = true;
            // 
            // frmCadastroCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(922, 587);
            this.Controls.Add(this.checkNoite);
            this.Controls.Add(this.checkTarde);
            this.Controls.Add(this.checkManha);
            this.Controls.Add(this.cmbCoordenador);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblCoordenador);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(916, 574);
            this.Name = "frmCadastroCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCursos";
            this.Load += new System.EventHandler(this.CadastroCursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCoordenador;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cmbCoordenador;
        private System.Windows.Forms.CheckBox checkNoite;
        private System.Windows.Forms.CheckBox checkTarde;
        private System.Windows.Forms.CheckBox checkManha;
    }
}
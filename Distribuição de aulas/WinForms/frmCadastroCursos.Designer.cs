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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCoordenador = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cmbCoordenador = new System.Windows.Forms.ComboBox();
            this.txtDur = new System.Windows.Forms.TextBox();
            this.lblDur = new System.Windows.Forms.Label();
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
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(278, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(579, 32);
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
            this.cmbCoordenador.Size = new System.Drawing.Size(579, 32);
            this.cmbCoordenador.TabIndex = 14;
            // 
            // txtDur
            // 
            this.txtDur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDur.Location = new System.Drawing.Point(278, 157);
            this.txtDur.Name = "txtDur";
            this.txtDur.Size = new System.Drawing.Size(579, 32);
            this.txtDur.TabIndex = 16;
            // 
            // lblDur
            // 
            this.lblDur.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDur.Location = new System.Drawing.Point(4, 154);
            this.lblDur.Name = "lblDur";
            this.lblDur.Size = new System.Drawing.Size(203, 37);
            this.lblDur.TabIndex = 15;
            this.lblDur.Text = "Duração do Curso ";
            // 
            // frmCadastroCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(922, 587);
            this.Controls.Add(this.txtDur);
            this.Controls.Add(this.lblDur);
            this.Controls.Add(this.cmbCoordenador);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblCoordenador);
            this.Controls.Add(this.txtNome);
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCoordenador;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cmbCoordenador;
        private System.Windows.Forms.TextBox txtDur;
        private System.Windows.Forms.Label lblDur;
    }
}
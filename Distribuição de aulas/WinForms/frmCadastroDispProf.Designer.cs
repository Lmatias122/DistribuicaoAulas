namespace Distribuição_de_aulas.WinForms
{
    partial class frmCadastroDispProf
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
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblDiaDisp = new System.Windows.Forms.Label();
            this.lblHoDisp = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.checkDiaDisp = new System.Windows.Forms.CheckedListBox();
            this.checkHoDisp = new System.Windows.Forms.CheckedListBox();
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(3, 14);
            this.lblProfessor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(97, 19);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "ID Professor";
            // 
            // lblDiaDisp
            // 
            this.lblDiaDisp.AutoSize = true;
            this.lblDiaDisp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDisp.Location = new System.Drawing.Point(28, 96);
            this.lblDiaDisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaDisp.Name = "lblDiaDisp";
            this.lblDiaDisp.Size = new System.Drawing.Size(110, 19);
            this.lblDiaDisp.TabIndex = 4;
            this.lblDiaDisp.Text = "Dia Disponível";
            // 
            // lblHoDisp
            // 
            this.lblHoDisp.AutoSize = true;
            this.lblHoDisp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoDisp.Location = new System.Drawing.Point(333, 96);
            this.lblHoDisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoDisp.Name = "lblHoDisp";
            this.lblHoDisp.Size = new System.Drawing.Size(140, 19);
            this.lblHoDisp.TabIndex = 5;
            this.lblHoDisp.Text = "Horário Disponível";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(410, 381);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(90, 38);
            this.btnCadastro.TabIndex = 38;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(572, 381);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(78, 38);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // checkDiaDisp
            // 
            this.checkDiaDisp.FormattingEnabled = true;
            this.checkDiaDisp.Location = new System.Drawing.Point(32, 143);
            this.checkDiaDisp.Margin = new System.Windows.Forms.Padding(2);
            this.checkDiaDisp.Name = "checkDiaDisp";
            this.checkDiaDisp.Size = new System.Drawing.Size(106, 64);
            this.checkDiaDisp.TabIndex = 40;
            // 
            // checkHoDisp
            // 
            this.checkHoDisp.FormattingEnabled = true;
            this.checkHoDisp.Items.AddRange(new object[] {
            ""});
            this.checkHoDisp.Location = new System.Drawing.Point(337, 147);
            this.checkHoDisp.Margin = new System.Windows.Forms.Padding(2);
            this.checkHoDisp.Name = "checkHoDisp";
            this.checkHoDisp.Size = new System.Drawing.Size(136, 64);
            this.checkHoDisp.TabIndex = 41;
            // 
            // cmbProf
            // 
            this.cmbProf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.Location = new System.Drawing.Point(121, 11);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(529, 27);
            this.cmbProf.TabIndex = 43;
            // 
            // frmCadastroDispProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 435);
            this.Controls.Add(this.cmbProf);
            this.Controls.Add(this.checkHoDisp);
            this.Controls.Add(this.checkDiaDisp);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblHoDisp);
            this.Controls.Add(this.lblDiaDisp);
            this.Controls.Add(this.lblProfessor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(754, 576);
            this.MinimumSize = new System.Drawing.Size(691, 474);
            this.Name = "frmCadastroDispProf";
            this.Text = "frmCadastroDispProf";
            this.Load += new System.EventHandler(this.frmCadastroDispProf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblDiaDisp;
        private System.Windows.Forms.Label lblHoDisp;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckedListBox checkDiaDisp;
        private System.Windows.Forms.CheckedListBox checkHoDisp;
        private System.Windows.Forms.ComboBox cmbProf;
    }
}
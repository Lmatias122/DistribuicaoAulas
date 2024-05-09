namespace Distribuição_de_aulas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarGradesCurricularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDisciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeGradescurricularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.aulasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarDToolStripMenuItem,
            this.cadastrarUsuáriosToolStripMenuItem,
            this.cadastrarGradesCurricularesToolStripMenuItem,
            this.cadastrarCursosToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastros";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeDisciplinasToolStripMenuItem,
            this.consultaDeCursosToolStripMenuItem,
            this.consultaDeUsuariosToolStripMenuItem,
            this.consultaDeGradescurricularesToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // aulasToolStripMenuItem
            // 
            this.aulasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeToolStripMenuItem});
            this.aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            this.aulasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.aulasToolStripMenuItem.Text = "Aulas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // cadastrarDToolStripMenuItem
            // 
            this.cadastrarDToolStripMenuItem.Name = "cadastrarDToolStripMenuItem";
            this.cadastrarDToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.cadastrarDToolStripMenuItem.Text = "Cadastrar disciplinas";
            this.cadastrarDToolStripMenuItem.Click += new System.EventHandler(this.cadastrarDToolStripMenuItem_Click);
            // 
            // cadastrarUsuáriosToolStripMenuItem
            // 
            this.cadastrarUsuáriosToolStripMenuItem.Name = "cadastrarUsuáriosToolStripMenuItem";
            this.cadastrarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.cadastrarUsuáriosToolStripMenuItem.Text = "Cadastrar usuários";
            this.cadastrarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuáriosToolStripMenuItem_Click);
            // 
            // cadastrarGradesCurricularesToolStripMenuItem
            // 
            this.cadastrarGradesCurricularesToolStripMenuItem.Name = "cadastrarGradesCurricularesToolStripMenuItem";
            this.cadastrarGradesCurricularesToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.cadastrarGradesCurricularesToolStripMenuItem.Text = "Cadastrar grades Curriculares";
            this.cadastrarGradesCurricularesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarGradesCurricularesToolStripMenuItem_Click);
            // 
            // cadastrarCursosToolStripMenuItem
            // 
            this.cadastrarCursosToolStripMenuItem.Name = "cadastrarCursosToolStripMenuItem";
            this.cadastrarCursosToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.cadastrarCursosToolStripMenuItem.Text = "Cadastrar cursos";
            this.cadastrarCursosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCursosToolStripMenuItem_Click);
            // 
            // consultaDeDisciplinasToolStripMenuItem
            // 
            this.consultaDeDisciplinasToolStripMenuItem.Name = "consultaDeDisciplinasToolStripMenuItem";
            this.consultaDeDisciplinasToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.consultaDeDisciplinasToolStripMenuItem.Text = "Consulta de disciplinas";
            this.consultaDeDisciplinasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDisciplinasToolStripMenuItem_Click);
            // 
            // consultaDeCursosToolStripMenuItem
            // 
            this.consultaDeCursosToolStripMenuItem.Name = "consultaDeCursosToolStripMenuItem";
            this.consultaDeCursosToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.consultaDeCursosToolStripMenuItem.Text = "Consulta de cursos";
            this.consultaDeCursosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeCursosToolStripMenuItem_Click);
            // 
            // consultaDeUsuariosToolStripMenuItem
            // 
            this.consultaDeUsuariosToolStripMenuItem.Name = "consultaDeUsuariosToolStripMenuItem";
            this.consultaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.consultaDeUsuariosToolStripMenuItem.Text = "Consulta de usuarios";
            this.consultaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUsuariosToolStripMenuItem_Click);
            // 
            // consultaDeGradescurricularesToolStripMenuItem
            // 
            this.consultaDeGradescurricularesToolStripMenuItem.Name = "consultaDeGradescurricularesToolStripMenuItem";
            this.consultaDeGradescurricularesToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.consultaDeGradescurricularesToolStripMenuItem.Text = "Consulta de grades-curriculares";
            this.consultaDeGradescurricularesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeGradescurricularesToolStripMenuItem_Click);
            // 
            // consultaDeToolStripMenuItem
            // 
            this.consultaDeToolStripMenuItem.Name = "consultaDeToolStripMenuItem";
            this.consultaDeToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.consultaDeToolStripMenuItem.Text = "Consulta de distribuição de aulas";
            this.consultaDeToolStripMenuItem.Click += new System.EventHandler(this.consultaDeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarGradesCurricularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDisciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeGradescurricularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeToolStripMenuItem;
    }
}


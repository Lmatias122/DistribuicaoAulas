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
    public partial class CadastroCursos : Form
    {
        public CadastroCursos()
        {
            InitializeComponent();
        }

        private void CadastroCursos_Load(object sender, EventArgs e)
        {
            
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

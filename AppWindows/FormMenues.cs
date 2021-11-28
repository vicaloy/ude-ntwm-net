using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows
{
    public partial class FormMenues : Form
    {
        public FormMenues()
        {
            InitializeComponent();
        }

        private void integranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cancionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void integranteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormularioIntegrante.FormIntegrante().ShowDialog();
        }

        private void bandaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormularioBanda.FormBanda().ShowDialog();
        }

        private void cancionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormularioCancion.FormCancion().ShowDialog();
        }

        private void albumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormularioAlbum.FormAlbum().ShowDialog();
        }

        private void FormMenues_Load(object sender, EventArgs e)
        {

        }
    }
}

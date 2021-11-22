using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows.FormularioIntegrante
{
    public partial class FormIntegrante : Form
    {
        byte[] buffer = null;
        public FormIntegrante()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IntegranteControlador controlador = new IntegranteControlador();
            lblError.Text=controlador.InsertarIntegranteForm(txtId.Text, txtNombre.Text, txtApellido.Text, pickerFecha.Value.Date, buffer);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
           
            if (dialogo.ShowDialog() == DialogResult.OK) {
                buffer = File.ReadAllBytes(dialogo.FileName);
            }
        }
    }
}

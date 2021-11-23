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
        IntegranteControlador controlador = new IntegranteControlador();
        byte[] buffer = null;
        public FormIntegrante()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = controlador.InsertarIntegranteForm(txtId.Text, txtNombre.Text, txtApellido.Text, pickerFecha.Value.Date, buffer);
            }
            catch
            {
                MessageBox.Show("Hubo error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
         }


    private void btnFoto_Click(object sender, EventArgs e)
    {
        try {
            OpenFileDialog dialogo = new OpenFileDialog();

            if (dialogo.ShowDialog() == DialogResult.OK)
                buffer = File.ReadAllBytes(dialogo.FileName);
        }
        catch
        {
            MessageBox.Show("Hubo error al intentar cargar la foto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
        private void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = controlador.ModificarIntegranteForm(txtId.Text, txtNombre.Text, txtApellido.Text, pickerFecha.Value.Date, buffer);
            }

        catch
        {
            MessageBox.Show("Hubo error al intentar modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference.IntegranteVO integranteVO = controlador.ObtenerIntegranteForm(txtId.Text);
                txtNombre.Text = integranteVO.Nombre;
                txtApellido.Text = integranteVO.Apellido;
                pickerFecha.Value = integranteVO.FechaNacimiento;
            }
        }   catch
                {
                    MessageBox.Show("Hubo error al intentar buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try { 
                    lblError.Text = controlador.EliminarIntegranteForm(txtId.Text, txtNombre.Text, txtApellido.Text, pickerFecha.Value.Date, buffer);
                }
        
           catch
                {
                    MessageBox.Show("Hubo error al intentar eliminar elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
         }

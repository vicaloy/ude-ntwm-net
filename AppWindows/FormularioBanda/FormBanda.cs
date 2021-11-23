using AppWindows.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows.FormularioBanda
{
    public partial class FormBanda : Form
    {
        BandaControlador controlador = new BandaControlador();
        public FormBanda()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference.IntegranteVO integrante = controlador.ObtenerIntegranteForm(txtIntegranteId.Text);
                if (integrante != null)
                {
                    lblIntegrante.Text = $"{integrante.Nombre} {integrante.Apellido}";
                    controlador.AgregarIntegrante(integrante);
                }
                else
                {
                    lblIntegrante.Text = "No existe integrante";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo error al intentar agregar elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = controlador.InsertarBandaForm(txtId.Text, txtNombre.Text, txtGenero.Text, txtCreacion.Text, txtSeparacion.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void btnModifcar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = controlador.ModificarBandaForm(txtId.Text, txtNombre.Text, txtGenero.Text, txtCreacion.Text, txtSeparacion.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = controlador.EliminarBandaForm(txtId.Text, txtNombre.Text, txtGenero.Text, txtCreacion.Text, txtSeparacion.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay nada que eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BandaVO banda = controlador.ObtenerBandaForm(txtId.Text);
                txtId.Text = banda.Id.ToString();
                txtNombre.Text = banda.Nombre;
                txtGenero.Text = banda.GeneroMusical;
                txtCreacion.Text = banda.AnioCreacion.ToString();
                txtSeparacion.Text = banda.AnioSeparacion.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
}

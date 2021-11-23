using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows.FormularioCancion
{
    public partial class FormCancion : Form
    {
        CancionControlador controlador = new CancionControlador();
        public FormCancion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           try{
                lblError.Text = controlador.InsertarCancionForm(txtId.Text, txtNombre.Text, txtDuracion.Text, txtAnio.Text, txtGenero.Text);
              }
           catch
            {
                MessageBox.Show("Hubo error al intentar agregar elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
             try {
                    lblError.Text = controlador.ModificarCancionForm(txtId.Text, txtNombre.Text, txtDuracion.Text, txtAnio.Text, txtGenero.Text);
                 }
            catch 
                {
                    MessageBox.Show("Hubo error al intentar agregar elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                try
                {
                    lblError.Text = controlador.EliminarCancionForm(txtId.Text, txtNombre.Text, txtDuracion.Text, txtAnio.Text, txtGenero.Text);
                }
                catch
                {
                    MessageBox.Show("Hubo error al intentar agregar elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
            {
                try
                {
                    ServiceReference.BandaVO banda = controlador.ObtenerBandaForm(txtBandaId.Text);
                    if (banda != null)
                    {
                        lblBanda.Text = $"{banda.Nombre} {banda.GeneroMusical}";
                        controlador.AgregarBanda(banda);
                    }
                    else
                    {
                        lblBanda.Text = "No existe banda";
                    }
                }
                }
            catch
            {
                MessageBox.Show("Hubo error al intentar agregar elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           try{
                    ServiceReference.CancionVO cancion = controlador.ObtenerCancionForm(txtId.Text);
                    txtAnio.Text = cancion.Anio.ToString();
                    txtDuracion.Text = cancion.Duracion.ToString();
                    txtGenero.Text = cancion.GeneroMusical;
                    txtId.Text = cancion.Id.ToString();
                    txtNombre.Text = cancion.Nombre;
              }
           catch
            {
                MessageBox.Show("Hubo error al intentar agregar elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                lblError.Text = "";
                ServiceReference.IntegranteVO integrante = controlador.ObtenerIntegranteForm(txtIntegranteId.Text);
                lblIntegrante.Text = $"{integrante.Nombre} {integrante.Apellido}";
                controlador.AgregarIntegrante(integrante);
                
            }catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblError.Text = controlador.InsertarBandaForm(txtId.Text, txtNombre.Text, txtGenero.Text, txtCreacion.Text, txtSeparacion.Text);

        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            lblError.Text = controlador.ModificarBandaForm(txtId.Text, txtNombre.Text, txtGenero.Text, txtCreacion.Text, txtSeparacion.Text);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblError.Text = controlador.EliminarBandaForm(txtId.Text, txtNombre.Text, txtGenero.Text, txtCreacion.Text, txtSeparacion.Text);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                BandaVO banda = controlador.ObtenerBandaForm(txtId.Text);
                txtId.Text = banda.Id.ToString();
                txtNombre.Text = banda.Nombre;
                txtGenero.Text = banda.GeneroMusical;
                txtCreacion.Text = banda.AnioCreacion.ToString();
                txtSeparacion.Text = banda.AnioSeparacion.ToString();
            }catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
            
        }
    }
}

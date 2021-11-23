﻿using AppWindows.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows.FormularioAlbum
{
    public partial class FormAlbum : Form
    {
        AlbumControlador controlador = new AlbumControlador();
        public FormAlbum()
        {
            InitializeComponent();
        }

        private void btnBuscarBanda_Click(object sender, EventArgs e)
        {
            BandaVO banda = controlador.ObtenerBandaForm(txtBandaId.Text);
            lblBanda.Text = banda.Nombre;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CancionVO cancion = controlador.ObtenerCancionForm(txtCancionId.Text);
            if (cancion != null)
            {
                lblCancion.Text = $"{cancion.Nombre} {cancion.GeneroMusical}";
                controlador.AgregarCancion(cancion);
            }
            else
            {
                lblCancion.Text = "No existe cancion";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AlbumVO album = controlador.ObtenerAlbumForm(txtId.Text);
            txtNombre.Text = album.Nombre;
            txtCreacion.Text = album.Anio.ToString();
            txtGenero.Text = album.GeneroMusical;
            txtId.Text = album.Id.ToString();
            txtBandaId.Text = album.Band.Id.ToString();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblError.Text = controlador.InsertarAlbumForm(txtId.Text, txtNombre.Text, txtCreacion.Text, txtGenero.Text);
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            lblError.Text = controlador.ModificarAlbumForm(txtId.Text, txtNombre.Text, txtCreacion.Text, txtGenero.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblError.Text = controlador.EliminarAlbumForm(txtId.Text, txtNombre.Text, txtCreacion.Text, txtGenero.Text);

        }
    }
}
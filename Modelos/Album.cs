﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Album
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }
        public string GeneroMusical { get; set; }
        public Banda Band { get; set; }
        public List<Cancion> Canciones { get; set; }

        public Album() { }

        public Album(int nId, string nNombre, int nAnio, string nGeneroMusica, Banda nBanda)
        {

            Id = nId;
            Nombre = nNombre;
            Anio = nAnio;
            GeneroMusical = nGeneroMusica;
            Band = nBanda;

        }

        public void AgregarCancion(Cancion nCancion)
        {

            Canciones.Add(nCancion);

        }

        public void QuitarCancion(Cancion rCancion)
        {

            Canciones.Remove(rCancion);

        }
    }
}

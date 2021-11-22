﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class AlbumVO
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }
        public string GeneroMusical { get; set; }
        public int Banda { get; set; }
        public List<CancionVO> Canciones { get; set; }

        public AlbumVO() { }

        public AlbumVO(int nId, string nNombre, int nAnio, string nGeneroMusica, int nBanda, List<CancionVO> nCanciones)
        {

            Id = nId;
            Nombre = nNombre;
            Anio = nAnio;
            GeneroMusical = nGeneroMusica;
            Banda = nBanda;
            Canciones = nCanciones;
        }

    }
}

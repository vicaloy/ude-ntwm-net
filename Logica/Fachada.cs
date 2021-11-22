﻿using Modelos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace Logica
{
    public class Fachada: IFachada
    {
        static Fachada instance;

        public Fachada()
        {

        }

        public static Fachada Instance()
        {
            if (instance == null)
            {
                instance = new Fachada();
            }
            return instance;
        }

        DAOIntegrante daoIntegrante = DAOIntegrante.Instance();
        DAOAlbum daoAlbum = DAOAlbum.Instance();
        DAOCancion daoCancion = DAOCancion.Instance();
        DAOBanda daoBanda = DAOBanda.Instance();

        public void InsertarIntegrante(IntegranteVO integranteVO)
        {
            Integrante integrante = new Integrante(integranteVO.Id, integranteVO.Nombre, integranteVO.Apellido,
                integranteVO.FechaNacimiento, integranteVO.Foto);
            daoIntegrante.InsertarIntegrante(integrante);

        }

        public void ModificarIntegrante(IntegranteVO integranteVO)
        {
            Integrante integrante = new Integrante(integranteVO.Id, integranteVO.Nombre, integranteVO.Apellido,
                integranteVO.FechaNacimiento, integranteVO.Foto);
            daoIntegrante.ModificarIntegrante(integrante);

        }

        public void EliminarIntegrante(IntegranteVO integranteVO)
        {
            Integrante integrante = new Integrante(integranteVO.Id, integranteVO.Nombre, integranteVO.Apellido,
                integranteVO.FechaNacimiento, integranteVO.Foto);
            daoIntegrante.EliminarIntegrante(integrante);

        }

        public IntegranteVO ObtenerIntegrante(int id) {
            return new IntegranteVO(1, "Nombre", "Apellido", DateTime.Now, null);
        }

        public void InsertarBanda(BandaVO bandaVO)
        {
            Banda banda = new Banda(bandaVO.Id, bandaVO.Nombre, bandaVO.GeneroMusical, bandaVO.AnioCreacion, bandaVO.AnioSeparacion);
            daoBanda.InsertarBanda(banda);

        }

        public void ModificarBanda(BandaVO bandaVO)
        {
            Banda banda = new Banda(bandaVO.Id, bandaVO.Nombre, bandaVO.GeneroMusical, bandaVO.AnioCreacion, bandaVO.AnioSeparacion);
            daoBanda.ModificarBanda(banda);

        }

        public void EliminarBanda(BandaVO bandaVO)
        {
            Banda banda = new Banda(bandaVO.Id, bandaVO.Nombre, bandaVO.GeneroMusical, bandaVO.AnioCreacion, bandaVO.AnioSeparacion);
            daoBanda.EliminarBanda(banda);

        }

        public BandaVO ObtenerBanda(int id)
        {
            return new BandaVO(1, "Nombre", "Genero", 1900, 0, null);
        }

        public void InsertarAlbum(AlbumVO albumVO)
        {
            Album album = new Album(albumVO.Id, albumVO.Nombre, albumVO.Anio, albumVO.GeneroMusical);
            daoAlbum.InsertarAlbum(album);
        }

        public void ModificarAlbum(AlbumVO albumVO)
        {
            Album album = new Album(albumVO.Id, albumVO.Nombre, albumVO.Anio, albumVO.GeneroMusical);
            daoAlbum.ModificarAlbum(album);
        }

        public void EliminarAlbum(AlbumVO albumVO)
        {
            Album album = new Album(albumVO.Id, albumVO.Nombre, albumVO.Anio, albumVO.GeneroMusical);
            daoAlbum.EliminarAlbum(album);
        }
        public void InsertarCancion(CancionVO cancionVO)
        {
            Cancion cancion = new Cancion(cancionVO.Id, cancionVO.Nombre, cancionVO.Duracion, cancionVO.Anio, cancionVO.GeneroMusical);
            daoCancion.InsertarCancion(cancion);
        }

        public void ModificarCancion(CancionVO cancionVO)
        {
            Cancion cancion = new Cancion(cancionVO.Id, cancionVO.Nombre, cancionVO.Duracion, cancionVO.Anio, cancionVO.GeneroMusical);
            daoCancion.ModificarCancion(cancion);
        }

        public void EliminarCancion(CancionVO cancionVO)
        {
            Cancion cancion = new Cancion(cancionVO.Id, cancionVO.Nombre, cancionVO.Duracion, cancionVO.Anio, cancionVO.GeneroMusical);
            daoCancion.EliminarCancion(cancion);
        }
    }
}

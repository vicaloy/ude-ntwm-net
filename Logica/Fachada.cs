using Modelos;
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

        private Fachada()
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
            Integrante integrante =  daoIntegrante.BuscarIntegrante(id);
            IntegranteVO integranteVO = new IntegranteVO();
            integranteVO.Apellido = integrante.Apellido;
            integranteVO.FechaNacimiento = integrante.FechaNacimiento;
            integranteVO.Foto = integrante.Foto;
            integranteVO.Nombre = integrante.Nombre;
            return integranteVO;
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
            Banda banda = daoBanda.BuscarBanda(id);
            return new BandaVO(banda.Id, banda.Nombre, banda.GeneroMusical, banda.AnioCreacion, banda.AnioSeparacion, null);
        }

        public void InsertarAlbum(AlbumVO albumVO)
        {
            Banda band = new Banda(albumVO.Band.Id, albumVO.Band.Nombre, albumVO.Band.GeneroMusical, albumVO.Band.AnioCreacion, albumVO.Band.AnioSeparacion);
            Album album = new Album(albumVO.Id, albumVO.Nombre, albumVO.Anio, albumVO.GeneroMusical, band);
            daoAlbum.InsertarAlbum(album);
        }

        public void ModificarAlbum(AlbumVO albumVO)
        {
            Banda band = new Banda(albumVO.Band.Id, albumVO.Band.Nombre, albumVO.Band.GeneroMusical, albumVO.Band.AnioCreacion, albumVO.Band.AnioSeparacion);
            Album album = new Album(albumVO.Id, albumVO.Nombre, albumVO.Anio, albumVO.GeneroMusical, band);
            daoAlbum.ModificarAlbum(album);
        }

        public void EliminarAlbum(AlbumVO albumVO)
        {
            Banda band = new Banda(albumVO.Band.Id, albumVO.Band.Nombre, albumVO.Band.GeneroMusical, albumVO.Band.AnioCreacion, albumVO.Band.AnioSeparacion);
            Album album = new Album(albumVO.Id, albumVO.Nombre, albumVO.Anio, albumVO.GeneroMusical, band);
            daoAlbum.EliminarAlbum(album);
        }

        public AlbumVO ObtenerAlbum(int id) {
            Album album = daoAlbum.BuscarAlbum(id);
            BandaVO bandaVO = new BandaVO(album.Band.Id, album.Band.Nombre, album.Band.GeneroMusical, album.Band.AnioCreacion, album.Band.AnioSeparacion, null);
            AlbumVO albumVO = new AlbumVO(album.Id, album.Nombre, album.Anio, album.GeneroMusical, bandaVO, null);
            return albumVO;
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

        public CancionVO ObtenerCancion(int id)
        {
            Cancion cancion = daoCancion.BuscarCancion(id);
            CancionVO cancionVO = new CancionVO();
            cancionVO.Nombre = cancion.Nombre;
            cancionVO.GeneroMusical = cancion.GeneroMusical;
            cancionVO.Id = cancion.Id;
            cancionVO.Anio = cancion.Anio;
            return cancionVO;
        }
    }
}

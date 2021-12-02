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
    public class Fachada: IFachada, IFachadaWeb
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
        DAOResena daoresegna = DAOResena.Instance();
        DAOUsuario daousuario = DAOUsuario.Instance();

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

        public void RegistrarUsuario(UsuarioVO nUsuario)
        {

            Usuario usuario = new Usuario(nUsuario.Id, nUsuario.Nombre, nUsuario.User, nUsuario.Password);
            daousuario.InsertarUsuario(usuario);

        }

        public void InsertarResena(ResenaVO nResena)
        {
            Resena resena = new Resena(nResena.Id, nResena.Id_Objeto, nResena.Tipo, nResena.Puntaje, nResena.Texto);
            daoresegna.InsertarResena(resena);
        }

        public List<ResenaVO> ListarResenas(int objeto, string tipo)
        {

            List<ResenaVO> resenasVO = new List<ResenaVO>();
            List<Resena>  resenas = daoresegna.ListarResena(objeto, tipo);

            foreach (Resena resena in resenas)
            {
                ResenaVO resenaVO = new ResenaVO(resena.Id, resena.Id_Objeto, resena.Tipo, resena.Puntaje, resena.Texto);
                resenasVO.Add(resenaVO);
            }

            return resenasVO;

        }

        public List<AlbumVO> ListarAlbums()
        {
            List<AlbumVO> albumsVO = new List<AlbumVO>();
            List<Album> albums = daoAlbum.ListarAlbumes();

            foreach (Album album in albums)
            {

                List<CancionVO> cancionesVO = new List<CancionVO>();

                foreach (Cancion cancion in album.Canciones)
                {
                    CancionVO cancionVO = new CancionVO(cancion.Id, cancion.Nombre, cancion.Duracion, cancion.Anio, cancion.GeneroMusical, null);
                    cancionesVO.Add(cancionVO);
                }

                BandaVO bandaVO = new BandaVO(album.Band.Id, album.Band.Nombre, album.Band.GeneroMusical, album.Band.AnioCreacion, album.Band.AnioSeparacion, null);

                AlbumVO albumVO = new AlbumVO(album.Id, album.Nombre, album.Anio, album.GeneroMusical, bandaVO, cancionesVO);
                albumsVO.Add(albumVO);
            }

            return albumsVO;
        }

        public List<BandaVO> ListarBandas()
        {
            List<BandaVO> bandasVO = new List<BandaVO>();
            List<Banda> bandas = daoBanda.ListarBandas();

            foreach (Banda banda in bandas)
            {

                BandaVO bandaVO = new BandaVO(banda.Id, banda.Nombre, banda.GeneroMusical, banda.AnioCreacion, banda.AnioSeparacion, null);
                bandasVO.Add(bandaVO);
            }

            return bandasVO;
        }

        public List<CancionVO> ListarCanciones()
        {

            List<CancionVO> cancionesVO = new List<CancionVO>();
            List<Cancion> canciones = daoCancion.ListarCanciones();

            foreach (Cancion cancion in canciones)
            {
                CancionVO cancionVO = new CancionVO(cancion.Id, cancion.Nombre, cancion.Duracion, cancion.Anio, cancion.GeneroMusical, null);
                cancionesVO.Add(cancionVO);
            }

            return cancionesVO;

        }

        public List<IntegranteVO> ListarIntegrantes()
        {

            List<IntegranteVO> integrantesVO = new List<IntegranteVO>();
            List<Integrante> integrantes = daoIntegrante.ListarIntegrantes();

            foreach (Integrante integrante in integrantes)
            {
                IntegranteVO integranteVO = new IntegranteVO(integrante.Id, integrante.Nombre, integrante.Apellido, integrante.FechaNacimiento, integrante.Foto);
                integrantesVO.Add(integranteVO);
            }

            return integrantesVO;

        }


    }
}

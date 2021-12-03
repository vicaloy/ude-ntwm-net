using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace Logica
{
    public interface IFachadaWeb
    {

        void RegistrarUsuario(UsuarioVO nUsuario);

        void InsertarResena(ResenaVO nResena);

        List<ResenaVO> ListarResenas(int objeto, string tipo);

        List<AlbumVO> ListarAlbums();

        List<BandaVO> ListarBandas();

        List<CancionVO> ListarCanciones();

        List<IntegranteVO> ListarIntegrantes();

        CancionVO ObtenerCancion(int id);

        AlbumVO ObtenerAlbum(int id);

        BandaVO ObtenerBanda(int id);

        IntegranteVO ObtenerIntegrante(int id);
    }
}

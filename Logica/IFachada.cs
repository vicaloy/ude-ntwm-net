using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace Logica
{
    public interface IFachada
    {
        void InsertarIntegrante(IntegranteVO integranteVO);
        void ModificarIntegrante(IntegranteVO integranteVO);
        void EliminarIntegrante(IntegranteVO integranteVO);
        IntegranteVO ObtenerIntegrante(int id);

        void InsertarBanda(BandaVO bandaVO);
        void ModificarBanda(BandaVO bandaVO);
        void EliminarBanda(BandaVO bandaVO);
        BandaVO ObtenerBanda(int id);

        void InsertarAlbum(AlbumVO albumVO);
        void ModificarAlbum(AlbumVO albumVO);
        void EliminarAlbum(AlbumVO albumVO);
        AlbumVO ObtenerAlbum(int id);
        void InsertarCancion(CancionVO cancionVO);
        void ModificarCancion(CancionVO cancionVO);
        void EliminarCancion(CancionVO cancionVO);
        CancionVO ObtenerCancion(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ValueObject;
using Logica;

namespace AppWeb
{
    /// <summary>
    /// Descripción breve de ServicioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb : System.Web.Services.WebService
    {
        IFachada fachada = Fachada.Instance();

        [WebMethod]
        public void InsertarIntegranteWS(IntegranteVO integranteVO)
        {
            fachada.InsertarIntegrante(integranteVO);
        }

        [WebMethod]
        public void ModificarIntegranteWS(IntegranteVO integranteVO)
        {
            fachada.ModificarIntegrante(integranteVO);
        }

        [WebMethod]
        public void EliminarIntegranteWS(IntegranteVO integranteVO)
        {
            fachada.EliminarIntegrante(integranteVO);
        }

        [WebMethod]
        public IntegranteVO ObtenerIntegranteWS(int id)
        {
            return fachada.ObtenerIntegrante(id);
        }
        [WebMethod]
        public void InsertarBandaWS(BandaVO bandaVO)
        {
            fachada.InsertarBanda(bandaVO);

        }
        [WebMethod]
        public void ModificarBandaWS(BandaVO bandaVO)
        {
            fachada.ModificarBanda(bandaVO);

        }
        [WebMethod]
        public void EliminarBandaWS(BandaVO bandaVO)
        {
            fachada.EliminarBanda(bandaVO);

        }
        [WebMethod]
        public BandaVO ObtenerBandaWS(int id)
        {
            return fachada.ObtenerBanda(id);
        }

        [WebMethod]
        public void EliminarCancionWS(CancionVO cancionVO)
        {
            fachada.EliminarCancion(cancionVO);
        }

        [WebMethod]
        public void ModificarCancionWS(CancionVO cancionVO)
        {
            fachada.ModificarCancion(cancionVO);
        }

        [WebMethod]
        public void InsertarCancionWS(CancionVO cancionVO)
        {
            fachada.InsertarCancion(cancionVO);
        }

        [WebMethod]
        public CancionVO ObtenerCancionWS(int id)
        {
            return fachada.ObtenerCancion(id);
        }

        [WebMethod]
        public void EliminarAlbumWS(AlbumVO albumVO)
        {
            fachada.EliminarAlbum(albumVO);
        }

        [WebMethod]
        public void ModificarAlbumWS(AlbumVO albumVO)
        {
            fachada.ModificarAlbum(albumVO);
        }

        [WebMethod]
        public void InsertarAlbumWS(AlbumVO albumVO)
        {
            fachada.InsertarAlbum(albumVO);
        }

        [WebMethod]
        public AlbumVO ObtenerAlbumWS(int id)
        {
            return fachada.ObtenerAlbum(id);
        }
    }
}

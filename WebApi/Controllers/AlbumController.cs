using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ValueObject;
using Logica;

namespace WebApi.Controllers
{
    public class AlbumController : ApiController
    {

        IFachadaWeb fachada = Fachada.Instance();

        public IEnumerable<AlbumVO> GetAllAlbums()
        {

            return fachada.ListarAlbums();

        }

        public AlbumVO GetAlbum(int id)
        {
            return fachada.ObtenerAlbum(id);
        }

    }
}

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
    public class CancionController : ApiController
    {

        IFachadaWeb fachada = Fachada.Instance();

        public IEnumerable<CancionVO> GetAllCanciones()
        {

            return fachada.ListarCanciones();

        }

        public CancionVO GetCancion(int id)
        {
            return fachada.ObtenerCancion(id);
        }

    }
}

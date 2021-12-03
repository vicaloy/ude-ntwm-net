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
    public class BandaController : ApiController
    {

        IFachadaWeb fachada = Fachada.Instance();

        public IEnumerable<BandaVO> GetAllBandas()
        {

            return fachada.ListarBandas();

        }

        public BandaVO GetBanda(int id)
        {
            return fachada.ObtenerBanda(id);
        }

    }
}

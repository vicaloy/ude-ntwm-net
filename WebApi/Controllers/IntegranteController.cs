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
    public class IntegranteController : ApiController
    {

        IFachadaWeb fachada = Fachada.Instance();

        public IEnumerable<IntegranteVO> GetAllIntegrante()
        {

            return fachada.ListarIntegrantes();

        }

    }
}

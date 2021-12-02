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
    public class ResenaController : ApiController
    {

        IFachadaWeb fachada = Fachada.Instance();

        public string GetAllResena(ResenaVO nResena)
        {

            fachada.InsertarResena(nResena);
            return "Ingresado";

        }

        public IEnumerable<ResenaVO> GetResenas(int objeto, string tipo)
        {
            return fachada.ListarResenas(objeto, tipo);
        }

    }
}

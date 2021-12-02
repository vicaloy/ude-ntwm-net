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
    public class FachadaController : ApiController
    {

        IFachadaWeb fachada = Fachada.Instance();

        public string RegistrarUsuario(UsuarioVO nUsuario)
        {

            fachada.RegistrarUsuario(nUsuario);

            return "Ingresado";

        }

        public string RegistrarResena(ResenaVO nResena)
        {

            fachada.InsertarResena(nResena);
            return "Ingresado";

        }

        public IEnumerable<ResenaVO> ListarResenas(int objeto, string tipo)
        {
            return fachada.ListarResenas(objeto, tipo);
        }
    }
}

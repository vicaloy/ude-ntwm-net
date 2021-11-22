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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWindows.FormularioIntegrante
{
    class IntegranteControlador
    {
        public String InsertarIntegranteForm(String id, string nombre, string apellido, DateTime fecha, byte [] archivo) {
            int nro;
            if (!Int32.TryParse(id, out nro)) {
                return "Ingrese un id mayor a 0";
            }
            if (nombre == null || nombre == "") {
                return "Ingrese un nombre";
            }
            if (apellido== null || apellido == "")
            {
                return "Ingrese un apellido";
            }
            if (fecha == null) {
                return "Ingrese fecha";
            }
            if (archivo == null) {
                return "Ingrese foto";
            }

            ServiceReference.ServicioWebSoapClient ws = new ServiceReference.ServicioWebSoapClient();
            ServiceReference.IntegranteVO integranteVO = new ServiceReference.IntegranteVO();
            integranteVO.Nombre = nombre;
            integranteVO.Id = nro;
            integranteVO.Apellido = apellido;
            integranteVO.FechaNacimiento = fecha;
            integranteVO.Foto = archivo;
            ws.InsertarIntegranteWS(integranteVO);
            return "Exito";
        }
    }
}

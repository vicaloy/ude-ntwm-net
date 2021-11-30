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
            if (nro < 0)
            {
                return "El codigo tiene que ser positivo";
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
            try
            {
                 ws.InsertarIntegranteWS(integranteVO);
                 return "Exito";
            }
            catch(Exception ex)
            {
                return "Ha ocurrido un error";
            }
           
        }

        public String ModificarIntegranteForm(String id, string nombre, string apellido, DateTime fecha, byte[] archivo)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id mayor a 0";
            }
            if (nro < 0)
            {
                return "El codigo tiene que ser positivo";
            }
            if (nombre == null || nombre == "")
            {
                return "Ingrese un nombre";
            }
            if (apellido == null || apellido == "")
            {
                return "Ingrese un apellido";
            }
            if (fecha == null)
            {
                return "Ingrese fecha";
            }
            if (archivo == null)
            {
                return "Ingrese foto";
            }

            ServiceReference.ServicioWebSoapClient ws = new ServiceReference.ServicioWebSoapClient();
            ServiceReference.IntegranteVO integranteVO = new ServiceReference.IntegranteVO();
            integranteVO.Nombre = nombre;
            integranteVO.Id = nro;
            integranteVO.Apellido = apellido;
            integranteVO.FechaNacimiento = fecha;
            integranteVO.Foto = archivo;
            try { 
                ws.ModificarIntegranteWS(integranteVO);
                return "Exito";
            }catch(Exception ex)
            {
                return "Ha ocurrido un error";
            }
}

        public String EliminarIntegranteForm(String id, string nombre, string apellido, DateTime fecha, byte[] archivo)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id mayor a 0";
            }
            if (nro < 0)
            {
                return "El codigo tiene que ser positivo";
            }
            if (nombre == null || nombre == "")
            {
                return "No se encontro integrante";
            }
            if (apellido == null || apellido == "")
            {
                return "No se encontro integrante";
            }
      

            ServiceReference.ServicioWebSoapClient ws = new ServiceReference.ServicioWebSoapClient();
            ServiceReference.IntegranteVO integranteVO = new ServiceReference.IntegranteVO();
            integranteVO.Nombre = nombre;
            integranteVO.Id = nro;
            integranteVO.Apellido = apellido;
            integranteVO.FechaNacimiento = fecha;
            integranteVO.Foto = archivo;
            try { 
                ws.EliminarIntegranteWS(integranteVO);
                return "Exito";
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error";
            }
        }

        public ServiceReference.IntegranteVO ObtenerIntegranteForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                throw new Exception("Tiene que ser numerico");
            }
            if(nro<0)
            {
                throw new Exception("El codigo tiene que ser positivo");
            }

            try { 
                ServiceReference.ServicioWebSoapClient ws = new ServiceReference.ServicioWebSoapClient();
                return ws.ObtenerIntegranteWS(nro);
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido un error");
            }

        }
    }
}

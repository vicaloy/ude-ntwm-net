using AppWindows.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWindows.FormularioBanda
{
    public class BandaControlador
    {
        List<IntegranteVO> integrantes = new List<IntegranteVO>();
        public String InsertarBandaForm(String id, string nombre, string genero, string anioCreacion, string anioSeparacion)
        {
            int nro;
            int creacion;
            int separacion=0;
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
            if (genero == null || genero == "")
            {
                return "Ingrese un genero";
            }
            if (!Int32.TryParse(anioCreacion, out creacion))
            {
                return "Ingrese un año creacion";
            }
            if (anioSeparacion.Trim() != "")
            {
                if (!Int32.TryParse(anioSeparacion, out separacion))
                {
                    return "Ingrese un año separacion";
                }
                if(separacion<creacion)
                {
                    return "El año de separacion no puede ser menor al año de creación";
                }
            }
            


            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            BandaVO bandaVO = new BandaVO();
            bandaVO.Id = nro;
            bandaVO.Nombre = nombre;
            bandaVO.GeneroMusical = genero;
            bandaVO.AnioCreacion = creacion;
            bandaVO.AnioSeparacion = separacion;
            bandaVO.Integrantes = integrantes.ToArray();
            try { 
           
                ws.InsertarBandaWS(bandaVO);
                return "Exito";

        }
            catch(Exception ex)
            {
                return ex.Message;
            }

}

        public String ModificarBandaForm(String id, string nombre, string genero, string anioCreacion, string anioSeparacion)
        {
            int nro;
            int creacion;
            int separacion=0;
            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id mayor a 0";
            }
            if (nro < 0)
            {
                return"El codigo tiene que ser positivo";
            }
            if (nombre == null || nombre == "")
            {
                return "Ingrese un nombre";
            }
            if (genero == null || genero == "")
            {
                return "Ingrese un genero";
            }
            if (!Int32.TryParse(anioCreacion, out creacion))
            {
                return "Ingrese un año creacion";
            }
            if (anioSeparacion.Trim() != "")
            {
                if (!Int32.TryParse(anioSeparacion, out separacion))
                {
                    return "Ingrese un año separacion";

                }
                else
                    if (creacion > separacion)
                {
                    return "El año de creacion tiene que ser menor, que le año de separacion ";
                }
            }

            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            BandaVO bandaVO = new BandaVO();
            bandaVO.Id = nro;
            bandaVO.Nombre = nombre;
            bandaVO.GeneroMusical = genero;
            bandaVO.AnioCreacion = creacion;
            bandaVO.AnioSeparacion = separacion;
            bandaVO.Integrantes = integrantes.ToArray();

            try { 
                ws.ModificarBandaWS(bandaVO);

                return "Exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public String EliminarBandaForm(String id, string nombre, string genero, string anioCreacion, string anioSeparacion)
        {
            int nro;
            int creacion;
            int separacion;
            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id tiene que ser numerico";
            }
            if (nro < 0)
            {
                return "El codigo tiene que ser positivo";
            }
            if (nombre == null || nombre == "")
            {
                return "Ingrese un nombre";
            }
            if (genero == null || genero == "")
            {
                return "Ingrese un genero";
            }
            if (!Int32.TryParse(anioCreacion, out creacion))
            {
                return "Ingrese un año creacion";
            }
            if (!Int32.TryParse(anioSeparacion, out separacion))
            {
                return "Ingrese un año separacion";
            }


            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            BandaVO bandaVO = new BandaVO();
            bandaVO.Id = nro;
            bandaVO.Nombre = nombre;
            bandaVO.GeneroMusical = genero;
            bandaVO.AnioCreacion = creacion;
            bandaVO.AnioSeparacion = separacion;
            bandaVO.Integrantes = integrantes.ToArray();
            try {  
                ws.EliminarBandaWS(bandaVO);

                return "Exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public IntegranteVO ObtenerIntegranteForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                throw new Exception("Debe ingresar numerico el codigo el intergrante");
            }
            if (nro < 0)
            {
                throw new Exception("El codigo tiene que ser positivo");
            }

            ServicioWebSoapClient ws = new ServicioWebSoapClient();
                return ws.ObtenerIntegranteWS(nro);
           

        }

        public void AgregarIntegrante(IntegranteVO integrante) {
            integrantes.Add(integrante);
        }

        public BandaVO ObtenerBandaForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                throw new Exception("El codigo es solamente numerico");
            }

            if (nro < 0)
            {
                throw new Exception("El codigo tiene que ser positivo");
            }
            ServiceReference.ServicioWebSoapClient ws = new ServiceReference.ServicioWebSoapClient();
            
                return ws.ObtenerBandaWS(nro);
           
            

        }
    }
}

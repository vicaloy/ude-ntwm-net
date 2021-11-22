using AppWindows.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWindows.FormularioCancion
{
    public class CancionControlador
    {
        List<BandaVO> bandas = new List<BandaVO>();
        //int nId, string nNombre, float nDuracion, int nAnio, string nGeneroMusica
        public String InsertarCancionForm(String id, string nombre, string duracion, string anio, string genero)
        {
            int nro;
            int anioNro;
            float duracionNro;

            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id mayor a 0";
            }
            if (nombre == null || nombre == "")
            {
                return "Ingrese un nombre";
            }
            if (genero == null || genero == "")
            {
                return "Ingrese un genero";
            }
            if (!Int32.TryParse(anio, out anioNro))
            {
                return "Ingrese un año creacion";
            }
            if (!float.TryParse(duracion, out duracionNro))
            {
                return "Ingrese una duracion";
            }


            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            

            return "Exito";
        }

        public String ModificarBandaForm(String id, string nombre, string genero, string anioCreacion, string anioSeparacion)
        {
            int nro;
            int creacion;
            int separacion;
            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id mayor a 0";
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

            ws.ModificarBandaWS(bandaVO);

            return "Exito";
        }

        public String EliminarBandaForm(String id, string nombre, string genero, string anioCreacion, string anioSeparacion)
        {
            int nro;
            int creacion;
            int separacion;
            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id mayor a 0";
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

            ws.EliminarBandaWS(bandaVO);

            return "Exito";
        }

        public IntegranteVO ObtenerIntegranteForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                return null;
            }


            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            return ws.ObtenerIntegranteWS(nro);

        }

        public void AgregarIntegrante(IntegranteVO integrante)
        {
            integrantes.Add(integrante);
        }

        public BandaVO ObtenerBandaForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                return null;
            }


            ServiceReference.ServicioWebSoapClient ws = new ServiceReference.ServicioWebSoapClient();
            return ws.ObtenerBandaWS(nro);

        }
    }
}

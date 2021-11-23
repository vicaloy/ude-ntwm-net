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

            CancionVO cancionVO = new CancionVO();
            cancionVO.Id = nro;
            cancionVO.Nombre = nombre;
            cancionVO.GeneroMusical = genero;
            cancionVO.Anio = anioNro;
            cancionVO.Duracion = duracionNro;
            cancionVO.Bandas = bandas.ToArray();

            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            ws.InsertarCancionWS(cancionVO);

            return "Exito";
        }

        public void AgregarBanda(BandaVO banda)
        {
            bandas.Add(banda);
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

        public String ModificarCancionForm(String id, string nombre, string duracion, string anio, string genero)
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

            CancionVO cancionVO = new CancionVO();
            cancionVO.Id = nro;
            cancionVO.Nombre = nombre;
            cancionVO.GeneroMusical = genero;
            cancionVO.Anio = anioNro;
            cancionVO.Duracion = duracionNro;
            cancionVO.Bandas = bandas.ToArray();

            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            ws.ModificarCancionWS(cancionVO);

            return "Exito";
        }

        public String EliminarCancionForm(String id, string nombre, string duracion, string anio, string genero)
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

            CancionVO cancionVO = new CancionVO();
            cancionVO.Id = nro;
            cancionVO.Nombre = nombre;
            cancionVO.GeneroMusical = genero;
            cancionVO.Anio = anioNro;
            cancionVO.Duracion = duracionNro;
            cancionVO.Bandas = bandas.ToArray();

            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            ws.EliminarCancionWS(cancionVO);

            return "Exito";
        }

        public CancionVO ObtenerCancionForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                return null;
            }


            ServiceReference.ServicioWebSoapClient ws = new ServiceReference.ServicioWebSoapClient();
            return ws.ObtenerCancionWS(nro);

        }

    }
}

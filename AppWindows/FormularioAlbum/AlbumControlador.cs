using AppWindows.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWindows.FormularioAlbum
{
    public class AlbumControlador
    {
        BandaVO bandaVO = new BandaVO();
        List<CancionVO> canciones = new List<CancionVO>();

        public String InsertarAlbumForm(String id, string nombre, string anio, string genero)
        {
            int nro;
            int anioNro;
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



            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            AlbumVO albumVO = new AlbumVO();
            albumVO.Nombre = nombre;
            albumVO.GeneroMusical = genero;
            albumVO.Id = nro;
            albumVO.Anio = anioNro;
            albumVO.Band = bandaVO;
            albumVO.Canciones = canciones.ToArray();

            ws.InsertarAlbumWS(albumVO);

            return "Exito";
        }

        public String ModificarAlbumForm(String id, string nombre, string anio, string genero)
        {
            int nro;
            int anioNro;
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



            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            AlbumVO albumVO = new AlbumVO();
            albumVO.Nombre = nombre;
            albumVO.GeneroMusical = genero;
            albumVO.Id = nro;
            albumVO.Anio = anioNro;
            albumVO.Band = bandaVO;
            albumVO.Canciones = canciones.ToArray();

            ws.ModificarAlbumWS(albumVO);

            return "Exito";
        }

        public String EliminarAlbumForm(String id, string nombre, string anio, string genero)
        {
            int nro;
            int anioNro;
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



            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            AlbumVO albumVO = new AlbumVO();
            albumVO.Nombre = nombre;
            albumVO.GeneroMusical = genero;
            albumVO.Id = nro;
            albumVO.Anio = anioNro;
            albumVO.Band = bandaVO;
            albumVO.Canciones = canciones.ToArray();

            ws.EliminarAlbumWS(albumVO);

            return "Exito";
        }

        public BandaVO ObtenerBandaForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                return null;
            }

            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            bandaVO= ws.ObtenerBandaWS(nro);
            return bandaVO;
        }

        public void AgregarCancion(CancionVO cancion)
        {
            canciones.Add(cancion);
        }

         public CancionVO ObtenerCancionForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                return null;
            }


            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            return ws.ObtenerCancionWS(nro);

        }

        public AlbumVO ObtenerAlbumForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                return null;
            }


            ServicioWebSoapClient ws = new ServicioWebSoapClient();
            return ws.ObtenerAlbumWS(nro);

        }
    }
}

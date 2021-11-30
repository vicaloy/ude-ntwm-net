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
            int nro=0;
            int anioNro;
            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id mayor a 0";
            }
            
            if (nro < 0)
            {
                throw new Exception("El codigo tiene que ser positivo");
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

            try
            {
                ws.InsertarAlbumWS(albumVO);

                return "Exito";
            }catch(Exception ex)
            {
                return "Ha ocurrido un error";
            }
           
        }

        public String ModificarAlbumForm(String id, string nombre, string anio, string genero)
        {
            int nro;
            int anioNro;
            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id tiene que ser numerico";
            }
            if (nro < 0)
            {
                throw new Exception("El codigo tiene que ser positivo");
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

            try { 
                ws.ModificarAlbumWS(albumVO);

                return "Exito";
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error";
            }
        }

        public String EliminarAlbumForm(String id, string nombre, string anio, string genero)
        {
            int nro;
            int anioNro;
            if (!Int32.TryParse(id, out nro))
            {
                return "Ingrese un id mayor a 0";
            }
            if (nro < 0)
            {
                throw new Exception("El codigo tiene que ser positivo");
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
            try
            {
                ws.EliminarAlbumWS(albumVO);

                return "Exito";
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error";
            }

        }

        public BandaVO ObtenerBandaForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                throw new Exception("Error tiene que ser numerico");
            }
            if (nro < 0)
            {
                throw new Exception("El codigo tiene que ser positivo");
            }
            try
            {
                ServicioWebSoapClient ws = new ServicioWebSoapClient();
                bandaVO = ws.ObtenerBandaWS(nro);
                return bandaVO;
            }catch(Exception ex)
            {
                throw new Exception("Ha ocurrido un error");
            }
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
                throw new Exception("Error tiene que ser numerico");
            }
            if (nro < 0)
            {
                throw new Exception("El codigo tiene que ser positivo");
            }

            try
            {
                ServicioWebSoapClient ws = new ServicioWebSoapClient();
                return ws.ObtenerCancionWS(nro);
            }catch(Exception ex)
            {
                throw new Exception("Ha ocurrido un error");
            }

        }

        public AlbumVO ObtenerAlbumForm(String id)
        {
            int nro;
            if (!Int32.TryParse(id, out nro))
            {
                throw new Exception("El codigo debe ser numerico");
            }
            if (nro < 0)
            {
                throw new Exception("El codigo tiene que ser positivo");
            }

            try
            {
                ServicioWebSoapClient ws = new ServicioWebSoapClient();
                return ws.ObtenerAlbumWS(nro);
            }catch(Exception ex)
            {
                throw new Exception("Ha ocurrido un error");
            }
            

        }
    }
}

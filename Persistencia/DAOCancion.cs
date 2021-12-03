using Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class DAOCancion
    {

        public Query query = new Query();

        static DAOCancion instance;

        private DAOCancion()
        {

        }

        public static DAOCancion Instance()
        {
            if (instance == null)
            {
                instance = new DAOCancion();
            }
            return instance;
        }


        public void InsertarCancion(Cancion cancion)
        {
            try { 
                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                string cmd = query.AgregarCancion();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@id", cancion.Id);
                comando.Parameters.AddWithValue("@nombre", cancion.Nombre);
                comando.Parameters.AddWithValue("@duracion", cancion.Duracion);
                comando.Parameters.AddWithValue("@genero", cancion.GeneroMusical);
                comando.Parameters.AddWithValue("@anio", cancion.Anio);

                comando.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ModificarCancion(Cancion cancion)
        {
            try { 
                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                string cmd = query.ModificarCancion();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@id", cancion.Id);
                comando.Parameters.AddWithValue("@nombre", cancion.Nombre);
                comando.Parameters.AddWithValue("@duracion", cancion.Duracion);
                comando.Parameters.AddWithValue("@genero", cancion.GeneroMusical);
                comando.Parameters.AddWithValue("@anio", cancion.Anio);

                comando.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EliminarCancion(Cancion cancion)
        {
            try { 
                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                string cmd = query.EliminarCancion();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@id", cancion.Id);

                comando.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AgregarBandas(Cancion cancion, List<Banda> bandas)
        {
            try { 
                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                foreach (Banda banda in bandas)
                {

                    string cmd = query.AgregarBandaCancion();

                    SqlCommand comando = new SqlCommand(cmd, connection);

                    comando.Parameters.AddWithValue("@id_banda", banda.Id);
                    comando.Parameters.AddWithValue("@id_cancion", cancion.Id);

                    comando.ExecuteNonQuery();

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EliminarBanda(Cancion cancion, Banda banda)
        {
            try { 
                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                string cmd = query.EliminarBandaCancion();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@id_banda", banda.Id);
                comando.Parameters.AddWithValue("@id_cancion", cancion.Id);

                comando.ExecuteNonQuery();


                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Cancion> ListarCanciones()
        {
            try { 
                List<Cancion> canciones = new List<Cancion>();

                Cancion cancion = new Cancion();

                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                string cmd = query.ListarCanciones();

                SqlCommand comando = new SqlCommand(cmd, connection);

                SqlDataReader resultado = comando.ExecuteReader();

            

                while (resultado.Read())
                {
                    cancion.Id = Convert.ToInt32(resultado["id"]);
                    cancion.Nombre = Convert.ToString(resultado["nombre"]);
                    cancion.Anio = Convert.ToInt32(resultado["anio"]);
                    cancion.Duracion = Convert.ToInt32(resultado["duracion"]);
                    cancion.GeneroMusical = Convert.ToString(resultado["genero"]);

                    canciones.Add(cancion);
                }

                connection.Close();

                return canciones;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Cancion BuscarCancion(int bId)
        {
            try { 
                Cancion cancion = new Cancion();

                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                string cmd = query.BuscarCancion();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@id", bId);

                SqlDataReader resultado = comando.ExecuteReader();

                while (resultado.Read())
                {

                    cancion.Id = Convert.ToInt32(resultado["id"]);
                    cancion.Nombre = Convert.ToString(resultado["nombre"]);
                    cancion.Anio = Convert.ToInt32(resultado["anio"]);
                    cancion.Duracion = Convert.ToInt32(resultado["duracion"]);
                    cancion.GeneroMusical = Convert.ToString(resultado["genero"]);

                }

                connection.Close();

                return cancion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

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

        private DAOCancion() { }

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

        public void ModificarCancion(Cancion cancion)
        {

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

        public void EliminarCancion(Cancion cancion)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.EliminarCancion();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", cancion.Id);

            comando.ExecuteNonQuery();

            connection.Close();

        }
    }
}

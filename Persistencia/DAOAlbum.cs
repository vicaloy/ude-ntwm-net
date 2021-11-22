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
    public class DAOAlbum
    {

        public Query query = new Query();

        static DAOAlbum instance;

        private DAOAlbum() { }

        public static DAOAlbum Instance()
        {
            if (instance == null)
            {
                instance = new DAOAlbum();
            }
            return instance;
        }

        public void InsertarAlbum(Album album)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.AgregarAlbum();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", album.Id);
            comando.Parameters.AddWithValue("@anio_creacion", album.Anio);
            comando.Parameters.AddWithValue("@nombre", album.Nombre);
            comando.Parameters.AddWithValue("@genero", album.GeneroMusical);

            comando.ExecuteNonQuery();

            connection.Close();
        }

        public void ModificarAlbum(Album album)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.ModificarAlbum();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", album.Id);
            comando.Parameters.AddWithValue("@anio_creacion", album.Anio);
            comando.Parameters.AddWithValue("@nombre", album.Nombre);
            comando.Parameters.AddWithValue("@genero", album.GeneroMusical);

            comando.ExecuteNonQuery();

            connection.Close();

        }

        public void EliminarAlbum(Album album)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.EliminarAlbum();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", album.Id);

            comando.ExecuteNonQuery();

            connection.Close();

        }
    }
}

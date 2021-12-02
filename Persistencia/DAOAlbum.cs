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

        private DAOAlbum()
        {

        }

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
            comando.Parameters.AddWithValue("@banda", album.Band.Id);

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
            comando.Parameters.AddWithValue("@banda", album.Band.Id);

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

        public void AgregarCanciones(Album album, List<Cancion> canciones)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            foreach (Cancion cancion in canciones)
            {

                string cmd = query.AgregarCancionAlbum();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@id_album", album.Id);
                comando.Parameters.AddWithValue("@id_cancion", cancion.Id);

                comando.ExecuteNonQuery();

            }

            connection.Close();

        }

        public void EliminarCancion(Album album, Cancion cancion)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.EliminarCancionAlbum();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id_album", album.Id);
            comando.Parameters.AddWithValue("@id_cancion", cancion.Id);

            comando.ExecuteNonQuery();


            connection.Close();

        }

        public List<Album> ListarAlbumes()
        {

            List<Album> albums = new List<Album>();

            Album album = new Album();

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.ListarAlbumes();

            SqlCommand comando = new SqlCommand(cmd, connection);

            SqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                album.Id = Convert.ToInt32(resultado["id"]);
                album.Nombre = Convert.ToString(resultado["nombre"]);
                album.Anio = Convert.ToInt32(resultado["anio_creacion"]);
                album.Band = new Banda();
                album.Band.Id = Convert.ToInt32(resultado["id_banda"]);
                album.GeneroMusical = Convert.ToString(resultado["genero"]);

                albums.Add(album);
            }

            connection.Close();

            return albums;
        }

        public Album BuscarAlbum(int bId)
        {

            Album album = new Album();

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.BuscarAlbum();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", bId);

            SqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {

                album.Id = Convert.ToInt32(resultado["id"]);
                album.Nombre = Convert.ToString(resultado["nombre"]);
                album.Anio = Convert.ToInt32(resultado["anio_creacion"]);
                album.Band = new Banda();
                album.Band.Id = Convert.ToInt32(resultado["id_banda"]);
                album.GeneroMusical = Convert.ToString(resultado["genero"]);

            }

            connection.Close();

            return album;
        }

    }
}

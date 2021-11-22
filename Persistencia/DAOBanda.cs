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
    public class DAOBanda
    {

        public Query query = new Query();

        static DAOBanda instance;

        private DAOBanda() { }

        public static DAOBanda Instance()
        {
            if (instance == null)
            {
                instance = new DAOBanda();
            }
            return instance;
        }

        public void InsertarBanda(Banda banda)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.AgregarBanda();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", banda.Id);
            comando.Parameters.AddWithValue("@anio_separacion", banda.AnioSeparacion);
            comando.Parameters.AddWithValue("@anio_creacion", banda.AnioCreacion);
            comando.Parameters.AddWithValue("@nombre", banda.Nombre);
            comando.Parameters.AddWithValue("@genero", banda.GeneroMusical);

            comando.ExecuteNonQuery();

            connection.Close();
        }

        public void ModificarBanda(Banda banda)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.ModificarBanda();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", banda.Id);
            comando.Parameters.AddWithValue("@anio_separacion", banda.AnioSeparacion);
            comando.Parameters.AddWithValue("@anio_creacion", banda.AnioCreacion);
            comando.Parameters.AddWithValue("@nombre", banda.Nombre);
            comando.Parameters.AddWithValue("@genero", banda.GeneroMusical);

            comando.ExecuteNonQuery();

            connection.Close();

        }

        public void EliminarBanda(Banda banda)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.EliminarBanda();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", banda.Id);

            comando.ExecuteNonQuery();

            connection.Close();

        }
    }
}

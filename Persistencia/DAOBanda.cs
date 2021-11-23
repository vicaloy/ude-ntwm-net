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

        private DAOBanda()
        {

        }

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

        public void AgregarIntegrantes(Banda banda, List<Integrante> integrantes)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            foreach (Integrante integrante in integrantes)
            {

                string cmd = query.AgregarIntegranteBanda();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@id_banda", banda.Id);
                comando.Parameters.AddWithValue("@id_integrante", integrante.Id);

                comando.ExecuteNonQuery();

            }

            connection.Close();

        }

        public void EliminarIntegrante(Banda banda, Integrante integrante)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.EliminarIntegranteBanda();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id_banda", banda.Id);
            comando.Parameters.AddWithValue("@id_integrante", integrante.Id);

            comando.ExecuteNonQuery();


            connection.Close();

        }

        public List<Banda> ListarBandas()
        {

            List<Banda> bandas = new List<Banda>();

            Banda banda = new Banda();

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.ListarBandas();

            SqlCommand comando = new SqlCommand(cmd, connection);

            SqlDataReader resultado = comando.ExecuteReader();

            connection.Close();

            while (resultado.Read())
            {
                banda.Id = Convert.ToInt32(resultado["id"]);
                banda.Nombre = Convert.ToString(resultado["nombre"]);
                banda.AnioCreacion = Convert.ToInt32(resultado["anio_creacion"]);
                banda.AnioSeparacion = Convert.ToInt32(resultado["anio_separacion"]);
                banda.GeneroMusical = Convert.ToString(resultado["genero"]);

                bandas.Add(banda);
            }

            return bandas;
        }

        public Banda BuscarBanda(int bId)
        {

            Banda banda = new Banda();

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.BuscarBanda();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", bId);

            SqlDataReader resultado = comando.ExecuteReader();

            connection.Close();

            while (resultado.Read())
            {

                banda.Id = Convert.ToInt32(resultado["id"]);
                banda.Nombre = Convert.ToString(resultado["nombre"]);
                banda.AnioCreacion = Convert.ToInt32(resultado["anio_creacion"]);
                banda.AnioSeparacion = Convert.ToInt32(resultado["anio_separacion"]);
                banda.GeneroMusical = Convert.ToString(resultado["genero"]);

            }

            return banda;
        }

    }
}

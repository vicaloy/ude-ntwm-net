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
public class DAOIntegrante
{

        public Query query = new Query();

        static DAOIntegrante instance;

        public DAOIntegrante() { }

        public static DAOIntegrante Instance()
        {
            if (instance == null)
            {
                instance = new DAOIntegrante();
            }
            return instance;
        }

        public void InsertarIntegrante(Integrante integrante)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.AgregarIntegrante();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", integrante.Id);
            comando.Parameters.AddWithValue("@nombre", integrante.Nombre);
            comando.Parameters.AddWithValue("@apellido", integrante.Apellido);
            comando.Parameters.AddWithValue("@nacimiento", integrante.FechaNacimiento);
            comando.Parameters.AddWithValue("@foto", integrante.Foto);

            comando.ExecuteNonQuery();

            connection.Close();
        }

        public void ModificarIntegrante(Integrante integrante)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.ModificarIntegrante();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", integrante.Id);
            comando.Parameters.AddWithValue("@nombre", integrante.Nombre);
            comando.Parameters.AddWithValue("@apellido", integrante.Apellido);
            comando.Parameters.AddWithValue("@nacimiento", integrante.FechaNacimiento);
            comando.Parameters.AddWithValue("@foto", integrante.Foto);

            comando.ExecuteNonQuery();

            connection.Close();

        }

        public void EliminarIntegrante(Integrante integrante)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.EliminarIntegrante();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", integrante.Id);

            comando.ExecuteNonQuery();

            connection.Close();

        }

    }
}

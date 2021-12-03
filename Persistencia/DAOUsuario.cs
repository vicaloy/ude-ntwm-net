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
    public class DAOUsuario
    {

        public Query query = new Query();

        static DAOUsuario instance;

        private DAOUsuario()
        {

        }

        public static DAOUsuario Instance()
        {
            if (instance == null)
            {
                instance = new DAOUsuario();
            }
            return instance;
        }

        public void InsertarUsuario(Usuario usuario)
        {
            try { 
                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                string cmd = query.AgregarUsuario();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@id", usuario.Id);
                comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@usuario", usuario.User);
                comando.Parameters.AddWithValue("@password", usuario.Password);

                comando.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidarPassword(Usuario usuario)
        {
            try { 
                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                string cmd = query.ValidarContrasena();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@usuario", usuario.User);

                SqlDataReader resultado = comando.ExecuteReader();

                resultado.Read();

                connection.Close();

                if (usuario.Password != resultado["password"])
                {
                    return false;
                }
                else
                {
                    return true;
                }

                }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

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
    class DAOResena
    {

        public Query query = new Query();

        static DAOResena instance;

        private DAOResena()
        {

        }

        public static DAOResena Instance()
        {
            if (instance == null)
            {
                instance = new DAOResena();
            }
            return instance;
        }

        public void InsertarResena(Resena resena)
        {

            String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);

            connection.Open();

            string cmd = query.DarResena();

            SqlCommand comando = new SqlCommand(cmd, connection);

            comando.Parameters.AddWithValue("@id", resena.Id);
            comando.Parameters.AddWithValue("@objeto", resena.Id_Objeto);
            comando.Parameters.AddWithValue("@tipo", resena.Tipo);
            comando.Parameters.AddWithValue("@puntaje", resena.Puntaje);
            comando.Parameters.AddWithValue("@texto", resena.Texto);

            comando.ExecuteNonQuery();

            connection.Close();
        }

    }

}

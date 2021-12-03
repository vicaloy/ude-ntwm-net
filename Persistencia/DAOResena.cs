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
    public class DAOResena
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
            try { 
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Resena> ListarResena(int objeto, string tipo)
        {
            try { 
                List<Resena> resenas = new List<Resena>();

                Resena resena = new Resena();

                String con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);

                connection.Open();

                string cmd = query.ListarResena();

                SqlCommand comando = new SqlCommand(cmd, connection);

                comando.Parameters.AddWithValue("@objeto", objeto);
                comando.Parameters.AddWithValue("@tipo", tipo);

                SqlDataReader resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    resena.Id = Convert.ToInt32(resultado["id"]);
                    resena.Id_Objeto = Convert.ToInt32(resultado["id_objeto"]);
                    resena.Tipo = Convert.ToString(resultado["tipo"]);
                    resena.Puntaje = Convert.ToInt32(resultado["puntaje"]);
                    resena.Texto = Convert.ToString(resultado["texto"]);

                    resenas.Add(resena);
                }

                connection.Close();

                return resenas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}

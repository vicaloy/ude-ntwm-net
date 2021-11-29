using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Password { get; set; }


        public  Usuario() { }

        public  Usuario(int nId, string nNombre, string nUsuario, string nPassword)
        {

            Id = nId;
            Nombre = nNombre;
            User = nUsuario;
            Password = nPassword;

        }

    }
}

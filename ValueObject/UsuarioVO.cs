using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    class UsuarioVO
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Password { get; set; }


        public UsuarioVO() { }

        public UsuarioVO(int nId, string nNombre, string nUsuario, string nPassword)
        {

            Id = nId;
            Nombre = nNombre;
            User = nUsuario;
            Password = nPassword;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Integrante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte[] Foto { get; set; }

        public Integrante() { }

        public Integrante(int nId, string nNombre, string nApellido, DateTime nFechaNacimiento, byte[] nFoto)
        {

            Id = nId;
            Nombre = nNombre;
            Apellido = nApellido;
            FechaNacimiento = nFechaNacimiento;
            Foto = nFoto;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ResenaVO
    {

        public int Id { get; set; }
        public int Id_Objeto { get; set; }
        public string Tipo { get; set; }
        public int Puntaje { get; set; }
        public string Texto { get; set; }

        public ResenaVO() { }

        public ResenaVO(int nId, int nObjeto, string nTipo, int nPuntaje, string nTexto)
        {

            Id = nId;
            Id_Objeto = nObjeto;
            Tipo = nTipo;
            Puntaje = nPuntaje;
            Texto = nTexto;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class CancionVO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Duracion { get; set; }
        public int Anio { get; set; }
        public string GeneroMusical { get; set; }
        public List<BandaVO> Bandas { get; set; }

        public CancionVO() { }

        public CancionVO(int nId, string nNombre, float nDuracion, int nAnio, string nGeneroMusica, List<BandaVO> nBandas)
        {

            Id = nId;
            Nombre = nNombre;
            Duracion = nDuracion;
            Anio = nAnio;
            GeneroMusical = nGeneroMusica;
            Bandas = nBandas;
        }

    }
}

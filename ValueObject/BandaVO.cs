using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class BandaVO
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string GeneroMusical { get; set; }
        public int AnioCreacion { get; set; }
        public int AnioSeparacion { get; set; }
        public List<IntegranteVO> Integrantes { get; set; }

        public BandaVO() { }

        public BandaVO(int nId, string nNombre, string nGeneroMusical, int nAnioCreacion, int nAnioSeparacion, List<IntegranteVO> nIntegrantes)
        {

            Id = nId;
            Nombre = nNombre;
            GeneroMusical = nGeneroMusical;
            AnioCreacion = nAnioCreacion;
            AnioSeparacion = nAnioSeparacion;
            Integrantes = nIntegrantes;

        }

    }
}

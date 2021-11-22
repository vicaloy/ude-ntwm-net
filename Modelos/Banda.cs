using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Banda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string GeneroMusical { get; set; }
        public int AnioCreacion { get; set; }
        public int AnioSeparacion { get; set; }
        public List<Integrante> Integrantes { get; set; }

        public Banda() { }

        public Banda(int nId, string nNombre, string nGeneroMusical, int nAnioCreacion, int nAnioSeparacion)
        {

            Id = nId;
            Nombre = nNombre;
            GeneroMusical = nGeneroMusical;
            AnioCreacion = nAnioCreacion;
            AnioSeparacion = nAnioSeparacion;

        }
        public void AgregarIntegrante(Integrante integrante)
        {
            Integrantes.Add(integrante);
        }
        public void QuitarIntegrante(Integrante integrante)
        {
            Integrantes.Remove(integrante);
        }
    }
}

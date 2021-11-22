using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Duracion { get; set; }
        public int Anio { get; set; }
        public string GeneroMusical { get; set; }
        public List<Banda> Bandas { get; set; }

        public Cancion() { }

        public Cancion(int nId, string nNombre, float nDuracion, int nAnio, string nGeneroMusica)
        {

            Id = nId;
            Nombre = nNombre;
            Duracion = nDuracion;
            Anio = nAnio;
            GeneroMusical = nGeneroMusica;

        }

        public void AgregarBanda(Banda nBanda)
        {

            Bandas.Add(nBanda);

        }

        public void QuitarBanda(Banda rBanda)
        {

            Bandas.Remove(rBanda);

        }
    }
}

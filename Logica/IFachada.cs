using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace Logica
{
    public interface IFachada
    {
        void InsertarIntegrante(IntegranteVO integranteVO);
        void ModificarIntegrante(IntegranteVO integranteVO);
        void EliminarIntegrante(IntegranteVO integranteVO);
    }
}

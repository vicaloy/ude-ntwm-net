using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace Logica
{
    public interface IFachadaWeb
    {

        void RegistrarUsuario(UsuarioVO nUsuario);

        void InsertarResena(ResenaVO nResena);

        List<ResenaVO> ListarResenas(int objeto, string tipo);

    }
}

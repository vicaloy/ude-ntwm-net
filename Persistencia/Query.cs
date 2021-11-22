using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Query
    {
        public Query()
        {

        }
        public string AgregarIntegrante() { return "INSERT INTO dbo.integrante (id, nombre, apellido, nacimiento, foto) VALUES (@id, @nombre, @apellido, @nacimiento, @foto)"; }

        public string AgregarCancion() { return "INSERT INTO dbo.cancion (id, nombre, duracion, genero, anio) VALUES (@id, @nombre, @duracion, @genero, @anio)"; }

        public string AgregarBanda() { return "INSERT INTO dbo.banda (id, anio_separacion, anio_creacion, nombre, genero) VALUES (@id, @anio_separacion, @anio_creacion, @nombre, @genero)"; }

        public string AgregarAlbum() { return "INSERT INTO dbo.album (id, anio_creacion, nombre, genero, id_banda) VALUES (@id, @anio_creacion, @nombre, @genero, @banda)"; }

        public string AgregarCancionAlbum() { return "INSERT INTO dbo.pertenece (id_album, id_cancion) VALUES (@id_album, @id_cancion)"; }

        public string AgregarIntegranteBanda() { return "INSERT INTO dbo.integra (id_integrante, id_banda) VALUES (@id_integrante, @id_banda)"; }

        public string AgregarBandaCancion() { return "INSERT INTO dbo.compuso (id_banda, id_cancion) VALUES (@id_banda, @id_cancion)"; }

        public string ModificarIntegrante() { return "UPDATE dbo.integrante SET nombre = @nombre, apellido = @apellido, nacimiento = @nacimiento, foto = @foto WHERE id = @id"; }

        public string ModificarCancion() { return "UPDATE dbo.cancion SET nombre = @nombre, duracion = @duracion, genero = @genero, anio = @anio WHERE id = @id"; }

        public string ModificarBanda() { return "UPDATE dbo.banda SET anio_separacion = @anio_separacion, anio_creacion = @anio_creacion, nombre = @nombre, genero = @genero WHERE id = @id"; }

        public string ModificarAlbum() { return "UPDATE dbo.album SET anio_creacion = @anio_creacion, nombre = @nombre, genero = @genero, id_banda = @banda WHERE id = @id"; }

        public string EliminarIntegrante() { return "DELETE FROM dbo.integrante WHERE id = @id"; }

        public string EliminarCancion() { return "DELETE FROM dbo.cancion WHERE id = @id"; }

        public string EliminarBanda() { return "DELETE FROM dbo.banda WHERE id = @id"; }

        public string EliminarAlbum() { return "DELETE FROM dbo.album WHERE id = @id"; }

        public string EliminarBandaCancion() { return "DELETE FROM dbo.compuso WHERE id_banda = @id_banda, id_cancion = @id_cancion"; }

        public string EliminarIntegranteBanda() { return "DELETE FROM dbo.integra WHERE id_integrante = @id_integrante, id_banda = @id_banda"; }

        public string EliminarCancionAlbum() { return "DELETE FROM dbo.pertenece WHERE id_cancion = @id_cancion, id_album = @id_album"; }

        public string ListarIntegrantes() { return "SELECT * FROM dbo.integrante"; }

        public string ListarCanciones() { return "SELECT * FROM dbo.cancion"; }

        public string ListarBandas() { return "SELECT * FROM dbo.banda"; }

        public string ListarAlbumes() { return "SELECT * FROM dbo.album"; }

        public string BuscarIntegrante() { return "SELECT * FROM dbo.integrante WHERE id = @id"; }

        public string BuscarCancion() { return "SELECT * FROM dbo.cancion WHERE id = @id"; }

        public string BuscarBanda() { return "SELECT * FROM dbo.banda WHERE id = @id"; }

        public string BuscarAlbum() { return "SELECT * FROM dbo.album WHERE id = @id"; }

    }
}

using SistemaUsuarios.Negocio;
using SistemaUsuarios.Presentacion;

namespace SistemaUsuarios
{
    class Program
    {
        static void Main()
        {
            SistemaUsuariosService servicio = new SistemaUsuariosService();
            Consola consola = new Consola();

            var usuarios = servicio.ObtenerUsuarios();

            consola.MostrarUsuarioValido(servicio.UsuarioEsValido(usuarios[0]));
            consola.MostrarUsuarios(usuarios);
        }
    }
}

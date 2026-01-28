using System.Collections.Generic;
using SistemaUsuarios.Entidades;

namespace SistemaUsuarios.Negocio
{
    class SistemaUsuariosService
    {
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario { Id = 1, Nombre = "Ana" });
            usuarios.Add(new Usuario { Id = 2, Nombre = "Luis" });

            return usuarios;
        }

        public bool UsuarioEsValido(Usuario usuario)
        {
            return usuario.Id > 0;
        }
    }
}

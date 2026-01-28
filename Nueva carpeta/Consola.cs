using System;
using System.Collections.Generic;
using SistemaUsuarios.Entidades;

namespace SistemaUsuarios.Presentacion
{
    class Consola
    {
        public void MostrarUsuarios(List<Usuario> usuarios)
        {
            Console.WriteLine("Usuarios del sistema:");
            foreach (Usuario u in usuarios)
            {
                Console.WriteLine(u.Id + " - " + u.Nombre);
            }
        }

        public void MostrarUsuarioValido(bool esValido)
        {
            if (esValido)
            {
                Console.WriteLine("Usuario valido");
            }
        }
    }
}

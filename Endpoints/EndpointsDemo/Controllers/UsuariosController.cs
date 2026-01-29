using Microsoft.AspNetCore.Mvc;
using EndpointsDemo.Models;
using System.Collections.Generic;
using System.Linq;


namespace EndpointsDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        static List<Usuario> usuarios = new();
        static int contadorId = 1;

        [HttpPost]
        public IActionResult CrearUsuario([FromBody] Usuario nuevo)
        {
            nuevo.Id = contadorId++;
            usuarios.Add(nuevo);
            return Ok(nuevo);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuario(int userid)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Id == userid);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpPost("crear-nuevo")]
        public IActionResult CrearNuevo()
        {
            return Ok("Nuevo usuario creado");
        }
    }
}

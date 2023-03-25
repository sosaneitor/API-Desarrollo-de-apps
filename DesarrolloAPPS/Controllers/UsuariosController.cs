using Microsoft.AspNetCore.Mvc;

namespace DesarrolloAPPS.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsuariosController : ControllerBase
    {
        public static List<Usuario> _usuarios;

        public UsuariosController()
        {
            _usuarios = new List<Usuario>
        {
            new Usuario
            {
                Nombre = "Juan Perez",
                Cedula = "123456789",
                Direccion = "Av. Siempreviva 123",
                Telefono = "555-1234",
                FechaNacimiento = new DateTime(1980, 1, 1)
            },
            new Usuario
            {
                Nombre = "Maria Gonzalez",
                Cedula = "987654321",
                Direccion = "Calle Falsa 123",
                Telefono = "555-4321",
                FechaNacimiento = new DateTime(1990, 1, 1)
            }
        };
        }


        [HttpGet(Name = "Listar")]
        public IEnumerable<Usuario> Get()
        {
            return _usuarios;
        }
    }

}

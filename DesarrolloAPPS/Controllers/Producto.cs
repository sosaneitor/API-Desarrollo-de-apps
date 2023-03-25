using Microsoft.AspNetCore.Mvc;

namespace DesarrolloAPPS.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class ProductosController : ControllerBase
    {
        public static List<Producto> _productos;

        public ProductosController()
        {
            _productos = new List<Producto>
        {
            new Producto
            {
                Nombre = "Producto 1",
                Codigo = "123",
                Precio = 10.0m,
                Estado = true
            },
            new Producto
            {
                Nombre = "Producto 2",
                Codigo = "456",
                Precio = 20.0m,
                Estado = false
            }
        };
        }
        [HttpGet(Name = "ListarProductos")]
        public IEnumerable<Producto> Get()
        {
            return _productos;
        }
    }

}

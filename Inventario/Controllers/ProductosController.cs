using ProyectoFinal.Application.DTOS;
using ProyectoFinal.Application.Service;
using ProyectoFinal.Domain.Common;
using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.Domain.Services;
using ProyectoFinal.InfraEstructure;
using ProyectoFinal.InfraEstructure.Common;
using System.Data.Entity;
using System.Web.Http;

namespace Inventario.Controllers
{

    [RoutePrefix("api/productos")]
        public class ProductosController : ApiController
        {
            private readonly ProductosAppService _productoAppService;
            public ProductosController()
            {
                ProductosDomainServices domainService = new ProductosDomainServices();
                DbContext dbContext = new ProductosDbContext();
                IRepository<Productos> repository = new Repository<Productos>(dbContext);
                _productoAppService = new ProductosAppService(repository, domainService);
            }

            [HttpPost]
            [Route("")]
            public IHttpActionResult Consulta([FromBody]ProductosDto productosDto)
            {
                bool esValido = _productoAppService.ElProductoExiste(productosDto);
                if (esValido)
                {
                    return Ok($"El producto {productosDto.NombreProducto} se encontro");
                }
                return BadRequest("Producto no encontrado");
            }
    }
}

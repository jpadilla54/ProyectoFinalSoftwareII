using ProyectoFinal.Application.DTOS;
using ProyectoFinal.Domain.Common;
using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.Domain.Services;

namespace ProyectoFinal.Application.Service
{
    public class ProductosAppService
    {
        private readonly IRepository<Productos> _repository;
        private readonly ProductosDomainServices _productosDomainService;

       
        public ProductosAppService(IRepository<Productos> repository,
            ProductosDomainServices productosDomainService)
            {
                _repository = repository;
                _productosDomainService = productosDomainService;
            }

        public bool ElProductoExiste(ProductosDto productosDto)
        {
            Productos productos = _repository.Obtener(u => u.NombreProducto == productosDto.NombreProducto);
            bool esValido = _productosDomainService
                .ElProductoExiste(productos, productosDto.NombreProducto);

            return esValido;
        }
    }
}

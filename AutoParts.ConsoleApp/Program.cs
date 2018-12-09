using ProyectoFinal.Application.DTOS;
using ProyectoFinal.Application.Service;
using ProyectoFinal.Domain.Common;
using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.Domain.Services;
using ProyectoFinal.InfraEstructure;
using ProyectoFinal.InfraEstructure.Common;
using System;
using System.Data.Entity;

namespace AutoParts.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductosAppService appService = GetAppService();
            ProductosDto producto = new ProductosDto();
            Console.WriteLine("Inrese el nombre del Producto a buscar:");
            producto.NombreProducto = Console.ReadLine();

            
            bool esValido = appService.ElProductoExiste(producto);
            if (esValido)
            {
                Console.WriteLine($"El producto {producto.NombreProducto} se encontro correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"No se encontro el producto {producto.NombreProducto}");
                Console.ReadKey();
            }
            
        }
        static ProductosAppService GetAppService()
        {
            ProductosDomainServices domainService = new ProductosDomainServices();
            DbContext dbContext = new ProductosDbContext();
            IRepository<Productos> repository = new Repository<Productos>(dbContext);
            return new ProductosAppService(repository, domainService);
        }
    }
}

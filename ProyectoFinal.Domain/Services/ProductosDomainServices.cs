using ProyectoFinal.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Services
{
    public class ProductosDomainServices
    {
        public bool ElProductoExiste(Productos productos, string Nombre)
        {
            if (productos == null)
            {
                return false;
            }
            if (productos.NombreProducto != Nombre)
            {
                return false;
            }
            return true;
        }

    }
}

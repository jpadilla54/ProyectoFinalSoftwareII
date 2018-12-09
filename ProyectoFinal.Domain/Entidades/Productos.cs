using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Entidades
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string PrecioCompra { get; set; }
        public string PrecioVenta { get; set; }
        public string Stock_Min { get; set; }
        public string Stock_Max { get; set; }
        public int IdProveedor { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public int IdAlmacen { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Entidades
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string IdProveedor { get; set; }
        public string Producto { get; set; }
        public string Cantidad { get; set; }
    }
}

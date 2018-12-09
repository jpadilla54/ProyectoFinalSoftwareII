using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Entidades
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
    }
}

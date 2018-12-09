using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Entidades
{
    public class Historico
    {
        public int IdHistorico { get; set; }
        public string NumeroFactura { get; set; }
        public int IdProductos { get; set; }
        public int Cantidad { get; set; }
        public string Fecha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Entidades
{
    public class Almacen
    {
        public int IdAlmacen { get; set; }
        public string Nombre { get; set; }
        public string Lote { get; set; }
        public string FechaEntrada { get; set; }
        public string FechaSalida { get; set; }
        public int Cantidad { get; set; }
    }
}

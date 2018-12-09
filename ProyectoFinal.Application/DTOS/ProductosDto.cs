namespace ProyectoFinal.Application.DTOS
{
    public class ProductosDto
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

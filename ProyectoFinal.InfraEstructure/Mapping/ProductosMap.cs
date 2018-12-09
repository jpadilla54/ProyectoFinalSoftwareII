using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ProyectoFinal.Domain.Entidades;

namespace ProyectoFinal.InfraEstructure.Mapping
{
    public class ProductosMap : EntityTypeConfiguration<Productos>
    {
        public ProductosMap()
        {
            ToTable("Productos");
            HasKey(p => p.IdProducto);
            Property(p => p.IdProducto).HasColumnName("IdProducto").IsRequired();
            Property(p => p.NombreProducto).HasColumnName("NombreProducto").HasMaxLength(50).IsRequired();
            Property(p => p.PrecioCompra).HasColumnName("PrecioCompra").IsRequired();
            Property(p => p.PrecioVenta).HasColumnName("PrecioVenta").IsRequired();
            Property(p => p.IdMarca).HasColumnName("IdMarca").IsRequired();
            Property(p => p.IdCategoria).HasColumnName("IdCategoria").IsRequired();
            Property(p => p.Stock_Max).HasColumnName("Stock_Max").IsRequired();
            Property(p => p.Stock_Min).HasColumnName("Stock_Min").IsRequired();
        }
    }
}

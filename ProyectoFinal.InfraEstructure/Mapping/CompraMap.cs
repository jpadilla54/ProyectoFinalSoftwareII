using System.Data.Entity.ModelConfiguration;
using ProyectoFinal.Domain.Entidades;

namespace ProyectoFinal.InfraEstructure.Mapping
{
    public class CompraMap : EntityTypeConfiguration<Compra>
    {
        public CompraMap()
        {
            ToTable("Compra");
            HasKey(p => p.IdCompra);
            Property(p => p.IdCompra).HasColumnName("IdCompra").IsRequired();
            Property(p => p.IdProveedor).HasColumnName("IdProveedor").IsRequired();
            Property(p => p.Cantidad).HasColumnName("Cantidad").IsRequired();
            Property(p => p.Producto).HasColumnName("Producto").HasMaxLength(50).IsRequired();
        }
    }
}

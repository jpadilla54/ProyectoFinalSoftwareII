using System.Data.Entity.ModelConfiguration;
using ProyectoFinal.Domain.Entidades;

namespace ProyectoFinal.InfraEstructure.Mapping
{
    public class AlmacenMap : EntityTypeConfiguration<Almacen>
    {
        public AlmacenMap()
        {
            ToTable("Almacen");
            HasKey(p => p.IdAlmacen);
            Property(p => p.IdAlmacen).HasColumnName("IdAlmacen").IsRequired();
            Property(p => p.Nombre).HasColumnName("Nombre").HasMaxLength(50).IsRequired();
            Property(p => p.FechaEntrada).HasColumnName("FechaEntrada").HasMaxLength(50).IsRequired();
            Property(p => p.FechaSalida).HasColumnName("FechaSalida").HasMaxLength(50).IsRequired();
            Property(p => p.Cantidad).HasColumnName("Cantidad").IsRequired();
            Property(p => p.Lote).HasColumnName("Lote").HasMaxLength(50).IsRequired();
        }
    }
}

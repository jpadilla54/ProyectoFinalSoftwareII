using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ProyectoFinal.Domain.Entidades;

namespace ProyectoFinal.InfraEstructure.Mapping
{
    public class ProveedorMap : EntityTypeConfiguration<Proveedor>
    {
        public ProveedorMap()
        {
            ToTable("Proveedor");
            HasKey(p => p.IdProveedor);
            Property(p => p.IdProveedor).HasColumnName("IdProveedor").IsRequired();
            Property(p => p.NombreProveedor).HasColumnName("NombreProveedor").HasMaxLength(50).IsRequired();
            Property(p => p.Celular).HasColumnName("Celular").HasMaxLength(50).IsRequired();
            Property(p => p.Direccion).HasColumnName("Direccion").HasMaxLength(50).IsRequired();
            Property(p => p.Telefono).HasColumnName("Telefono").HasMaxLength(50).IsRequired();
        }
    }
}

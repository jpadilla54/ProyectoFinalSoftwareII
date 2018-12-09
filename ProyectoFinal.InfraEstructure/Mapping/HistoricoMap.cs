using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ProyectoFinal.Domain.Entidades;

namespace ProyectoFinal.InfraEstructure.Mapping
{
    public class HistoricoMap : EntityTypeConfiguration<Historico>
    {
        public HistoricoMap()
        {
            ToTable("Historico");
            HasKey(p => p.IdHistorico);
            Property(p => p.IdHistorico).HasColumnName("IdHistorico").IsRequired();
            Property(p => p.Cantidad).HasColumnName("Cantidad").IsRequired();
            Property(p => p.Fecha).HasColumnName("Fecha").HasMaxLength(50).IsRequired();
            Property(p => p.IdProductos).HasColumnName("IdProductos").IsRequired();
            Property(p => p.NumeroFactura).HasColumnName("NumeroFatura").IsRequired();
        }
    }
}

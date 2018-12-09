using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ProyectoFinal.Domain.Entidades;

namespace ProyectoFinal.InfraEstructure.Mapping
{
    public class MarcaMap : EntityTypeConfiguration<Marca>
    {
        public MarcaMap()
        {
            ToTable("Marca");
            HasKey(p => p.IdMarca);
            Property(p => p.IdMarca).HasColumnName("IdMarca").IsRequired();
            Property(p => p.NombreMarca).HasColumnName("NombreMarca").HasMaxLength(50).IsRequired();
        }
    }
}

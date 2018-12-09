using System.Data.Entity.ModelConfiguration;
using ProyectoFinal.Domain.Entidades;

namespace ProyectoFinal.InfraEstructure.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("Categoria");
            HasKey(p => p.IdCategoria);
            Property(p => p.IdCategoria).HasColumnName("IdCategoria").IsRequired();
            Property(p => p.NombreCate).HasColumnName("NombreCate").HasMaxLength(50).IsRequired();
        }
    }
}

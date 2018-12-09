using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.InfraEstructure.Mapping;
using System.Data.Entity;

namespace ProyectoFinal.InfraEstructure
{
    public class CategoriaDbContext : DbContext
    {
       
        public CategoriaDbContext(): base("AutoParts")
        {
        }

        
        public DbSet<Categoria> Categoria{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaMap());
            base.OnModelCreating(modelBuilder);
        }
    }




}

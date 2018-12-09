using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.InfraEstructure.Mapping;
using System.Data.Entity;

namespace ProyectoFinal.InfraEstructure
{
    public class ProductosDbContext : DbContext
    {
       
        public ProductosDbContext(): base("AutoParts")
        {
        }

        public DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductosMap());
            base.OnModelCreating(modelBuilder);
        }
    }




}

using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.InfraEstructure.Mapping;
using System.Data.Entity;

namespace ProyectoFinal.InfraEstructure
{
    public class CompraDbContext : DbContext
    {
       
        public CompraDbContext(): base("AutoParts")
        {
        }
        
        public DbSet<Compra> Compra{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CompraMap());
            base.OnModelCreating(modelBuilder);
        }
    }




}

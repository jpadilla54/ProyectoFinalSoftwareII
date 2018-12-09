using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.InfraEstructure.Mapping;
using System.Data.Entity;

namespace ProyectoFinal.InfraEstructure
{
    public class AlmacenDbContext : DbContext
    {
       
        public AlmacenDbContext(): base("AutoParts")
        {
        }

        
        public DbSet<Almacen> Almacen{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlmacenMap());
            base.OnModelCreating(modelBuilder);
        }
    }




}

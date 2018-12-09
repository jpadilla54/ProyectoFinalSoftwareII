using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.InfraEstructure.Mapping;
using System.Data.Entity;

namespace ProyectoFinal.InfraEstructure
{
    public class MarcaDbContext : DbContext
    {
       
        public MarcaDbContext(): base("AutoParts")
        {
        }
        
        public DbSet<Marca> Marca { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MarcaMap());
            base.OnModelCreating(modelBuilder);
        }
    }




}

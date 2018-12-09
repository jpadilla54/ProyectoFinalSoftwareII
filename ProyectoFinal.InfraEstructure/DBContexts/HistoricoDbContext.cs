using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.InfraEstructure.Mapping;
using System.Data.Entity;

namespace ProyectoFinal.InfraEstructure
{
    public class HistoricoDbContext : DbContext
    {
       
        public HistoricoDbContext(): base("AutoParts")
        {
        }
   
        public DbSet<Historico> Historico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HistoricoMap());
            base.OnModelCreating(modelBuilder);
        }
    }




}

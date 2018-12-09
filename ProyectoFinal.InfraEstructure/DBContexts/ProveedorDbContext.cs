using ProyectoFinal.Domain.Entidades;
using ProyectoFinal.InfraEstructure.Mapping;
using System.Data.Entity;

namespace ProyectoFinal.InfraEstructure
{
    public class ProveedorDbContext : DbContext
    {
       
        public ProveedorDbContext(): base("AutoParts")
        {
        }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProveedorMap());
            base.OnModelCreating(modelBuilder);
        }
    }




}

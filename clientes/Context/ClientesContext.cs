using clientes.Models;
using Microsoft.EntityFrameworkCore;

namespace clientes.Context
{
    public class ClientesContext :DbContext
    {
        public ClientesContext(DbContextOptions<ClientesContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var cliente = modelBuilder.Entity<Cliente>();

            cliente.HasKey(c => c.Id);
            cliente.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            cliente.Property(c => c.Sobrenome).IsRequired().HasMaxLength(100);
            cliente.Property(c => c.Idade).IsRequired().HasDefaultValue(0);
        }
    }
}
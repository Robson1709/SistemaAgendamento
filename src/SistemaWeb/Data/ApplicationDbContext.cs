using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaWeb.Models;

namespace SistemaWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<TipoServico> TipoServicos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using MySite.Models;

namespace MySite.Data
{
    public class MySiteContext : DbContext
    {
        public MySiteContext (DbContextOptions<MySiteContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; } = default!;
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Venda> Venda { get; set; }
    }
}

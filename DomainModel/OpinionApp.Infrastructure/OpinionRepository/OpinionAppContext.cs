using Microsoft.EntityFrameworkCore;
using OpinionApp.Core;

namespace OpinionApp.Infrastructure.OpinionRepository
{
    public sealed class OpinionAppContext : DbContext
    {
        public OpinionAppContext(DbContextOptions<OpinionAppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Opinion> Opinions { get; set; }
    }
}

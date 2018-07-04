using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpinionApp.Core;

namespace OpinionApp.Infrastructure.ObjectiveRepository
{
    public sealed class ObjectiveAppContext : DbContext
    {
        public ObjectiveAppContext(DbContextOptions<ObjectiveAppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Objective> Objectives { get; set; }
    }
}

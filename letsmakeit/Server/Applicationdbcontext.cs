using letsmakeit.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace letsmakeit.Server
{
    public class Applicationdbcontext : DbContext
    {
        public Applicationdbcontext(DbContextOptions<Applicationdbcontext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class1>().HasKey(x => new { x.ID });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Class1> Class1Set { get; set; }
    }
}

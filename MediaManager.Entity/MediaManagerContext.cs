using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaManager.Entity
{
    public class MediaManagerContext : DbContext, IDisposable
    {
        public MediaManagerContext()
        {

        }

        public MediaManagerContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MediaManager;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Saison> Saisons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Acteur> Acteurs { get; set; }
        public DbSet<Serie> Series { get; set; }
    }
}

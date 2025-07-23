using CodeFirstBasic.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PatikaCodeFirstDb1;Trusted_Connection=True;");
        }

        public DbSet<MovieEntity> Movies { get; set; }

        public DbSet<GameEntity> Games { get; set; }
    }
}

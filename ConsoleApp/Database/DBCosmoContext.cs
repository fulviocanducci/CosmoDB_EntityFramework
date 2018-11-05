using Microsoft.EntityFrameworkCore;
using Models;
namespace ConsoleApp.Database
{
    public class DBCosmoContext: DbContext
    {
        public DbSet<People> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
                ConfigurationDBCosmo.URI,
                ConfigurationDBCosmo.PrimaryKey,
                ConfigurationDBCosmo.DatabaseName,
                options =>
                {                    
                }
           );            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>(x =>
            {
                x.ToContainer("people");                
            });
        }

    }
}

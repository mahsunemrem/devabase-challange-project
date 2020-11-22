
using DataAccess.Concrete.EntityFramework.DataSeed;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class EfContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.Development.json", true);

                IConfigurationRoot _configuration = config.Build();
                optionsBuilder.UseSqlServer(_configuration["SqlConnectionString"]);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employee { get; set; } 
   
        

   }
}

            

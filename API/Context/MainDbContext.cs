#pragma warning disable CS8618

using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options) { }
        public MainDbContext() { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();

                var connectionString = configuration.
                    GetConnectionString("DefaultConnection");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }
}

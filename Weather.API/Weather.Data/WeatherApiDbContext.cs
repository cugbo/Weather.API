using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Weather.API.Weather.Data.Configurations;
using Weather.API.Weather.Models;

namespace Weather.API.Weather.Data
{
    public class WeatherApiDbContext : IdentityDbContext<User>
    {
        public WeatherApiDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Weathers> Weathers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new WeatherConfiguration());
        }
    }
}

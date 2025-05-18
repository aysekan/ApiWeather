using Microsoft.EntityFrameworkCore;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Context
{
    public class WeatherContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; initial catalog =DbProject;integrated Security = true;TrustServerCertificate=True\r\n");
        }
        public DbSet<City> Cities { get; set; }

    }
}

using Gym_TrackerDWAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gym_TrackerDWAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        public DbSet<CustomerEmail> CustomerEmails { get; set; }
        public DbSet<WeatherData> WeatherData { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace L01_2020HH601.Models
{
    public class RestauranteDBContext : DbContext
    {
        public RestauranteDBContext(DbContextOptions<RestauranteDBContext> options) : base(options)
        {

        }
        public DbSet<RestauranteDBContext> equipos { get; set; }
    }
}

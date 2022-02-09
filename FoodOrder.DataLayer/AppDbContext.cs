using FoodOrder.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.DataLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Mahsulot> Mahsulotlar { get; set;}
        public DbSet<Katagoriya> Katagoriyalar { get; set; }
        public DbSet<User> Userlar { get; set; }
    }
}

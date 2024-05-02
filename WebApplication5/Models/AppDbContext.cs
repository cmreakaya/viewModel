using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Urun> Urunler { get; set; }
    }
}

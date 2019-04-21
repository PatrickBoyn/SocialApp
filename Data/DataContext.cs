using Microsoft.EntityFrameworkCore;
using SocialAppAPI.Models;

namespace SocialAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) {}
        public DbSet<Value> Values { get; set; }
    }
}
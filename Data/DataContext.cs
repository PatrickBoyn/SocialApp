using Microsoft.EntityFrameworkCore;
using SocialAppAPI.Models;

namespace SocialAppAPI.Data
{
    public class DataContext : DbContext
    {
        
        public DbSet<Value> Values { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options) {}
    }
}
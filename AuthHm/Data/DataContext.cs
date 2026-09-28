using AuthHm.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthHm.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        
    }
}

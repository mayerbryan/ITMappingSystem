using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
     public class DatabaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        public DbSet<Device> Devices { get; set; }        
    }
}
using Domain.Models;
using Microsoft.EntityFrameworkCore;



namespace ITMappingSystem.Presentation.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Device> Devices { get; set; }
        
    }
}
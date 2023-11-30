using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMappingSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace ITMappingSystem.Presentation.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Device> Devices { get; set; }
        
    }
}
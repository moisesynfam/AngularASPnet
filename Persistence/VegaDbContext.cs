using Angular_2___Asp_Net.Models;
using Microsoft.EntityFrameworkCore;

namespace Angular_2___Asp_Net.Persistence
{
    public class VegaDbContext : DbContext
    {
        
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            :base(options)
        {
        
        }

        public DbSet<Make> Makes{ get; set; }
    }
}
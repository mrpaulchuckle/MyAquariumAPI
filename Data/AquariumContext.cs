using Microsoft.EntityFrameworkCore;
using MyAquariumAPI.Models;

namespace MyAquariumAPI.Data
{
    public class AquariumContext : DbContext, IAquariumContext
    {
        public AquariumContext(DbContextOptions<AquariumContext> opt) : base(opt)
        { }

        public DbSet<Tank> Tanks { get; set; }
    }
}

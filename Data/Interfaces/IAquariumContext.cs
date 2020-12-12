using Microsoft.EntityFrameworkCore;
using MyAquariumAPI.Models;

namespace MyAquariumAPI.Data
{
    public interface IAquariumContext
    {
        public DbSet<Tank> Tanks { get; set; }
    }
}

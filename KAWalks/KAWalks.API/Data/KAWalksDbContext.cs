using KAWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace KAWalks.API.Data
{
    
    public class KAWalksDbContext : DbContext
    {
        public KAWalksDbContext(DbContextOptions <KAWalksDbContext> options):base(options)
        {

        }
        public DbSet<Region>Regions { get; set; }
        public DbSet<Walk>Walks { get; set; }
        public DbSet<WalkDifficulty>WalkDifficulty { get; set; }
    }
  

}

using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Data
{
    public class NzWalksDbContext : DbContext
    {
        public NzWalksDbContext(DbContextOptions<NzWalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> regions { get; set; }
        public DbSet<Walk> walks { get; set; }
        public DbSet<WalkDifficulty> walkDifficulty { get; set; }

    }
}

using Demo_EFCF.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_EFCF.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Player> players { get; set; }
        public DbSet<Club> clubs { get; set; }
        public DbSet<PlayerInformation> playerInfomations { get; set; }
        public DbSet<Position> positions { get; set; }
    }
}

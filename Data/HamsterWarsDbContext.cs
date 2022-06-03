using HamsterWars.Shared;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class HamsterWarsDbContext : DbContext
{
    public HamsterWarsDbContext(DbContextOptions<HamsterWarsDbContext> options)
        : base(options)
    {
    }

    public DbSet<Hamster> Hamsters => Set<Hamster>();
}

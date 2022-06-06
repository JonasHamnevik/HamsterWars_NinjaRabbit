using Data;

namespace Services;

public class HamsterService
{
    private readonly HamsterWarsDbContext _context;

    public HamsterService(HamsterWarsDbContext context)
    {
        _context = context;
    }

    public bool Exists(int id)
    {
        return _context.Hamsters.Any(h => h.Id == id);
    }
}

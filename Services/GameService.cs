using Data;
using HamsterWars.Shared;

namespace Services;

public class GameService
{
    private readonly HamsterWarsDbContext _context;

    public GameService(HamsterWarsDbContext context)
    {
        _context = context;
    }

    //public static HamsterDTO HamsterToDTO(Hamster hamster)
    //{
    //    return new HamsterDTO()
    //    {
    //        Id = hamster.Id,
    //        Name = hamster.Name,
    //        Age = hamster.Age,
    //        FavouriteFood = hamster.FavouriteFood,
    //        Loves = hamster.Loves,
    //        ImageName = hamster.ImageName
    //    };
    //}

    //public IEnumerable<HamsterDTO> CreateHamsterDTOs()
    //{
    //    return _context.Hamsters
    //        .Select(h => HamsterToDTO(h))
    //        .ToList();
    //}

    private int GetRandomHamsterId()
    {
        List<int> hamsterId = _context.Hamsters.Select(h => h.Id).ToList();
        Random random = new Random();

        var hamster = random.Next(0, hamsterId.Count);
        return hamster;
    }
    public Game CreateGame()
    {
        var firstId = GetRandomHamsterId();
        var secondId = GetRandomHamsterId();

        if (secondId == firstId)
            secondId = GetRandomHamsterId();

        Hamster first = _context.Hamsters.FirstOrDefault(x => x.Id == firstId);
        Hamster second = _context.Hamsters.FirstOrDefault(x => x.Id == secondId);

        var game = new Game(first, second);
        return game;
    }

    public bool Play(int firstId, int secondId, int winnerId)
    {
        var first = _context.Hamsters.Where(h => h.Id == firstId).FirstOrDefault<Hamster>();
        var second = _context.Hamsters.Where(h => h.Id == secondId).FirstOrDefault<Hamster>();
        if (firstId == winnerId)
        {
            first.Wins++;
            first.Games++;
            second.Games++;
            second.Losses++;
        }
        else
        {
            second.Wins++;
            second.Games++;
            first.Games++;
            first.Losses++;
        }
        _context.SaveChanges();
        return true;
    }
}
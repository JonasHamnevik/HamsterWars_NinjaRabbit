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

    public bool Play(Hamster first, Hamster second, int winnerId)
    {
        first = _context.Hamsters.Where(h => h.Id == first.Id).FirstOrDefault<Hamster>();
        second = _context.Hamsters.Where(h => h.Id == second.Id).FirstOrDefault<Hamster>();

        if (first.Id == winnerId)
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
        _context.SaveChangesAsync();
        return true;
    }
}
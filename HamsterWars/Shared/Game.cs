namespace HamsterWars.Shared;

public class Game
{
    public Hamster First { get; set; }
    public Hamster Second { get; set; }

    public Game(Hamster first, Hamster second)
    {
        if (first is null)
            throw new ArgumentNullException();

        First = first;
        Second = second;
    }
}
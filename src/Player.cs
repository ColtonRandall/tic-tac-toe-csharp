namespace TicTacToe;

public class Player : IPlayerType
{
    public string? Name { get; set; }

    // public Player(string? name)
    // {
    //     _name = name;
    // }

    public Turn TakeTurn()
    {
        return null;
    }

    public string? GetPlayerName()
    {
        Console.WriteLine("What's your name?");
        Name = Console.ReadLine();
        Console.WriteLine($"Welcome {Name}\n");
        return Name;
    }
}
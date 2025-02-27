namespace TicTacToe;

public class Computer : IPlayerType
{
    private readonly string?[] _computerNames = { "Jeff", "David", "Anthony", "Chuck", "Liam" };
    public string? name { get; set; }

    public string? GetPlayerName()
    {
        var randomNum = new Random().Next(0, 5);
        name = _computerNames[randomNum];
        Console.WriteLine($"Your opponent's name is {name} 🤖");
        return name;
    }

    public Turn TakeTurn()
    {
        return null;
    }
}
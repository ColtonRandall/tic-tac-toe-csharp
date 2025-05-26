using TicTacToe.Data;

namespace TicTacToe;

public class Computer : IPlayerType
{
    Names computer = new Names();

    public string? name { get; set; }

    public string? GetPlayerName()
    {
        var randomNum = new Random().Next(0, 5);
        name = computer._computerNames[randomNum];
        Console.WriteLine($"Your opponent's name is {name} 🤖");
        return name;
    }

    public Turn TakeTurn()
    {
        return null; // TODO implement
    }
}
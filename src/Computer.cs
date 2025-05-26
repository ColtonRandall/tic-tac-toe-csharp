using TicTacToe.Data;

namespace TicTacToe;

public class Computer : IPlayerType
{
    Names computer = new Names();
    public string name { get; set; } = "Computer"; // Default computer name

    public string GetPlayerName()
    {
        var randomNum = new Random().Next(0, 5);
        name = computer._computerNames[randomNum];
        Console.WriteLine($"The computer's name is {name} 🤖");
        return name;
    }

    public void TakeTurn(Board board, string computerName, char symbol)
    {
        Thread.Sleep(1000);
        var available = board.GetState().Where(cell => cell != 'X' && cell != 'O').ToArray();
        
        var rand = new Random();

        int move = int.Parse(available[rand.Next(available.Length)].ToString());

        Console.WriteLine($"{computerName} 🤖 puts a '{symbol}' on {move}");
        board.MakeMove(move, symbol);
        Thread.Sleep(1000);
    }
}
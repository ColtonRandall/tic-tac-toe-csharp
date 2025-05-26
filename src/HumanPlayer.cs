namespace TicTacToe;

public class HumanPlayer : IPlayerType
{
    public string Name { get; set; } = "Player"; // Default name

    public void TakeTurn(Board board, string playerName, char symbol)
    {
        int move;
        Console.Write($"{playerName}, enter your move (1-9): ");
        while (!int.TryParse(Console.ReadLine(), out move) || !board.MakeMove(move, symbol))
        {
            Console.Write("Invalid move. Try again: ");
        }
        Console.WriteLine($"{playerName}, puts a '{symbol}' on {move}.");
    }

    public string GetPlayerName()
    {
        Console.WriteLine("What's your name?\n");
        var input = Console.ReadLine();
        Name = input ?? "Player";
        Console.WriteLine($"Welcome {Name}\n");
        return Name;
    }
}
namespace TicTacToe;

public class Board
{
    private const string BoardLines = "---|---|---";

    public static void GenerateBoard()
    {
        for (var i = 0; i < 4; i++) Console.WriteLine(BoardLines);
    }
}
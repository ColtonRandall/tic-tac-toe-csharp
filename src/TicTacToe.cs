using static System.Threading.Thread;

namespace TicTacToe;

public class TicTacToe
{
    const string welcomeBorder = " X O X O X O X O X O X O X  \n";

    public static void Main(string[] args)
    {
        Console.WriteLine(welcomeBorder);
        Console.WriteLine("  Welcome to Tic Tac Toe \n");
        Console.WriteLine(welcomeBorder);

        var player = new HumanPlayer();

        player.GetPlayerName();

        var computer = new Computer();
        Sleep(1000);

        computer.GetPlayerName();

        var turn = new Turn();
        Sleep(1000);
        var starter = GameStart.DecideStartingPlayer(player, computer);
        turn.PlayGame(player, computer, starter);
    }
}
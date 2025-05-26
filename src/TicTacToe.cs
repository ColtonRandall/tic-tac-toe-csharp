using static System.Threading.Thread;

namespace TicTacToe;

public class TicTacToe
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic Tac Toe \n");

        var board = new Board();

        var player = new HumanPlayer();

        var playerName = player.GetPlayerName();


        var computer = new Computer();
        Sleep(1000);

        var computerName = computer.GetPlayerName();

        var turn = new Turn();
        Sleep(1000);
        turn.StartingPlayer(player, computer);
        turn.ShowBoardOnly();
        turn.PlayGame(player, computer);
    }
}
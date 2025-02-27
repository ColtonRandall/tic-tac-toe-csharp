using static System.Threading.Thread;

namespace TicTacToe;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic Tac Toe \n");

        // Create the board
        var board = new Board();
        Board.GenerateBoard();

        // --- HUMAN PLAYER ---
        var player = new Player();

        // Get the player's Name
        var playerName = player.GetPlayerName();

        // --- COMPUTER PLAYER ---

        var computer = new Computer();
        Sleep(1000);

        // Get computer's name
        var computerName = computer.GetPlayerName();

        // --- STARTING PLAYER ---
        var turn = new Turn();
        Sleep(1000);
        turn.StartingPlayer(player, computer);
    }
}
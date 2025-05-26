namespace TicTacToe;

public class Turn
{
    public void PlayGame(HumanPlayer player, Computer computer, Starter starter)
    {
        var board = new Board();
        bool isHumanTurn = starter == Starter.Human;
        char currentSymbol = isHumanTurn ? 'X' : 'O';
        while (true)
        {
            Console.Clear();
            board.Display();
            Console.WriteLine();
            if (isHumanTurn)
            {
                player.TakeTurn(board, player.Name, currentSymbol);
            }
            else
            {
                computer.TakeTurn(board, computer.name, currentSymbol);
            }
            var winner = board.CheckWinner();
            if (winner != null)
            {
                Console.Clear();
                board.Display();
                Console.WriteLine($"\n{(winner == 'X' ? player.Name : computer.name)} wins!");
                break;
            }
            if (board.IsFull())
            {
                Console.Clear();
                board.Display();
                Console.WriteLine("\nIt's a draw!");
                break;
            }
            isHumanTurn = !isHumanTurn;
            currentSymbol = isHumanTurn ? 'X' : 'O';
        }
    }

    public void ShowBoardOnly()
    {
        var board = new Board();
        Console.Clear();
        Console.WriteLine("Tic Tac Toe\n");
        board.Display();
        Console.WriteLine("\n(Press Enter to exit)");
        Console.ReadLine();
    }
}
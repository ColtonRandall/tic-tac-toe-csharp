namespace TicTacToe;

public class Turn
{
    public void StartingPlayer(HumanPlayer player, Computer computer)
    {
        var randomNumber = new Random();
        var decidingNumber = randomNumber.Next(1, 3);

        switch (decidingNumber)
        {
            case 1:
                Console.WriteLine($"{player.Name} starts!");
                break;
            case 2:
                Console.WriteLine($"{computer.name} starts!");
                break;
        }
    }

    public void PlayGame(HumanPlayer player, Computer computer)
    {
        var board = new Board();
        char currentSymbol = 'X';
        bool isHumanTurn = true;

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
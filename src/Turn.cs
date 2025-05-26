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
        // string currentPlayer = player.Name;
        bool isHumanTurn = true;

        while (true)
        {
            Console.Clear();
            board.Display();
            Console.WriteLine();

            int move;
            if (isHumanTurn)
            {
                Console.Write($"{player.Name}, enter your move (1-9): ");
                while (!int.TryParse(Console.ReadLine(), out move) || !board.MakeMove(move, currentSymbol))
                    Console.Write("Invalid move. Try again: ");
            }
            else
            {
                Thread.Sleep(1000);
                var available = board.GetState().Where(cell => cell != 'X' && cell != 'O').ToArray();
                var rand = new Random();
                move = int.Parse(available[rand.Next(available.Length)].ToString());
                Console.WriteLine($"{computer.name} 🤖 chooses {move}");
                board.MakeMove(move, currentSymbol);
                Thread.Sleep(1000);
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
namespace TicTacToe;

public class Turn
{
    // private readonly Computer computer = new();
    // private readonly Player player = new();

    public void StartingPlayer(Player player, Computer computer)
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
}
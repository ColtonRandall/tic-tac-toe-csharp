namespace TicTacToe;

public enum Starter { Human, Computer }

public static class GameStart
{
    public static Starter DecideStartingPlayer(HumanPlayer player, Computer computer)
    {
        var randomNumber = new Random();
        var decidingNumber = randomNumber.Next(1, 3);
        if (decidingNumber == 1)
        {
            Console.WriteLine($"{player.Name} starts!");
            return Starter.Human;
        }
        else
        {
            Console.WriteLine($"{computer.name} starts!");
            return Starter.Computer;
        }
    }
}

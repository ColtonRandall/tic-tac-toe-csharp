namespace TicTacToe;

public class HumanPlayer : IPlayerType
{
    public string? Name { get; set; }

    // TODO - Uncomment and implement the ChosenValue property 
    // protected ChosenValue chosenValue { get; set; }

    // public Player(ChosenValue chosenValue)
    // {
    //     
    //     ChosenValue = chosenValue;
    // }

    public Turn TakeTurn()
    {
        return null;
    }

    public string? GetPlayerName()
    {
        Console.WriteLine("What's your name?");
        Name = Console.ReadLine();
        Console.WriteLine($"Welcome {Name}\n");
        return Name;
    }
}
namespace TicTacToe;

public class Board
{
    private readonly char[] state = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    private const string BoardLine = "---+---+---";

    public void Display()
    {
        Console.WriteLine($" {state[0]} | {state[1]} | {state[2]}");
        Console.WriteLine(BoardLine);
        Console.WriteLine($" {state[3]} | {state[4]} | {state[5]}");
        Console.WriteLine(BoardLine);
        Console.WriteLine($" {state[6]} | {state[7]} | {state[8]}");
    }

    public bool MakeMove(int position, char symbol)
    {
        // input validation
        if (position < 1 || position > 9 || state[position - 1] == 'X' || state[position - 1] == 'O')
            return false;
        state[position - 1] = symbol;
        return true;
    }

    public bool IsFull() => state.All(cell => cell == 'X' || cell == 'O');

    public char? CheckWinner()
    {
        int[][] winningCombinations = new int[][] {
            new int[] {0,1,2}, new int[] {3,4,5}, new int[] {6,7,8}, // rows
            new int[] {0,3,6}, new int[] {1,4,7}, new int[] {2,5,8}, // columns
            new int[] {0,4,8}, new int[] {2,4,6} // diagonals
        };

        foreach (var combination in winningCombinations)
        {
            char firstCell = state[combination[0]];
            char secondCell = state[combination[1]];
            char thirdCell = state[combination[2]];
            if ((firstCell == 'X' || firstCell == 'O') && firstCell == secondCell && firstCell == thirdCell)
                return firstCell;
        }
        // No winner found
        return null;
    }

    public char[] GetState() => state;
}
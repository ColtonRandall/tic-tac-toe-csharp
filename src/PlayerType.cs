namespace TicTacToe;

public interface IPlayerType
{
    string? GetPlayerName();
    Turn TakeTurn();
}
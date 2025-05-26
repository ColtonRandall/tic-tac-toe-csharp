namespace TicTacToe;

public interface IPlayerType
{
    string GetPlayerName();
    void TakeTurn(Board board, string playerName, char symbol);
}
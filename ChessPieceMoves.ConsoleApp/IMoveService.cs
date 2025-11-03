namespace ChessPieceMoves.ConsoleApp;

public interface IMoveService
{
    /// <summary>
    ///     Calculates all valid moves for a knight piece from a given position on a chess board.
    ///     A knight moves in an "L" shape: 2 squares in one direction and 1 square perpendicular,
    ///     or 1 square in one direction and 2 squares perpendicular.
    /// </summary>
    /// <param name="position">
    ///     An array containing the knight's current position [x, y] where x and y are 0-based coordinates
    ///     (0-7).
    /// </param>
    /// <returns>A 2D array where each row represents a valid move as [x, y] coordinates on the chess board.</returns>
    /// <remarks>
    ///     The method validates all potential knight moves and only returns positions that fall within
    ///     the standard 8x8 chess board boundaries (coordinates 0-7 for both x and y).
    /// </remarks>
    int[,] KnightPossibleMoves(int[] position);
}
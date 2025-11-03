namespace ChessPieceMoves.ConsoleApp;

public class MoveService : IMoveService
{
    /// <inheritdoc />
    public int[,] KnightPossibleMoves(int[] position)
    {
        var results = new List<int[]>();
        var x = position[0];
        var y = position[1];
        var moves = new[,]
        {
            { x - 2, y - 1 }, { x - 2, y + 1 },
            { x - 1, y - 2 }, { x - 1, y + 2 },
            { x + 1, y - 2 }, { x + 1, y + 2 },
            { x + 2, y - 1 }, { x + 2, y + 1 }
        };

        for (var i = 0; i < moves.GetLength(0); i++)
        {
            var moveX = moves[i, 0];
            var moveY = moves[i, 1];
            if (IsValidPosition(moveX, moveY)) results.Add([moveX, moveY]);
        }

        return ToArray2D(results);
    }
        
    private static int[,] ToArray2D(List<int[]> list)
    {
        var array2D = new int[list.Count, 2];
        for (var i = 0; i < list.Count; i++)
        {
            array2D[i, 0] = list[i][0];
            array2D[i, 1] = list[i][1];
        }

        return array2D;
    }

    private static bool IsValidPosition(int x, int y)
    {
        return x is >= 0 and < 8 && y is >= 0 and < 8;
    }
}
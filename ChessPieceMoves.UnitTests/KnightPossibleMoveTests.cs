using ChessPieceMoves.ConsoleApp;

namespace ChessPieceMoves.UnitTests;

public class KnightPossibleMoveTests
{
    [Fact]
    public void KnightPossibleMoves_ValidPosition_ReturnsCorrectMoves()
    {
        // Arrange
        var moveService = new MoveService();
        var position = new[] { 4, 4 }; // e5

        // Act
        var result = moveService.KnightPossibleMoves(position);

        // Assert
        var expectedMoves = new[,]
        {
            { 2, 3 }, { 2, 5 }, { 3, 2 }, { 3, 6 },
            { 5, 2 }, { 5, 6 }, { 6, 3 }, { 6, 5 }
        };
        Assert.Equal(expectedMoves, result);
    }


    [Fact]
    public void KnightPossibleMoves_LeftBottomCorner_ReturnsCorrectMoves()
    {
        // Arrange
        var moveService = new MoveService();
        var position = new[] { 0, 0 }; // e5

        // Act
        var result = moveService.KnightPossibleMoves(position);

        // Assert
        var expectedMoves = new[,]
        {
            { 1, 2 }, { 2, 1 }
        };
        Assert.Equal(expectedMoves, result);
    }


    [Fact]
    public void KnightPossibleMoves_LeftTopCorner_ReturnsCorrectMoves()
    {
        // Arrange
        var moveService = new MoveService();
        var position = new[] { 0, 7 };

        // Act
        var result = moveService.KnightPossibleMoves(position);

        // Assert
        var expectedMoves = new[,]
        {
            { 1, 5 }, { 2, 6 }
        };
        Assert.Equal(expectedMoves, result);
    }


    [Fact]
    public void KnightPossibleMoves_RightTopCorner_ReturnsCorrectMoves()
    {
        // Arrange
        var moveService = new MoveService();
        var position = new[] { 7, 7 };

        // Act
        var result = moveService.KnightPossibleMoves(position);

        // Assert
        var expectedMoves = new[,]
        {
            { 5, 6 }, { 6, 5 }
        };
        Assert.Equal(expectedMoves, result);

    }

    [Fact]
    public void KnightPossibleMoves_RightBottomCorner_ReturnsCorrectMoves()
    {
        // Arrange
        var moveService = new MoveService();
        var position = new[] { 7, 0 };

        // Act
        var result = moveService.KnightPossibleMoves(position);

        // Assert
        var expectedMoves = new[,]
        {
            { 5, 1 }, { 6, 2 }
        };
        Assert.Equal(expectedMoves, result);

    }
}
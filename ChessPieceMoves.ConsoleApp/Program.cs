// See https://aka.ms/new-console-template for more information

using ChessPieceMoves.ConsoleApp;

Console.WriteLine("Knight Moves");

var moveService = new MoveService();
var possibleMoves = moveService.KnightPossibleMoves(new[] { 4, 4 });    

Console.WriteLine("Possible moves for Knight at position (4,4):");
for (var i = 0; i < possibleMoves.GetLength(0); i++)
{
    Console.WriteLine($"({possibleMoves[i, 0]}, {possibleMoves[i, 1]})");
}


# Chess Piece Moves

A .NET 9 application Soution for Cassido's Interview question of the week - 3rd November 2025

## Overview

This project implements chess piece movement logic, currently supporting knight moves. The application calculates all valid possible moves from a given position on the chessboard, taking into account board boundaries.

## Project Structure

```
ChessPieceMoves/
├── ChessPieceMoves.ConsoleApp/    # Console application
│   ├── Program.cs       # Application entry point
│   ├── IMoveService.cs     # Move service interface
│   └── MoveService.cs  # Move service implementation
├── ChessPieceMoves.UnitTests/        # Unit tests
│   └── KnightPossibleMoveTests.cs    # Tests for knight moves
└── README.md     # This file
```

## Technologies

- **.NET 9**
- **C# 13.0**
- **xUnit** (for unit testing)

## Features

### Knight Moves
Calculate all valid moves for a knight from any position on the chessboard.

**Knight Movement Pattern:**
- Knights move in an "L" shape: 2 squares in one direction and 1 square perpendicular
- 8 possible move patterns from any given position
- Only returns moves that remain within the 8x8 board boundaries

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### Building the Project

```bash
# Clone or navigate to the project directory
cd ChessPieceMoves

# Restore dependencies
dotnet restore

# Build the solution
dotnet build
```

### Running the Application

```bash
cd ChessPieceMoves.ConsoleApp
dotnet run
```

### Running Tests

```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --verbosity normal
```

## Usage

### Basic Example

```csharp
using ChessPieceMoves.ConsoleApp;

var moveService = new MoveService();

// Calculate knight moves from position (4, 4) - center of board
int[] position = new[] { 4, 4 };
int[,] possibleMoves = moveService.KnightPossibleMoves(position);

// Returns an array of valid move coordinates
// Example output: { {2,3}, {2,5}, {3,2}, {3,6}, {5,2}, {5,6}, {6,3}, {6,5} }
```

### Coordinate System

The chessboard uses a 0-indexed coordinate system:
- **X-axis**: 0-7 (columns, equivalent to files a-h)
- **Y-axis**: 0-7 (rows, equivalent to ranks 1-8)
- Position `[0, 0]` represents the bottom-left corner (a1)
- Position `[7, 7]` represents the top-right corner (h8)

## API Reference

### IMoveService Interface

```csharp
public interface IMoveService
{
    int[,] KnightPossibleMoves(int[] position);
}
```

#### Methods

**`KnightPossibleMoves(int[] position)`**
- **Parameters**: 
  - `position`: An integer array `[x, y]` representing the current position on the board
- **Returns**: A 2D integer array containing all valid move coordinates
- **Description**: Calculates all possible knight moves from the given position that remain within board boundaries

## Test Coverage

The project includes comprehensive unit tests for knight moves:

- ✅ Valid position in center of board (maximum moves)
- ✅ Bottom-left corner position (limited moves)
- ✅ Top-left corner position (limited moves)
- ✅ Top-right corner position (limited moves)

## Future Enhancements

Potential features for future development:
- [ ] Additional chess pieces (rook, bishop, queen, king, pawn)
- [ ] Move validation considering piece captures
- [ ] Check and checkmate detection
- [ ] Full game state management
- [ ] Interactive console interface
- [ ] Graphical user interface

## Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for bugs and feature requests.

## License

This project is provided as-is for educational and development purposes.

## Author

Developed as a .NET 9 demonstration project showcasing chess piece movement logic.

using GameOfLifeProcessor;
using GameOfLifeProcessor.GameBoard;
using GameOfLifeUI;
using Pastel;
using System.Drawing;

//Settings
var generations = 150;
var boardWidth = 25;
var boardHeight = 10;
var delayOutput = true;
var delayInMs = 100;
var cellCharacter = "x";
var clearOutput = true;
var cellTextColor = Color.FromArgb(0, 0, 0);
var activeCellTextColor = Color.FromArgb(66, 245, 72);
var randomBoard = true;
var activeCells = ActiveCellsExamples.Beacon;

//Game
try
{
    var game = randomBoard ? new Game(boardWidth, boardHeight) : new Game(boardWidth, boardHeight, activeCells);
    for (var i = 0; i < generations; i++)
    {
        Print(game.GetBoard());
        game.NextGeneration();

        if (delayOutput)
        {
            Thread.Sleep(delayInMs);
        }

        if (clearOutput && i + 1 < generations)
        {
            Console.Clear();
        }
    }
}
catch(Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}".Pastel(Color.FromArgb(247, 52, 52)));
}

//Output method
void Print(Board board)
{
    for (var y = 0; y < boardHeight; y++)
    {
        for (var x = 0; x < boardWidth; x++)
        {
            var textColor = cellTextColor;
            if (board.Cells[y, x].IsAlive)
            {
                textColor = activeCellTextColor;
            }
            
            Console.Write(cellCharacter.Pastel(textColor));
        }

        Console.WriteLine();
    }
}

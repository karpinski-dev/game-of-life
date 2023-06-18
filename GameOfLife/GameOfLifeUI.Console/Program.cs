﻿using GameOfLifeProcessor;
using GameOfLifeProcessor.GameBoard;
using GameOfLifeUI;
using Pastel;
using System.Drawing;

//Settings
var settings = new SettingsModel();

//Game
try
{
    var game = settings.RandomBoard ? new Game(settings.BoardWidth, settings.BoardHeight) : new Game(settings.BoardWidth, settings.BoardHeight, settings.ActiveCells);
    for (var i = 0; i < settings.Generations; i++)
    {
        Print(game.GetBoard());
        game.NextGeneration();

        if (settings.DelayOutput)
        {
            Thread.Sleep(settings.DelayInMs);
        }

        if (settings.ClearOutput && i + 1 < settings.Generations)
        {
            Console.Clear();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}".Pastel(Color.FromArgb(247, 52, 52)));
}

//Output method
void Print(Board board)
{
    for (var y = 0; y < settings.BoardHeight; y++)
    {
        for (var x = 0; x < settings.BoardWidth; x++)
        {
            var textColor = settings.CellTextColor;
            if (board.Cells[y, x].IsAlive)
            {
                textColor = settings.ActiveCellTextColor;
            }

            Console.Write(settings.CellCharacter.Pastel(textColor));
        }

        Console.WriteLine();
    }
}

using System;

namespace GameOfLifeProcessor.GameBoard
{
    public class Board : IGameBoard
    {
        public int Width { get; private set; }
        
        public int Height { get; private set; }
        
        public IBoardCell[,] Cells { get; private set; }
        

        public Board(int width, int height)
        {
            if(width <= 0 || height <= 0)
            {
                throw new Exception("Game board has invalid width/height value(s)");
            } 
            else
            {
                Width = width;
                Height = height;
                Cells = new BoardCellModel[Height, Width];
            }
        }

        public void Create()
        {
            var random = new Random();

            for (var y = 0; y < Height; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    var randomNum = random.Next(1, 121);
                    Cells[y, x] = new BoardCellModel
                    {
                        IsAlive = randomNum % 3 == 0
                    };
                }
            }
        }

        public void Create(IList<ICellCoordinates> activeCells)
        {
            if(activeCells == null || activeCells.Count <= 0)
            {
                throw new Exception($"Provided active cells are not valid: {nameof(Create)}");
            }

            var maxY = activeCells.OrderByDescending(c => c.YAxis).First().YAxis;
            var maxX = activeCells.OrderByDescending(c => c.XAxis).First().XAxis;

            if(Height < maxY || Width < maxX)
            {
                throw new Exception($"Some/all provided active cells are outside the board: {nameof(Create)}");
            }

            for (var y = 0; y < Height; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    Cells[y, x] = new BoardCellModel
                    {
                        IsAlive = false
                    };
                }
            }

            foreach (var cell in activeCells)
            {
                Cells[cell.YAxis, cell.XAxis] = new BoardCellModel
                {
                    IsAlive = true
                };
            }
        }

        public void Update(IBoardCell[,] cells)
        {
            if(cells == null)
            {
                throw new Exception($"New cells are null: {nameof(Update)}");
            }

            Cells = cells;
        }
    }
}

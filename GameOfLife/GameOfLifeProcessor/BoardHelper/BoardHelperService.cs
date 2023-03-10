using GameOfLifeProcessor.GameBoard;

namespace GameOfLifeProcessor.BoardHelper
{
    internal class BoardHelperService : IBoardHelperService
    {
        public IEnumerable<IBoardChunk> GetBoardChunks(IGameBoard board)
        {
            var output = new List<BoardChunk>();

            if (board == null)
            {
                return output;
            }

            for (var y = 0; y < board.Height; y++)
            {
                for (var x = 0; x < board.Width; x++)
                {
                    var chunk = new BoardChunk()
                    {
                        Cells = new ChunkCellModel[3, 3],
                        CenterCellOriginalX = x,
                        CenterCellOriginalY = y
                    };

                    var outOfRangeCell = new ChunkCellModel
                    {
                        IsAlive = false,
                        IsOutOfRange = true
                    };

                    var canGoUp = y - 1 >= 0;
                    var canGoDown = y + 1 < board.Height;
                    var canGoLeft = x - 1 >= 0;
                    var canGoRight = x + 1 < board.Width;

                    chunk.Cells[0, 0] = canGoUp && canGoLeft ? new ChunkCellModel { IsAlive = board.Cells[y - 1, x - 1].IsAlive, IsOutOfRange = false } : outOfRangeCell;
                    chunk.Cells[1, 0] = canGoLeft ? new ChunkCellModel { IsAlive = board.Cells[y, x - 1].IsAlive, IsOutOfRange = false } : outOfRangeCell;
                    chunk.Cells[2, 0] = canGoDown && canGoLeft ? new ChunkCellModel { IsAlive = board.Cells[y + 1, x - 1].IsAlive, IsOutOfRange = false } : outOfRangeCell;

                    chunk.Cells[0, 1] = canGoUp ? new ChunkCellModel { IsAlive = board.Cells[y - 1, x].IsAlive, IsOutOfRange = false } : outOfRangeCell;
                    chunk.Cells[1, 1] = new ChunkCellModel { IsAlive = board.Cells[y, x].IsAlive, IsOutOfRange = false };                                                          //Center cell
                    chunk.Cells[2, 1] = canGoDown ? new ChunkCellModel { IsAlive = board.Cells[y + 1, x].IsAlive, IsOutOfRange = false } : outOfRangeCell;

                    chunk.Cells[0, 2] = canGoUp && canGoRight ? new ChunkCellModel { IsAlive = board.Cells[y - 1, x + 1].IsAlive, IsOutOfRange = false } : outOfRangeCell;
                    chunk.Cells[1, 2] = canGoRight ? new ChunkCellModel { IsAlive = board.Cells[y, x + 1].IsAlive, IsOutOfRange = false } : outOfRangeCell;
                    chunk.Cells[2, 2] = canGoDown && canGoRight ? new ChunkCellModel { IsAlive = board.Cells[y + 1, x + 1].IsAlive, IsOutOfRange = false } : outOfRangeCell;

                    output.Add(chunk);
                }
            }

            return output;
        }
    }
}

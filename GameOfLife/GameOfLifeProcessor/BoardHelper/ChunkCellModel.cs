using GameOfLifeProcessor.GameBoard;

namespace GameOfLifeProcessor.BoardHelper
{
    internal class ChunkCellModel : IChunkCell
    {
        public bool IsAlive { get; set; }

        public bool IsOutOfRange { get; set; }
    }
}

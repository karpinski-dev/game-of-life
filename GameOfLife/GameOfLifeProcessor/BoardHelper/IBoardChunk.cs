namespace GameOfLifeProcessor.BoardHelper
{
    public interface IBoardChunk
    {
        /// <summary>
        /// Original x-axis value of the cell on the game board.
        /// </summary>
        public int CenterCellOriginalX { get; set; }

        /// <summary>
        /// Original y-axis value of the cell on the game board.
        /// </summary>
        public int CenterCellOriginalY { get; set; }

        /// <summary>
        /// 3x3 board chunk
        /// </summary>
        public IChunkCell[,] Cells { get; set; }

        /// <summary>
        /// Returns all neighbours of the center cell.
        /// </summary>
        public IEnumerable<IChunkCell> GetNeighbours();
    }
}

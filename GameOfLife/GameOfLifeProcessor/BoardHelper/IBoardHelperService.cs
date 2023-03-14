using GameOfLifeProcessor.GameBoard;

namespace GameOfLifeProcessor.BoardHelper
{
    public interface IBoardHelperService
    {
        /// <summary>
        /// Gets the 3x3 chunk for every cell on the game board.
        /// </summary>
        /// <param name="board"></param>
        IEnumerable<IBoardChunk> GetBoardChunks(IGameBoard board);
    }
}
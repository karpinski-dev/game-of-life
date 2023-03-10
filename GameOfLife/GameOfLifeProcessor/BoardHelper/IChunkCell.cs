using GameOfLifeProcessor.GameBoard;

namespace GameOfLifeProcessor.BoardHelper
{
    public interface IChunkCell : IBoardCell, ICanBeOutOfRange
    {
    }
}

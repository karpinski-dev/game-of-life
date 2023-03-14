namespace GameOfLifeProcessor.BoardHelper
{
    public interface ICanBeOutOfRange
    {
        /// <summary>
        /// Specifies if this cell is outside the game board.
        /// </summary>
        public bool IsOutOfRange { get; set; }
    }
}

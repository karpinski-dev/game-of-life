namespace GameOfLifeProcessor.GameBoard
{
    public interface IBoardCell
    {
        /// <summary>
        /// If <see langword="true"/> cell is alive otherwise this cell is dead. Default is <see langword="false"/>.
        /// </summary>
        bool IsAlive { get; set; }
    }
}
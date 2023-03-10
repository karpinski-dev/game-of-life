namespace GameOfLifeProcessor.GameBoard
{
    public interface IGameBoard
    {
        /// <summary>
        /// The width of the board (x-axis).
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// The height of the board (y-axis).
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// All cells on the board.
        /// </summary>
        public IBoardCell[,] Cells { get; }

        /// <summary>
        /// Creates randomized board.
        /// </summary>
        void Create();

        /// <summary>
        /// Creates board with selected active cells.
        /// </summary>
        /// <param name="activeCells"></param>
        void Create(IList<ICellCoordinates> activeCells);

        /// <summary>
        /// Updates existing board.
        /// </summary>
        /// <param name="cells"></param>
        void Update(IBoardCell[,] cells);
    }
}

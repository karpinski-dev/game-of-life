namespace GameOfLifeProcessor.GameBoard
{
    public interface ICellCoordinates
    {
        /// <summary>
        /// The x-axis value (index).
        /// </summary>
        uint XAxis { get; set; }

        /// <summary>
        /// The y-axis value (index).
        /// </summary>
        uint YAxis { get; set; }
    }
}

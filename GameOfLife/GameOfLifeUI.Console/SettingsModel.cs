using GameOfLifeProcessor.GameBoard;
using System.Drawing;

namespace GameOfLifeUI
{
    /// <summary>
    /// Settings
    /// </summary>
    internal class SettingsModel
    {
        public int Generations { get; set; } = 150;
        public int BoardWidth { get; set; } = 25;
        public int BoardHeight { get; set; } = 10;
        public bool DelayOutput { get; set; } = true;
        public int DelayInMs { get; set; } = 100;
        public string CellCharacter { get; set; } = "x";
        public bool ClearOutput { get; set; } = true;
        public Color CellTextColor { get; set; } = Color.FromArgb(0, 0, 0);
        public Color ActiveCellTextColor { get; set; } = Color.FromArgb(66, 245, 72);
        public bool RandomBoard { get; set; } = true;
        public IList<ICellCoordinates> ActiveCells { get; set; } = ActiveCellsExamples.Beacon;
    }
}

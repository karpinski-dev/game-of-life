using GameOfLifeProcessor.GameBoard;

namespace GameOfLifeProcessor.BoardHelper
{
    internal class BoardChunk : IBoardChunk
    {
        private readonly int[,] _neighboursCoordinates = new int[,]
        {
            { 0, 0 },
            { 1, 0 },
            { 2, 0 },
            { 0, 1 },
            { 2, 1 },
            { 0, 2 },
            { 1, 2 },
            { 2, 2 },
        };

        public IChunkCell[,] Cells { get; set; } = new ChunkCellModel[3, 3];
        
        public int CenterCellOriginalX { get; set; }
        
        public int CenterCellOriginalY { get; set; }

        public IEnumerable<IChunkCell> GetNeighbours()
        {
            for(var i = 0; i < 8; i++)
            {
                var y = _neighboursCoordinates[i, 0];
                var x = _neighboursCoordinates[i, 1];

                yield return Cells[y, x];
            }
        }
    }
}

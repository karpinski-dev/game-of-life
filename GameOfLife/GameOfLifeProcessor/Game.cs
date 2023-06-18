using GameOfLifeProcessor.BoardHelper;
using GameOfLifeProcessor.BoardValidator;
using GameOfLifeProcessor.GameBoard;

namespace GameOfLifeProcessor
{
    public class Game
    {
        private Board _board;
        private readonly IChunkBoardService _chunkBoardService = new ChunkBoardService();
        private readonly IGameRulesValidator _validatorService = new GameRulesValidator();

        public Game(int boardWidth, int boardHeight)
        {
            _board = new Board(boardWidth, boardHeight);
            _board.Create();
        }

        public Game(int boardWidth, int boardHeight, IList<ICellCoordinates> activeCells)
        {
            _board = new Board(boardWidth, boardHeight);
            _board.Create(activeCells);
        }

        public void NextGeneration()
        {
            var chunks = _chunkBoardService.GetBoardChunks(_board).ToList();

            for (var y = 0; y < _board.Height; y++)
            {
                for (var x = 0; x < _board.Width; x++)
                {
                    var chunkForCell = chunks.First(chunk => chunk.CenterCellOriginalX == x && chunk.CenterCellOriginalY == y);

                    if (_board.Cells[y, x].IsAlive)
                    {
                        _board.Cells[y, x].IsAlive = _validatorService.WillCellSurvive(chunkForCell);
                    }
                    else
                    {
                        _board.Cells[y, x].IsAlive = _validatorService.WillCellBeResurrected(chunkForCell);
                    }
                }
            }
        }

        public Board GetBoard()
        {
            return _board;
        }
    }
}

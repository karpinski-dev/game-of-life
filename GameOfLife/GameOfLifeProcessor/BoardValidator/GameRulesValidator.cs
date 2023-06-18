using GameOfLifeProcessor.BoardHelper;

namespace GameOfLifeProcessor.BoardValidator
{
    internal class GameRulesValidator : IGameRulesValidator
    {
        public bool WillCellSurvive(IBoardChunk chunk)
        {
            return CellHasEnoughAndNotToManyNeighboursToStayAlive(GetNeighboursCount(chunk));
        }

        public bool WillCellBeResurrected(IBoardChunk chunk)
        {
            return CellHasEnoughAndNotToManyNeighboursToBeResurrected(GetNeighboursCount(chunk));
        }

        private int GetNeighboursCount(IBoardChunk chunk)
        {
            if(chunk == null)
            {
                throw new Exception($"Chunk was null: {nameof(GetNeighboursCount)}");
            }
            else
            {
                var neighbours = chunk.GetNeighbours();
                if(neighbours == null)
                {
                    return 0;
                }

                return neighbours.Where(x => x.IsAlive && !x.IsOutOfRange).ToList().Count;
            }
        }

        private static bool CellHasEnoughAndNotToManyNeighboursToStayAlive(int neighboursCount)
        {
            return neighboursCount >= 2 && neighboursCount <= 3;
        }

        private static bool CellHasEnoughAndNotToManyNeighboursToBeResurrected(int neighboursCount)
        {
            return neighboursCount == 3;
        }
    }
}

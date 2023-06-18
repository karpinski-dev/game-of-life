using GameOfLifeProcessor.BoardHelper;

namespace GameOfLifeProcessor.BoardValidator
{
    public interface IGameRulesValidator
    {
        /// <summary>
        /// Checks if the cell satisfies game conditions so it can stay alive.
        /// </summary>
        /// <param name="chunk"></param>
        /// <returns><see langword="true"/> if yes, otherwise <see langword="false"/></returns>
        bool WillCellSurvive(IBoardChunk chunk);

        /// <summary>
        /// Checks if the cell satisfies game conditions so it can be resurrected.
        /// </summary>
        /// <param name="chunk"></param>
        /// <returns><see langword="true"/> if yes, otherwise <see langword="false"/></returns>
        bool WillCellBeResurrected(IBoardChunk chunk);
    }
}
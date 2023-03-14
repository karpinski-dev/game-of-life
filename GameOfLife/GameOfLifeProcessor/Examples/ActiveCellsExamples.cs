using GameOfLifeProcessor.GameBoard;

namespace GameOfLifeUI
{
    public static class ActiveCellsExamples
    {
        //https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life#/media/File:Game_of_life_animated_glider.gif
        public static IList<ICellCoordinates> Glider { get; set; } = new List<ICellCoordinates> {
            new CellCoordinatesModel
            {
                XAxis = 2,
                YAxis = 0,
            },
            new CellCoordinatesModel
            {
                XAxis = 3,
                YAxis = 1,
            },
            new CellCoordinatesModel
            {
                XAxis = 3,
                YAxis = 2,
            },
            new CellCoordinatesModel
            {
                XAxis = 2,
                YAxis = 2,
            },
            new CellCoordinatesModel
            {
                XAxis = 1,
                YAxis = 2,
            },
        };

        //https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life#/media/File:Game_of_life_beacon.gif
        public static IList<ICellCoordinates> Beacon { get; set; } = new List<ICellCoordinates> {
            new CellCoordinatesModel
            {
                XAxis = 0,
                YAxis = 0,
            },
            new CellCoordinatesModel
            {
                XAxis = 0,
                YAxis = 1,
            },
            new CellCoordinatesModel
            {
                XAxis = 1,
                YAxis = 0,
            },
            new CellCoordinatesModel
            {
                XAxis = 1,
                YAxis = 1,
            },
            new CellCoordinatesModel
            {
                XAxis = 2,
                YAxis = 2,
            },
            new CellCoordinatesModel
            {
                XAxis = 2,
                YAxis = 3,
            },
            new CellCoordinatesModel
            {
                XAxis = 3,
                YAxis = 2,
            },
            new CellCoordinatesModel
            {
                XAxis = 3,
                YAxis = 3,
            },
        };
    }
}

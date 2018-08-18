using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainInstance();
            CountingInstance();
        }

        private static void StandartInstance()
        {
            Maze maze;
            MazeGame mazeGame = new MazeGame();
            StandartMazeBuilder builder = new StandartMazeBuilder();

            mazeGame.CreateMaze(builder);

            maze = builder.GetMaze();
        }

        private static void CountingInstance()
        {
            int rooms, doors;

            Maze maze;
            MazeGame game = new MazeGame();
            CountingMazeBuilder builder = new CountingMazeBuilder();

            game.CreateMaze(builder);

            maze = builder.GetMaze();
            builder.GetCounts(out rooms, out doors);

            Console.WriteLine($"Rooms: {rooms}, Doors: {doors}");
        }
    }
}

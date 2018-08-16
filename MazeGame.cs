using System;
namespace Builder
{
    public class MazeGame
    {
        public MazeGame()
        {
        }

        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return builder.GetMaze();
        }

        public Maze CreateComplexMaze(MazeBuilder builder)
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(100);

            return builder.GetMaze();
        }
    }
}

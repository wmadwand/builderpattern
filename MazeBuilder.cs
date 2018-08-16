using System;
using System.Collections.Generic;

namespace Builder
{
    #region MazeParts
    public enum Direction
    {
        North, South, East, West
    }

    public class MapSite { }

    public class Maze
    {
        private List<Room> _rooms;

        public Maze()
        {
            _rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room GetRoom(int number)
        {
            return _rooms[number];
        }
    }

    public class Room : MapSite
    {
        private int _number;
        private MapSite[] _sides = new MapSite[4];

        public Room(int number)
        {
            _number = number;
        }

        public void SetSide() { }
    }

    public class Wall : MapSite
    {

    }

    public class Door : MapSite { }
    #endregion

    public class MazeBuilder
    {
        public virtual void BuildMaze() { }
        public virtual void BuildRoom(int room) { }
        public virtual void BuildDoor(int roomFrom, int roomTo) { }

        public virtual Maze GetMaze() { return null; }

        protected MazeBuilder()
        {
        }
    }

    public class StandartMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze;
        //private Direction CommonWall(Room r1, Room r2);

        public override void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public override Maze GetMaze()
        {
            return _currentMaze;
        }
    }
}

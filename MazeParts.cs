using System;
using System.Collections.Generic;

namespace Builder
{
    public class MazeParts
    {
        public MazeParts()
        {
        }
    }

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

    public class Door : MapSite
    {

        public Door() { }

        public Door(Room r1, Room r2) { }

    }
    #endregion
}

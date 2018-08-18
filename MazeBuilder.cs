using System;
using System.Collections.Generic;

namespace Builder
{
    public class MazeBuilder
    {
        public virtual void BuildMaze() { }
        public virtual void BuildRoom(int roomNum) { }
        public virtual void BuildDoor(int roomFrom, int roomTo) { }

        public virtual Maze GetMaze() { return null; }

        protected MazeBuilder()
        {
        }
    }

    #region Builder variants
    public class StandartMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze;
        //private Direction CommonWall(Room r1, Room r2);

        public StandartMazeBuilder()
        {
            _currentMaze = null;
        }

        public override void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public override void BuildRoom(int roomNum)
        {
            Room room = new Room(roomNum);

            room.SetSide(/*Direction.North, new Wall()*/);
            room.SetSide(/*Direction.South, new Wall()*/);
            room.SetSide(/*Direction.East, new Wall()*/);
            room.SetSide(/*Direction.West, new Wall()*/);

            _currentMaze.AddRoom(room);
        }

        public override void BuildDoor(int n1, int n2)
        {
            Room r1 = _currentMaze.GetRoom(n1);
            Room r2 = _currentMaze.GetRoom(n2);

            Door door = new Door(r1, r2);

            r1.SetSide(/*CommonWall(r1,r2), door*/);
            r2.SetSide(/*CommonWall(r2,r1), door*/);
        }

        public override Maze GetMaze()
        {
            return _currentMaze;
        }

        private Direction CommonWall(Room r1, Room r2) { return Direction.East; }
    }

    public class CountingMazeBuilder : MazeBuilder
    {
        private int _doors;
        private int _rooms;

        public CountingMazeBuilder()
        {
            _doors = _rooms = 0;
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            _doors++;
        }

        public override void BuildMaze()
        {
            base.BuildMaze();
        }

        public override void BuildRoom(int roomNum)
        {
            _rooms++;
        }

        public virtual void AddWall()
        {

        }

        public void GetCounts(out int rooms, out int doors)
        {
            rooms = _rooms;
            doors = _doors;
        }
    }
    #endregion
}

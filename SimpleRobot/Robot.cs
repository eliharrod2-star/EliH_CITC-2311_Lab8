
using System;
using System.Drawing;

namespace SimpleRobot
{
    public enum Direction
    {
        North,
        South,
        East,
        West
    }

    public class RobotMovement
    {
        private Point position;

        public Direction CurrentDirection { get; set; }

        public Point Position
        {
            get { return position; }
        }

        public event EventHandler RangeExceeded;

        public RobotMovement()
        {
            position = new Point(0, 0);
            CurrentDirection = Direction.North;
        }

        public void Move(int distance)
        {
            int x = position.X;
            int y = position.Y;

            switch (CurrentDirection)
            {
                case Direction.North:
                    y += distance;
                    break;

                case Direction.South:
                    y -= distance;
                    break;

                case Direction.East:
                    x += distance;
                    break;

                case Direction.West:
                    x -= distance;
                    break;
            }

            if (x < -100 || x > 100 || y < -100 || y > 100)
            {
                RangeExceeded?.Invoke(this, EventArgs.Empty);
                return;
            }

            position = new Point(x, y);
        }
    }
}

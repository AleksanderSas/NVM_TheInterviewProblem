using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterviewProblem.Board
{
    public class Piece
    {
        public Direction Direction { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        private GameBoard Board;

        public Piece(GameBoard board, int x = 0, int y = 0, Direction direction = Direction.N)
        {
            Direction = direction;
            Board = board;
            X = x;
            Y = y;
        }

        public bool Move(string commands)
        {
            foreach(char command in commands)
            {
                if(!Move(command))
                {
                    return false;
                }
            }
            return true;
        }

        public bool Move(char command)
        {
            switch(command)
            {
                case 'M':
                    return Move();
                case 'L':
                    return TurnLeft();
                case 'R':
                    return TurnRigth();
                default:
                    throw new GameException($"Command {command} is unknown");
            }
        }

        private bool Move()
        {
            int newX = X;
            int newY = Y;
            switch(Direction)
            {
                case Direction.N:
                    newY += 1;
                    break;
                case Direction.S:
                    newY -= 1;
                    break;
                case Direction.W:
                    newX -= 1;
                    break;
                case Direction.E:
                    newX += 1;
                    break;
            }

            if(Board.Move(X, Y, newX, newY))
            {
                X = newX;
                Y = newY;
                return true;
            }
            return false;
        }

        private bool TurnLeft()
        {
            Direction = Direction.OnLeft();
            return true;
        }

        private bool TurnRigth()
        {
            Direction = Direction.OnRigth();
            return true;
        }

        public string PrintLocation()
        {
            return $"{X} {Y} {Direction}";
        }
    }
}

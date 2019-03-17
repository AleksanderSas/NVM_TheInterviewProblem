using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterviewProblem.Board
{
    /// <summary>
    /// The class allows many <see cref="Piece"/> to share one space.
    /// The class allows to detect colision between <see cref="Piece"/>
    /// This class should be used to create new <see cref="Piece"/> by method <see cref="CreateNewPiece(int, int)"/>
    /// </summary>
    public class GameBoard
    {
        private Piece[,] Fields;
        private int Size;

        public GameBoard():this(5)
        {
        }

        public GameBoard(int size)
        {
            Fields = new Piece[size, size];
            Size = size;
        }

        public Piece CreateNewPiece(int x = 0, int y = 0)
        {
            if(Fields[y,x] != null)
            {
                throw new GameException($"Field at position x={x}, y={y} is not empty.");
            }
            if (x < 0 || x >= Size || y < 0 || y >= Size)
            {
                throw new GameException($"Position x={x}, y={y} is invalid.");
            }
            Piece piece = new Piece(this, x, y);
            Fields[y, x] = piece;
            return piece;
        }

        public Piece GetPiece(int x, int y)
        {
            return Fields[y,x] ?? throw new GameException($"Field at position x={x}, y={y} is empty.");
        }

        public virtual bool Move(int originX, int originY, int newX, int newY)
        {
            if (newX < 0 || newX >= Size || newY < 0 || newY >= Size)
            {
                return false;
            }

            //TODO: should we test if the new position is empty?
            Fields[newY, newX] = Fields[originY, originX];
            return true;
        }

    }
}

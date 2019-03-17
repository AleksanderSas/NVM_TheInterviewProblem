using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TheInterviewProblem.Board;

namespace TheInterviewProblemTests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void TryToMoveOutOfBoard()
        {
            int size = 5;
            GameBoard board = new GameBoard(size);

            Assert.IsFalse(board.Move(0, 0, -1, 0));
            Assert.IsFalse(board.Move(0, 0, 0, -1));
            Assert.IsFalse(board.Move(0, 0, 5, 0));
            Assert.IsFalse(board.Move(0, 0, 0, 5));
        }

        [TestMethod]
        public void SomeValidoMove()
        {
            int size = 5;
            GameBoard board = new GameBoard(size);

            Assert.IsTrue(board.Move(0, 0, 0, 0));
            Assert.IsTrue(board.Move(0, 0, 1, 0));
            Assert.IsTrue(board.Move(0, 0, 0, 1));
            Assert.IsTrue(board.Move(0, 0, size - 1, 0));
            Assert.IsTrue(board.Move(0, 0, 0, size - 1));
        }

        [TestMethod]
        public void CreateNewPiece()
        {
            int x = 3;
            int y = 4;
            GameBoard board = new GameBoard();
            Piece piece = board.CreateNewPiece(x, y);

            Assert.AreEqual(piece.X, x);
            Assert.AreEqual(piece.Y, y);
            Assert.AreEqual(piece.Direction, Direction.N);
        }

        [TestMethod]
        public void CreatePieceAtBusyPosition()
        {
            int x = 3;
            int y = 4;
            try
            {
                GameBoard board = new GameBoard();
                board.CreateNewPiece(x, y);
                board.CreateNewPiece(x, y);
                Assert.Fail();
            }
            catch(GameException ex)
            {
                Assert.AreEqual(ex.Message, $"Field at position x={x}, y={y} is not empty.");
            }
            catch(Exception)
            {
                Assert.Fail();
            }
        }
    }
}

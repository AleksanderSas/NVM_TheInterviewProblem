using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TheInterviewProblem.Board;

namespace TheInterviewProblemTests
{
    [TestClass]
    public class PieceTests
    {
        [TestMethod]
        public void MoveForward()
        {
            Mock<GameBoard> mockedGameBoard = new Mock<GameBoard>();
            mockedGameBoard.Setup(x => x.Move(0, 0, 0, 1)).Returns(true);
            mockedGameBoard.Setup(x => x.Move(0, 1, 0, 2)).Returns(true);

            Piece piece = new Piece(mockedGameBoard.Object);

            piece.Move('M');
            piece.Move('M');

            mockedGameBoard.Verify(x => x.Move(0, 1, 0, 2));
        }
    }
}

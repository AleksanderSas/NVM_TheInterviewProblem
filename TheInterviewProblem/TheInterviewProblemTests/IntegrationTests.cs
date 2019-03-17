using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TheInterviewProblem.Board;

namespace TheInterviewProblemTests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void Scenerio0()
        {
            Scenerio("", "0 0 N", true);
        }

        [TestMethod]
        public void Scenerio1()
        {
            Scenerio("MRMLMRM", "2 2 E", true);
        }

        [TestMethod]
        public void Scenerio2()
        {
            Scenerio("RMMMLMM", "3 2 N", true);
        }

        [TestMethod]
        public void Scenerio3()
        {
            Scenerio("MMMM", "0 4 N", true);
        }

        [TestMethod]
        public void Scenerio4_HitBorder()
        {
            Scenerio("MMMMM", "0 4 N", false);
        }

        [TestMethod]
        public void Scenerio5()
        {
            Scenerio("RRRRRLLLL", "0 0 E", true);
        }

        public void Scenerio(string command, string expectedLocation, bool isMoveSuccessful)
        {
            GameBoard board = new GameBoard();
            Piece piece = board.CreateNewPiece();
            bool movedSuccessfully = piece.Move(command);

            Assert.AreEqual(expectedLocation, piece.PrintLocation());
            Assert.AreEqual(isMoveSuccessful, movedSuccessfully);
        }
    }
}
